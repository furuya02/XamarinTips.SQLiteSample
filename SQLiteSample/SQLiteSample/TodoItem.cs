using System;
using SQLite.Net.Attributes;

namespace SQLiteSample {
    public class TodoItem {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // <- ①
        public string Text { get; set; } // <- ②
        public DateTime CreatedAt { get; set; } // <- ③
        public bool Delete { get; set; } // <- ④
    }
}
