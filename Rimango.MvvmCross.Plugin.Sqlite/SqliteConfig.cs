using SQLite.Net.Interop;

namespace Rimango.MvvmCross.Plugin.Sqlite
{
    public class SqLiteConfig
    {
        public string PathToDataBase { get; set; }

        public ISQLitePlatform Plattform { get; set; }
    }
}
