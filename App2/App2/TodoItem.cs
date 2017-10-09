using System;
//using System.Collections.Generic;
//using System.Text;
using SQLite.Net.Attributes;


namespace App2
{
    public class TodoItem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Diary { get; set; }
        public string Weather { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public string Who { get; set; }
        public string How { get; set; }
        public string What { get; set; }
        public string Do { get; set; }
        public string Feeling { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Delete { get; set; }
    }
}
