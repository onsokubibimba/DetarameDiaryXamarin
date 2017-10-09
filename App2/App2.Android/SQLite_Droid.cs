﻿using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using App2.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace App2.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // <-1
            var path = Path.Combine(documentsPath, "TodoSQLite.db3"); // <-2
            return new SQLiteConnection(new SQLitePlatformAndroid(), path); // <-3
        }
    }
}
