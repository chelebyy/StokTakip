namespace StokTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.panelAyarSubmenu = new System.Windows.Forms.Panel();
            this.btnVeritabaniYedekle = new System.Windows.Forms.Button();
            this.btnBirimEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.butnAyarlar = new System.Windows.Forms.Button();
            this.panelStokSubmenu = new System.Windows.Forms.Panel();
            this.btnStokDus = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnStokislem = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelAyarSubmenu.SuspendLayout();
            this.panelStokSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.pictureBox2);
            this.panelSideMenu.Controls.Add(this.btnHakkinda);
            this.panelSideMenu.Controls.Add(this.panelAyarSubmenu);
            this.panelSideMenu.Controls.Add(this.butnAyarlar);
            this.panelSideMenu.Controls.Add(this.panelStokSubmenu);
            this.panelSideMenu.Controls.Add(this.btnStokislem);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 616);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 502);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sorgu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHakkinda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHakkinda.Location = new System.Drawing.Point(0, 460);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHakkinda.Size = new System.Drawing.Size(220, 42);
            this.btnHakkinda.TabIndex = 10;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // panelAyarSubmenu
            // 
            this.panelAyarSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAyarSubmenu.Controls.Add(this.btnVeritabaniYedekle);
            this.panelAyarSubmenu.Controls.Add(this.btnBirimEkle);
            this.panelAyarSubmenu.Controls.Add(this.btnUrunEkle);
            this.panelAyarSubmenu.Controls.Add(this.btnKategoriEkle);
            this.panelAyarSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAyarSubmenu.Location = new System.Drawing.Point(0, 285);
            this.panelAyarSubmenu.Name = "panelAyarSubmenu";
            this.panelAyarSubmenu.Size = new System.Drawing.Size(220, 175);
            this.panelAyarSubmenu.TabIndex = 6;
            // 
            // btnVeritabaniYedekle
            // 
            this.btnVeritabaniYedekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeritabaniYedekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeritabaniYedekle.FlatAppearance.BorderSize = 0;
            this.btnVeritabaniYedekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnVeritabaniYedekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeritabaniYedekle.ForeColor = System.Drawing.Color.LightGray;
            this.btnVeritabaniYedekle.Location = new System.Drawing.Point(0, 119);
            this.btnVeritabaniYedekle.Name = "btnVeritabaniYedekle";
            this.btnVeritabaniYedekle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVeritabaniYedekle.Size = new System.Drawing.Size(220, 39);
            this.btnVeritabaniYedekle.TabIndex = 3;
            this.btnVeritabaniYedekle.Text = "Veritabanı İşlemleri";
            this.btnVeritabaniYedekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeritabaniYedekle.UseVisualStyleBackColor = true;
            this.btnVeritabaniYedekle.Click += new System.EventHandler(this.btnVeritabaniYedekle_Click_1);
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBirimEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBirimEkle.FlatAppearance.BorderSize = 0;
            this.btnBirimEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnBirimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBirimEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnBirimEkle.Location = new System.Drawing.Point(0, 80);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBirimEkle.Size = new System.Drawing.Size(220, 39);
            this.btnBirimEkle.TabIndex = 2;
            this.btnBirimEkle.Text = "Birim İşlemleri";
            this.btnBirimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBirimEkle.UseVisualStyleBackColor = true;
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnUrunEkle.Location = new System.Drawing.Point(0, 40);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUrunEkle.Size = new System.Drawing.Size(220, 40);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün İşlemleri";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKategoriEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategoriEkle.FlatAppearance.BorderSize = 0;
            this.btnKategoriEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnKategoriEkle.Location = new System.Drawing.Point(0, 0);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnKategoriEkle.Size = new System.Drawing.Size(220, 40);
            this.btnKategoriEkle.TabIndex = 0;
            this.btnKategoriEkle.Text = "Kategori İşlemleri";
            this.btnKategoriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // butnAyarlar
            // 
            this.butnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.butnAyarlar.FlatAppearance.BorderSize = 0;
            this.butnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnAyarlar.ForeColor = System.Drawing.Color.Gainsboro;
            this.butnAyarlar.Location = new System.Drawing.Point(0, 239);
            this.butnAyarlar.Name = "butnAyarlar";
            this.butnAyarlar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.butnAyarlar.Size = new System.Drawing.Size(220, 46);
            this.butnAyarlar.TabIndex = 5;
            this.butnAyarlar.Text = "Ayarlar";
            this.butnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butnAyarlar.UseVisualStyleBackColor = true;
            this.butnAyarlar.Click += new System.EventHandler(this.butnAyarlar_Click);
            // 
            // panelStokSubmenu
            // 
            this.panelStokSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStokSubmenu.Controls.Add(this.btnStokDus);
            this.panelStokSubmenu.Controls.Add(this.btnStok);
            this.panelStokSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStokSubmenu.Location = new System.Drawing.Point(0, 143);
            this.panelStokSubmenu.Name = "panelStokSubmenu";
            this.panelStokSubmenu.Size = new System.Drawing.Size(220, 96);
            this.panelStokSubmenu.TabIndex = 4;
            // 
            // btnStokDus
            // 
            this.btnStokDus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokDus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokDus.FlatAppearance.BorderSize = 0;
            this.btnStokDus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnStokDus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokDus.ForeColor = System.Drawing.Color.LightGray;
            this.btnStokDus.Location = new System.Drawing.Point(0, 40);
            this.btnStokDus.Name = "btnStokDus";
            this.btnStokDus.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStokDus.Size = new System.Drawing.Size(220, 40);
            this.btnStokDus.TabIndex = 1;
            this.btnStokDus.Text = "Stok İşlem";
            this.btnStokDus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokDus.UseVisualStyleBackColor = true;
            this.btnStokDus.Click += new System.EventHandler(this.btnStokDus_Click);
            // 
            // btnStok
            // 
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.ForeColor = System.Drawing.Color.LightGray;
            this.btnStok.Location = new System.Drawing.Point(0, 0);
            this.btnStok.Name = "btnStok";
            this.btnStok.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStok.Size = new System.Drawing.Size(220, 40);
            this.btnStok.TabIndex = 0;
            this.btnStok.Text = "Stok";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnStokislem
            // 
            this.btnStokislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokislem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokislem.FlatAppearance.BorderSize = 0;
            this.btnStokislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokislem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStokislem.Location = new System.Drawing.Point(0, 97);
            this.btnStokislem.Name = "btnStokislem";
            this.btnStokislem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStokislem.Size = new System.Drawing.Size(220, 46);
            this.btnStokislem.TabIndex = 3;
            this.btnStokislem.Text = "Stok İşlemleri";
            this.btnStokislem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokislem.UseVisualStyleBackColor = true;
            this.btnStokislem.Click += new System.EventHandler(this.btnStokislem_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.pictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 97);
            this.panelLogo.TabIndex = 0;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(960, 57);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(858, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(894, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(930, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(400, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STOK";
            this.lblTitle.Visible = false;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 57);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(960, 559);
            this.panelDesktopPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 57);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 616);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelAyarSubmenu.ResumeLayout(false);
            this.panelStokSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnStokislem;
        private System.Windows.Forms.Panel panelStokSubmenu;
        private System.Windows.Forms.Button btnStokDus;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Panel panelAyarSubmenu;
        private System.Windows.Forms.Button btnBirimEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button butnAyarlar;
        private System.Windows.Forms.Button btnVeritabaniYedekle;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

