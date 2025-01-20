using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelReervasyon
{
    internal class dbBaglatnı
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection connection = new MySqlConnection("Server= 172.21.54.253;Database= 25_132330051;" +
                      "Uid = 25_132330051;Pwd=!nif.ogr51BA");
            connection.Open();
            return connection;
        }
    }
}
