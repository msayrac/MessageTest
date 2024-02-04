using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MessageTest
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		public string numara;

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=Test;Integrated Security=True");

		void GelenKutusu()
		{
			connection.Open();
			SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMESAJLAR Where ALICI =" + numara, connection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		void GidenKutusu()
		{
			connection.Open();
			SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLMESAJLAR Where GONDEREN =" + numara, connection);
			DataTable dt2 = new DataTable();
			da2.Fill(dt2);
			dataGridView2.DataSource = dt2;
			connection.Close();
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			LblNumara.Text = numara;
			GelenKutusu();
			GidenKutusu();

			//Ad Soyad Çekme

			connection.Open();
			SqlCommand komut = new SqlCommand("Select Ad, Soyad From TBLKISILER Where NUMARA="+numara, connection);


			SqlDataReader dr = komut.ExecuteReader();
			
			while(dr.Read())
			{
				LblAdSoyad.Text = (dr[0]+ " "+ dr[1]);
			}
			connection.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			connection.Open();

			SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) Values (@P1, @P2,@P3,@P4)", connection);

			komut.Parameters.AddWithValue("@P1", numara);
			komut.Parameters.AddWithValue("@P2",maskedTextBox1.Text);
			komut.Parameters.AddWithValue("@P3", textBox1.Text);
			komut.Parameters.AddWithValue("@P4", richTextBox1.Text);
			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Mesaj İletildi");
			GidenKutusu();
			GelenKutusu();

		}


	}
}
