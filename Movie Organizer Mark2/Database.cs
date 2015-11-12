using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Movie_Organizer_Mark2
{
    class Database
    {

        private string movieDatabase = "Database.db";
        private SQLiteConnection databaseConnection;

        public Database()
        {
        }
        // Making a connection with the Database
        private void databaseConnect()
        {
            databaseConnection = new SQLiteConnection("Data Source=" + movieDatabase + ";Version=3;");
            databaseConnection.Open();
        }
        //Execute the query
        private int executeSql(string sql)
        {
            var Execute = new SQLiteCommand(sql, databaseConnection);
            return Execute.ExecuteNonQuery();
        }
    }
}
