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
//using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;


namespace StokTakip
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        SqliteBaglanti bgl = new SqliteBaglanti();





        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            // Verileri bir DataTable nesnesine aktar
            System.Data.DataTable dataTable = (System.Data.DataTable)dataGridView1.DataSource;

            // Excel uygulamasını başlat
            Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;

            try
            {
                // Aktif sayfayı seç
                worksheet = workbook.ActiveSheet;

                // Excel'e verileri aktar
                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }

                // Excel dosyasını kaydet ve kapat
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Excel Dosyası Kaydet";
                saveFileDialog.FileName = "StokRaporu.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel dosyası başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel dosyası kaydedilemedi: " + ex.Message);
            }
            finally
            {
                workbook.Close();
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                excel = null;
                workbook = null;
                worksheet = null;
                GC.Collect();
            }
        }

        private void btnSorgula_Click_1(object sender, EventArgs e)
        {
            //string connectionString = "Data Source = Storage.db; Version = 3; Read Only = False; ";
            //DateTime baslangicTarihi = date1.Value;
            //DateTime bitisTarihi = date2.Value;

            //using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = "SELECT * FROM Tbl_StokIslem WHERE StokTarih BETWEEN @BaslangicTarihi AND @BitisTarihi";
            //    using (SQLiteCommand command = new SQLiteCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
            //        command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

            //        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);

            //        // GridView'e aktarma işlemi
            //        dataGridView1.DataSource = dataTable;


            //    }

            //    connection.Close();
            //}


            try
            {
                string connectionString = "Data Source=Storage.db; Version=3; Read Only=False;";
                DateTime baslangicTarihi = date1.Value;
                DateTime bitisTarihi = date2.Value;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Tbl_StokIslem WHERE StokTarih BETWEEN @BaslangicTarihi AND @BitisTarihi";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                        command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // GridView'e aktarma işlemi
                        dataGridView1.DataSource = dataTable;
                    }


                }

            }
            catch (Exception ex)
            {
                // Hata durumunda işlemler
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }




        }
    }
}






