using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Viewer : Form
    {
        Timer myTimer = new Timer();
        List<string> filelist = new List<string>();
        private Bitmap MyImage;
        public Viewer(int time,List<string> files)
        {
            InitializeComponent();
            filelist = files;
            run();
        }
        private async void run()
        {

            for (int i = 0; i < filelist.Count; i++)
            {
                MyImage = new Bitmap(filelist[i]);
                Invalidate();
                await Task.Delay(5000);
            }
            DialogResult = DialogResult.OK;
            
        }

        private void Viewer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(MyImage, 0, 0);

        }

     

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
