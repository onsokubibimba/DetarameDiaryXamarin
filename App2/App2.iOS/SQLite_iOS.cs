using System;
using System.Collections.Generic;
using System.Text;

using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinIOS;
using App2.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace App2.iOS
{
    public class SQLite_iOS : ISQLite 
    {
        public SQLiteConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, "TodoSQLite.db3");
            return new SQLiteConnection(new SQLitePlatformIOS(),path);

        }
    }
}
