using DIOSeries.Bussines;

namespace DIOSeries.Database {
    public class GenderDatabaseFactory {
        public static IGenderDatabase Create(string connectionString, IGender gender) {
            return new GenderDatabase(connectionString, gender);
        }
        public static IGenderDatabase Create(string connectionString) {
            return new GenderDatabase(connectionString);
        }
    }
}
