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
   
    public partial class FormSupplier : Form
    {
        koneksiku konekin = new koneksiku();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            string sql = "select * from supplier";
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
            TambahDataSupplier dp = new TambahDataSupplier();
            dp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Id_Supplier = (string)dataGridView1.CurrentRow.Cells[0].Value;
            String Nama_Supplier = (string)dataGridView1.CurrentRow.Cells[1].Value;
            String Jenis_Kelamin = (string)dataGridView1.CurrentRow.Cells[2].Value;
            String Tanggal_Lahir = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String Alamat = (string)dataGridView1.CurrentRow.Cells[4].Value;
            UbahDataSupplier ds = new UbahDataSupplier(Id_Supplier, Nama_Supplier, Jenis_Kelamin, Tanggal_Lahir, Alamat);
            ds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            if (MessageBox.Show("Apakah Data Supplier : " + dataGridView1.CurrentRow.Cells[1].Value + " akan dihapus?", "Hapus Supplier", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DatabaseKoneksi.Open();
                    MySqlCommand sql = new MySqlCommand();
                    sql.Connection = DatabaseKoneksi;
                    sql.CommandType = CommandType.Text;
                    sql.CommandText = "DELETE FROM supplier WHERE Id_Supplier='" +
                    dataGridView1.CurrentRow.Cells[0].Value + "'";
                    sql.ExecuteNonQuery();
                    DatabaseKoneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal " + ex.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            string sql = "select * from supplier";
            MySqlCommand da = new MySqlCommand(sql, DatabaseKoneksi);
            DatabaseKoneksi.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(da);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
            DatabaseKoneksi.Close();
        }
    }
}
