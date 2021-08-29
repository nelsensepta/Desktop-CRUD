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
    public partial class TambahDataBarang : Form
    {
        public TambahDataBarang()
        {
            InitializeComponent();
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
                sql.CommandText = "Insert Into barang(Id_Barang, Nama_Barang,Jenis_Barang, Id_Supplier, Stok)" + "values('" + txtId_Barang.Text + "', '" + txtNama_Barang.Text + "', '" + txtJenis_Barang.Text + "', '" + txtId_Supplier.Text + "', '" + int.Parse(Stok.Text) + "')";
                sql.ExecuteNonQuery();
                DatabaseKoneksi.Close();
                this.Close();
                MessageBox.Show("Data Berhasil Ditambahkan");
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
