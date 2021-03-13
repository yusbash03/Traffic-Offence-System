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
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\UM-YASEER\Documents\Visual Studio 2010\Projects\Trafficjam\Trafficjam\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        public FRSCDB()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into trafficdb(Date_of_Offence,Time_of_Offence,Vehicle_Number) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ", conn);
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
                SqlDataAdapter SDA = new SqlDataAdapter("select * from trafficdb where Date_Of_Offence='"+textBox4.Text+"'", conn);
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
                SqlDataAdapter SDA = new SqlDataAdapter("select * from trafficdb", conn);
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
    }
}
