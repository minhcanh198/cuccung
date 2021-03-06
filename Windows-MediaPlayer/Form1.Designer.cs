﻿namespace Windows_MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Library");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Playlists", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Artists", 6, 6);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Album", 5, 5);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Genre", 7, 7);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Music", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Videos", 3, 3);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Pictures", 4, 4);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_countsongs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playlist_listview = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.organizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordedTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyMediaInformationChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowInternetAccessToHomeMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.turnOnMeidaStreamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAutoPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabplaybt = new System.Windows.Forms.Button();
            this.tabburnbt = new System.Windows.Forms.Button();
            this.tabsyncbt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltimeremain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helpbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new Windows_MediaPlayer.RoundButton();
            this.forwardButton = new Windows_MediaPlayer.RoundButton();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 402);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(805, 60);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.CurrentPlaylistChange += new AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEventHandler(this.axWindowsMediaPlayer1_CurrentPlaylistChange);
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 120;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(805, 354);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Library";
            treeNode1.Text = "Library";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Playlists";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Playlists";
            treeNode3.ImageIndex = 6;
            treeNode3.Name = "Artists";
            treeNode3.SelectedImageIndex = 6;
            treeNode3.Text = "Artists";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "Album";
            treeNode4.SelectedImageIndex = 5;
            treeNode4.Text = "Album";
            treeNode5.ImageIndex = 7;
            treeNode5.Name = "Genre";
            treeNode5.SelectedImageIndex = 7;
            treeNode5.Text = "Genre";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "Music";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Music";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "Videos";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "Videos";
            treeNode8.ImageIndex = 4;
            treeNode8.Name = "Pictures";
            treeNode8.SelectedImageIndex = 4;
            treeNode8.Text = "Pictures";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(150, 324);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Library.png");
            this.imageList1.Images.SetKeyName(1, "Playlist.png");
            this.imageList1.Images.SetKeyName(2, "if_083_Music_183211.png");
            this.imageList1.Images.SetKeyName(3, "Videos.png");
            this.imageList1.Images.SetKeyName(4, "Pictures.png");
            this.imageList1.Images.SetKeyName(5, "Albums.png");
            this.imageList1.Images.SetKeyName(6, "Artists.png");
            this.imageList1.Images.SetKeyName(7, "Genre.png");
            this.imageList1.Images.SetKeyName(8, "helpbut.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1MinSize = 347;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Controls.Add(this.label_countsongs);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.playlist_listview);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2MinSize = 200;
            this.splitContainer2.Size = new System.Drawing.Size(651, 352);
            this.splitContainer2.SplitterDistance = 408;
            this.splitContainer2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.AliceBlue;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(408, 352);
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // label_countsongs
            // 
            this.label_countsongs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_countsongs.AutoSize = true;
            this.label_countsongs.Location = new System.Drawing.Point(10, 335);
            this.label_countsongs.Name = "label_countsongs";
            this.label_countsongs.Size = new System.Drawing.Size(40, 13);
            this.label_countsongs.TabIndex = 5;
            this.label_countsongs.Text = "0 items";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // playlist_listview
            // 
            this.playlist_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlist_listview.BackColor = System.Drawing.Color.AliceBlue;
            this.playlist_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlist_listview.FullRowSelect = true;
            this.playlist_listview.Location = new System.Drawing.Point(2, 113);
            this.playlist_listview.Name = "playlist_listview";
            this.playlist_listview.Size = new System.Drawing.Size(234, 218);
            this.playlist_listview.TabIndex = 3;
            this.playlist_listview.UseCompatibleStateImageBehavior = false;
            this.playlist_listview.DoubleClick += new System.EventHandler(this.playlist_listview_DoubleClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(7, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(80, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(196, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizeToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.createPlaylistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // organizeToolStripMenuItem
            // 
            this.organizeToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.organizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLibraryToolStripMenuItem,
            this.applyMediaInformationChangesToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortByToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionToolStripMenuItem});
            this.organizeToolStripMenuItem.Name = "organizeToolStripMenuItem";
            this.organizeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.organizeToolStripMenuItem.Text = "Organize";
            // 
            // manageLibraryToolStripMenuItem
            // 
            this.manageLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.videosToolStripMenuItem,
            this.picturesToolStripMenuItem,
            this.recordedTVToolStripMenuItem});
            this.manageLibraryToolStripMenuItem.Name = "manageLibraryToolStripMenuItem";
            this.manageLibraryToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.manageLibraryToolStripMenuItem.Text = "Manage library";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.videosToolStripMenuItem.Text = "Videos";
            this.videosToolStripMenuItem.Click += new System.EventHandler(this.videosToolStripMenuItem_Click);
            // 
            // picturesToolStripMenuItem
            // 
            this.picturesToolStripMenuItem.Name = "picturesToolStripMenuItem";
            this.picturesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.picturesToolStripMenuItem.Text = "Pictures";
            this.picturesToolStripMenuItem.Click += new System.EventHandler(this.picturesToolStripMenuItem_Click);
            // 
            // recordedTVToolStripMenuItem
            // 
            this.recordedTVToolStripMenuItem.Name = "recordedTVToolStripMenuItem";
            this.recordedTVToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.recordedTVToolStripMenuItem.Text = "Recorded TV";
            // 
            // applyMediaInformationChangesToolStripMenuItem
            // 
            this.applyMediaInformationChangesToolStripMenuItem.Name = "applyMediaInformationChangesToolStripMenuItem";
            this.applyMediaInformationChangesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.applyMediaInformationChangesToolStripMenuItem.Text = "Apply media information changes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.albumArtistToolStripMenuItem,
            this.albumsToolStripMenuItem,
            this.releaseDateToolStripMenuItem,
            this.ratingToolStripMenuItem,
            this.fileNameToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.streamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowInternetAccessToHomeMediaToolStripMenuItem,
            this.toolStripSeparator3,
            this.turnOnMeidaStreamingToolStripMenuItem});
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // allowInternetAccessToHomeMediaToolStripMenuItem
            // 
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Name = "allowInternetAccessToHomeMediaToolStripMenuItem";
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.allowInternetAccessToHomeMediaToolStripMenuItem.Text = "Allow Internet access to home media";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(266, 6);
            // 
            // turnOnMeidaStreamingToolStripMenuItem
            // 
            this.turnOnMeidaStreamingToolStripMenuItem.Name = "turnOnMeidaStreamingToolStripMenuItem";
            this.turnOnMeidaStreamingToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.turnOnMeidaStreamingToolStripMenuItem.Text = "Turn on meida streaming";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.createPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPlaylistToolStripMenuItem1,
            this.createAutoPlaylistToolStripMenuItem});
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            // 
            // createPlaylistToolStripMenuItem1
            // 
            this.createPlaylistToolStripMenuItem1.Name = "createPlaylistToolStripMenuItem1";
            this.createPlaylistToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.createPlaylistToolStripMenuItem1.Text = "Create playlist";
            this.createPlaylistToolStripMenuItem1.Click += new System.EventHandler(this.createPlaylistToolStripMenuItem1_Click);
            // 
            // createAutoPlaylistToolStripMenuItem
            // 
            this.createAutoPlaylistToolStripMenuItem.Name = "createAutoPlaylistToolStripMenuItem";
            this.createAutoPlaylistToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.createAutoPlaylistToolStripMenuItem.Text = "Create auto playlist";
            // 
            // tabplaybt
            // 
            this.tabplaybt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabplaybt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabplaybt.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.tabplaybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabplaybt.Location = new System.Drawing.Point(574, 10);
            this.tabplaybt.Name = "tabplaybt";
            this.tabplaybt.Size = new System.Drawing.Size(75, 47);
            this.tabplaybt.TabIndex = 1;
            this.tabplaybt.Text = "Play";
            this.tabplaybt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabplaybt.UseVisualStyleBackColor = false;
            this.tabplaybt.Click += new System.EventHandler(this.button1_Click);
            this.tabplaybt.MouseHover += new System.EventHandler(this.tabplaybt_MouseHover);
            // 
            // tabburnbt
            // 
            this.tabburnbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabburnbt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabburnbt.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.tabburnbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabburnbt.Location = new System.Drawing.Point(654, 10);
            this.tabburnbt.Name = "tabburnbt";
            this.tabburnbt.Size = new System.Drawing.Size(75, 47);
            this.tabburnbt.TabIndex = 9;
            this.tabburnbt.Text = "Burn";
            this.tabburnbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabburnbt.UseVisualStyleBackColor = false;
            this.tabburnbt.Click += new System.EventHandler(this.tabburnbt_Click);
            this.tabburnbt.MouseHover += new System.EventHandler(this.tabburnbt_MouseHover);
            // 
            // tabsyncbt
            // 
            this.tabsyncbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsyncbt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabsyncbt.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.tabsyncbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabsyncbt.Location = new System.Drawing.Point(734, 10);
            this.tabsyncbt.Name = "tabsyncbt";
            this.tabsyncbt.Size = new System.Drawing.Size(71, 47);
            this.tabsyncbt.TabIndex = 10;
            this.tabsyncbt.Text = "Sync";
            this.tabsyncbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabsyncbt.UseVisualStyleBackColor = false;
            this.tabsyncbt.Click += new System.EventHandler(this.tabsyncbt_Click);
            this.tabsyncbt.MouseHover += new System.EventHandler(this.tabsyncbt_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Details",
            "Large icon"});
            this.comboBox1.Location = new System.Drawing.Point(573, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "View";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "if_ic_arrow_back_48px_352020.png");
            this.imageList2.Images.SetKeyName(1, "if_ic_arrow_forward_48px_352024.png");
            this.imageList2.Images.SetKeyName(2, "if_083_Music_183211.png");
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaddress.Location = new System.Drawing.Point(87, 11);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(297, 14);
            this.textBoxaddress.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(663, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseClick);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.helpbut);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 29);
            this.panel1.TabIndex = 20;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Artists.png");
            this.imageList3.Images.SetKeyName(1, "Albums.png");
            this.imageList3.Images.SetKeyName(2, "Genre.png");
            this.imageList3.Images.SetKeyName(3, "Videos.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltimeremain
            // 
            this.labeltimeremain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labeltimeremain.AutoSize = true;
            this.labeltimeremain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labeltimeremain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimeremain.Location = new System.Drawing.Point(280, 435);
            this.labeltimeremain.Name = "labeltimeremain";
            this.labeltimeremain.Size = new System.Drawing.Size(0, 15);
            this.labeltimeremain.TabIndex = 26;
            this.labeltimeremain.MouseHover += new System.EventHandler(this.labeltimeremain_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(347, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 28);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(313, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 28);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.BackgroundImage = global::Windows_MediaPlayer.Properties.Resources.repeatbut;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(251, 432);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 21);
            this.button6.TabIndex = 24;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(217, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 21);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Windows_MediaPlayer.Properties.Resources.fullscreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(769, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // helpbut
            // 
            this.helpbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpbut.BackColor = System.Drawing.Color.AliceBlue;
            this.helpbut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpbut.BackgroundImage")));
            this.helpbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpbut.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.helpbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbut.ImageKey = "(none)";
            this.helpbut.ImageList = this.imageList1;
            this.helpbut.Location = new System.Drawing.Point(770, 3);
            this.helpbut.Name = "helpbut";
            this.helpbut.Size = new System.Drawing.Size(24, 23);
            this.helpbut.TabIndex = 17;
            this.helpbut.UseVisualStyleBackColor = false;
            this.helpbut.Click += new System.EventHandler(this.helpbut_Click);
            this.helpbut.MouseHover += new System.EventHandler(this.helpbut_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // backButton
            // 
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.imageList2;
            this.backButton.Location = new System.Drawing.Point(9, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 35);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseHover);
            this.backButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseMove);
            // 
            // forwardButton
            // 
            this.forwardButton.ImageIndex = 1;
            this.forwardButton.ImageList = this.imageList2;
            this.forwardButton.Location = new System.Drawing.Point(38, -1);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(35, 35);
            this.forwardButton.TabIndex = 7;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            this.forwardButton.MouseLeave += new System.EventHandler(this.roundButton2_MouseLeave);
            this.forwardButton.MouseHover += new System.EventHandler(this.forwardButton_MouseHover);
            this.forwardButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roundButton2_MouseMove);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // albumArtistToolStripMenuItem
            // 
            this.albumArtistToolStripMenuItem.Name = "albumArtistToolStripMenuItem";
            this.albumArtistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.albumArtistToolStripMenuItem.Text = "Album artist";
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.albumsToolStripMenuItem.Text = "Albums";
            // 
            // releaseDateToolStripMenuItem
            // 
            this.releaseDateToolStripMenuItem.Name = "releaseDateToolStripMenuItem";
            this.releaseDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.releaseDateToolStripMenuItem.Text = "Release date";
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ratingToolStripMenuItem.Text = "Rating";
            // 
            // fileNameToolStripMenuItem
            // 
            this.fileNameToolStripMenuItem.Name = "fileNameToolStripMenuItem";
            this.fileNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileNameToolStripMenuItem.Text = "File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labeltimeremain);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabplaybt);
            this.Controls.Add(this.tabburnbt);
            this.Controls.Add(this.tabsyncbt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem organizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyMediaInformationChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowInternetAccessToHomeMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem turnOnMeidaStreamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAutoPlaylistToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private RoundButton forwardButton;
        private RoundButton backButton;
        private System.Windows.Forms.Button tabplaybt;
        private System.Windows.Forms.Button tabburnbt;
        private System.Windows.Forms.Button tabsyncbt;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordedTVToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button helpbut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView playlist_listview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltimeremain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_countsongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNameToolStripMenuItem;
    }
}

