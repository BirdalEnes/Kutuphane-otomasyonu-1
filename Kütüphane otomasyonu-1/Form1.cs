using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_otomasyonu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkleFrm uyeekle = new UyeEkleFrm();
            uyeekle.ShowDialog();
        }

        private void btnUyeLıstele_Click(object sender, EventArgs e)
        {
            UyeLıstelemefrm uyelıste = new UyeLıstelemefrm();
            uyelıste.ShowDialog();
        }

        private void btnKıtapEkle_Click(object sender, EventArgs e)
        {
            KıtapEklefrm kıtapekle = new KıtapEklefrm();    
            kıtapekle.ShowDialog();
        }

        private void btnKıtapLıstele_Click(object sender, EventArgs e)
        {
            KitapListelefrm kıtaplistele = new KitapListelefrm();
            kıtaplistele.ShowDialog(); 
        }

        private void btnEmanetKıtap_Click(object sender, EventArgs e)
        {
            EmanetKitapVerFrm emanetkitap = new EmanetKitapVerFrm();
            emanetkitap.ShowDialog();
        }

        private void btnEmanetLısteleme_Click(object sender, EventArgs e)
        {
            EmanetKitapLİsteleFrm listele = new EmanetKitapLİsteleFrm();
            listele.ShowDialog();
        }

        private void btnEmanetIade_Click(object sender, EventArgs e)
        {
            EmanetKitapİadeFrm iade = new EmanetKitapİadeFrm();
            iade.ShowDialog();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            SıralamaFrm sıralama = new SıralamaFrm();
            sıralama.ShowDialog();
        }

        private void btnGrafık_Click(object sender, EventArgs e)
        {
            GrafikFrm grafik = new GrafikFrm();
            grafik.ShowDialog();
        }
    }
}
