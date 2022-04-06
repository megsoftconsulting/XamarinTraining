using System.Collections.ObjectModel;
using System.ComponentModel;
using ListViewSample.Models;

namespace ListViewSample.ViewModels
{
    public class MusicsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Musics> Musics { get; set; }

        public MusicsViewModel()
        {
            Musics = new ObservableCollection<Musics>
            {
                new Musics
                {
                    Picture = "Music",
                    Name = "Las Abejas",
                    Description = "A song of Juan Luis Guerra"
                },
                new Musics
                {
                    Picture = "Music",
                    Name = "Bachata Rosa",
                    Description = "A song of Juan Luis Guerra"
                },
                new Musics
                {
                    Picture = "Music",
                    Name = "Un hombre normal",
                    Description = "A song ofRicardo Montaner"
                },
                new Musics
                {
                    Picture = "Music",
                    Name = "La bilirubina Rosa",
                    Description = "A song of Juan Luis Guerra"
                },
                new Musics
                {
                    Picture = "Music",
                    Name = "Minutos",
                    Description = "A song of Ricardo Arjona"
                },
                new Musics
                {
                    Picture = "Music",
                    Name = "La cima del cielo",
                    Description = "A song of Ricardo Montaner"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}