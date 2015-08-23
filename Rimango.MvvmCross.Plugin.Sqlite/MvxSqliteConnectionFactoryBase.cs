using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Async;

namespace Rimango.MvvmCross.Plugin.Sqlite
{
    public abstract class MvxSqliteConnectionFactoryBase : IMvxSqliteConnectionFactory
    {
        protected SQLiteConnectionString GetConnectionStringFromConfig(SqliteConfig config) 
            => new SQLiteConnectionString(GetDevicePath(config.Path), config.StoreDateTimeAsTicks);

        protected abstract string GetDevicePath(string filename);

        public abstract SQLiteConnectionWithLock GetConnectionWithLock(SqliteConfig config);

        public abstract SQLiteAsyncConnection GetAsyncConnection(SqliteConfig config);

        public abstract SQLiteConnection GetConnection(SqliteConfig config);
    }
}
