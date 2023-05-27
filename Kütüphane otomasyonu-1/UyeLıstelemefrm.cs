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
    public partial class UyeLıstelemefrm : Form
    {
        public UyeLıstelemefrm()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");

        private void btnsılme_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstiyormusunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                bgl.Open();
                SqlCommand komut = new SqlCommand("delete from Uye where tc=@tc ", bgl);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                bgl.Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                daset.Tables["Uye"].Clear();
                uyelıstele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like'" + txtTc.Text + "'", bgl);
            SqlDataReader read =komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                cmbCınsıyet.Text = read["cınsıyet"].ToString();
                txtTel.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtEmaıl.Text = read["emaıl"].ToString();
                txtOkunanSayı.Text = read["okunankıtap"].ToString();
            }
            bgl.Close();
        }

        DataSet daset = new DataSet();
        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Uye"].Clear();
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye where tc like'%" + txtAraTc.Text +"%'",bgl);
            adtr.Fill(daset,"Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];    
            bgl.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uyelıstele()
        {
            bgl.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye ",bgl);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            bgl.Close();
        }
        private void UyeLıstelemefrm_Load(object sender, EventArgs e)
        {
            uyelıstele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("update Uye set adsoyad=@adsoyad,yas=@yas,cınsıyet=@cınsıyet,telefon=@telefon,adres=@adres,emaıl=@emaıl,okunankıtap=@okunankıtap where tc=@tc", bgl);
            komut.Parameters.AddWithValue("tc",txtTc.Text);
            komut.Parameters.AddWithValue("adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("yas", txtYas.Text);
            komut.Parameters.AddWithValue("cınsıyet", cmbCınsıyet.Text);
            komut.Parameters.AddWithValue("telefon", txtTel.Text);
            komut.Parameters.AddWithValue("adres", txtAdres.Text);
            komut.Parameters.AddWithValue("emaıl", txtEmaıl.Text);
            komut.Parameters.AddWithValue("okunankıtap", int.Parse (txtOkunanSayı.Text));
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            daset.Tables["Uye"].Clear();
            uyelıstele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
