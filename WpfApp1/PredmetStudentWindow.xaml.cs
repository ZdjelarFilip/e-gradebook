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
    /// Interaction logic for PredmetStudentWindow.xaml
    /// </summary>
    public partial class PredmetStudentWindow : Window
    {
        SolaStoritev.IstoritevClient servis;
        GlavniWindow gw;
        public PredmetStudentWindow(GlavniWindow gw)
        {
            servis = new SolaStoritev.IstoritevClient();
            this.gw = gw;
            InitializeComponent();
        }

        public void dodaj_click(object sender, RoutedEventArgs e)
        {
            var studentId=Convert.ToInt32(StudenComboBox.SelectedValue);
            var predmetKratica = PredmetComboBox.SelectedValue.ToString();

            servis.dodajStudentuPredmet(studentId,predmetKratica, int.Parse(OcenaTextBox.Text));
            gw.redovalnica_load();
            this.Close();
        }

        public void spremeni_click(object sender, RoutedEventArgs e)
        {
            var podatkiRedovalnice = (RedovalnicaPodatki)gw.DataGridPodatki.SelectedItem;

            servis.spremeniOcenoStudenta(podatkiRedovalnice.Student_Id,podatkiRedovalnice.Kratica,int.Parse(OcenaTextBox.Text));
            gw.redovalnica_load();
            this.Close();
        }
    }
}
