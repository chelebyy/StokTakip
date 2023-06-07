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
using ADGV;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using OfficeOpenXml;
using System.IO;




namespace StokTakip
{
    public partial class FrmStokIslemleri : Form
    {
        public FrmStokIslemleri()
        {
            InitializeComponent();
        }
        SqliteBaglanti bgl = new SqliteBaglanti();
        System.Data.DataTable dt = new System.Data.DataTable();

        private void Listele()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_StokIslem", bgl.baglanti());
            //SQLiteDataAdapter da = new SQLiteDataAdapter("select ID,StokUrunAd , StokUrunAdet , StokUrunCins , StokUrunKategori , StokUrunAltKategori , StokTarih , StokBirim from Tbl_StokIslem", bgl.baglanti());
            da.Fill(dt);
            
            advancedDataGridView1.DataSource = dt;
            advancedDataGridView1.Columns[0].Visible = false;

        }
        private void SutunBaslik()
        {


            //advancedDataGridView1.Columns[1].HeaderText = "Ürün";
            //advancedDataGridView1.Columns[2].HeaderText = "Stok";
            //advancedDataGridView1.Columns[3].HeaderText = "Birim";
            //advancedDataGridView1.Columns[4].HeaderText = "Kategori";
            //advancedDataGridView1.Columns[5].HeaderText = "Alt Kategori";
            //advancedDataGridView1.Columns[6].HeaderText = "Tarih";
            //advancedDataGridView1.Columns[7].HeaderText = "Kullanıldığı Yer";
        }

