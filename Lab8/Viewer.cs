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
        private int ticktoc;
        private bool imagegood = true;
        List<string> filelist = new List<string>();
        private Bitmap MyImage;
        private int timetowait;
        public Viewer(int time,List<string> files)
        {
            InitializeComponent();
            filelist = files;
            timetowait = time * 1000;
            run();
        }
        private void run()
        {

            timer1.Interval = timetowait;
            timer1.Enabled = true;
            ticktoc = 0;
            MyImage = new Bitmap(filelist[ticktoc]);
            Invalidate();

        }

        private void Viewer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (imagegood)
            {
                //check if the image height or width will constrain its size

                float restraining = Math.Min((float)this.Width / (float)MyImage.Width, (float)this.Height / (float)MyImage.Height);
                //Then scale the image by this factor both ways to ensure that the aspect ratio remains the same
                float imagewidth = MyImage.Width * restraining;
                float imageheight = MyImage.Height * restraining;
                float widthoffset = (this.Width - imagewidth) / 2;
                float heightoffset = (this.Height - imageheight) / 2;
                g.DrawImage(MyImage, widthoffset, heightoffset, imagewidth, imageheight);
            }
            else
            {
                g.DrawString("Not an image File !",  new Font("Cambria", 40), Brushes.Red, 10, 10);
            }

        }

     

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++ticktoc;
            
            if (ticktoc != filelist.Count)
            {
                try
                {
                    MyImage = new Bitmap(filelist[ticktoc]);
                    imagegood = true;
                    Invalidate();
                }
                catch
                {
                    imagegood = false;
                    Invalidate();
                }
            }
            else
            {
                timer1.Enabled = false;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
