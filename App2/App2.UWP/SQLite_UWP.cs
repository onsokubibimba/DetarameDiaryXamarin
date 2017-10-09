using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using App2.UWP;

using SQLite.Net.Platform.WinRT;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace App2.UWP
{
    class SQLite_UWP : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var path = Path.Combine(Path.GetTempPath(), "TodoSQLite.db3"); // <-2
            return new SQLiteConnection(new SQLitePlatformWinRT(), path); // <-3
        }
    }
}
