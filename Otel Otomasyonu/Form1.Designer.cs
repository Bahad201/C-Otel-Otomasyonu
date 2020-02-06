namespace Otel_Otomasyonu
{
    partial class Otel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbtnMudur = new System.Windows.Forms.RadioButton();
            this.rdbtnResepsiyonist = new System.Windows.Forms.RadioButton();
            this.rdbtnPatron = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtkullaniciAdi
            // 
            this.txtkullaniciAdi.BackColor = System.Drawing.Color.PeachPuff;
            this.txtkullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkullaniciAdi.Location = new System.Drawing.Point(175, 347);
            this.txtkullaniciAdi.Name = "txtkullaniciAdi";
            this.txtkullaniciAdi.ShortcutsEnabled = false;
            this.txtkullaniciAdi.Size = new System.Drawing.Size(169, 23);
            this.txtkullaniciAdi.TabIndex = 2;
            this.txtkullaniciAdi.TextChanged += new System.EventHandler(this.txtkullaniciAdi_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(175, 396);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(169, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Location = new System.Drawing.Point(175, 443);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(139, 23);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdbtnMudur
            // 
            this.rdbtnMudur.AutoSize = true;
            this.rdbtnMudur.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnMudur.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMudur.ForeColor = System.Drawing.Color.White;
            this.rdbtnMudur.Location = new System.Drawing.Point(201, 307);
            this.rdbtnMudur.Name = "rdbtnMudur";
            this.rdbtnMudur.Size = new System.Drawing.Size(69, 21);
            this.rdbtnMudur.TabIndex = 8;
            this.rdbtnMudur.TabStop = true;
            this.rdbtnMudur.Text = "Müdür";
            this.rdbtnMudur.UseVisualStyleBackColor = false;
            // 
            // rdbtnResepsiyonist
            // 
            this.rdbtnResepsiyonist.AutoSize = true;
            this.rdbtnResepsiyonist.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnResepsiyonist.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnResepsiyonist.ForeColor = System.Drawing.Color.White;
            this.rdbtnResepsiyonist.Location = new System.Drawing.Point(276, 307);
            this.rdbtnResepsiyonist.Name = "rdbtnResepsiyonist";
            this.rdbtnResepsiyonist.Size = new System.Drawing.Size(111, 21);
            this.rdbtnResepsiyonist.TabIndex = 9;
            this.rdbtnResepsiyonist.TabStop = true;
            this.rdbtnResepsiyonist.Text = "Resepsiyonist";
            this.rdbtnResepsiyonist.UseVisualStyleBackColor = false;
            this.rdbtnResepsiyonist.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbtnPatron
            // 
            this.rdbtnPatron.AutoSize = true;
            this.rdbtnPatron.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnPatron.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPatron.ForeColor = System.Drawing.Color.White;
            this.rdbtnPatron.Location = new System.Drawing.Point(126, 307);
            this.rdbtnPatron.Name = "rdbtnPatron";
            this.rdbtnPatron.Size = new System.Drawing.Size(69, 21);
            this.rdbtnPatron.TabIndex = 10;
            this.rdbtnPatron.TabStop = true;
            this.rdbtnPatron.Text = "Patron";
            this.rdbtnPatron.UseVisualStyleBackColor = false;
            this.rdbtnPatron.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(351, 401);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Otel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rdbtnPatron);
            this.Controls.Add(this.rdbtnResepsiyonist);
            this.Controls.Add(this.rdbtnMudur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtkullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Otel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Otel_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbtnMudur;
        private System.Windows.Forms.RadioButton rdbtnResepsiyonist;
        private System.Windows.Forms.RadioButton rdbtnPatron;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

