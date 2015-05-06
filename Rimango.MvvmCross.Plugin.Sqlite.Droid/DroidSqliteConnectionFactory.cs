using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Platform.XamarinAndroid;

namespace Rimango.MvvmCross.Plugin.Sqlite.Droid
{
    public class DroidSqliteConnectionFactory : IMvxSqliteConnectionFactory
    {
        public SQLiteConnectionWithLock GetConnectionWithLock(SQLiteConnectionString connectionString)
        {
            return new SQLiteConnectionWithLock(new SQLitePlatformAndroid(), connectionString);
        }

        public SQLiteAsyncConnection GetAsyncConnection(SQLiteConnectionString connectionString)
        {
            return new SQLiteAsyncConnection(() => GetConnectionWithLock(connectionString));
        }

        public SQLiteConnection GetConnection(SQLiteConnectionString connectionString)
        {
            return new SQLiteConnection(new SQLitePlatformAndroid(), connectionString.DatabasePath, connectionString.StoreDateTimeAsTicks, connectionString.Serializer);
        }
    }
}