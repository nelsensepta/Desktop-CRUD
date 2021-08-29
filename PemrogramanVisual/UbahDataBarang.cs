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
    public partial class UbahDataBarang : Form
    {
        public UbahDataBarang(string Id_Barang, string Nama_Barang, string Jenis_Barang, string Id_Supplier, int Stok)
        {
            InitializeComponent();
            txtId_Barang.Text = Id_Barang;
            txtNama_Barang.Text = Nama_Barang;
            txtJenis_Barang.Text = Jenis_Barang;
            txtId_Supplier.Text = Id_Supplier;
            txtStok.Text = Stok.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            koneksiku konekin = new koneksiku();
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            try
            {
                DatabaseKoneksi.Open();
                MySqlCommand sql = new MySqlCommand();
                sql.Connection = DatabaseKoneksi;
                sql.CommandType = CommandType.Text;
                sql.CommandText = "UPDATE barang SET Nama_Barang='" + txtNama_Barang.Text + "', Jenis_Barang='" + txtJenis_Barang.Text + "'" + ", Id_Supplier='" + txtId_Supplier.Text + "', Stok='" + int.Parse(txtStok.Text) + "' WHERE Id_Barang='" + txtId_Barang.Text + "'";
                sql.ExecuteNonQuery();
                DatabaseKoneksi.Close();
                this.Close();
                MessageBox.Show("Data Berhasil Diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ada error : " + ex.ToString());
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
