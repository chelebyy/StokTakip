using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace StokTakip
{
    class SqliteClass
    {


        public SQLiteConnection baglanti()
        {
            SQLiteConnection baglan = new SQLiteConnection("Data Source=Storage.db;Version=3;Read Only=False;");//stringi yazdık
            
            baglan.Open();
            return baglan;
        }
    }
}
