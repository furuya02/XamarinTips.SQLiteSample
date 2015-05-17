using System;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using SQLiteSample.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))] // <- ‡@
namespace SQLiteSample.iOS {
    public class SQLite_iOS : ISQLite {
        public SQLiteConnection GetConnection() {
            const string sqliteFilename = "TodoSQLite.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // <- ‡A
            var libraryPath = Path.Combine(documentsPath, "..", "Library"); // <- ‡B
            var path = Path.Combine(libraryPath, sqliteFilename);// <- ‡C
            var plat = new SQLitePlatformIOS();
            return new SQLiteConnection(plat, path);
        }
    }
}
