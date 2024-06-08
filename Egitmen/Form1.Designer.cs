namespace Egitmen
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgwEgitmen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbxDers = new System.Windows.Forms.ComboBox();
            this.cbxEgitmen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.cbxListele = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.chxSosyal = new System.Windows.Forms.CheckBox();
            this.chxBiyo = new System.Windows.Forms.CheckBox();
            this.chxFizik = new System.Windows.Forms.CheckBox();
            this.chxKimya = new System.Windows.Forms.CheckBox();
            this.chxMat = new System.Windows.Forms.CheckBox();
            this.chxTurkce = new System.Windows.Forms.CheckBox();
            this.tbxOlusturID = new System.Windows.Forms.TextBox();
            this.tbxOlusturAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEgitmen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eğitmen Adı:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders:";
            // 
            // dgwEgitmen
            // 
            this.dgwEgitmen.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgwEgitmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEgitmen.Location = new System.Drawing.Point(11, 12);
            this.dgwEgitmen.Name = "dgwEgitmen";
            this.dgwEgitmen.RowHeadersWidth = 51;
            this.dgwEgitmen.RowTemplate.Height = 24;
            this.dgwEgitmen.Size = new System.Drawing.Size(670, 172);
            this.dgwEgitmen.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbxDers);
            this.groupBox1.Controls.Add(this.cbxEgitmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(360, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(211, 140);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 29);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbxDers
            // 
            this.cbxDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDers.FormattingEnabled = true;
            this.cbxDers.Location = new System.Drawing.Point(149, 97);
            this.cbxDers.Name = "cbxDers";
            this.cbxDers.Size = new System.Drawing.Size(155, 28);
            this.cbxDers.TabIndex = 5;
            // 
            // cbxEgitmen
            // 
            this.cbxEgitmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxEgitmen.FormattingEnabled = true;
            this.cbxEgitmen.Location = new System.Drawing.Point(149, 40);
            this.cbxEgitmen.Name = "cbxEgitmen";
            this.cbxEgitmen.Size = new System.Drawing.Size(155, 28);
            this.cbxEgitmen.TabIndex = 4;
            this.cbxEgitmen.SelectedIndexChanged += new System.EventHandler(this.cbxEgitmen_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.cbxListele);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(360, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Listele";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(178, 84);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 28);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cbxListele
            // 
            this.cbxListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxListele.FormattingEnabled = true;
            this.cbxListele.Location = new System.Drawing.Point(129, 40);
            this.cbxListele.Name = "cbxListele";
            this.cbxListele.Size = new System.Drawing.Size(146, 28);
            this.cbxListele.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eğitmen Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnOlustur);
            this.groupBox3.Controls.Add(this.chxSosyal);
            this.groupBox3.Controls.Add(this.chxBiyo);
            this.groupBox3.Controls.Add(this.chxFizik);
            this.groupBox3.Controls.Add(this.chxKimya);
            this.groupBox3.Controls.Add(this.chxMat);
            this.groupBox3.Controls.Add(this.chxTurkce);
            this.groupBox3.Controls.Add(this.tbxOlusturID);
            this.groupBox3.Controls.Add(this.tbxOlusturAd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(11, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 342);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eğitmen Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(189, 291);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(118, 28);
            this.btnOlustur.TabIndex = 11;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // chxSosyal
            // 
            this.chxSosyal.AutoSize = true;
            this.chxSosyal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxSosyal.Location = new System.Drawing.Point(210, 248);
            this.chxSosyal.Name = "chxSosyal";
            this.chxSosyal.Size = new System.Drawing.Size(81, 24);
            this.chxSosyal.TabIndex = 10;
            this.chxSosyal.Text = "Sosyal";
            this.chxSosyal.UseVisualStyleBackColor = true;
            // 
            // chxBiyo
            // 
            this.chxBiyo.AutoSize = true;
            this.chxBiyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxBiyo.Location = new System.Drawing.Point(122, 248);
            this.chxBiyo.Name = "chxBiyo";
            this.chxBiyo.Size = new System.Drawing.Size(85, 24);
            this.chxBiyo.TabIndex = 9;
            this.chxBiyo.Text = "Biyoloji";
            this.chxBiyo.UseVisualStyleBackColor = true;
            // 
            // chxFizik
            // 
            this.chxFizik.AutoSize = true;
            this.chxFizik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxFizik.Location = new System.Drawing.Point(122, 206);
            this.chxFizik.Name = "chxFizik";
            this.chxFizik.Size = new System.Drawing.Size(66, 24);
            this.chxFizik.TabIndex = 8;
            this.chxFizik.Text = "Fizik";
            this.chxFizik.UseVisualStyleBackColor = true;
            // 
            // chxKimya
            // 
            this.chxKimya.AutoSize = true;
            this.chxKimya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxKimya.Location = new System.Drawing.Point(210, 206);
            this.chxKimya.Name = "chxKimya";
            this.chxKimya.Size = new System.Drawing.Size(77, 24);
            this.chxKimya.TabIndex = 7;
            this.chxKimya.Text = "Kimya";
            this.chxKimya.UseVisualStyleBackColor = true;
            // 
            // chxMat
            // 
            this.chxMat.AutoSize = true;
            this.chxMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxMat.Location = new System.Drawing.Point(210, 164);
            this.chxMat.Name = "chxMat";
            this.chxMat.Size = new System.Drawing.Size(108, 24);
            this.chxMat.TabIndex = 6;
            this.chxMat.Text = "Matematik";
            this.chxMat.UseVisualStyleBackColor = true;
            // 
            // chxTurkce
            // 
            this.chxTurkce.AutoSize = true;
            this.chxTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxTurkce.Location = new System.Drawing.Point(122, 164);
            this.chxTurkce.Name = "chxTurkce";
            this.chxTurkce.Size = new System.Drawing.Size(82, 24);
            this.chxTurkce.TabIndex = 5;
            this.chxTurkce.Text = "Türkçe";
            this.chxTurkce.UseVisualStyleBackColor = true;
            // 
            // tbxOlusturID
            // 
            this.tbxOlusturID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOlusturID.Location = new System.Drawing.Point(122, 94);
            this.tbxOlusturID.Multiline = true;
            this.tbxOlusturID.Name = "tbxOlusturID";
            this.tbxOlusturID.Size = new System.Drawing.Size(185, 31);
            this.tbxOlusturID.TabIndex = 4;
            // 
            // tbxOlusturAd
            // 
            this.tbxOlusturAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOlusturAd.Location = new System.Drawing.Point(122, 37);
            this.tbxOlusturAd.Multiline = true;
            this.tbxOlusturAd.Name = "tbxOlusturAd";
            this.tbxOlusturAd.Size = new System.Drawing.Size(185, 31);
            this.tbxOlusturAd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dersler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Eğitmen ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eğitmen Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(712, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwEgitmen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEgitmen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwEgitmen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEgitmen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbxDers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chxFizik;
        private System.Windows.Forms.CheckBox chxKimya;
        private System.Windows.Forms.CheckBox chxMat;
        private System.Windows.Forms.CheckBox chxTurkce;
        private System.Windows.Forms.TextBox tbxOlusturID;
        private System.Windows.Forms.TextBox tbxOlusturAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.CheckBox chxSosyal;
        private System.Windows.Forms.CheckBox chxBiyo;
    }
}

