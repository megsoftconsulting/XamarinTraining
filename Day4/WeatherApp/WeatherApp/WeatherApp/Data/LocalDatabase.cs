using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class LocalDatabase
    {
        private readonly SQLiteAsyncConnection _databaseConnection;

        public LocalDatabase(string path)
        {
            _databaseConnection = new SQLiteAsyncConnection(path);
            _databaseConnection.CreateTableAsync<History>();
        }


        public async Task<List<T>> Lookup<T>() where T : new()
        {
            try
            {
                var result = await _databaseConnection.Table<T>().ToListAsync();
                return result;
            }
            catch (Exception)
            {
                return new List<T>();
            }
        }

        public void Insert<T>(T entry) where T : new()
        {
            _databaseConnection.InsertAsync(entry).Wait();
        }
    }
}