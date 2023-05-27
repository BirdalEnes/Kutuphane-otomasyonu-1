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
    public partial class EmanetKitapİadeFrm : Form
    {
        public EmanetKitapİadeFrm()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();

        private void EmanetListele()
        {
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", bgl);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            bgl.Close();
        }

        private void EmanetKitapİadeFrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where tc like '%"+txtTcAra.Text+"%'",bgl);
            adtr.Fill(daset,"EmanetKitaplar");
            bgl.Close();
            if (txtTcAra.Text=="")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkodno like '%" + txtBarkodNoAra.Text + "%'", bgl);
            adtr.Fill(daset, "EmanetKitaplar");
            bgl.Close();
            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno",bgl);
            komut.Parameters.AddWithValue("tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+'" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() +"' where barkodno=@barkodno", bgl);
            komut2.Parameters.AddWithValue("barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kitap/lar İade Edildi");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
