
namespace DIOSeries.Bussines{
    public static class GenderFactory {
        public static IGender Create() {
            return new Gender();
        }
        public static IGender Create(int id, string name) {
            return new Gender(id, name);
        }
    }
}
