using DIOSeries.Bussines;
using DIOSeries.UI.Controls;

namespace DIOSeries.UI.Factory {
    public class CardThumbSerieFactory {
        public static CardThumbSerie Create(ISerie serie) {
            return new CardThumbSerie(serie);
        }
    }
}
