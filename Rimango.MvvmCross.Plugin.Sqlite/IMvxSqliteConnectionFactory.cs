using SQLite.Net;
using SQLite.Net.Async;

namespace Rimango.MvvmCross.Plugin.Sqlite
{
    public interface IMvxSqliteConnectionFactory
    {
        SQLiteConnectionWithLock GetConnectionWithLock(SQLiteConnectionString connectionString);
        SQLiteAsyncConnection GetAsyncConnection(SQLiteConnectionString connectionString);
        SQLiteConnection GetConnection(SQLiteConnectionString connectionString);
    }
}
