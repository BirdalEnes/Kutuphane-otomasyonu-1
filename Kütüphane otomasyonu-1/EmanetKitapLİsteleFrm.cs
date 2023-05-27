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
    public partial class EmanetKitapLİsteleFrm : Form
    {
        public EmanetKitapLİsteleFrm()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        private void EmanetKitapLİsteleFrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex=0;
        }

        private void EmanetListele()
        {
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", bgl);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            bgl.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                EmanetListele();
            }
            else if(comboBox1.SelectedIndex==1)
            {
                bgl.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '"+DateTime.Now.ToShortTimeString()+"'>iadetarihi", bgl);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                bgl.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                bgl.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortTimeString() + "'<= iadetarihi", bgl);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                bgl.Close();
            }
        }
    }
}
