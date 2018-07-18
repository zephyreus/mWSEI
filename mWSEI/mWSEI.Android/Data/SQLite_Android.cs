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
using mWSEI.Data;
using System.IO;
using Xamarin.Forms;
using mWSEI.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]

namespace mWSEI.Droid.Data
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileNameDroid = "mWseiDB.db3";
            string documentsDirectoryDroid = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsDirectoryDroid, sqliteFileNameDroid);
            var connectAndroid = new SQLite.SQLiteConnection(path);

            return connectAndroid;
        }
    }
}