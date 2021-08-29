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
    public partial class UbahDataCustomers : Form
    {
        String Gender;
        public UbahDataCustomers(string Id_Customers, string Nama_Customers, string Jenis_Kelamin, string Tanggal_Lahir, string Alamat)
        {
            InitializeComponent();
            txtId_Customer.Text = Id_Customers;
            txtNama_Customer.Text = Nama_Customers;
            if (Jenis_Kelamin == "LK")
            {
                radioButton1.Checked = true;
            }
            else if (Jenis_Kelamin == "P")
            {
                radioButton2.Checked = true;
            }
            dateTimePicker1.Text = Tanggal_Lahir;
            txtAlamat.Text = Alamat;
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
                sql.CommandText = "UPDATE customers SET Nama_Customers='" + txtNama_Customer.Text + "', Jenis_Kelamin='" + Gender + "'" + ", Tanggal_Lahir='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', Alamat='" + txtAlamat.Text + "' WHERE Id_Customers='" + txtId_Customer.Text + "'";
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
