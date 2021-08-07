
namespace DIOSeries.Bussines{
    public static class GenderFactory {
        public static IGender Create() {
            return new Gender();
        }
    }
}
