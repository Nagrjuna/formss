using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dropdown
{
    public partial class Form1 : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=harshitha;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cc();
        }
        public void cc()
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from [Drop]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt); ;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Name"].ToString());
            }
            con.Close();
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into [Drop] values('"+textBox1.Text+"','"+ textBox2.Text + "','"+ textBox3.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            cc();
            MessageBox.Show("record is inserted");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from [Drop] where name='"+comboBox1.SelectedItem.ToString()+"'" ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt); ;
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["Name"].ToString();
                textBox2.Text = dr["Age"].ToString();
                textBox3.Text = dr["Address"].ToString();
            }
            con.Close();
        }
    }
}
