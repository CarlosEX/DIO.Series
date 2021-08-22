using DIOSeries.Bussines;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace DIOSeries.Database.Entities {
    public class SerieDatabase : ISerieDatabase {

        private readonly string _connectionString;
        private readonly ISerie _serie;

        public SerieDatabase(string connectionString, ISerie serie) {
            _connectionString = connectionString;
            _serie = serie;
        }
        public SerieDatabase(string connectionString) {
            _connectionString = connectionString;
        }

        public IList<ISerie> GetAllListSerie(int idGender) {

            List<ISerie> series = new List<ISerie>();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ");
            sql.Append("serie_id, ");
            sql.Append("serie_title, ");
            sql.Append("serie_description, ");
            sql.Append("serie_year, ");
            sql.Append("serie_deleted, ");
            sql.Append("serie_image, ");
            sql.Append("serie_video, ");
            sql.Append("serie_views, ");
            sql.Append("genders.gender_id AS genderId, ");
            sql.Append("genders.gender_name AS genderName ");
            sql.Append("FROM series ");
            sql.Append("INNER JOIN genders ON genders.gender_id = series.gender_id ");
            sql.Append($"WHERE series.gender_id = {idGender} AND series.serie_deleted = 0");


            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = new SQLiteCommand(sql.ToString(), conn)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {


                            int serie_id = int.Parse(reader["serie_id"].ToString());
                            int serie_views = int.Parse(reader["serie_views"].ToString());
                            int gender_id = int.Parse(reader["genderId"].ToString());
                            string serie_title = reader["serie_title"].ToString();
                            string serie_description = reader["serie_description"].ToString();
                            string serie_year = reader["serie_year"].ToString();
                            string serie_image = reader["serie_image"].ToString();
                            string serie_video = reader["serie_video"].ToString();
                            string gender_name = reader["genderName"].ToString();
                            StateRegister serie_deleted = (StateRegister)int.Parse(reader["serie_deleted"].ToString());

                            series.Add(
                                new Serie(serie_title) {
                                    Id = serie_id,
                                    Description = serie_description,
                                    Year = serie_year,
                                    Deleted = serie_deleted,
                                    Image = serie_image,
                                    Video = serie_video,
                                    Views = serie_views,
                                    Gender = GenderFactory.Create(gender_id, gender_name)
                                });
                        }
                    }
                }

                conn.Close();
                conn.Dispose();
            }
            return series;
        }

        public void Insert() {

            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {

                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO series ");
                    sql.Append(" ( ");
                    sql.Append("serie_title, ");
                    sql.Append("serie_description, ");
                    sql.Append("serie_year, ");
                    sql.Append("serie_image, ");
                    sql.Append("serie_video, ");
                    sql.Append("serie_views, ");
                    sql.Append("gender_id ");
                    sql.Append(" ) ");
                    sql.Append(" VALUES ");
                    sql.Append(" ( ");
                    sql.Append("@serie_title, ");
                    sql.Append("@serie_description,");
                    sql.Append("@serie_year, ");
                    sql.Append("@serie_deleted, ");
                    sql.Append("@serie_image, ");
                    sql.Append("@serie_video, ");
                    sql.Append("@serie_views, ");
                    sql.Append("@gender_id)");


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
                    command.CommandText = $"UPDATE series SET serie_views = {_serie.Views} WHERE serie_id = {_serie.Id}";
                    command.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void Update() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {

                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE series SET ");
                    sql.Append($"serie_title = '{_serie.Title}', ");
                    sql.Append($"serie_description = '{_serie.Description}', ");
                    sql.Append($"serie_year = '{_serie.Year}', ");
                    sql.Append($"serie_image = '{_serie.Image}', ");
                    sql.Append($"serie_video = '{_serie.Video}', ");
                    sql.Append($"gender_id = {_serie.Gender.Id} ");
                    sql.Append($"WHERE serie_id = {_serie.Id}");

                    command.CommandText = sql.ToString();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete() {
            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = conn.CreateCommand()) {
                    command.CommandText = $"UPDATE series SET serie_deleted = {1} WHERE serie_id = {_serie.Id}";
                    command.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
