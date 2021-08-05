using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DIO.Series.Model {
    public class Gender : INotifyPropertyChanged {
        
        private string _name;

        public string Name {
            get => _name;
            set { 
                if(_name != value) {
                    _name = value;
                    RaisePropertyChanges();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanges([CallerMemberName]string propName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
