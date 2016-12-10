using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        string filename;
        List<string> files = new List<string>();//s

        public Form1()
        {
            InitializeComponent();
            filelistview.View = View.List;
            openFileDialog1.Filter = "*.jpg;*.gif;*.png;*.bmp | *.jpg;*.gif;*.png;*.bmp; | *.* (All Files)|*.*";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    filename = file;
                    filelistview.Items.Add(filename);
                }
            }
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            files.Clear();
            for (int i = 0; i < filelistview.Items.Count; i++)
            {
                files.Add(filelistview.Items[i].Text);
            }
                Viewer myviewer = new Viewer(Convert.ToInt32(Interval_Text.Text), files);
            if (myviewer.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in filelistview.SelectedItems)
            {
                filelistview.Items.Remove(eachItem);
            }
        }
    }
}
