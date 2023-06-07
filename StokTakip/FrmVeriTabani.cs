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
using System.IO;

namespace StokTakip
{
    public partial class FrmVeriTabani : Form
    {
        public FrmVeriTabani()
        {
            InitializeComponent();
        }
        SqliteBaglanti bgl = new SqliteBaglanti();

        protected void BackUp1(String path)
        {
            string src = Application.StartupPath + @"\Storage.db"; string dst = path; System.IO.File.Copy(src, dst, true);
           

        }
        protected void BackUp(String path)
        {
           

            var src = Application.StartupPath + @"\Storage.db";
            var dst = path;
            File.Copy(src, dst, true);

        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            try
            {

                var SaveFD1 = new SaveFileDialog();
                var FileName = "Storage";
                SaveFD1.InitialDirectory = "C:";
                SaveFD1.Title = "Yedek Alma";
                SaveFD1.DefaultExt = "db";
                SaveFD1.FileName = "Storage.db";
                SaveFD1.Filter = "SQLite (*.db)|*.db|All Files|*.* ";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;

                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    //BackupAllUserDatabases();
                    FileName = SaveFD1.FileName;
                    BackUp(FileName);
                    MessageBox.Show("Yedekleme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekleme Yapılırken Hata Oluştu !" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geri Yüklemek İstediğiniz Veritabanı Adı : Storage olması gerekmektedir.Yoksa Program Hata Verir ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SaveFileDialog SaveFD2 = new SaveFileDialog();
            string FileName = "Storage";
            SaveFD2.InitialDirectory = "D:"; SaveFD2.FileName = "Storage";
            SaveFD2.Title = "Geri yüklemek istediğiniz veritabanını seçiniz. Veritabanı adı Data olması zorunludur.";
            SaveFD2.DefaultExt = "accdb";
            SaveFD2.Filter = "Microsoft.Data.SqLite(*.db)|*.db|All Files|*.*";
            SaveFD2.FilterIndex = 1;
            SaveFD2.RestoreDirectory = true;

            if (SaveFD2.ShowDialog() == DialogResult.OK)
            {
                FileName = SaveFD2.FileName;
                var src = FileName;
                var dst = Application.StartupPath + @"\Storage.db";
                File.Copy(src, dst, true);
                MessageBox.Show("Geri yükleme işlemi başarılı !", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
