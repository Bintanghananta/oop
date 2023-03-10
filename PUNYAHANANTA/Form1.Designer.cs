
namespace PUNYAHANANTA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Kode = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.Cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KODE";
            // 
            // Kode
            // 
            this.Kode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kode.Location = new System.Drawing.Point(27, 108);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(207, 39);
            this.Kode.TabIndex = 1;
            this.Kode.TextChanged += new System.EventHandler(this.E);
            // 
            // Nama
            // 
            this.Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(27, 214);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(207, 39);
            this.Nama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAMA";
            // 
            // Stok
            // 
            this.Stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stok.Location = new System.Drawing.Point(27, 314);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(207, 39);
            this.Stok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK";
            // 
            // Harga
            // 
            this.Harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(27, 420);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(207, 39);
            this.Harga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "HARGA";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(280, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(664, 397);
            this.dataGridView.TabIndex = 8;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(280, 482);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(160, 92);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(446, 482);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(141, 92);
            this.EDIT.TabIndex = 11;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(593, 482);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(184, 92);
            this.DELETE.TabIndex = 12;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(783, 482);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(161, 92);
            this.LOAD.TabIndex = 13;
            this.LOAD.Text = "LOAD";
            this.LOAD.UseVisualStyleBackColor = true;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // Cari
            // 
            this.Cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.Location = new System.Drawing.Point(362, 16);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(582, 39);
            this.Cari.TabIndex = 15;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "NAMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(972, 586);
            this.Controls.Add(this.Cari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LOAD);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kode;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.TextBox Cari;
        private System.Windows.Forms.Label label5;
    }
}

