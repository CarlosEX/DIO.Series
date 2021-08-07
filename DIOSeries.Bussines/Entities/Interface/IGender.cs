using System.ComponentModel;

namespace DIOSeries.Bussines {
    public interface IGender {
        int Id { get; set; }
        string Name { get; set; }
        int Deleted { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
