
namespace UAS_2003040125
{
    partial class UbahDataBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId_Barang = new System.Windows.Forms.TextBox();
            this.txtNama_Barang = new System.Windows.Forms.TextBox();
            this.txtJenis_Barang = new System.Windows.Forms.TextBox();
            this.txtId_Supplier = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(395, 337);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(493, 337);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id_Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama_Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis_Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id_Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stok";
            // 
            // txtId_Barang
            // 
            this.txtId_Barang.Location = new System.Drawing.Point(189, 30);
            this.txtId_Barang.Name = "txtId_Barang";
            this.txtId_Barang.Size = new System.Drawing.Size(155, 20);
            this.txtId_Barang.TabIndex = 7;
            // 
            // txtNama_Barang
            // 
            this.txtNama_Barang.Location = new System.Drawing.Point(189, 80);
            this.txtNama_Barang.Name = "txtNama_Barang";
            this.txtNama_Barang.Size = new System.Drawing.Size(155, 20);
            this.txtNama_Barang.TabIndex = 8;
            // 
            // txtJenis_Barang
            // 
            this.txtJenis_Barang.Location = new System.Drawing.Point(189, 125);
            this.txtJenis_Barang.Name = "txtJenis_Barang";
            this.txtJenis_Barang.Size = new System.Drawing.Size(155, 20);
            this.txtJenis_Barang.TabIndex = 9;
            // 
            // txtId_Supplier
            // 
            this.txtId_Supplier.Location = new System.Drawing.Point(189, 183);
            this.txtId_Supplier.Name = "txtId_Supplier";
            this.txtId_Supplier.Size = new System.Drawing.Size(155, 20);
            this.txtId_Supplier.TabIndex = 10;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(189, 245);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(155, 20);
            this.txtStok.TabIndex = 11;
            // 
            // UbahDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 390);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtId_Supplier);
            this.Controls.Add(this.txtJenis_Barang);
            this.Controls.Add(this.txtNama_Barang);
            this.Controls.Add(this.txtId_Barang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Name = "UbahDataBarang";
            this.Text = "UbahDataBarang";
            ((System.ComponentModel.ISupportInitialize)(this.txtStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId_Barang;
        private System.Windows.Forms.TextBox txtNama_Barang;
        private System.Windows.Forms.TextBox txtJenis_Barang;
        private System.Windows.Forms.TextBox txtId_Supplier;
        private System.Windows.Forms.NumericUpDown txtStok;
    }
}