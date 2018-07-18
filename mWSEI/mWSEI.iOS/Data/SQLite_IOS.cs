using mWSEI.Data;
using mWSEI.iOS.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace mWSEI.iOS.Data
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileNameIOS = "mWseiDB.db3";
            var documentsDirectoryIOS = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libPathIOS = Path.Combine(documentsDirectoryIOS, "..", "Library");
            var path = Path.Combine(libPathIOS, sqliteFileNameIOS);
            var connectIOS = new SQLite.SQLiteConnection(path);

            return connectIOS;
        }
    }
}
