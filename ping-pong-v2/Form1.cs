using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speed = 5;
        int vdir = +1;
        int slider_speed = 10;
        bool gameOver = false;

        
        private void Vert_Tick(object sender, EventArgs e)
        {
            
            if (Ball.Top < 0)
            {

                vdir = +1;
            }
            else if (Ball.Top > (this.Height - (Ball.Height + Slider.Height)))
            {



                if (Ball.Left < Slider.Left ||(Ball.Left+Ball.Width) > (Slider.Left+Slider.Width))
                {
                    Vert.Enabled = Horz.Enabled = false;
                    bunifuCustomLabel1.BackColor = Color.DarkRed;
                    bunifuCustomLabel1.Text = "Замина";
                   this.Enabled = false;
                }
                else
                {
                    speed++;
                }





                vdir = -1;
            }
                Ball.Top += (vdir*speed);


        }


        int hdir = +1;
        private void Horz_Tick(object sender, EventArgs e)
        {

            if (Ball.Left < 0)
            {
                hdir = +1;
            }
            else if (Ball.Left > (this.Width - Ball.Width))
            {
                hdir = -1;
            }

                Ball.Left += (hdir*speed);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }




        bool _left = false, _right = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //active
            if (e.KeyCode ==Keys.Right)
            {
                _right = true;
            }else if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }else if (e.KeyCode == Keys.Escape)
            {
                //pause
                Vert.Enabled = Horz.Enabled = paused = false;

            }
            else if (e.KeyCode == Keys.End)
            {
                //resume
                Vert.Enabled = Horz.Enabled = paused = true;

            }


        }
        bool paused
        {
            get
            {
                return !pblpause.Visible;
            }
            set
            {
                pblpause.Visible = !value;
            }
        }

        private void key_watch_Tick(object sender, EventArgs e)
        {
            if (_right && Slider.Left <(this.Width- Slider.Width))
            {
                Slider.Left = Slider.Left + 10;

            }else if (_left && Slider.Left > 0)
            {  
                Slider.Left = Slider.Left - 10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //inactive
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false; // disable 
            }
        }
    }
}
