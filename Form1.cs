using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int time = 0;
        bool reset = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
            {
                time++;
                if (reset == true) time = 0;
                reset = false;
                switch (time)
                {

                    case 2:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.BBkCpDX_img;  break;
                    case 4:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.DESKTOP1; break;
                    case 6:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.DESKTOP; break;
                    case 8:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.MeControlMediumUserTile2; break;
                    case 10:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.MeControlMediumUserTile1; break;
                    case 12:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE161; break;
                    case 14:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE16; break;
                    case 16:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE171; break;
                    case 18:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE17; break;
                    case 20:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE191; break;
                    case 22:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE19; break;
                    case 24:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE201; break;
                    case 26:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.PICTURE20; break;
                    case 28:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.DICK; break;
                   
                    case 30:
                        pictureBox1.Image = WindowsFormsApplication10.Properties.Resources.optiongirl; break;
                    case 32:
                        reset = true; break;
                    default: break;
                }
           
            }
        }
    }
}
