using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trafficjam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void rectangleShape13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox14.Visible == true)
            {
                pictureBox15.Visible = true;
                pictureBox14.Visible = false;
                pictureBox16.Visible = false;
            }
            else if (pictureBox15.Visible == true)
            {
                pictureBox16.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
           }
            else if (pictureBox16.Visible == true)
            {
               pictureBox14.Visible = true;
               pictureBox15.Visible = false;
               pictureBox16.Visible = false;
               timertraffic1.Stop();
               timertraffic2.Enabled = true;
               timercarlane2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox15.Visible == true)
            {
               // pictureBox17.Left = pictureBox17.Left + 1; //left is the direction and 1 is the speed limit
            }
            else if (pictureBox16.Visible == true)
            {
                pictureBox17.Left = pictureBox17.Left + 5;
           }

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//stop
        {
            timertraffic1.Enabled = false;
            timercarlane1.Enabled = false;
            timertraffic2.Enabled = false;
            timercarlane2.Enabled = false;

            //pictureBox9.Visible = true;
            //pictureBox10.Visible = true;
            //pictureBox14.Visible = true;
            //pictureBox16.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//start
        {
            //timertraffic1.Start();
            //timercarlane1.Start();
            timertraffic1.Enabled = true;
            timercarlane1.Enabled = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox14.Visible = false;
            pictureBox16.Visible = false;
           // timertraffic2.Enabled = true;
            //timercarlane2.Enabled = true;
        }

        private void timercarlane2_Tick(object sender, EventArgs e)//car2
        {
            if (pictureBox9.Visible == true)
            {
                //pictureBox19.Top = pictureBox19.Top - 0; 
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox19.Top = pictureBox19.Top - 7;

                timertraffic1.Start();
            }
            if (pictureBox15.Visible == true)
            {
                //pictureBox17.Left = pictureBox17.Left + 1; //left is the direction and 1 is the speed limit
            }
            else if (pictureBox16.Visible == true)
            {
                pictureBox17.Left = pictureBox17.Left + 5;
            }

            
        }

        private void timertraffic2_Tick(object sender, EventArgs e)
        {

            if (pictureBox8.Visible == true)
            {
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox10.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                //timertraffic2.Stop();
            }
        }

        private void rectangleShape40_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox17.Location = new Point(11, 317);
            pictureBox19.Location = new Point(839, 731);
        }

        private void rectangleShape23_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Colission col = new Colission();
            col.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Colission col = new Colission();
            col.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timertraffic1.Enabled = true;
            timercarlane1.Enabled = true;
            //timertraffic2.Enabled = false;
            //timercarlane2.Enabled = false;

            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox14.Visible = true;
            pictureBox16.Visible = true;
        }
    }
}
