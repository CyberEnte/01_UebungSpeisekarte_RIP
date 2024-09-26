using _01_UebungSpeisekarte.Model;
using System.Collections.ObjectModel;

namespace _01_UebungSpeisekarte
{
    public class MainViewModel : BaseModel
    {
        // Klasse zur Kapselung von Logik und Daten,
        // da laut dem MVVM Pattern diese Elemente in der UI nicht erlaubt sind -> (fast) leeres CodeBehind


        private ObservableCollection<Gericht> _LstGericht;
        public ObservableCollection<Gericht> LstGericht
        {
            get { return _LstGericht; }
            set
            {
                _LstGericht = value;
                OnPropertyChanged("LstGericht");
            }
        }
        
        private ObservableCollection<Gericht> _LstGerichtNachDatum;
        public ObservableCollection<Gericht> LstGerichtNachDatum
        {
            get { return _LstGerichtNachDatum; }
            set
            {
                _LstGerichtNachDatum = value;
                OnPropertyChanged("LstGerichtNachDatum");
            }
        }

        private Gericht _SelGericht;
        public Gericht SelGericht
        {
            get { return _SelGericht; }
            set
            {
                _SelGericht = value;
                OnPropertyChanged("SelGericht");
            }
        }

        public MainViewModel()
        {
            this.LstGericht = new ObservableCollection<Gericht>(Gericht.AlleLesen());
            this.LstGerichtNachDatum = new ObservableCollection<Gericht>(Gericht.AlleLesen());
        }
    }
}
