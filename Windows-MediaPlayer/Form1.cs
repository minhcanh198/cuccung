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

namespace Windows_MediaPlayer
{

    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            Manage_music ms = new Manage_music();
            MusicLib = ms.getadress;

            render("Music");
        }
        Stack<string> backstack = new Stack<string>();
        Stack<string> forwardstack = new Stack<string>();
        string MusicLib;
        string VideosLib;
        string PicturesLib;
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.Fill;
            textBoxaddress.Text = "Library";
            splitContainer2.Panel2Collapsed=true;
        }


        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
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
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.View = View.Details;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                listView1.View = View.LargeIcon;

            }


        }


        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap image;
            image = new Bitmap(imageList2.Images[0]);
            backButton.Image = image;
        }
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
                new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
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

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_music managemusicform = new Manage_music();
            managemusicform.Text = "Music Library Location";
            managemusicform.StartPosition = FormStartPosition.CenterScreen;
            managemusicform.ShowDialog();

            if (managemusicform.DialogResult == DialogResult.OK)
            {
                MusicLib = managemusicform.getadress;
            }
        }
        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Pictures manage_Pictures = new Manage_Pictures();
            manage_Pictures.Text = "Pictures Library Location";
            manage_Pictures.StartPosition = FormStartPosition.CenterScreen;
            manage_Pictures.ShowDialog();
            if (manage_Pictures.DialogResult== DialogResult.OK)
            {
                PicturesLib = manage_Pictures.getadress;
            }
        }
        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Videos manage_Videos = new Manage_Videos();
            manage_Videos.Text = "Videos Library Location";
            manage_Videos.StartPosition = FormStartPosition.CenterScreen;
            manage_Videos.ShowDialog();
            if (manage_Videos.DialogResult== DialogResult.OK)
            {
                VideosLib = manage_Videos.getadress;
            }
        }

        private void render(string name)
        {
            if (name=="Music")
            {
                textBoxaddress.Text = "Library → Music";
                listView1.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                listView1.LargeImageList = imageList2;
                listView1.SmallImageList = imageList2;

                listView1.Columns.Add("Song",200);
                listView1.Columns.Add("Singer",90);
                listView1.Columns.Add("Length",100);
                listView1.Columns.Add("Year");
                listView1.Columns.Add("Filename",0);
                ListViewItem itm;

                string[] fileEntries = Directory.GetFiles(MusicLib, "*.mp3");
                foreach (string fileName in fileEntries)
                {
                    string filedir;
                    filedir = fileName;

                    itm = new ListViewItem(converttotaglib(filedir));

                    listView1.Items.Add(itm);
                    itm.ImageIndex = 2;

                }

            }
            else if (name == "Album")
            {
                textBoxaddress.Text= "Library → Music → Albums";
                listView1.Clear();
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                listView1.LargeImageList = imageList2;
                listView1.SmallImageList = imageList2;

                listView1.Columns.Add("Song", 200);
                listView1.Columns.Add("Singer", 90);
                listView1.Columns.Add("Length",100);
                listView1.Columns.Add("Year");
                listView1.Columns.Add("Filename", 0);
                listView1.Columns.Add("AdressFile", 0);
                ListViewItem itm;

                string[] fileEntries = Directory.GetFiles(MusicLib,"*.mp3");
                foreach (string fileName in fileEntries)
                {
                    string filedir;
                    filedir = fileName;

                    itm = new ListViewItem(converttotaglib(filedir));

                    listView1.Items.Add(itm);
                    itm.ImageIndex = 2;

                }
            }
            else if (name== "Videos")
            {
                textBoxaddress.Text = "Library → Videos → All Videos";
                listView1.Clear();
                listView1.View = View.Details;

            }
            else if (name=="Pictures")
            {
                textBoxaddress.Text = "Library → Pictures→ All Pictures";
                listView1.Clear();
                listView1.View = View.Details;

            }
            else if (name == "Playlists")
            {
                textBoxaddress.Text = "Library → Playlists";
                listView1.Clear();
                listView1.View = View.Details;

            }


        }
        string[] converttotaglib(string a)
        {
            string[] returnvalue= new string[6];
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
                returnvalue[3] = "N/A";
            else
                returnvalue[3] = mp3.Tag.Year.ToString();
            returnvalue[4] = Path.GetFileName(a);
            returnvalue[5] = a;

            return returnvalue;

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            render(e.Node.Name);
            backstack.Push(e.Node.Name);
            forwardstack.Clear();

        }



        private void backButton_Click(object sender, EventArgs e)
        {
            if (backstack.Count>0)
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

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Save List";
            button3.Text = "Clear List";
        }
        private void tabburnbt_Click(object sender, EventArgs e)
        {

            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Start Burn";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia media;
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");

            int count = listView1.SelectedItems.Count;
            for ( int i= 0; i<count; i++)
            {
                string st = listView1.SelectedItems[i].SubItems[5].Text;
                media = axWindowsMediaPlayer1.newMedia(st);
                playlist.appendItem(media);

            }

            axWindowsMediaPlayer1.currentPlaylist = playlist;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            OpenFileDialog ofdSong = new OpenFileDialog();
            ofdSong.Multiselect = true;
            if (ofdSong.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofdSong.FileNames)
                {
                    media = axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
            }
            axWindowsMediaPlayer1.currentPlaylist = playlist;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia media;
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            int count = listView1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                string st = listView1.SelectedItems[i].SubItems[5].Text;
                media = axWindowsMediaPlayer1.newMedia(st);
                playlist.appendItem(media);

            }

            axWindowsMediaPlayer1.currentPlaylist = playlist;

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WMPLib.IWMPMedia media;
                var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
                int count = listView1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    string st = listView1.SelectedItems[i].SubItems[5].Text;
                    media = axWindowsMediaPlayer1.newMedia(st);
                    playlist.appendItem(media);

                }

                axWindowsMediaPlayer1.currentPlaylist = playlist;


            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem =
                listView1.FindItemWithText(textBoxSearch.Text, true, 0, true);
            if (foundItem != null)
            {
                listView1.TopItem = foundItem;

            }
        }

        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Font = new Font(textBoxSearch.Font, FontStyle.Regular);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {

        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
           //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
           // {
           //     label1.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
           // } 
            label1.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = true;
        }

        private void tabsyncbt_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = false;
            button4.Text = "Start Sync";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        bool loop = false;

        private void button6_Click(object sender, EventArgs e)
        {
            if (loop == true)
            {
                loop = false;
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                label2.Text = "Turn off repeat";
            }
            else
            {
                loop = true;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                label2.Text = "Turn on repeat";
                

            }
        }


    }
}
