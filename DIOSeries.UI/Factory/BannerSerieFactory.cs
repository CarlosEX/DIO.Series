using DIOSeries.Bussines;
using DIOSeries.UI.Controls;
using System.Collections.Generic;

namespace DIOSeries.UI.Factory {
    public class BannerSerieFactory {
        public static BannerSeries Create(string titleBanner, IList<ISerie> listSeries) {
            return new BannerSeries(titleBanner, listSeries);
        }
    }
}
