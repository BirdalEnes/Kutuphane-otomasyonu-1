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

namespace Kütüphane_otomasyonu_1
{
    public partial class UyeEkleFrm : Form
    {
        public UyeEkleFrm()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(tc,adsoyad,yas,cınsıyet,telefon,adres,emaıl,okunankıtap) values(@tc,@adsoyad,@yas,@cınsıyet,@telefon,@adres,@emaıl,@okunankıtap)", bgl);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cınsıyet", cmbCınsıyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@emaıl", txtEmaıl.Text);
            komut.Parameters.AddWithValue("@okunankıtap", txtOkunanSayı.Text);
            komut.ExecuteNonQuery(); 
            bgl.Close();
            MessageBox.Show("Üye Kayıt İşlemi Yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item !=txtOkunanSayı)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void UyeEkleFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
