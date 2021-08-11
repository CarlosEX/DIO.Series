using DIOSeries.Bussines;
using System.Data;
using System.Data.SQLite;

namespace DIOSeries.Database.Entities {
    public class SerieDatabase {
        
        private readonly string _connectionString;
        private readonly ISerie _serie;

        public SerieDatabase(string connectionString, ISerie serie) {
            _connectionString = connectionString;
            _serie = serie;
        }
        public SerieDatabase(string connectionString) {
            _connectionString = connectionString;
        }

        public DataTable GetSerieDataTable(string sql) {
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
                    command.CommandText = "INSERT INTO series(" +
                        "serie_title, " +
                        "serie_description, " +
                        "serie_year, " +
                        "serie_deleted, " +
                        "serie_image, " +
                        "serie_video, " +
                        "serie_views, " +
                        "gender_id ) " +
                            "VALUES (" +
                            "@serie_title, " +
                            "@serie_description," +
                            "@serie_year, " +
                            "@serie_deleted, " +
                            "@serie_image, " +
                            "@serie_video, " +
                            "@serie_views, " +
                            "@gender_id)";

                    command.Parameters.AddWithValue($"@serie_title", _serie.Title);
                    command.Parameters.AddWithValue($"@serie_description", _serie.Description);
                    command.Parameters.AddWithValue($"@serie_year", _serie.Year);
                    command.Parameters.AddWithValue($"@serie_deleted", _serie.Deleted);
                    command.Parameters.AddWithValue($"@serie_image", _serie.Image);
                    command.Parameters.AddWithValue($"@serie_video", _serie.Video);
                    command.Parameters.AddWithValue($"@serie_views", _serie.Views);
                    command.Parameters.AddWithValue($"@gender_id", _serie.Gender.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateViews() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE series SET " +
                        $"serie_views = {_serie.Views} " +
                        $"WHERE serie_id = {_serie.Id}";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE series SET " +
                        $"serie_title = {_serie.Title} " +
                        $"serie_description = {_serie.Description} " +
                        $"serie_year = {_serie.Year} " +
                        $"serie_deleted = {_serie.Deleted} " +
                        $"serie_image = {_serie.Image} " +
                        $"serie_views = {_serie.Views} " +
                        $"gender_id = {_serie.Gender.Id} " +
                        $"WHERE serie_id = {_serie.Id}";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE series SET serie_deleted = {_serie.Deleted} WHERE serie_id = {_serie.Id}";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
