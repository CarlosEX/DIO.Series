
namespace DIOSeries.Bussines {
    public class SerieFactoy {
        public static ISerie Create(string title, IGender gender) {
            return new Serie(title, gender);
        }
        public static ISerie Create(string title) {
            return new Serie(title);
        }
    }
}
