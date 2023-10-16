using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TUGAS_DATAGRIDVIEW
{
    public partial class Form1 : Form
    {
        List<ObjekKategori> listObjekKategori = new List<ObjekKategori>();
        public Form1()
        {
            InitializeComponent();
            ObjekKategori objekKategori = new ObjekKategori();
            objekKategori.Nama = "Ayam";
            objekKategori.Deskripsi = "Ayam Menghasilkan telur";
            objekKategori.Kategori = "Peternakan";
            objekKategori.Jenis = "Herbivora";

            listObjekKategori.Add(objekKategori);
            dataGridView1.DataSource = listObjekKategori;
            // InitializeDataGridView();
            // Panggil fungsi ini untuk mengisi DataGridView saat form pertama dimuat.
        }

        // Kelas ObjekKategori harus ditempatkan di luar kelas Form1.


        // Inisialisasi koleksi objek dan mengisi DataGridView
        //private List<ObjekKategori> objekKategoriList = new List<ObjekKategori>();
        //private void InitializeDataGridView()
        //{
        //    objekKategoriList.Add(new ObjekKategori { Nama = "m", Deskripsi = "y ", Kategori = "z " });



        //    dataGridView1.DataSource = objekKategoriList;
        //}




        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Kode untuk treeView1_AfterSelect
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kode untuk checkedListBox1_SelectedIndexChanged
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kode untuk dataGridView1_CellContentClick
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ObjekKategori newObjekKategori = form2.GetObjekKategori();
                    listObjekKategori.Add(newObjekKategori);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listObjekKategori;

                    form2.Close();

                }
            }
        }
    }
}
