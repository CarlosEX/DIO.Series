using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOSeries.Database {
    public interface IBase {
        string ConnectionString { get; }
        void Insert();
        void Delete();
        void Update();
        void Search();
    }
}
