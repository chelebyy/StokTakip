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
    public partial class FrmBirimEkle : Form
    {
        public FrmBirimEkle()
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
           



        }

        private void Temizle()
        {
            txtBirimAd.Clear();
            txtBirimID.Clear();
            txtBirimAd.Focus();
        }

        private void Listele()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_Birim", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmBirimEkle_Load(object sender, EventArgs e)
        {
            
           
            Listele();

            dataGridView1.Columns[1].HeaderText = "Birim";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtBirimID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBirimAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirimAd.Text))
            {
                MessageBox.Show("Lütfen bir Birim adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SQLiteCommand komut5 = new SQLiteCommand("insert into Tbl_Birim (BirimAd) values (@b1)", bgl.baglanti());
                    komut5.Parameters.AddWithValue("@b1", txtBirimAd.Text);
                    komut5.ExecuteNonQuery();
                    Temizle();
                    MessageBox.Show("Birim Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
                try
                {
                    
                    
                    

                    SQLiteCommand komut6 = new SQLiteCommand("delete from Tbl_Birim where BirimID=@k1", bgl.baglanti());
                    komut6.Parameters.AddWithValue("@k1", txtBirimID.Text);
                    komut6.ExecuteNonQuery();
                    MessageBox.Show("Birim Silindi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand komut7 = new SQLiteCommand("update Tbl_Birim set BirimAd=@b1 where BirimID=@b2", bgl.baglanti());
                komut7.Parameters.AddWithValue("@b1", txtBirimAd.Text);
                komut7.Parameters.AddWithValue("@b2", txtBirimID.Text);
                komut7.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Birim Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

