using System.Data;
using System.Data.SQLite;

namespace DIOSeries.Database.Entities {
    public abstract class BaseDatabase {

        private readonly string _connectionString;

        public BaseDatabase(string connectionString) {
            _connectionString = connectionString;
        }

        public DataTable GetGenderDataTable(string sql) {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = new SQLiteCommand(sql, conn)) {
                    using (var adapter = new SQLiteDataAdapter(command)) {
                        using (var dataTable = new DataTable()) {
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
        }
        
    }
}
