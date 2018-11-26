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
    public partial class Manage_Pictures : Form
    {
        List<string> address = new List<string>();

        public Manage_Pictures()
        {
            InitializeComponent();

            listBox1.Items.Add(@"D:\M E D I A\P I C T U R E S\HD");
            listBox1.Items.Add(@"D:\M E D I A\P I C T U R E S");
            this.CancelButton = cancelbtn;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string st = listBox1.Items[i].ToString();
                address.Add(st);
            }

        }

        public List<string> getadress
        {
            get { return address; }
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.Hide();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string st;
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                st = ofd.SelectedPath;
                listBox1.Items.Add(st);
                address.Clear();
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                address.Add(listBox1.Items[i].ToString());
            }

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(selectedItems[i]);

                }
                address.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    address.Add(listBox1.Items[i].ToString());

                }
            }
        }
    }
}
