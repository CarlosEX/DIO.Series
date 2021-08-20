using DIOSeries.Bussines;
using System.Collections.Generic;
using System.Data;

namespace DIOSeries.Database {
    public interface IGenderDatabase {
        void Delete();
        IList<IGender> GetAllListGenders(FlagGender flagGender);
        DataTable GetGenderDataTable(string sql);
        void Insert();
        void Update();
    }
}