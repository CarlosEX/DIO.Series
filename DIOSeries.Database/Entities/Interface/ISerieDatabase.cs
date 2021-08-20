using DIOSeries.Bussines;
using System.Collections.Generic;

namespace DIOSeries.Database.Entities {
    public interface ISerieDatabase {
        void Delete();
        IList<ISerie> GetAllListSerie(int idGender);
        void Insert();
        void Update();
        void UpdateViews();
    }
}