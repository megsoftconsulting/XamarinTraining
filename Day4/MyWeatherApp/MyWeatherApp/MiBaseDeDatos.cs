using System;
using System.Collections.Generic;
using MyWeatherApp.Entities;
using SQLite;
using System.Linq;

namespace MyWeatherApp
{
    public class MiBaseDeDatos
    {
        SQLiteAsyncConnection myDatabaseConnection;

        public MiBaseDeDatos(string path)
        {
            myDatabaseConnection = new SQLiteAsyncConnection(path);
          myDatabaseConnection.CreateTableAsync<MiHistoricoDeBusquedas>();

        }


        public List<T> BuscarTodos<T>() where T:new()
        {
            return myDatabaseConnection.Table<T>().ToListAsync().Result;
        }

        public void Insertar<T>(T entrada) where T : new()
        {
            myDatabaseConnection.InsertAsync(entrada).Wait();
        }
    }
}
