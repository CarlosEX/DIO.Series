using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOSeries.Database {
    public abstract class Base : IBase {
        public string ConnectionString => throw new NotImplementedException();

        public void Delete() {
            throw new NotImplementedException();
        }

        public void Insert() {
            throw new NotImplementedException();
        }

        public void Search() {
            throw new NotImplementedException();
        }

        public void Update() {
            throw new NotImplementedException();
        }
    }
}
