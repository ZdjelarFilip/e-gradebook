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
    /// Interaction logic for VnosStudentaWindow.xaml
    /// </summary>
    public partial class VnosStudentaWindow : Window
    {
        SolaStoritev.IstoritevClient servis;
        GlavniWindow gw;
        public VnosStudentaWindow(GlavniWindow gw)
        {
            this.gw = gw;
            servis = new SolaStoritev.IstoritevClient();
            InitializeComponent();
        }

        public void dodaj_click(object sender, RoutedEventArgs e)
        {
            servis.dodajStudenta(TextBoxIme.Text,TextBoxPriimek.Text,DatePickerDatum.DisplayDate);
            gw.student_load();
            this.Close();
        }

        public void spremeni_click(object sender, RoutedEventArgs e)
        {
            var izbran = (WpfApp1.SolaStoritev.Student)gw.DataGridPodatki.SelectedItem;

            servis.spremeniStudenta(izbran.Id,TextBoxIme.Text, TextBoxPriimek.Text, DatePickerDatum.DisplayDate);

            gw.student_load();
            this.Close();
        }
    }
}
