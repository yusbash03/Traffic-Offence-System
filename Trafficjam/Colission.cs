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
    public partial class Colission : Form
    {
        public Colission()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void rectangleShape8_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape12_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape23_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape14_Click(object sender, EventArgs e)
        {

        }

        private void timertraccol1_Tick(object sender, EventArgs e)//trafcol1
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

                timertrafcol1.Enabled = false;

                timertrafcol2.Enabled = true;
                timercarcol2.Enabled = true;
                
                }
            }
        

        private void timercarcol1_Tick(object sender, EventArgs e)
        {
            if (pictureBox14.Visible == true)
            {
                Car1.Left = Car1.Left + 2; //left is the direction and 1 is the speed limit
            }
            else if (pictureBox15.Visible == true)
            {
               // Car1.Left = Car1.Left + 2;
            }
            else if (pictureBox16.Visible == true)
            {
                Car1.Left = Car1.Left + 4;
            }
        }

        private void timertrafcol2_Tick(object sender, EventArgs e)//carlane 2 traf
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
                //timertrafcol2.Stop();
                //timercarcol2.Stop();
            }
        }

        private void timercarcol2_Tick(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                Car2.Top = Car2.Top - 0;
            }
            else if (pictureBox10.Visible == true)
            {
                Car2.Top = Car2.Top - 5;
            }

            if (Car1.Bounds.IntersectsWith(Car2.Bounds))
            {
                timercarcol1.Enabled = false;
               // timercarcol1.Stop();
                timercarcol2.Stop();
               
               // MessageBox.Show("They Have collided");
                FRSCDB frs = new FRSCDB();
                frs.Show();

                
                frs.textBox1.AppendText(DateTime.Now.ToShortDateString());
                frs.textBox2.AppendText(DateTime.Now.ToLongTimeString());
                frs.textBox3.AppendText(label1.Text);

                
            }
            timertrafcol2.Enabled = true;
            //timertrafcol1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timertrafcol1.Enabled = true;
            timercarcol1.Enabled = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox14.Visible = false;
            pictureBox16.Visible = false;

            //timertrafcol2.Enabled = true;
           // timercarcol2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRSCDB frs = new FRSCDB();
            frs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Fpage = new Form1();
            Fpage.Show();
        }

        private void Colission_Load(object sender, EventArgs e)
        {

        }
    }
}
