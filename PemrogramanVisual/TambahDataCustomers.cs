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
    public partial class TambahDataCustomers : Form
    {
        String Gender;
        public TambahDataCustomers()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            koneksiku konekin = new koneksiku();
            MySqlConnection DatabaseKoneksi = new MySqlConnection(konekin.kedatabase());
            if (radioButton1.Checked == true)
            {
                Gender = "LK";

            }
            else if (radioButton2.Checked == true)
            {
                Gender = "P";

            }

            try
            {
                DatabaseKoneksi.Open();
                MySqlCommand sql = new MySqlCommand();
                sql.Connection = DatabaseKoneksi;
                sql.CommandType = CommandType.Text;
                sql.CommandText = "Insert into customers(Id_Customers, Nama_Customers, Jenis_Kelamin, Tanggal_Lahir, Alamat)" + "Values('" + txtId_Customer.Text + "','" + txtNama_Customer.Text + "','" + Gender + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtAlamat.Text + "')";
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
