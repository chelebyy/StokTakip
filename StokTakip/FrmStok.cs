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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }


        SqliteBaglanti bgl = new SqliteBaglanti();
        DataTable dt = new DataTable();

        private void Listele()
        {


            
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Tbl_Urun", bgl.baglanti());
            da.Fill(dt);
            advancedDataGridView1.DataSource = dt;
            advancedDataGridView1.Columns[0].Visible = false;


        }

        private void FrmStok_Load(object sender, EventArgs e)
        {



            Listele();
            advancedDataGridView1.EnableHeadersVisualStyles = false;
            advancedDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
            advancedDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;


            ////

            advancedDataGridView1.Columns[1].HeaderText = "Ürün";
            advancedDataGridView1.Columns[2].HeaderText = "Stok";
            advancedDataGridView1.Columns[3].HeaderText = "Birim";
            advancedDataGridView1.Columns[4].HeaderText = "Kategori";
            advancedDataGridView1.Columns[5].HeaderText = "Alt Kategori";


            ///KRİTİK SEVİYE 
            // Veritabanı bağlantısını açın


            // SQL sorgusunu yürütün ve sonuçları okuyun
            // SQL sorgusunu oluşturun
            string query = "SELECT UrunAd, UrunAdet , UrunCins FROM Tbl_Urun WHERE UrunAdet <=20";

            // Veritabanı bağlantısını açın
            //connection.Open();

            // SQL sorgusunu yürütün ve sonuçları okuyun
            using (SQLiteCommand command = new SQLiteCommand(query, bgl.baglanti()))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    // RichTextBox kontrolüne yazdırılacak metnioluşturun
                    StringBuilder sb = new StringBuilder();
                    // "Kritik Seviyedeki Ürünler" yazısını ekleyin
                    sb.AppendLine("\u0332   <Kritik Seviyedeki Ürünler>\n");
                    


                    while (reader.Read())
                    {
                        string urunAdi = reader.GetString(0);
                        
                        int urunAdet = reader.GetInt32(1);
                        string urunCins = reader.GetString(2);
                        sb.AppendFormat("* {0} > {1}  {2}\n", urunAdi, urunAdet , urunCins);
                    }

                    // RichTextBox kontrolüne metni yazdırın
                    richTextBox1.Text = sb.ToString();
                }
            }

        }

        private void advancedDataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Satırın arkaplan rengini belirleyin
            if (e.RowIndex % 2 == 0)
            {
                // Çift satırlar için arkaplan rengi
                advancedDataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                // Tek satırlar için arkaplan rengi
                advancedDataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = advancedDataGridView1.SortString;
        }


        //TXT YE YAZDIKÇA ÇIKAN SONUÇ
        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {


            SQLiteCommand komut = new SQLiteCommand("Select * From Tbl_Urun where UrunAd like'%" + txtUrunAra.Text + "%'", bgl.baglanti());
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(komut);
            da.Fill(dt);
            advancedDataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }

        
    }
}
