using DIOSeries.Bussines;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DIOSeries.Database {
    public class GenderDatabase : IGenderDatabase {

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

        private string ParametersFilterColumnDeleted(FlagGender flagGender) {

            string filterAllGender = "(0,1)";
            string filterActivateGender = "(0)";
            string filterDeletedeGender = "(1)";

            string result = "";


            switch (flagGender) {
                case FlagGender.Active:
                    result = filterActivateGender;
                    break;
                case FlagGender.All:
                    result = filterAllGender;
                    break;
                case FlagGender.Deleted:
                    result = filterDeletedeGender;
                    break;
            }

            return result;
        }

        public IList<IGender> GetAllListGenders(FlagGender flagGender) {


            string resultFlag = ParametersFilterColumnDeleted(flagGender);


            IList<IGender> genders = new List<IGender>();

            using (var conn = new SQLiteConnection(_connectionString)) {
                conn.Open();
                using (var command = new SQLiteCommand($"SELECT * FROM genders WHERE gender_deleted IN {resultFlag}", conn)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {

                            int gendeId = int.Parse(reader["gender_id"].ToString());
                            int genderDeleted = int.Parse(reader["gender_deleted"].ToString());
                            string genderName = reader["gender_name"].ToString();

                            IGender gender = GenderFactory.Create();
                            gender.Id = gendeId;
                            gender.Deleted = genderDeleted;
                            gender.Name = genderName;

                            genders.Add(gender);
                        }
                    }
                }
            }
            return genders;
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
