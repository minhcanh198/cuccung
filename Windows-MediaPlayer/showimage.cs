using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_MediaPlayer
{
    public partial class ShowImage : Form
    {
        public ShowImage()
        {
            InitializeComponent();
        }
        string adress;
        public string get_adress_image
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(adress);

        }

        private void ShowImage_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = Path.GetFileName(adress);

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else WindowState = FormWindowState.Maximized;
        }
    }
}
