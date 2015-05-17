using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using SQLiteSample.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace SQLiteSample.Droid {
    public class SQLite_Android : ISQLite {
        public SQLiteConnection GetConnection() {
            const string sqliteFilename = "TodoSQLite.db3"; //データベース名
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);//Documentsフォルダ
            var path = Path.Combine(documentsPath, sqliteFilename);//DBファイルのパス
            var plat = new SQLitePlatformAndroid();
            return new SQLiteConnection(plat, path);
        }
    }
}
