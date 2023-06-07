using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
            LoadTheme();
        }
        SqliteBaglanti bgl = new SqliteBaglanti();
       

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;



        }


        private void Temizle()
        {
            txtUrunAd.Clear();
            txtUrunID.Clear();
            masketUrunAdet.Clear();
            comboUrunCıns.SelectedItem = null;
            comboAnaKategori.SelectedItem = null;
            comboAltKategori.SelectedItem = null;
            txtUrunAd.Focus();
        }
        private void Listele()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_Urun", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {



            // DataGridView'ın özelliklerini ayarlayın
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            Listele();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ürün";
            dataGridView1.Columns[2].HeaderText = "Stok";
            dataGridView1.Columns[3].HeaderText = "Birim";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Alt Kategori";


            SQLiteCommand kategorigetir = new SQLiteCommand("Select KategoriAd from Tbl_Kategori", bgl.baglanti());
            SQLiteDataReader dr25 = kategorigetir.ExecuteReader();
            while (dr25.Read())
            {
                comboAnaKategori.Items.Add(dr25[0]);
                //comboAltKategori.Items.Add(dr25[1]);
            }
            bgl.baglanti().Close();

            SQLiteCommand kategorigetir2 = new SQLiteCommand("Select AltKAtegoriAd from Tbl_AltKategori", bgl.baglanti());
            SQLiteDataReader dr26 = kategorigetir2.ExecuteReader();
            while (dr26.Read())
            {
                //comboAnaKategori.Items.Add(dr25[0]);
                comboAltKategori.Items.Add(dr26[0]);
            }
            bgl.baglanti().Close();





        }




        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAd.Text) || string.IsNullOrWhiteSpace(masketUrunAdet.Text) || comboUrunCıns.SelectedItem == null || string.IsNullOrWhiteSpace(comboUrunCıns.SelectedItem.ToString()))
            {
                MessageBox.Show("Lütfen bir Ürün Adı ve Cinsini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SQLiteCommand komut9 = new SQLiteCommand("insert into Tbl_Urun (UrunAd,UrunAdet,UrunCins,AnaKAtegori,AltKategori) values (@u1,@u2,@u3,@u4,@u5)", bgl.baglanti());
                    komut9.Parameters.AddWithValue("@u1", txtUrunAd.Text);
                    komut9.Parameters.AddWithValue("@u2", masketUrunAdet.Text);
                    komut9.Parameters.AddWithValue("@u3", comboUrunCıns.SelectedItem);
                    komut9.Parameters.AddWithValue("@u4", comboAnaKategori.SelectedItem);
                    komut9.Parameters.AddWithValue("@u5", comboAltKategori.SelectedItem);
                    komut9.ExecuteNonQuery();
                    Temizle();
                    MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.baglanti().Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                masketUrunAdet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboAnaKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboAltKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }


            //txtUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //masketUrunAdet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //comboAnaKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //comboAltKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            //comboUrunCıns.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                object selectedValue = selectedRow.Cells[3].Value;

                if (selectedValue != null && !string.IsNullOrWhiteSpace(selectedValue.ToString()))
                {
                    comboUrunCıns.SelectedItem = selectedValue.ToString();
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {




                SQLiteCommand komut10 = new SQLiteCommand("delete from Tbl_Urun where UrunID=@k1", bgl.baglanti());
                komut10.Parameters.AddWithValue("@k1", txtUrunID.Text);
                komut10.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Satırın arkaplan rengini belirleyin
            if (e.RowIndex % 2 == 0)
            {
                // Çift satırlar için arkaplan rengi
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                // Tek satırlar için arkaplan rengi
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand komut11 = new SQLiteCommand("update Tbl_Urun set UrunAd=@b1,UrunAdet=@b2,UrunCins=@b3,AnaKategori=@b5,AltKategori=@b6 where UrunID=@b4", bgl.baglanti());
                komut11.Parameters.AddWithValue("@b1", txtUrunAd.Text);
                komut11.Parameters.AddWithValue("@b2", masketUrunAdet.Text);
                komut11.Parameters.AddWithValue("@b3", comboUrunCıns.Text);
                komut11.Parameters.AddWithValue("@b4", txtUrunID.Text);
                komut11.Parameters.AddWithValue("@b5", comboAnaKategori.Text);
                komut11.Parameters.AddWithValue("@b6", comboAltKategori.Text);
                komut11.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir Hata Oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (bgl.baglanti().State == ConnectionState.Open)
                {
                    bgl.baglanti().Close();
                }
            }
        }

       
    }
}







