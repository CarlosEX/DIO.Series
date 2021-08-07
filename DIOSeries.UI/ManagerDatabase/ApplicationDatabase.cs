using System.Configuration;

namespace DIOSeries.UI {
    public static class ApplicationDatabase{
        
        private readonly static string _connectionString = ConfigurationManager.ConnectionStrings["SQLiteDatabase"].ConnectionString;
        public static string ConnectionString { get => _connectionString; }
    }
}
