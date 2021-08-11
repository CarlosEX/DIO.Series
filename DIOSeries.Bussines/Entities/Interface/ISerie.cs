using System.ComponentModel;

namespace DIOSeries.Bussines {
    public interface ISerie {
        int Id { get; }
        string Title { get; set; }
        string Description { get; set; }
        string Year { get; set; }
        string Image { get; set; }
        string Video { get; set; }
        int Views { get; set; }
        IGender Gender { get; set; }
        StateRegister Deleted { get; set; }
        

        event PropertyChangedEventHandler PropertyChanged;
    }
}