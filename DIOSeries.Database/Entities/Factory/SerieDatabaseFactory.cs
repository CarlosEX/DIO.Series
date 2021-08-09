using DIOSeries.Bussines;

namespace DIOSeries.Database.Entities.Factory {
    public class SerieDatabaseFactory {
        public static SerieDatabase Create(string connectionString, ISerie gender) {
            return new SerieDatabase(connectionString, gender);
        }
        public static SerieDatabase Create(string connectionString) {
            return new SerieDatabase(connectionString);
        }
    }
}
