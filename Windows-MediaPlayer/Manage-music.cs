using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_MediaPlayer
{
    public partial class Manage_music : Form
    {
        public Manage_music()
        {
            InitializeComponent();
            listBox1.Items.Add(@"D:/M E D I A/M U S I C/");
            listBox1.Items.Add(@"D:/M E D I A");
            listBox1.Items.Add("fhhjd");
            listBox1.Items.Add("ggs");
            this.CancelButton = cancelbtn;
            OKbtn.DialogResult = DialogResult.OK;
            address = listBox1.Items[0].ToString();

        }
        string address;

        public string getadress
        {
            get { return address;}
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            address = listBox1.SelectedItem.ToString();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
