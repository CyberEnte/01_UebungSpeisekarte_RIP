using _01_UebungSpeisekarte.Model;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01_UebungSpeisekarte
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _mvmodel;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this._mvmodel = FindResource("mvmodel") as MainViewModel;
        }
        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            DateTime datum = dpAnlegen.DisplayDate;
            String gericht = tbGericht.Text;
            double preis = Convert.ToDouble(tbPreis.Text);

            Gericht g = new Gericht(datum, gericht, preis);

            _mvmodel.LstGericht.Add(g);
            _mvmodel.LstGerichtNachDatum.Add(g);
        }

        private void btnAnz_Click(object sender, RoutedEventArgs e)
        {
            _mvmodel.LstGerichtNachDatum.Clear();
            foreach (Gericht g in _mvmodel.LstGericht)
            {
                if(g.Datum == dpSort.SelectedDate)
                    _mvmodel.LstGerichtNachDatum.Add(g);
            }

            datagrid.ItemsSource = _mvmodel.LstGerichtNachDatum;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = _mvmodel.LstGericht;
        }

        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            _mvmodel.LstGerichtNachDatum.Remove(_mvmodel.SelGericht);
            _mvmodel.LstGericht.Remove(_mvmodel.SelGericht);
        }

        private void tbPreis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}