namespace EntityFramework
{
    partial class FrmUrun
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txturunadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btnekle = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxkategorı = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(149, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 30);
            this.txtid.TabIndex = 1;
            // 
            // txturunadı
            // 
            this.txturunadı.Location = new System.Drawing.Point(149, 64);
            this.txturunadı.Name = "txturunadı";
            this.txturunadı.Size = new System.Drawing.Size(148, 30);
            this.txturunadı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Adı :";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(149, 100);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(148, 30);
            this.txtmarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(149, 136);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(148, 30);
            this.txtstok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok Sayısı:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(149, 172);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(148, 30);
            this.txtfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 30);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori:";
            // 
            // Btnekle
            // 
            this.Btnekle.Location = new System.Drawing.Point(323, 31);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(109, 39);
            this.Btnekle.TabIndex = 14;
            this.Btnekle.Text = "Ekle";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(323, 76);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(109, 39);
            this.Btnsil.TabIndex = 15;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.Location = new System.Drawing.Point(323, 121);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(109, 39);
            this.Btnguncelle.TabIndex = 16;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = true;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(323, 177);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(109, 39);
            this.btnlistele.TabIndex = 17;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(323, 233);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(109, 39);
            this.btntemizle.TabIndex = 18;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // cbxkategorı
            // 
            this.cbxkategorı.FormattingEnabled = true;
            this.cbxkategorı.Location = new System.Drawing.Point(149, 247);
            this.cbxkategorı.Name = "cbxkategorı";
            this.cbxkategorı.Size = new System.Drawing.Size(148, 33);
            this.cbxkategorı.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 455);
            this.Controls.Add(this.cbxkategorı);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.Btnguncelle);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturunadı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txturunadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxkategorı;
    }
}