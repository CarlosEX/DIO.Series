using DIOSeries.Bussines;

namespace DIOSeries.Database.Entities.Factory {
    public class SerieDatabaseFactory {
        public static SerieDatabase Create(string connectionString, ISerie serie) {
            return new SerieDatabase(connectionString, serie);
        }
        public static SerieDatabase Create(string connectionString) {
            return new SerieDatabase(connectionString);
        }
    }
}
