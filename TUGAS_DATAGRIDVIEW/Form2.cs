using System;
using System.Windows.Forms;
using static TUGAS_DATAGRIDVIEW.Form1;

namespace TUGAS_DATAGRIDVIEW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Kode yang akan dijalankan saat Form2 dimuat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kode yang akan dijalankan saat tombol 3 ditekan
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kode yang akan dijalankan saat tombol 2 ditekan
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            // Misalnya, Anda ingin membuka Form1 jika suatu kondisi terpenuhi
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonsimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public ObjekKategori GetObjekKategori()
        {
            ObjekKategori newObjekKategori = new ObjekKategori();
            newObjekKategori.Nama = textNama.Text;
            newObjekKategori.Deskripsi = textDeskripsi.Text;
            newObjekKategori.Kategori = textKategori.Text;
            newObjekKategori.Jenis = textJenis.Text;

            return newObjekKategori;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
