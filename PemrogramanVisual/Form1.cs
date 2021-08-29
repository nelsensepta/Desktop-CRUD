using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_2003040125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool oneOnly(String Fm)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == Fm)
                {
                    frm.Focus();
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!oneOnly("FormCustomers"))
            {
                FormCustomers fr = new FormCustomers();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!oneOnly("FormBarang"))
            {
                FormBarang fr = new FormBarang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!oneOnly("FormSupplier"))
            {
                FormSupplier fr = new FormSupplier();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
