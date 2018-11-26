using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using WMPLib;
using System.Collections;
using System.IO;
using TagLib;
using System.Diagnostics;

namespace Windows_MediaPlayer
{

    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        #region Form1
        Stack<string> backstack = new Stack<string>();
        Stack<string> forwardstack = new Stack<string>();
        List<string>MusicLib;
        string VideosLib;
        List<string> PicturesLib;

        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            Manage_music manage_Music = new Manage_music();
            Manage_Videos manage_Videos = new Manage_Videos();
            Manage_Pictures manage_Pictures = new Manage_Pictures();
            MusicLib = manage_Music.getadress;
            VideosLib = manage_Videos.getadress;
            PicturesLib = manage_Pictures.getadress;
            now_is_at = "Music";
            render(now_is_at);
            this.listView1.BackColor = Color.AliceBlue;
            this.listView1.ForeColor = Color.Black;
            playlist_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            listView1.Dock = DockStyle.Fill;
            textBoxaddress.Text = "Library";
            splitContainer2.Panel2Collapsed=true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                this.button1_Click_2(sender, e);
            }
            if (e.KeyCode == Keys.O && e.Control)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Media file (*.mp3; *.mp4)|*.mp3;*.mp4";
                WMPLib.IWMPMedia wMP;
                string plist = DateTime.UtcNow.ToString();
                var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist(plist);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fn in openFileDialog.FileNames)
                    {
                        wMP = axWindowsMediaPlayer1.newMedia(fn);
                        playlist.appendItem(wMP);

                    }
                    axWindowsMediaPlayer1.currentPlaylist = playlist;
                }

            }
            if (e.KeyCode == Keys.Escape)
            {
                if (axWindowsMediaPlayer1.fullScreen==true)
                {
                    axWindowsMediaPlayer1.fullScreen = false;
                }
            }
            if (e.KeyCode== Keys.Delete)
            {
                this.delete_selected_items(sender,e);
            }
        }

        private void helpbut_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(helpbut, "Help");
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(backButton, "Back");
        }

        private void forwardButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(forwardButton, "Forward");
        }

        private void tabplaybt_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(tabplaybt, "Create playlist, manage content, and share your music");

        }

        private void tabburnbt_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(tabburnbt, "Burn files to discs");


        }
        private void tabsyncbt_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(tabsyncbt, "Sync content to and from your potable devices");

        }

        private void helpbut_Click(object sender, EventArgs e)
        {
            string url;
            url = "https://www.google.com.vn/";
            System.Diagnostics.Process.Start(url);
        }
        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap image;
            image = new Bitmap(imageList2.Images[0]);
            backButton.Image = image;
        }

        #region imageprocessing
        Bitmap Change_brightnessbutton(Bitmap b1)
        {
            Bitmap originalImage = b1;
            Bitmap adjustedImage = b1;
            float brightness = 0.8f; // no change in brightness
            float contrast = 2.0f; // twice the contrast
            float gamma = 1.0f; // no change in gamma

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
                new float[] {contrast, 0, 0, 0, 0}, // scale red
                new float[] {0, contrast, 0, 0, 0}, // scale green
                new float[] {0, 0, contrast, 0, 0}, // scale blue
                new float[] {0, 0, 0, 0.3f, 0}, // don't scale alpha
                new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(adjustedImage);
            g.DrawImage(originalImage, new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                , 0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes);

            return adjustedImage;
        }
        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }

        #endregion



        private void roundButton1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap originalImage = (Bitmap)backButton.Image;
            backButton.Image = Change_brightnessbutton(originalImage);

        }

        private void roundButton2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap originalImage = (Bitmap)forwardButton.Image;
            forwardButton.Image = Change_brightnessbutton(originalImage);

        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap image;
            image = new Bitmap(imageList2.Images[1]);
            forwardButton.Image = image;

        }

        Manage_music manage_Music = new Manage_music();
        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_Music.Text = "Music Library Location";
            manage_Music.StartPosition = FormStartPosition.CenterScreen;
            MusicLib = manage_Music.getadress;

            manage_Music.ShowDialog();

        }
        Manage_Pictures manage_Pictures = new Manage_Pictures();
        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_Pictures.Text = "Pictures Library Location";
            manage_Pictures.StartPosition = FormStartPosition.CenterScreen;
            manage_Pictures.ShowDialog();
            PicturesLib = manage_Pictures.getadress;
        }
        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Videos manage_Videos = new Manage_Videos();
            manage_Videos.Text = "Videos Library Location";
            manage_Videos.StartPosition = FormStartPosition.CenterScreen;
            manage_Videos.ShowDialog();
            if (manage_Videos.DialogResult == DialogResult.OK)
            {
                VideosLib = manage_Videos.getadress;
            }
        }
        private void createPlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("Untitled list");
            tn.ImageIndex = 1;
            tn.SelectedImageIndex = 1;
            treeView1.Nodes[1].Nodes.Add(tn);
            treeView1.ExpandAll();

        }
        string now_is_at;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            now_is_at = e.Node.Name;
            render(now_is_at);
            backstack.Push(e.Node.Name);
            forwardstack.Clear();

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenu context = new ContextMenu();
                        context.MenuItems.Add("Delete");
                        context.MenuItems[0].Click += this.delete_treenode;
                        context.Show(treeView1, e.Location);
                        break;
                    }
            }
        }


        private void delete_treenode( Object sender, EventArgs eventArgs)
        {
            treeView1.SelectedNode.Remove();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (backstack.Count > 0)
            {
                forwardstack.Push(backstack.Peek());
                string text = backstack.Pop();
                render(text);

            }

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (forwardstack.Count > 0)
            {
                backstack.Push(forwardstack.Peek());
                string text = forwardstack.Pop();
                render(text);

            }

        }

        #endregion

        #region mainlistview
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.listView1.Sort();
        }


        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.AliceBlue, e.Bounds);
            e.DrawText();
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void render(string node)
        {
            if (node == "Music")
            {
                textBoxaddress.Text = "Library → Music";
                listView1.Clear();
                listView1.BackColor = Color.AliceBlue;
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                listView1.LargeImageList = imageList2;
                listView1.SmallImageList = imageList2;

                listView1.Columns.Add("Title", 240);
                listView1.Columns.Add("Contributing artist", 180);
                listView1.Columns.Add("Length", 90);
                listView1.Columns.Add("Release", 70);
                listView1.Columns.Add("Filename", 0);
                listView1.Columns.Add("Filedir", 0);
                listView1.Columns.Add("Album", 200);
                listView1.Columns.Add("Genre", 70);
                listView1.Columns.Add("Composer", 110);
                listView1.Columns.Add("Size", 70);
                listView1.Columns.Add("", 130);
                ListViewItem itm;
                for (int i=0; i< MusicLib.Count; i++)
                {
                    string[] fileEntries = Directory.GetFiles(MusicLib[i], "*.mp3");
                    foreach (string fileName in fileEntries)
                    {
                        string filedir;
                        filedir = fileName;

                        itm = new ListViewItem(converttotaglib_music(filedir));

                        listView1.Items.Add(itm);
                        itm.ImageIndex = 2;

                    }

                }

            }
            else if (node == "Artists")
            {
                textBoxaddress.Text = "Library → Music → Artists";
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList3;

                listView1.Columns.Add("Album artists", 50);
                listView1.Columns.Add("Count", 50);
                listView1.Columns.Add("Length", 50);

                ListViewItem viewItem;
                for (int i = 0; i< MusicLib.Count; i++)
                {
                    string[] fileEntries = Directory.GetFiles(MusicLib[i], "*.mp3");
                    foreach (string fileName in fileEntries)
                    {
                        string filedir;
                        filedir = fileName;

                        viewItem = new ListViewItem(converttotaglib_artist(filedir));

                        listView1.Items.Add(viewItem);
                        viewItem.ImageIndex = 0;

                    }


                }

            }
            else if (node == "Album")
            {
                textBoxaddress.Text = "Library → Music → Albums";
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList3;

                listView1.Columns.Add("Albums", 10);
                listView1.Columns.Add("Singer", 90);
                listView1.Columns.Add("Length", 100);
                listView1.Columns.Add("Year");
                listView1.Columns.Add("Filename", 0);
                listView1.Columns.Add("AdressFile", 0);
                ListViewItem viewItem;
                for (int i = 0; i<MusicLib.Count; i++)
                {
                    string[] fileEntries = Directory.GetFiles(MusicLib[i], "*.mp3");
                    foreach (string fileName in fileEntries)
                    {
                        string filedir;
                        filedir = fileName;

                        viewItem = new ListViewItem(converttotaglib_album(filedir));

                        listView1.Items.Add(viewItem);
                        viewItem.ImageIndex = 1;

                    }
                }

            }
            else if (node == "Genre")
            {
                textBoxaddress.Text = "Library → Music → Genre";
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList3;

                listView1.Columns.Add("Genre", 50);
                listView1.Columns.Add("Count", 50);
                listView1.Columns.Add("Length", 50);

                ListViewItem viewItem;
                for (int i = 0; i<MusicLib.Count; i++)
                {
                    string[] fileEntries = Directory.GetFiles(MusicLib[i], "*.mp3");
                    foreach (string fileName in fileEntries)
                    {
                        string filedir;
                        filedir = fileName;

                        viewItem = new ListViewItem(converttotaglib_genre(filedir));

                        listView1.Items.Add(viewItem);
                        viewItem.ImageIndex = 2;

                    }
                }

            }
            else if (node == "Videos")
            {
                textBoxaddress.Text = "Library → Videos → All Videos";
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList3;
                listView1.SmallImageList = imageList3;

                listView1.Columns.Add("Title", 400);
                listView1.Columns.Add("Length", 100);
                listView1.Columns.Add("Size", 100);
                listView1.Columns.Add("Release year", 100);
                listView1.Columns.Add("Genre", 100);
                listView1.Columns.Add("Path", 0);
                listView1.Columns.Add("", 400);


                ListViewItem viewItem;
                string[] fileEntries = Directory.GetFiles(VideosLib, "*.mp4");
                foreach (string fileName in fileEntries)
                {
                    string filedir;
                    filedir = fileName;

                    viewItem = new ListViewItem(converttotaglib_video(filedir));

                    listView1.Items.Add(viewItem);
                    viewItem.ImageIndex = 3;

                }



            }
            else if (node == "Pictures")
            {

                textBoxaddress.Text = "Library → Pictures→ All Pictures";
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.Columns.Add("Images");
                ImageList iml = new ImageList();
                iml.ImageSize = new Size(90, 70);

                listView1.LargeImageList = iml;
                for (int i = 0; i<PicturesLib.Count; i++)
                {
                    string[] fileEntries = Directory.GetFiles(PicturesLib[i], "*.jpg");
                    foreach (string fileName in fileEntries)
                    {
                        Image image = Image.FromFile(fileName);
                        string file = Path.GetFileName(fileName);
                        iml.Images.Add(file, image);

                        ListViewItem viewItem = new ListViewItem();
                        viewItem.Text = file;

                        viewItem.ImageKey = file;
                        viewItem.SubItems.Add(fileName);

                        listView1.Items.Add(viewItem);

                    }
                }
              

            }
            else if (node == "Playlists")
            {
                textBoxaddress.Text = "Library → Playlists";
                listView1.Clear();
                listView1.View = View.Details;

            }



        }
        string[] converttotaglib_music(string a)
        {
            string[] returnvalue = new string[10];
            TagLib.File mp3 = TagLib.File.Create(a);

            if (mp3.Tag.Title == null)
            {
                returnvalue[0] = Path.GetFileName(a);
            }
            else
                returnvalue[0] = mp3.Tag.Title;

            returnvalue[1] = mp3.Tag.FirstPerformer;
            returnvalue[2] = mp3.Properties.Duration.ToString().Split('.')[0];
            if (mp3.Tag.Year.ToString() == "0")
                returnvalue[3] = "Unknown";
            else
                returnvalue[3] = mp3.Tag.Year.ToString();
            returnvalue[4] = Path.GetFileName(a);
            returnvalue[5] = a;
            returnvalue[6] = mp3.Tag.Album;
            returnvalue[7] = mp3.Tag.FirstGenre;
            returnvalue[8] = mp3.Tag.FirstComposer;
            double size = new FileInfo(a).Length;
            size = size / 1024 / 1024;
            size = Math.Round(size, 1);
            returnvalue[9] = size.ToString() + " MB";

            return returnvalue;

        }

        string[] converttotaglib_artist(string a)
        {
            string[] returnvalue = new string[6];
            TagLib.File mp3 = TagLib.File.Create(a);

            if (mp3.Tag.FirstPerformer==null)
            {
                returnvalue[0] = "Unknown";
            }
            else
                returnvalue[0] = mp3.Tag.FirstPerformer;
            returnvalue[5] = a;

            return returnvalue;

        }
        string[] converttotaglib_genre(string a)
        {
            string[] returnvalue = new string[6];
            TagLib.File mp3 = TagLib.File.Create(a);

            if (mp3.Tag.FirstGenre == null)
            {
                returnvalue[0] = "Unknown";
            }
            else
                returnvalue[0] = mp3.Tag.FirstGenre;
            returnvalue[5] = a;

            return returnvalue;

        }

        string[] converttotaglib_album(string a)
        {
            string[] returnvalue = new string[6];
            TagLib.File mp3 = TagLib.File.Create(a);

            if (mp3.Tag.Album == null)
            {
                returnvalue[0] = "Unknown";
            }
            else
                returnvalue[0] = mp3.Tag.Album;
            returnvalue[5] = a;

            return returnvalue;

        }

        string[] converttotaglib_video(string a)
        {
            string[] returnvalue = new string[6];
            TagLib.File mp3 = TagLib.File.Create(a);
            returnvalue[0] = Path.GetFileName(a);
            returnvalue[1] = mp3.Properties.Duration.ToString().Split('.')[0];

            double size = new FileInfo(a).Length;
            size = size / 1024 / 1024;
            size = Math.Round(size, 1);
            returnvalue[2] = size.ToString() + " MB";
            if (mp3.Tag.Year.ToString() == "0")
                returnvalue[3] = "Unknown";
            else
                returnvalue[3] = mp3.Tag.Year.ToString();

            returnvalue[5] = a;

            return returnvalue;

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (now_is_at == "Pictures")
            {
                ShowImage showImage = new ShowImage();
                string imagefile = listView1.SelectedItems[0].SubItems[1].Text;
                showImage.get_adress_image = imagefile;
                showImage.StartPosition = FormStartPosition.CenterParent;
                showImage.ShowDialog();
                return;
            }
               
            WMPLib.IWMPMedia media;
            string plist = DateTime.UtcNow.ToString();
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist(plist);
            int count = listView1.SelectedItems.Count;
            label_countsongs.Text = count + " items";
            playlist_listview.Clear();
            playlist_listview.Columns.Add("Song", 150);
            playlist_listview.Columns.Add("Artist", 100);
            playlist_listview.Columns.Add("Length", 90);
            playlist_listview.Columns.Add("Path", 0);

            playlist_listview.View = View.Details;
            for (int i = 0; i < count; i++)
            {
                string st = listView1.SelectedItems[i].SubItems[5].Text;
                string[] row = {
                        listView1.SelectedItems[i].SubItems[0].Text,
                        listView1.SelectedItems[i].SubItems[1].Text,
                        listView1.SelectedItems[i].SubItems[2].Text,
                        listView1.SelectedItems[i].SubItems[5].Text,

                    };
                var listviewitem = new ListViewItem(row);

                playlist_listview.Items.Add(listviewitem);

                media = axWindowsMediaPlayer1.newMedia(st);
                playlist.appendItem(media);

            }

            axWindowsMediaPlayer1.currentPlaylist = playlist;

            
            //
        }

        private void playlist_listview_DoubleClick(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia media;
            string plist = DateTime.UtcNow.ToString();
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist(plist);
            int index = playlist_listview.Items.IndexOf(playlist_listview.SelectedItems[0]);
            media = axWindowsMediaPlayer1.currentPlaylist.Item[index];
            playlist.appendItem(media);
            axWindowsMediaPlayer1.Ctlcontrols.playItem(media);

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs ea = (EventArgs)e;
                this.listView1_DoubleClick(sender, ea);

            }
            if (e.KeyCode == Keys.A && e.Control)
            {
                listView1.MultiSelect = true;
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Selected = true;
                }
            }
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenu contextMenu = new ContextMenu();
                        contextMenu.MenuItems.Add("Play");
                        contextMenu.MenuItems.Add("Play all");
                        contextMenu.MenuItems.Add("Play next");
                        contextMenu.MenuItems.Add("Cast to device");
                        contextMenu.MenuItems.Add("_______");
                        contextMenu.MenuItems.Add("Edit");
                        contextMenu.MenuItems.Add("Rate");
                        contextMenu.MenuItems.Add("Find album info");
                        contextMenu.MenuItems.Add("Delete");
                        contextMenu.MenuItems.Add("_______");
                        contextMenu.MenuItems.Add("Property");
                        contextMenu.MenuItems.Add("_______");
                        contextMenu.MenuItems.Add("Open file location");


                        contextMenu.Show(listView1, e.Location);
                        contextMenu.MenuItems[0].Click += this.listView1_DoubleClick;
                        contextMenu.MenuItems[1].Click += this.play_all_meida;
                        contextMenu.MenuItems[8].Click += this.delete_selected_items;
                        contextMenu.MenuItems[12].Click += this.open_file_location;
                        break;
                    }
            }
            //

        }

        private void delete_selected_items(Object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }
        private void play_all_meida(Object sender, EventArgs eventArgs)
        {
            foreach (ListViewItem eachItem in listView1.Items)
            {
                eachItem.Selected = true;
            }
            this.listView1_DoubleClick(sender,eventArgs);

        }
        private void open_file_location ( Object sender, EventArgs eventArgs)
        {
            string filePath;
            if (now_is_at == "Pictures")

                filePath = listView1.SelectedItems[0].SubItems[1].Text;
            else
                filePath = listView1.SelectedItems[0].SubItems[5].Text;

            if (System.IO.File.Exists(filePath))
            {
                Process.Start("explorer.exe", "/select, " + filePath);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            label3.Text = listView1.SelectedItems.Count.ToString() + " items selected";
            label3.ForeColor = Color.RoyalBlue;
            label3.Show();
            var t = new Timer();
            t.Interval = 5000; 
            t.Tick += (s, ee) =>
            {
                label3.Hide();
                t.Stop();
            };
            t.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((now_is_at == "Artists") || (now_is_at == "Album") || (now_is_at == "Genre")|| (now_is_at=="Pictures"))
                return;
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.View = View.Details;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                listView1.View = View.LargeIcon;

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Save list";
            button3.Text = "Clear list";
            playlist_listview.Show();
            textBox1.Text = "Unsaved list";
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            textBox1.Enabled = true;
            Image image = Windows_MediaPlayer.Properties.Resources.Playlist;

            pictureBox2.BackgroundImage = image;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            label2.Text = "Unsaved list";
            label2.ForeColor = Color.Blue;
        }
        private void tabburnbt_Click(object sender, EventArgs e)
        {

            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Start burn";
            playlist_listview.Hide();
            textBox1.Text = "Burn list";
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox1.Enabled = true;

            Image image = Windows_MediaPlayer.Properties.Resources.cd_music;
            pictureBox2.BackgroundImage = image;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            label2.Text = "Insert a blank CD";
            label2.ForeColor = Color.Gray;

        }

        private void tabsyncbt_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Start sync";
            textBox1.Text = "Sync list";
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox1.Enabled = false;
            Image image = Windows_MediaPlayer.Properties.Resources.Mobile_connect;
            pictureBox2.BackgroundImage = image;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            label2.Text = "Connect a device";
            label2.ForeColor = Color.Black;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text=="Save list")
            {
                TreeNode tn = new TreeNode(textBox1.Text);
                tn.ImageIndex = 1;
                tn.SelectedImageIndex = 1;
                treeView1.Nodes[1].Nodes.Add(tn);
                treeView1.ExpandAll();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                KeyEventArgs ea = (KeyEventArgs)e;
                this.button4_Click(sender, ea);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Clear list")
            {
                playlist_listview.Clear();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            listView1.BeginUpdate();

            render(now_is_at);

            string search = textBoxSearch.Text;
            if (search != String.Empty)
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    ListViewItem currentItem = listView1.Items[i];
                    if (ItemMatches(currentItem, search))
                    {
                        currentItem.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        listView1.Items.RemoveAt(i);
                    }
                }
            }

            listView1.EndUpdate();
        }

        private bool ItemMatches(ListViewItem item, string text)
        {
            bool matches = false;

            matches |= item.Text.ToLower().Contains(text.ToLower());

            if (matches)
            {
                return true;
            }

            foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
            {
                matches |= subitem.Text.ToLower().Contains(text.ToLower());
                if (matches)
                {
                    return true;
                }
            }

            return false;
        }

        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Font = new Font(textBoxSearch.Font, FontStyle.Regular);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = true;
        }



        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.None;
        }

        #endregion


        #region player
        private void axWindowsMediaPlayer1_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            //
        }
        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            label1.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");

            if (now_is_at =="Videos")
            {
                var bmp = new Bitmap(Windows_MediaPlayer.Properties.Resources.Videos);
                pictureBox1.BackgroundImage = (Image)bmp;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

            }
            else
            {
                var bmp = new Bitmap(Windows_MediaPlayer.Properties.Resources.if_083_Music_183211);
                pictureBox1.BackgroundImage = (Image)bmp;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        bool loop = false;
        bool shuffle = false;

        private void button5_Click(object sender, EventArgs e)
        {
            if (shuffle == true)
            {
                shuffle = false;
                axWindowsMediaPlayer1.settings.setMode("shuffle", false);
                return;
            }
            if (shuffle == false)
            {
                shuffle = true;
                axWindowsMediaPlayer1.settings.setMode("shuffle", true);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (loop == true)
            {
                loop = false;
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                return;
            }
            else
            {
                loop = true;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (shuffle == false)
                tt.SetToolTip(button5, "Turn shuffle on");
            else if (shuffle == true)
            {
                tt.SetToolTip(button5, "Turn shuffle off");

            }


        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (loop == true)
                tt.SetToolTip(button6, "Turn repeat off ");
            else if (loop == false)
            {
                tt.SetToolTip(button6, "Turn repeat on ");

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(button1, "Enter full screen mode (F12)");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double t = Math.Floor(axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            var timespan = new TimeSpan(0, 0, (int)t);
            var yourStr = string.Format("{00}:{1:00}",
                            (int)timespan.TotalMinutes,
                            timespan.Seconds);
            labeltimeremain.Text = yourStr.ToString();

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();

            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();

            }
            if (now_is_at == "Videos")
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.fullScreen = true;
                }
            }
        }

        private void labeltimeremain_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(labeltimeremain, "Time remaining");
        }





        #endregion


    }
}
