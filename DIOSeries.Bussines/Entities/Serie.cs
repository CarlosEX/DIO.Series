using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DIOSeries.Bussines {
    public class Serie : INotifyPropertyChanged, ISerie {
        
        private int _id;
        private IGender _gender;
        private string _title;
        private string _description;
        private int _year;
        private bool _deleted;

        public int Id { get => _id; protected set => _id = value; }

        public IGender Gender {
            get => _gender;
            set {
                if (_gender != null) {
                    _gender = value;
                    RaisePropertyChanges();
                }
            }
        }

        public string Title {
            get => _title;
            set {
                if (_title != null) {
                    _title = value;
                    RaisePropertyChanges();
                }
            }
        }

        public string Description {
            get => _description;
            set {
                if (_description != null) {
                    _description = value;
                    RaisePropertyChanges();
                }
            }
        }

        public int Year {
            get => _year;
            set {
                _year = value;
                RaisePropertyChanges();
            }
        }

        public bool Deleted {
            get => _deleted;
            set {
                _deleted = value;
                RaisePropertyChanges();
            }
        }

        public Serie() {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanges([CallerMemberName] string propName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
