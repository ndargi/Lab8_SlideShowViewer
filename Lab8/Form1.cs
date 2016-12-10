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
            openFileDialog1.Filter = "*.jpg;*.gif;*.png;*.bmp | *.jpg; *.gif *.png *.bmp |*.* (All Files)|*.*";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this)==DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                filelistview.Items.Add(filename);
                Viewer myviewer = new Viewer(1000,files);
                if (myviewer.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
