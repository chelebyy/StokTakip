using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StokTakip
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
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
            label4.ForeColor = ThemeColor.SecondColor;
            label6.ForeColor = ThemeColor.PrimaryColor;



        }
        private void Temizle()
        {
            txtKategoriID.Clear();
            txtKategoriAd.Clear();
            
            
        }

        private void Temizle2()
        {
           
            txtAltKategoriID.Clear();
            txtAltKategoriAd.Clear();

        }
        private void Listele()
        {

            LoadTheme();
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_Kategori", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }
        private void Listele2()
        {

            LoadTheme();
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_AltKategori", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {

            Listele();
            Listele2();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "KATEGORİ";
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "AT KATEGORİ";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtKategoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtKategoriAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }

            
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //TRY-CATCH KULLANACAKSIN


            if (string.IsNullOrWhiteSpace(txtKategoriAd.Text) )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SQLiteCommand komut2 = new SQLiteCommand("insert into Tbl_Kategori (KategoriAd) values (@p1)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
                    
                    komut2.ExecuteNonQuery();

                    bgl.baglanti().Close();
                    Temizle();
                    MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut3 = new SQLiteCommand("delete from Tbl_Kategori where KategoriID=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtKategoriID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle();
            MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut4 = new SQLiteCommand("Update Tbl_kategori set KategoriAd=@k2 where KategoriID=@k1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@k2", txtKategoriAd.Text);
            komut4.Parameters.AddWithValue("@k1", txtKategoriID.Text);
            
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAltKategoriID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAltKategoriAd.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAltKategoriAd.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SQLiteCommand komut2 = new SQLiteCommand("insert into Tbl_AltKategori (AltKategoriAd) values (@p1)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@p1", txtAltKategoriAd.Text);

                    komut2.ExecuteNonQuery();

                    bgl.baglanti().Close();
                    Temizle2();
                    MessageBox.Show("Alt Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele2();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut3 = new SQLiteCommand("delete from Tbl_AltKategori where AltKategoriID=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtAltKategoriID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle2();
            MessageBox.Show("Alt Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut4 = new SQLiteCommand("Update Tbl_AltKategori set AltKategoriAd=@k2 where AltKategoriID=@k1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@k2", txtAltKategoriAd.Text);
            komut4.Parameters.AddWithValue("@k1", txtAltKategoriID.Text);

            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle2();
            MessageBox.Show("Alt Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele2();
        }
    }
}
