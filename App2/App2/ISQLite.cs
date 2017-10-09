using System;
using System.Collections.Generic;
using System.Text;

using SQLite.Net;

namespace App2
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
