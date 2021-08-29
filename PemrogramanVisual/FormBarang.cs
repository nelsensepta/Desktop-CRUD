using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UAS_2003040125
{
    public partial class FormBarang : Form
    {
        koneksiku konekin = new koneksiku();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            string sql = "select * from barang";
            MySqlCommand da = new MySqlCommand(sql, DatabaseKoneksi);
            DatabaseKoneksi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(da);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
            DatabaseKoneksi.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            string sql = "select * from barang";
            MySqlCommand da = new MySqlCommand(sql, DatabaseKoneksi);
            DatabaseKoneksi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(da);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
            DatabaseKoneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahDataBarang db = new TambahDataBarang();
            db.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            if (MessageBox.Show("Apakah Data Barang : " + dataGridView1.CurrentRow.Cells[1].Value + " akan dihapus?", "Hapus Barang", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DatabaseKoneksi.Open();
                    MySqlCommand sql = new MySqlCommand();
                    sql.Connection = DatabaseKoneksi;
                    sql.CommandType = CommandType.Text;
                    sql.CommandText = "DELETE FROM barang WHERE Id_Barang='" +
                    dataGridView1.CurrentRow.Cells[0].Value + "'";
                    sql.ExecuteNonQuery();
                    DatabaseKoneksi.Close();
                    MessageBox.Show("Data Barang Berhasil Dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal " + ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Id_Barang = (string)dataGridView1.CurrentRow.Cells[0].Value;
            String Nama_Barang = (string)dataGridView1.CurrentRow.Cells[1].Value;
            String Jenis_Barang = (string)dataGridView1.CurrentRow.Cells[2].Value;
            String Id_Supplier = (string)dataGridView1.CurrentRow.Cells[3].Value;
            int Stok = (int)dataGridView1.CurrentRow.Cells[4].Value;
            UbahDataBarang ubah = new UbahDataBarang(Id_Barang, Nama_Barang, Jenis_Barang, Id_Supplier, Stok);
            ubah.Show();
        }
    }
}
