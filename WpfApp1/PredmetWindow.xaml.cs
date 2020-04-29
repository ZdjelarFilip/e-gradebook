using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PredmetWindow.xaml
    /// </summary>
    public partial class PredmetWindow : Window
    {
        SolaStoritev.IstoritevClient servis;
        GlavniWindow gw;
        public PredmetWindow(GlavniWindow gw)
        {
            this.gw = gw;
            servis = new SolaStoritev.IstoritevClient();
            InitializeComponent();
        }

        public void dodaj_click(object sender, RoutedEventArgs e)
        {
            //doda predmet in updata gui v glavnem oknu
            servis.dodajPredmet(NazivTextBox.Text, KraticaTextBox.Text, int.Parse(EctsTextBox.Text));
            gw.predmet_load();
            this.Close();
        }

        public void spremeni_click(object sender, RoutedEventArgs e)
        {
            var izbran = (WpfApp1.SolaStoritev.Predmet)gw.DataGridPodatki.SelectedItem;

            servis.spremeniPredmet(izbran.Kratica, NazivTextBox.Text, KraticaTextBox.Text, int.Parse(EctsTextBox.Text));

            gw.predmet_load();
            this.Close();
        }

    }
}
