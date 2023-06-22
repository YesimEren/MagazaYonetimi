namespace SunumLayer.Personel
{
    partial class PersonelAnaEkran
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
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelDepartman = new System.Windows.Forms.TextBox();
            this.txtPersonelMaas = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelGüncelle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(13, 13);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.RowHeadersWidth = 51;
            this.dgwPersonel.RowTemplate.Height = 24;
            this.dgwPersonel.Size = new System.Drawing.Size(590, 225);
            this.dgwPersonel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelSil);
            this.groupBox1.Controls.Add(this.btnPersonelGüncelle);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.txtPersonelDepartman);
            this.groupBox1.Controls.Add(this.txtPersonelMaas);
            this.groupBox1.Controls.Add(this.txtPersonelSoyad);
            this.groupBox1.Controls.Add(this.txtPersonelAd);
            this.groupBox1.Controls.Add(this.txtPersonelNo);
            this.groupBox1.Controls.Add(this.txtPersonelId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "No :";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad :";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad :";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maas:";
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departman :";
            this.label6.UseMnemonic = false;
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Enabled = false;
            this.txtPersonelId.Location = new System.Drawing.Point(132, 21);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelId.TabIndex = 6;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(132, 57);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelNo.TabIndex = 7;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(132, 135);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelSoyad.TabIndex = 9;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(132, 99);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelAd.TabIndex = 8;
            // 
            // txtPersonelDepartman
            // 
            this.txtPersonelDepartman.Location = new System.Drawing.Point(132, 212);
            this.txtPersonelDepartman.Name = "txtPersonelDepartman";
            this.txtPersonelDepartman.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelDepartman.TabIndex = 11;
            // 
            // txtPersonelMaas
            // 
            this.txtPersonelMaas.Location = new System.Drawing.Point(132, 176);
            this.txtPersonelMaas.Name = "txtPersonelMaas";
            this.txtPersonelMaas.Size = new System.Drawing.Size(244, 22);
            this.txtPersonelMaas.TabIndex = 10;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Location = new System.Drawing.Point(420, 34);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(139, 32);
            this.btnPersonelEkle.TabIndex = 12;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            // 
            // btnPersonelGüncelle
            // 
            this.btnPersonelGüncelle.BackColor = System.Drawing.Color.LightGray;
            this.btnPersonelGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGüncelle.Location = new System.Drawing.Point(420, 138);
            this.btnPersonelGüncelle.Name = "btnPersonelGüncelle";
            this.btnPersonelGüncelle.Size = new System.Drawing.Size(164, 32);
            this.btnPersonelGüncelle.TabIndex = 13;
            this.btnPersonelGüncelle.Text = "Personel Güncelle";
            this.btnPersonelGüncelle.UseVisualStyleBackColor = false;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.LightGray;
            this.btnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Location = new System.Drawing.Point(420, 176);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(164, 32);
            this.btnPersonelSil.TabIndex = 14;
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            // 
            // PersonelAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwPersonel);
            this.Name = "PersonelAnaEkran";
            this.Text = "PersonelAnaEkran";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGüncelle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TextBox txtPersonelDepartman;
        private System.Windows.Forms.TextBox txtPersonelMaas;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}