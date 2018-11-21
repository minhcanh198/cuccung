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
        public Manage_Pictures()
        {
            InitializeComponent();

            listBox1.Items.Add(@"D:\M E D I A\P I C T U R E S\HD");
            listBox1.Items.Add(@"D:\M E D I A\P I C T U R E S");
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
            if (listBox1.SelectedItem != null)

                address = listBox1.SelectedItem.ToString();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string st="a";
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog()== DialogResult.OK)
            {
                st = ofd.SelectedPath;
                listBox1.Items.Add(st);
            }
            
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
            }
        }
    }
}
