namespace WindowsFormsApp18
{
    partial class kayıt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sifre_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sifre_tekrarlama_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sartlar_checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sartlar_txt = new System.Windows.Forms.Label();
            this.KayitOl_Btn = new System.Windows.Forms.Button();
            this.KayidVar_Btn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 861);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(102, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 35);
            this.label8.TabIndex = 17;
            this.label8.Text = "YETERKİ EVDE KALIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "SİZLERE LEZZET TAŞIYORUZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(545, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-MAİL ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(545, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEKRAR ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(545, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(545, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "KULLANCI ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(550, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "KAYD OL";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintText = "full ad";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(546, 149);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(449, 39);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifre_box
            // 
            this.sifre_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre_box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sifre_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifre_box.HintForeColor = System.Drawing.Color.Empty;
            this.sifre_box.HintText = "pasword";
            this.sifre_box.isPassword = true;
            this.sifre_box.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.sifre_box.LineIdleColor = System.Drawing.Color.Crimson;
            this.sifre_box.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sifre_box.LineThickness = 3;
            this.sifre_box.Location = new System.Drawing.Point(555, 242);
            this.sifre_box.Margin = new System.Windows.Forms.Padding(4);
            this.sifre_box.Name = "sifre_box";
            this.sifre_box.Size = new System.Drawing.Size(445, 46);
            this.sifre_box.TabIndex = 8;
            this.sifre_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifre_tekrarlama_box
            // 
            this.sifre_tekrarlama_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre_tekrarlama_box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sifre_tekrarlama_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifre_tekrarlama_box.HintForeColor = System.Drawing.Color.Black;
            this.sifre_tekrarlama_box.HintText = "pasword";
            this.sifre_tekrarlama_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sifre_tekrarlama_box.isPassword = true;
            this.sifre_tekrarlama_box.LineFocusedColor = System.Drawing.Color.Blue;
            this.sifre_tekrarlama_box.LineIdleColor = System.Drawing.Color.Crimson;
            this.sifre_tekrarlama_box.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sifre_tekrarlama_box.LineThickness = 3;
            this.sifre_tekrarlama_box.Location = new System.Drawing.Point(553, 347);
            this.sifre_tekrarlama_box.Margin = new System.Windows.Forms.Padding(4);
            this.sifre_tekrarlama_box.Name = "sifre_tekrarlama_box";
            this.sifre_tekrarlama_box.Size = new System.Drawing.Size(442, 39);
            this.sifre_tekrarlama_box.TabIndex = 9;
            this.sifre_tekrarlama_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "sameone@example.com";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(550, 438);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(445, 39);
            this.bunifuMaterialTextbox4.TabIndex = 10;
            this.bunifuMaterialTextbox4.Text = "sameone@gmail.com";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sartlar_checkbox
            // 
            this.sartlar_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.sartlar_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sartlar_checkbox.Checked = true;
            this.sartlar_checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.sartlar_checkbox.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sartlar_checkbox.ForeColor = System.Drawing.Color.White;
            this.sartlar_checkbox.Location = new System.Drawing.Point(568, 710);
            this.sartlar_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.sartlar_checkbox.Name = "sartlar_checkbox";
            this.sartlar_checkbox.Size = new System.Drawing.Size(20, 20);
            this.sartlar_checkbox.TabIndex = 12;
            // 
            // sartlar_txt
            // 
            this.sartlar_txt.AutoSize = true;
            this.sartlar_txt.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sartlar_txt.ForeColor = System.Drawing.Color.Crimson;
            this.sartlar_txt.Location = new System.Drawing.Point(612, 703);
            this.sartlar_txt.Name = "sartlar_txt";
            this.sartlar_txt.Size = new System.Drawing.Size(370, 27);
            this.sartlar_txt.TabIndex = 13;
            this.sartlar_txt.Text = "şartları ve kuraları kabul ediyorum";
            this.sartlar_txt.Click += new System.EventHandler(this.sartlar_txt_Click);
            // 
            // KayitOl_Btn
            // 
            this.KayitOl_Btn.BackColor = System.Drawing.Color.Black;
            this.KayitOl_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KayitOl_Btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitOl_Btn.ForeColor = System.Drawing.Color.Crimson;
            this.KayitOl_Btn.Location = new System.Drawing.Point(555, 747);
            this.KayitOl_Btn.Name = "KayitOl_Btn";
            this.KayitOl_Btn.Size = new System.Drawing.Size(450, 53);
            this.KayitOl_Btn.TabIndex = 14;
            this.KayitOl_Btn.Text = "Kayit Ol";
            this.KayitOl_Btn.UseVisualStyleBackColor = false;
            this.KayitOl_Btn.Click += new System.EventHandler(this.KayitOl_Btn_Click);
            // 
            // KayidVar_Btn
            // 
            this.KayidVar_Btn.BackColor = System.Drawing.Color.Black;
            this.KayidVar_Btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayidVar_Btn.ForeColor = System.Drawing.Color.Crimson;
            this.KayidVar_Btn.Location = new System.Drawing.Point(555, 806);
            this.KayidVar_Btn.Name = "KayidVar_Btn";
            this.KayidVar_Btn.Size = new System.Drawing.Size(450, 55);
            this.KayidVar_Btn.TabIndex = 15;
            this.KayidVar_Btn.Text = "ZATEN KAYIDIM VAR";
            this.KayidVar_Btn.UseVisualStyleBackColor = false;
            this.KayidVar_Btn.Click += new System.EventHandler(this.KayidVar_Btn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.maskedTextBox1.Location = new System.Drawing.Point(550, 563);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(450, 33);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(541, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "TELEFON NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(545, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adres Bilgisi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(546, 641);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 52);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1003, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(871, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "EN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(784, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "TR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.KayidVar_Btn);
            this.Controls.Add(this.KayitOl_Btn);
            this.Controls.Add(this.sartlar_txt);
            this.Controls.Add(this.sartlar_checkbox);
            this.Controls.Add(this.bunifuMaterialTextbox4);
            this.Controls.Add(this.sifre_tekrarlama_box);
            this.Controls.Add(this.sifre_box);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayıt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kayıt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifre_box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifre_tekrarlama_box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCheckbox sartlar_checkbox;
        private System.Windows.Forms.Button KayitOl_Btn;
        private System.Windows.Forms.Button KayidVar_Btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sartlar_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

