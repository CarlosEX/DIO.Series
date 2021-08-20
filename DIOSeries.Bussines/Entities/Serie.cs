using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DIOSeries.Bussines {
    public class Serie : INotifyPropertyChanged, ISerie {
        
        private int _id;
        private string _title;
        private string _description;
        private string _year;
        private string _image;
        private string _video;
        private int _views;
        private IGender _gender;
        private StateRegister _deleted;

        public int Id { 
            get => _id;
            set {
                _id = value;
                RaisePropertyChanges();
            }
        }
        
        public string Title {
            get => _title;
            set {
                _title = value;
            }
        }

        public string Description {
            get => _description;
            set {
                _description = value;
                RaisePropertyChanges();

            }
        }

        public string Year {
            get => _year;
            set {
                _year = value;
                RaisePropertyChanges();
            }
        }

        public string Image {
            get => _image;
            set {
                _image = value;
                RaisePropertyChanges();
            }
        }

        public string Video {
            get => _video;
            set {
                _video = value;
                RaisePropertyChanges();
            }
        }

        public int Views {
            get => _views;
            set {
                _views = value;
                RaisePropertyChanges();
            }
        }

        public IGender Gender {
            get => _gender;
            set {
                _gender = value;
                RaisePropertyChanges();
            }
        }

        public StateRegister Deleted {
            get => _deleted;
            set {
                _deleted = value;
                RaisePropertyChanges();
            }
        }
        public Serie(string title) {
            _title = title;
            _deleted = 0;
        }

        public Serie(string title, IGender gender ) {
            _title = title;
            _gender = gender;
            _deleted = 0;
        }

        public void IncrementViews() {
            _views += 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanges([CallerMemberName] string propName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
