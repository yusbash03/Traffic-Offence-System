using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trafficjam
{
    public partial class FRSCDB : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yusbash Cool\source\repos\TrafficOffenceSimulationSystem\Trafficjam\Database2.mdf; Integrated Security=True;");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP - 4LFGKCC;Initial Catalog = TestBd;Integrated Security=True;User Instance=True");
       
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        public FRSCDB()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into trafficdbs(Date_of_Offence,Time_of_Offence,Vehicle_Number) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Offender Details Saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("select * from trafficdbs where Date_Of_Offence='"+textBox4.Text+"'", conn);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("select * from trafficdbs", conn);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRSCDB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //back to colission page
        {
            this.Hide();
            Colission col = new Colission();
            col.Show();
        }
    }
}
