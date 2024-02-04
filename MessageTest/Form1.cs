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

namespace MessageTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=Test;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TBLKISILER where NUMARA=@P1 AND SIFRE=@P2",connection);

			command.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
			command.Parameters.AddWithValue("@P2", textBox1.Text);

			SqlDataReader dr = command.ExecuteReader();

			if (dr.Read())
			{
				Form2 fr = new Form2();
				fr.numara= maskedTextBox1.Text;
				fr.Show();
			}
			else
			{
				MessageBox.Show("Hatalı giriş tekrar deneyiniz.");
				
			}
			connection.Close();






		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
