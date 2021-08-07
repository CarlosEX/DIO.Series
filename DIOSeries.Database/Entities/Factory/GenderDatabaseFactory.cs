using DIOSeries.Bussines;

namespace DIOSeries.Database {
    public class GenderDatabaseFactory {
        public static GenderDatabase Create(string connectionString, IGender gender) {
            return new GenderDatabase(connectionString, gender);
        }
        public static GenderDatabase Create(string connectionString) {
            return new GenderDatabase(connectionString);
        }
    }
}
