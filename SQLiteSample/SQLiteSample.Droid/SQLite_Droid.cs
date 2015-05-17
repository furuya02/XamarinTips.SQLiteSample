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
            const string sqliteFilename = "TodoSQLite.db3"; //�f�[�^�x�[�X��
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);//Documents�t�H���_
            var path = Path.Combine(documentsPath, sqliteFilename);//DB�t�@�C���̃p�X
            var plat = new SQLitePlatformAndroid();
            return new SQLiteConnection(plat, path);
        }
    }
}
