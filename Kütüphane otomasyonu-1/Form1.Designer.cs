namespace Kütüphane_otomasyonu_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeLıstele = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKıtapLıstele = new System.Windows.Forms.Button();
            this.btnKıtapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetIade = new System.Windows.Forms.Button();
            this.btnEmanetLısteleme = new System.Windows.Forms.Button();
            this.btnEmanetKıtap = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafık = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeLıstele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(45, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeLıstele
            // 
            this.btnUyeLıstele.Location = new System.Drawing.Point(7, 74);
            this.btnUyeLıstele.Name = "btnUyeLıstele";
            this.btnUyeLıstele.Size = new System.Drawing.Size(241, 23);
            this.btnUyeLıstele.TabIndex = 1;
            this.btnUyeLıstele.Text = "Üye listeleme";
            this.btnUyeLıstele.UseVisualStyleBackColor = true;
            this.btnUyeLıstele.Click += new System.EventHandler(this.btnUyeLıstele_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(7, 34);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(241, 23);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme ";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKıtapLıstele);
            this.groupBox2.Controls.Add(this.btnKıtapEkle);
            this.groupBox2.Location = new System.Drawing.Point(419, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKıtapLıstele
            // 
            this.btnKıtapLıstele.Location = new System.Drawing.Point(22, 74);
            this.btnKıtapLıstele.Name = "btnKıtapLıstele";
            this.btnKıtapLıstele.Size = new System.Drawing.Size(213, 23);
            this.btnKıtapLıstele.TabIndex = 1;
            this.btnKıtapLıstele.Text = "Kitap Listeleme";
            this.btnKıtapLıstele.UseVisualStyleBackColor = true;
            this.btnKıtapLıstele.Click += new System.EventHandler(this.btnKıtapLıstele_Click);
            // 
            // btnKıtapEkle
            // 
            this.btnKıtapEkle.Location = new System.Drawing.Point(22, 20);
            this.btnKıtapEkle.Name = "btnKıtapEkle";
            this.btnKıtapEkle.Size = new System.Drawing.Size(213, 23);
            this.btnKıtapEkle.TabIndex = 0;
            this.btnKıtapEkle.Text = "Kitap Ekleme";
            this.btnKıtapEkle.UseVisualStyleBackColor = true;
            this.btnKıtapEkle.Click += new System.EventHandler(this.btnKıtapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetIade);
            this.groupBox3.Controls.Add(this.btnEmanetLısteleme);
            this.groupBox3.Controls.Add(this.btnEmanetKıtap);
            this.groupBox3.Location = new System.Drawing.Point(45, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetIade
            // 
            this.btnEmanetIade.Location = new System.Drawing.Point(7, 80);
            this.btnEmanetIade.Name = "btnEmanetIade";
            this.btnEmanetIade.Size = new System.Drawing.Size(241, 23);
            this.btnEmanetIade.TabIndex = 2;
            this.btnEmanetIade.Text = "Emanet Kitap İade Edilenler";
            this.btnEmanetIade.UseVisualStyleBackColor = true;
            this.btnEmanetIade.Click += new System.EventHandler(this.btnEmanetIade_Click);
            // 
            // btnEmanetLısteleme
            // 
            this.btnEmanetLısteleme.Location = new System.Drawing.Point(7, 50);
            this.btnEmanetLısteleme.Name = "btnEmanetLısteleme";
            this.btnEmanetLısteleme.Size = new System.Drawing.Size(241, 23);
            this.btnEmanetLısteleme.TabIndex = 1;
            this.btnEmanetLısteleme.Text = "Emanet Kitap Listeleme";
            this.btnEmanetLısteleme.UseVisualStyleBackColor = true;
            this.btnEmanetLısteleme.Click += new System.EventHandler(this.btnEmanetLısteleme_Click);
            // 
            // btnEmanetKıtap
            // 
            this.btnEmanetKıtap.Location = new System.Drawing.Point(7, 20);
            this.btnEmanetKıtap.Name = "btnEmanetKıtap";
            this.btnEmanetKıtap.Size = new System.Drawing.Size(241, 23);
            this.btnEmanetKıtap.TabIndex = 0;
            this.btnEmanetKıtap.Text = "Emanet Kitap Verme";
            this.btnEmanetKıtap.UseVisualStyleBackColor = true;
            this.btnEmanetKıtap.Click += new System.EventHandler(this.btnEmanetKıtap_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrafık);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Location = new System.Drawing.Point(419, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 109);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralma Ve Grafikler";
            // 
            // btnGrafık
            // 
            this.btnGrafık.Location = new System.Drawing.Point(7, 68);
            this.btnGrafık.Name = "btnGrafık";
            this.btnGrafık.Size = new System.Drawing.Size(241, 23);
            this.btnGrafık.TabIndex = 1;
            this.btnGrafık.Text = "Grafikler";
            this.btnGrafık.UseVisualStyleBackColor = true;
            this.btnGrafık.Click += new System.EventHandler(this.btnGrafık_Click);
            // 
            // btnSıralama
            // 
            this.btnSıralama.Location = new System.Drawing.Point(7, 20);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(241, 23);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralma";
            this.btnSıralama.UseVisualStyleBackColor = true;
            this.btnSıralama.Click += new System.EventHandler(this.btnSıralama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUyeLıstele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKıtapLıstele;
        private System.Windows.Forms.Button btnKıtapEkle;
        private System.Windows.Forms.Button btnEmanetIade;
        private System.Windows.Forms.Button btnEmanetLısteleme;
        private System.Windows.Forms.Button btnEmanetKıtap;
        private System.Windows.Forms.Button btnGrafık;
        private System.Windows.Forms.Button btnSıralama;
    }
}

