namespace Doviz_Ofisi_Mini_Uygulama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDolarS = new System.Windows.Forms.Label();
            this.lblEuroS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDolarA = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnDolarS = new System.Windows.Forms.Button();
            this.btnEuroA = new System.Windows.Forms.Button();
            this.btnEuroS = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarA.ForeColor = System.Drawing.Color.White;
            this.lblDolarA.Location = new System.Drawing.Point(165, 73);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(18, 18);
            this.lblDolarA.TabIndex = 1;
            this.lblDolarA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // lblDolarS
            // 
            this.lblDolarS.AutoSize = true;
            this.lblDolarS.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarS.ForeColor = System.Drawing.Color.White;
            this.lblDolarS.Location = new System.Drawing.Point(165, 101);
            this.lblDolarS.Name = "lblDolarS";
            this.lblDolarS.Size = new System.Drawing.Size(18, 18);
            this.lblDolarS.TabIndex = 3;
            this.lblDolarS.Text = "0";
            // 
            // lblEuroS
            // 
            this.lblEuroS.AutoSize = true;
            this.lblEuroS.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroS.ForeColor = System.Drawing.Color.White;
            this.lblEuroS.Location = new System.Drawing.Point(165, 183);
            this.lblEuroS.Name = "lblEuroS";
            this.lblEuroS.Size = new System.Drawing.Size(18, 18);
            this.lblEuroS.TabIndex = 7;
            this.lblEuroS.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış:";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroA.ForeColor = System.Drawing.Color.White;
            this.lblEuroA.Location = new System.Drawing.Point(165, 151);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(18, 18);
            this.lblEuroA.TabIndex = 5;
            this.lblEuroA.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // btnDolarA
            // 
            this.btnDolarA.Location = new System.Drawing.Point(250, 71);
            this.btnDolarA.Name = "btnDolarA";
            this.btnDolarA.Size = new System.Drawing.Size(39, 23);
            this.btnDolarA.TabIndex = 8;
            this.btnDolarA.Text = "...";
            this.btnDolarA.UseVisualStyleBackColor = true;
            this.btnDolarA.Click += new System.EventHandler(this.btnDolarA_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(76, 31);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(226, 26);
            this.txtKur.TabIndex = 10;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Location = new System.Drawing.Point(318, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 249);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(76, 62);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(226, 26);
            this.txtMiktar.TabIndex = 12;
            // 
            // btnDolarS
            // 
            this.btnDolarS.Location = new System.Drawing.Point(250, 99);
            this.btnDolarS.Name = "btnDolarS";
            this.btnDolarS.Size = new System.Drawing.Size(39, 23);
            this.btnDolarS.TabIndex = 12;
            this.btnDolarS.Text = "...";
            this.btnDolarS.UseVisualStyleBackColor = true;
            this.btnDolarS.Click += new System.EventHandler(this.btnDolarS_Click);
            // 
            // btnEuroA
            // 
            this.btnEuroA.Location = new System.Drawing.Point(250, 149);
            this.btnEuroA.Name = "btnEuroA";
            this.btnEuroA.Size = new System.Drawing.Size(39, 23);
            this.btnEuroA.TabIndex = 13;
            this.btnEuroA.Text = "...";
            this.btnEuroA.UseVisualStyleBackColor = true;
            this.btnEuroA.Click += new System.EventHandler(this.btnEuroA_Click);
            // 
            // btnEuroS
            // 
            this.btnEuroS.Location = new System.Drawing.Point(250, 181);
            this.btnEuroS.Name = "btnEuroS";
            this.btnEuroS.Size = new System.Drawing.Size(39, 23);
            this.btnEuroS.TabIndex = 14;
            this.btnEuroS.Text = "...";
            this.btnEuroS.UseVisualStyleBackColor = true;
            this.btnEuroS.Click += new System.EventHandler(this.btnEuroS_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(76, 94);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(226, 26);
            this.txtTutar.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(76, 126);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(226, 26);
            this.txtKalan.TabIndex = 16;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSatisYap.Location = new System.Drawing.Point(76, 158);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(226, 28);
            this.btnSatisYap.TabIndex = 17;
            this.btnSatisYap.Text = "Miktar Kadar Kur Al";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(76, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ne Kadar Kur Alabilirim?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 328);
            this.Controls.Add(this.btnEuroS);
            this.Controls.Add(this.btnEuroA);
            this.Controls.Add(this.btnDolarS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDolarA);
            this.Controls.Add(this.lblEuroS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDolarS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Döviz Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDolarS;
        private System.Windows.Forms.Label lblEuroS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDolarA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnDolarS;
        private System.Windows.Forms.Button btnEuroA;
        private System.Windows.Forms.Button btnEuroS;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button button1;
    }
}

