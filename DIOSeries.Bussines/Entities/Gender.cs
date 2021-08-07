using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DIOSeries.Bussines {
    public class Gender : INotifyPropertyChanged, IGender {
        
        private string _name;
        private int _id;
        private int _deleted;

        public int Id { get => _id; set => _id = value; }
        public string Name {
            get => _name;
            set { 
                if(_name != value) {
                    _name = value;
                    RaisePropertyChanges();
                }
            }
        }
        public int Deleted {
            get => _deleted;
            set {
                if (_deleted != value) {
                    _deleted = value;
                    RaisePropertyChanges();
                }
            }
        }

        public Gender() {
            _deleted = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanges([CallerMemberName]string propName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
