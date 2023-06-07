namespace StokTakip
{
    partial class FrmStokIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.btnStokDus = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.comboUrunAd = new System.Windows.Forms.ComboBox();
            this.ComboBirim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboAltKategori = new System.Windows.Forms.ComboBox();
            this.comboAnaKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboUrunCıns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokIslemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.StokUrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokUrunAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokUrunCins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokUrunKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokUrunAltKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtUrunAdet);
            this.panel1.Controls.Add(this.btnStokDus);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.comboUrunAd);
            this.panel1.Controls.Add(this.ComboBirim);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboAltKategori);
            this.panel1.Controls.Add(this.comboAnaKategori);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboUrunCıns);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStokIslemID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 217);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(674, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 53);
            this.button2.TabIndex = 130;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(676, 43);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 53);
            this.btnGuncelle.TabIndex = 129;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(122, 110);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(135, 20);
            this.txtUrunAdet.TabIndex = 2;
            // 
            // btnStokDus
            // 
            this.btnStokDus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokDus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokDus.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnStokDus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokDus.ForeColor = System.Drawing.Color.White;
            this.btnStokDus.Location = new System.Drawing.Point(567, 42);
            this.btnStokDus.Name = "btnStokDus";
            this.btnStokDus.Size = new System.Drawing.Size(77, 53);
            this.btnStokDus.TabIndex = 120;
            this.btnStokDus.Text = "Stok Düş";
            this.btnStokDus.UseVisualStyleBackColor = true;
            this.btnStokDus.Click += new System.EventHandler(this.btnStokDus_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(567, 113);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(77, 53);
            this.btnExcel.TabIndex = 127;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // comboUrunAd
            // 
            this.comboUrunAd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboUrunAd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboUrunAd.FormattingEnabled = true;
            this.comboUrunAd.Location = new System.Drawing.Point(122, 79);
            this.comboUrunAd.Name = "comboUrunAd";
            this.comboUrunAd.Size = new System.Drawing.Size(135, 21);
            this.comboUrunAd.TabIndex = 1;
            this.comboUrunAd.SelectedIndexChanged += new System.EventHandler(this.comboUrunAd_SelectedIndexChanged);
            // 
            // ComboBirim
            // 
            this.ComboBirim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBirim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBirim.FormattingEnabled = true;
            this.ComboBirim.Location = new System.Drawing.Point(351, 143);
            this.ComboBirim.Name = "ComboBirim";
            this.ComboBirim.Size = new System.Drawing.Size(123, 21);
            this.ComboBirim.TabIndex = 1237;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(298, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 124;
            this.label9.Text = "Birim :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(297, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 122;
            this.label7.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // comboAltKategori
            // 
            this.comboAltKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAltKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAltKategori.FormattingEnabled = true;
            this.comboAltKategori.Location = new System.Drawing.Point(351, 78);
            this.comboAltKategori.Name = "comboAltKategori";
            this.comboAltKategori.Size = new System.Drawing.Size(123, 21);
            this.comboAltKategori.TabIndex = 5;
            // 
            // comboAnaKategori
            // 
            this.comboAnaKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAnaKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAnaKategori.FormattingEnabled = true;
            this.comboAnaKategori.Location = new System.Drawing.Point(351, 45);
            this.comboAnaKategori.Name = "comboAnaKategori";
            this.comboAnaKategori.Size = new System.Drawing.Size(123, 21);
            this.comboAnaKategori.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(267, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 119;
            this.label5.Text = "Alt Kategori :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(283, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 118;
            this.label6.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Birimi :";
            // 
            // comboUrunCıns
            // 
            this.comboUrunCıns.FormattingEnabled = true;
            this.comboUrunCıns.Items.AddRange(new object[] {
            "Adet",
            "Metre",
            "Kutu",
            "Torba",
            "Paket",
            "Kilo"});
            this.comboUrunCıns.Location = new System.Drawing.Point(122, 143);
            this.comboUrunCıns.Name = "comboUrunCıns";
            this.comboUrunCıns.Size = new System.Drawing.Size(135, 21);
            this.comboUrunCıns.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "Ürün :";
            // 
            // txtStokIslemID
            // 
            this.txtStokIslemID.Enabled = false;
            this.txtStokIslemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokIslemID.Location = new System.Drawing.Point(122, 46);
            this.txtStokIslemID.Name = "txtStokIslemID";
            this.txtStokIslemID.Size = new System.Drawing.Size(135, 22);
            this.txtStokIslemID.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "ID :";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.ColumnHeadersHeight = 24;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokUrunAd,
            this.StokUrunAdet,
            this.StokUrunCins,
            this.StokUrunKategori,
            this.StokUrunAltKategori,
            this.StokTarih,
            this.StokBirim});
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advancedDataGridView1.EnableHeadersVisualStyles = false;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 217);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView1.Size = new System.Drawing.Size(800, 233);
            this.advancedDataGridView1.TabIndex = 13;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellClick);
            // 
            // StokUrunAd
            // 
            this.StokUrunAd.DataPropertyName = "StokUrunAd";
            this.StokUrunAd.HeaderText = "Ürün";
            this.StokUrunAd.MinimumWidth = 22;
            this.StokUrunAd.Name = "StokUrunAd";
            this.StokUrunAd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokUrunAdet
            // 
            this.StokUrunAdet.DataPropertyName = "StokUrunAdet";
            this.StokUrunAdet.HeaderText = "Adet";
            this.StokUrunAdet.MinimumWidth = 22;
            this.StokUrunAdet.Name = "StokUrunAdet";
            this.StokUrunAdet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokUrunCins
            // 
            this.StokUrunCins.DataPropertyName = "StokUrunCins";
            this.StokUrunCins.HeaderText = "Birim";
            this.StokUrunCins.MinimumWidth = 22;
            this.StokUrunCins.Name = "StokUrunCins";
            this.StokUrunCins.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokUrunKategori
            // 
            this.StokUrunKategori.DataPropertyName = "StokUrunKategori";
            this.StokUrunKategori.HeaderText = "Kategori";
            this.StokUrunKategori.MinimumWidth = 22;
            this.StokUrunKategori.Name = "StokUrunKategori";
            this.StokUrunKategori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokUrunAltKategori
            // 
            this.StokUrunAltKategori.DataPropertyName = "StokUrunAltKategori";
            this.StokUrunAltKategori.HeaderText = "Alt Kategori";
            this.StokUrunAltKategori.MinimumWidth = 22;
            this.StokUrunAltKategori.Name = "StokUrunAltKategori";
            this.StokUrunAltKategori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokTarih
            // 
            this.StokTarih.DataPropertyName = "StokTarih";
            this.StokTarih.HeaderText = "Tarih";
            this.StokTarih.MinimumWidth = 22;
            this.StokTarih.Name = "StokTarih";
            this.StokTarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StokBirim
            // 
            this.StokBirim.DataPropertyName = "StokBirim";
            this.StokBirim.HeaderText = "Birimi";
            this.StokBirim.MinimumWidth = 22;
            this.StokBirim.Name = "StokBirim";
            this.StokBirim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStokIslemleri";
            this.Text = "StokIslemleri";
            this.Load += new System.EventHandler(this.FrmStokIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox comboUrunAd;
        private System.Windows.Forms.ComboBox ComboBirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboAltKategori;
        private System.Windows.Forms.ComboBox comboAnaKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboUrunCıns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStokIslemID;
        private System.Windows.Forms.Button btnStokDus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokUrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokUrunAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokUrunCins;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokUrunKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokUrunAltKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokBirim;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}