﻿using SQLite.Net;
using SQLite.Net.Interop;

namespace Rimango.MvvmCross.Plugin.Sqlite
{
    public class SqLiteConfig
    {
        public SqLiteConfig(
            string databaseName, 
            bool storeDateTimeAsTicks = true,
            IBlobSerializer serializer = null,
            IContractResolver resolver = null,
            SQLiteOpenFlags? openFlags = null)
        {
            DatabaseName = databaseName;
            StoreDateTimeAsTicks = storeDateTimeAsTicks;

            BlobSerializer = serializer;
            //OpenFlags = openFlags ?? SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        }
        public string DatabaseName { get; set; }
        public bool StoreDateTimeAsTicks { get; set; }

        public IContractResolver ContractResolver { get; set; }
        public IBlobSerializer BlobSerializer { get; set; }
        //public SQLiteOpenFlags OpenFlags { get; set; }
    }
}
