namespace StokTakip
{
    partial class FrmVeriTabani
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
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYedekle
            // 
            this.btnYedekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYedekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnYedekle.Location = new System.Drawing.Point(64, 60);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(139, 34);
            this.btnYedekle.TabIndex = 0;
            this.btnYedekle.Text = "Veritabanı Yedekle";
            this.toolTip1.SetToolTip(this.btnYedekle, "Veritabanı ismi \" Storage \" olarak kaydedilmelidir.");
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeriYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriYukle.Location = new System.Drawing.Point(55, 60);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(139, 34);
            this.btnGeriYukle.TabIndex = 14;
            this.btnGeriYukle.Text = "Veritabanı Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnYedekle);
            this.groupBox1.Location = new System.Drawing.Point(118, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnGeriYukle);
            this.groupBox2.Location = new System.Drawing.Point(454, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 154);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // FrmVeriTabani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVeriTabani";
            this.Text = "FrmVeriTabani";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}