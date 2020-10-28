namespace Deneme_tez2
{
    partial class YilanOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YilanOyunu));
            this.label1 = new System.Windows.Forms.Label();
            this.oyunSüresi = new System.Windows.Forms.Timer(this.components);
            this.lbskor = new System.Windows.Forms.Label();
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan:";
            // 
            // lbskor
            // 
            this.lbskor.AutoSize = true;
            this.lbskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbskor.Location = new System.Drawing.Point(434, 44);
            this.lbskor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbskor.Name = "lbskor";
            this.lbskor.Size = new System.Drawing.Size(0, 17);
            this.lbskor.TabIndex = 2;
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.AutoSize = true;
            this.lblOyunBitti.Location = new System.Drawing.Point(375, 89);
            this.lblOyunBitti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(35, 13);
            this.lblOyunBitti.TabIndex = 3;
            this.lblOyunBitti.Text = "label2";
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Thistle;
            this.pb.Location = new System.Drawing.Point(25, 44);
            this.pb.Margin = new System.Windows.Forms.Padding(2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(319, 317);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // YilanOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 448);
            this.Controls.Add(this.lblOyunBitti);
            this.Controls.Add(this.lbskor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YilanOyunu";
            this.Text = "YilanOyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YilanOyunu_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.YilanOyunu_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer oyunSüresi;
        private System.Windows.Forms.Label lbskor;
        private System.Windows.Forms.Label lblOyunBitti;
    }
}