using System.ComponentModel;

namespace DIOSeries.Bussines {
    public interface ISerie {
        bool Deleted { get; set; }
        string Description { get; set; }
        IGender Gender { get; set; }
        int Id { get; }
        string Title { get; set; }
        int Year { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}