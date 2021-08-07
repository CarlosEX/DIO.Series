using DIOSeries.Bussines;
using System.Data;
using System.Data.SQLite;

namespace DIOSeries.Database {
    public class GenderDatabase {
        
        private readonly string _connectionString;
        private readonly IGender _gender;
        
        public GenderDatabase(string connectionString, IGender gender) {
            _connectionString = connectionString;
            _gender = gender;
        }
        
        public GenderDatabase(string connectionString) {
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

        public void Insert() {

            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = "INSERT INTO genders(gender_name) values (@gender_name)";
                    command.Parameters.AddWithValue($"@gender_name", _gender.Name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE genders SET gender_deleted = {_gender.Deleted} WHERE gender_id = {_gender.Id}";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE genders SET gender_name = '{_gender.Name}' WHERE gender_id = {_gender.Id}";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
