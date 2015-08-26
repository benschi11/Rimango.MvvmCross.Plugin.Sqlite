using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Platform.WinRT;

namespace Rimango.MvvmCross.Plugin.Sqlite.UWP
{
    public class WindowsSqliteConnectionFactory : IMvxSqliteConnectionFactory
    {
        public SQLiteConnectionWithLock GetConnectionWithLock(SQLiteConnectionString connectionString)
        {
            return new SQLiteConnectionWithLock(new SQLitePlatformWinRT(), connectionString);
        }

        public SQLiteAsyncConnection GetAsyncConnection(SQLiteConnectionString connectionString)
        {
            return new SQLiteAsyncConnection(() => GetConnectionWithLock(connectionString));
        }

        public SQLiteConnection GetConnection(SQLiteConnectionString connectionString)
        {
            return new SQLiteConnection(new SQLitePlatformWinRT(), connectionString.DatabasePath, connectionString.StoreDateTimeAsTicks, connectionString.Serializer); 
        }
    }
}