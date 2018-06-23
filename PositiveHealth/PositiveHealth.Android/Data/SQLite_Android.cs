
using PositiveHealth.Data;
using PositiveHealth.Droid.Data;
using SQLite;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace PositiveHealth.Droid.Data
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }

        public SQLiteConnection GetConnection()
            {
            var sqliteFileName = "FoodDatabase.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);

            var con = new SQLite.SQLiteConnection(path);

            return con;
            }



    }
}