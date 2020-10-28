namespace Deneme_tez2
{
    partial class Renkler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renkler));
            this.lblsayac = new System.Windows.Forms.Label();
            this.btnkırmızı = new System.Windows.Forms.Button();
            this.lblRenk = new System.Windows.Forms.Label();
            this.pgrbar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.btnmavi = new System.Windows.Forms.Button();
            this.btnsarı = new System.Windows.Forms.Button();
            this.btnturuncu = new System.Windows.Forms.Button();
            this.btnmor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsayac
            // 
            this.lblsayac.AutoSize = true;
            this.lblsayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayac.Location = new System.Drawing.Point(324, 9);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(32, 16);
            this.lblsayac.TabIndex = 0;
            this.lblsayac.Text = "100";
            // 
            // btnkırmızı
            // 
            this.btnkırmızı.BackColor = System.Drawing.Color.Crimson;
            this.btnkırmızı.Location = new System.Drawing.Point(36, 183);
            this.btnkırmızı.Name = "btnkırmızı";
            this.btnkırmızı.Size = new System.Drawing.Size(97, 74);
            this.btnkırmızı.TabIndex = 1;
            this.btnkırmızı.UseVisualStyleBackColor = false;
            this.btnkırmızı.Click += new System.EventHandler(this.btnkırmızı_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(324, 124);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(51, 20);
            this.lblRenk.TabIndex = 6;
            this.lblRenk.Text = "Renk";
            // 
            // pgrbar
            // 
            this.pgrbar.Location = new System.Drawing.Point(36, 72);
            this.pgrbar.Name = "pgrbar";
            this.pgrbar.Size = new System.Drawing.Size(617, 23);
            this.pgrbar.TabIndex = 7;
            this.pgrbar.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(588, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skor:";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblskor.Location = new System.Drawing.Point(645, 13);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(19, 20);
            this.lblskor.TabIndex = 9;
            this.lblskor.Text = "0";
            // 
            // btnmavi
            // 
            this.btnmavi.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnmavi.Location = new System.Drawing.Point(163, 183);
            this.btnmavi.Name = "btnmavi";
            this.btnmavi.Size = new System.Drawing.Size(97, 74);
            this.btnmavi.TabIndex = 10;
            this.btnmavi.UseVisualStyleBackColor = false;
            this.btnmavi.Click += new System.EventHandler(this.btnmavi_Click);
            // 
            // btnsarı
            // 
            this.btnsarı.BackColor = System.Drawing.Color.Yellow;
            this.btnsarı.Location = new System.Drawing.Point(297, 183);
            this.btnsarı.Name = "btnsarı";
            this.btnsarı.Size = new System.Drawing.Size(97, 74);
            this.btnsarı.TabIndex = 11;
            this.btnsarı.UseVisualStyleBackColor = false;
            this.btnsarı.Click += new System.EventHandler(this.btnsarı_Click);
            // 
            // btnturuncu
            // 
            this.btnturuncu.BackColor = System.Drawing.Color.Coral;
            this.btnturuncu.Location = new System.Drawing.Point(422, 183);
            this.btnturuncu.Name = "btnturuncu";
            this.btnturuncu.Size = new System.Drawing.Size(97, 74);
            this.btnturuncu.TabIndex = 12;
            this.btnturuncu.UseVisualStyleBackColor = false;
            this.btnturuncu.Click += new System.EventHandler(this.btnturuncu_Click);
            // 
            // btnmor
            // 
            this.btnmor.BackColor = System.Drawing.Color.Orchid;
            this.btnmor.Location = new System.Drawing.Point(556, 183);
            this.btnmor.Name = "btnmor";
            this.btnmor.Size = new System.Drawing.Size(97, 74);
            this.btnmor.TabIndex = 13;
            this.btnmor.UseVisualStyleBackColor = false;
            this.btnmor.Click += new System.EventHandler(this.btnmor_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Renkler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(718, 366);
            this.Controls.Add(this.btnmor);
            this.Controls.Add(this.btnturuncu);
            this.Controls.Add(this.btnsarı);
            this.Controls.Add(this.btnmavi);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgrbar);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.btnkırmızı);
            this.Controls.Add(this.lblsayac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renkler";
            this.Text = "Renkler";
            this.Load += new System.EventHandler(this.Renkler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayac;
        private System.Windows.Forms.Button btnkırmızı;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.ProgressBar pgrbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Button btnmavi;
        private System.Windows.Forms.Button btnsarı;
        private System.Windows.Forms.Button btnturuncu;
        private System.Windows.Forms.Button btnmor;
        private System.Windows.Forms.Timer timer1;
    }
}