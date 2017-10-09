using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SQLite.Net;


namespace App2
{
    public class TodoRepository
    {
        static readonly object Locker = new object();
        readonly SQLiteConnection _db;

        public TodoRepository()
        {
            _db = DependencyService.Get<ISQLite>().GetConnection();
            _db.CreateTable<TodoItem>();

        }

        public IEnumerable<TodoItem> GetItems()
        { // <-5
            lock (Locker)
            { // <-6
              // Delete==falseの一覧を取得する（削除フラグが立っているものは対象外）
                return _db.Table<TodoItem>().Where(m => m.Delete == false); // <-7
            }
        }

        public IEnumerable<TodoItem> GetItemById(int Did)
        { // <-5
            lock (Locker)
            { // <-6
                return _db.Table<TodoItem>().Where(m => m.Id == Did); // <-7
            }
        }

        public int SaveItem(TodoItem item)
        { // <-8
            lock (Locker)
            { // <-9
                if (item.Id != 0)
                { // Idが0でない場合は、更新
                    _db.Update(item); // <-10
                    return item.Id;
                }
                return _db.Insert(item); // <-11
            }
        }

        public void Commit()
        {
            _db.Commit();
        }


    }
}
