using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;
using SQLite;

namespace Database.Data
{
    public class LocalDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public int LastInsertedId { get; set; }

        public LocalDatabase(string path)
        {
            _database = new SQLiteAsyncConnection(path);
            _database.CreateTableAsync<TodoItem>().Wait();
        }

        internal void Delete(object item)
        {
            _database.DeleteAsync(item).Wait();
        }

        public async Task<IList<TodoItem>> GetTodoItems()
        {
            var results = await _database.QueryAsync<TodoItem>("Select * from TodoItem");

            return results;
        }

        public void Insert(TodoItem item)
        {
            _database.InsertAsync(item).Wait();
        }

        internal void Update(TodoItem item)
        {
            _database.UpdateAsync(item).Wait();
        }
    }
}