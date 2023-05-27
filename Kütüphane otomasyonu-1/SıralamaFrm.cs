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

namespace Kütüphane_otomasyonu_1
{
    public partial class SıralamaFrm : Form
    {
        public SıralamaFrm()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        private void SıralamaFrm_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye order by okunankitap desc ", bgl);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            bgl.Close();
            label3.Text = "";
            label4.Text = "";
            label3.Text = daset.Tables["Uye"].Rows[0]["adsoyad"].ToString()+"=";
            label3.Text += daset.Tables["Uye"].Rows[0]["okunankitap"].ToString();
            label4.Text = daset.Tables["Uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+"=";
            label4.Text += daset.Tables["Uye"].Rows[0][dataGridView1.Rows.Count - 2].ToString();
        }
    }
}
