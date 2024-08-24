using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasPrj
{
    public class DbConnection : IDisposable
    {
        private readonly SQLiteConnection _connection;
        public SQLiteConnection connetion => _connection;

        public DbConnection()
        {
            _connection = new SQLiteConnection("Data Source=C:\\Heitor\\MaquinasPrj\\MaquinasPrj\\maquinas.db");
            _connection.Open();

        }

             
        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
                     
        }
    }
}
