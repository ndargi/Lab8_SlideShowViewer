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
        public Viewer(int time,List<string> filelist)
        {
            InitializeComponent();
            run();
        }
        private async void run()
        {

            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
            }
            DialogResult = DialogResult.OK;

        }

    }
}