        private void Temizle()
        {
            txtStokIslemID.Clear();
            comboUrunAd.SelectedItem = null;
            txtUrunAdet.Clear();
            ComboBirim.SelectedItem = null;
            comboAltKategori.SelectedItem = null;
            comboAnaKategori.SelectedItem = null;

            comboUrunCıns.SelectedItem = null;



        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmStokIslemleri_Load(object sender, EventArgs e)
        {

            //SÜTUN BAŞLIKLARINI DEĞİŞTİRME 



            Listele();

            // ÜRÜN ADINI COMBOYA GETİR
            SQLiteCommand urungetir = new SQLiteCommand("Select UrunAd from Tbl_Urun", bgl.baglanti());
            SQLiteDataReader dr2 = urungetir.ExecuteReader();
            while (dr2.Read())
            {
                comboUrunAd.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //KATEGORİ COMBİYA GETİR
            SQLiteCommand kategorigetir = new SQLiteCommand("Select KategoriAd from Tbl_Kategori", bgl.baglanti());
            SQLiteDataReader dr3 = kategorigetir.ExecuteReader();
            while (dr3.Read())
            {
                comboAnaKategori.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();


            //ALT KATEGORİ COMBO GETİR

            SQLiteCommand altkategorigetir = new SQLiteCommand("Select AltKategoriAd from Tbl_AltKategori", bgl.baglanti());
            SQLiteDataReader dr4 = altkategorigetir.ExecuteReader();
            while (dr4.Read())
            {
                comboAltKategori.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();


            //BİRİM COMBO GETİR

            SQLiteCommand birimgetir = new SQLiteCommand("Select BirimAd from Tbl_Birim", bgl.baglanti());
            SQLiteDataReader dr5 = birimgetir.ExecuteReader();
            while (dr5.Read())
            {
                ComboBirim.Items.Add(dr5[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnStokDus_Click(object sender, EventArgs e)
        {

            int kullanilanAdet;
            if (int.TryParse(txtUrunAdet.Text, out kullanilanAdet))
            {
                // Başarılı bir şekilde dönüştürüldü.

                // Tbl_Urun tablosundaki adet değerini oku
                string urunAdi = comboUrunAd.SelectedItem.ToString();
                int adet = 0;
                string connectionString = @"Data Source = Storage.db; Version = 3; Read Only = False; ";
                string selectQuery = "SELECT UrunAdet FROM Tbl_Urun WHERE UrunAd = @urunAdi";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@urunAdi", urunAdi);
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        adet = reader.GetInt32(0);
                    }
                    reader.Close();


                    // Tbl_Stok tablosuna yeni kaydı ekle

                    try
                    {
                        SQLiteCommand komut9 = new SQLiteCommand("insert into Tbl_StokIslem(StokUrunAd,StokUrunAdet,StokUrunCins,StokUrunKategori,StokUrunAltKategori,StokTarih,StokBirim) values (@u1,@u2,@u3,@u4,@u5,@u6,@u7)", bgl.baglanti());
                        komut9.Parameters.AddWithValue("@u1", comboUrunAd.SelectedItem);
                        komut9.Parameters.AddWithValue("@u2", kullanilanAdet);
                        komut9.Parameters.AddWithValue("@u3", comboUrunCıns.SelectedItem);
                        komut9.Parameters.AddWithValue("@u4", comboAnaKategori.SelectedItem);
                        komut9.Parameters.AddWithValue("@u5", comboAltKategori.SelectedItem);
                        komut9.Parameters.AddWithValue("@u6", dateTimePicker1.Value);
                        komut9.Parameters.AddWithValue("@u7", ComboBirim.SelectedItem);

                        komut9.ExecuteNonQuery();

                        MessageBox.Show("İşleminiz Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
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


                    // Tbl_Urun tablosundaki adet değerini güncelle
                    int kalanAdet = adet - kullanilanAdet;
                    string updateQuery = "UPDATE Tbl_Urun SET UrunAdet = @kalanAdet WHERE UrunAd = @urunAdi";
                    using (SQLiteConnection connectionn = new SQLiteConnection(connectionString))
                    {
                        SQLiteCommand commandd = new SQLiteCommand(updateQuery, connection);
                        commandd.Parameters.AddWithValue("@kalanAdet", kalanAdet);
                        commandd.Parameters.AddWithValue("@urunAdi", urunAdi);
                        connectionn.Open();
                        commandd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                // Dönüştürme başarısız oldu.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteCommand komut10 = new SQLiteCommand("delete from Tbl_StokIslem where ID=@k1", bgl.baglanti());
                komut10.Parameters.AddWithValue("@k1", txtStokIslemID.Text);
                komut10.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SQLiteCommand komut11 = new SQLiteCommand("update Tbl_StokIslem set StokUrunAd=@b1,StokUrunAdet=@b2,StokUrunCins=@b3,StokUrunKategori=@b4,StokUrunAltKategori=@b5,StokTarih=@b6,StokBirim=@b7 where ID=@b8", bgl.baglanti());
                komut11.Parameters.AddWithValue("@b1", comboUrunAd.SelectedItem);
                komut11.Parameters.AddWithValue("@b2", txtUrunAdet.Text);
                komut11.Parameters.AddWithValue("@b3", comboUrunCıns.SelectedItem);
                komut11.Parameters.AddWithValue("@b4", comboAnaKategori.SelectedItem);
                komut11.Parameters.AddWithValue("@b5", comboAltKategori.SelectedItem);
                komut11.Parameters.AddWithValue("@b6", dateTimePicker1.Value);
                komut11.Parameters.AddWithValue("@b7", ComboBirim.SelectedItem);
                komut11.Parameters.AddWithValue("@b8", txtStokIslemID.Text);
                komut11.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();



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


        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                int StartCol = 1;
                int StartRow = 1;

                for (int j = 0; j < advancedDataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = advancedDataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                for (int i = 0; i < advancedDataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < advancedDataGridView1.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = advancedDataGridView1[j, i].Value == null ? "" : advancedDataGridView1[j, i].Value;
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.StackTrace);
            }
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = advancedDataGridView1.SortString;
        }

        private void comboUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand komutt = new SQLiteCommand("select * from Tbl_Urun where UrunAd='" + comboUrunAd.Text + "'", bgl.baglanti());
            SQLiteDataReader oku = komutt.ExecuteReader();
            while (oku.Read())
            {
                //comboUrunCıns.Items.Clear();
                //txtUrunAdet.Clear();
                txtUrunAdet.Text = oku["UrunAdet"].ToString();
                comboUrunCıns.Text = oku["UrunCins"].ToString();
                txtUrunAdet.Text = oku["UrunAdet"].ToString();
                comboAnaKategori.Text = oku["AnaKategori"].ToString();
                comboAltKategori.Text = oku["AltKategori"].ToString();
            }
            bgl.baglanti().Close();
        }

        private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < advancedDataGridView1.Rows.Count)
            {
                txtStokIslemID.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboUrunAd.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUrunAdet.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboUrunCıns.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboAnaKategori.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboAltKategori.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                DateTime dateValue;
                if (DateTime.TryParse(advancedDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(), out dateValue))
                {
                    dateTimePicker1.Value = dateValue;
                }

                ComboBirim.Text = advancedDataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

        }


    }
}
    






