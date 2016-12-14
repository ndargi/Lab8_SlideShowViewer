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
            filelistview.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col";
            header.Width = filelistview.Width - 30;
            filelistview.Columns.Add(header);
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg;*.gif;*.png;*.bmp | *.jpg;*.gif;*.png;*.bmp; | *.* (All Files)|*.*";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                foreach (String filename in openFileDialog1.FileNames)
                {
                   
                    filelistview.Items.Add(filename);
                }
            }
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            if (filelistview.Items.Count == 0)
            {
                MessageBox.Show("No Images to Show", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int x;
            if (int.TryParse(Interval_Text.Text, out x) && x > 0)//Check if number is positive integer
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
            else
            {
                MessageBox.Show("Please Enter an Integer Time Interval > 0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in filelistview.SelectedItems)
            {
                filelistview.Items.Remove(eachItem);
            }
        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " | *.pix";
            saveFileDialog1.DefaultExt = "pix";
            if (filelistview.Items.Count == 0)
            {
                MessageBox.Show("No File Names to Save", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
             
                using (System.IO.StreamWriter savefile = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {

                    for (int i = 0; i < filelistview.Items.Count; i++)
                    {
                        savefile.WriteLine(filelistview.Items[i].Text);
                    }

                }
            }
        }

        private void openCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            openFileDialog1.Filter = " | *.pix";
            
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                files.Clear();
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    filelistview.Items.Add(line);
                }

                file.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
