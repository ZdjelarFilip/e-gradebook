using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class GlavniWindow : Window
    {

        SolaStoritev.IstoritevClient servis;

        Strani trenutnaStran;

        string[] tabelaStudent = {"ID","Ime", "Priimek", "Datum rojstva" };
        string[] tabelaPredmet = {"ID", "Naziv", "Kratica", "ECTS" };
        string[] tabelaRedovalnica = {"ID","Student_ID","Predmet_ID", "Kratica", "Ime", "Priimek", "Ocena" };

        string[] tabelaStudentBinding = { "Id","Ime", "Priimek", "DatumRojstva" };
        string[] tabelaPredmetBinding = { "Id","Naziv", "Kratica", "Ects" };
        string[] tabelaRedovalnicaBinding = {"Id","Student_Id", "Predmet_Id","Kratica","Ime","Priimek","Ocena" };

        public GlavniWindow()
        {
            servis = new SolaStoritev.IstoritevClient();
            InitializeComponent();
            DataGridPodatki.AutoGenerateColumns = false;
            student_load();
        }

        private void menu_click(object sender, RoutedEventArgs e)
        { 
        }


        private void dodaj_click(object sender, RoutedEventArgs e)
        {
            switch (trenutnaStran)
            {
                case Strani.Predmet:
                    PredmetWindow pw = new PredmetWindow(this);
                    pw.Tipka.Background = Brushes.Green;
                    pw.Tipka.Content = "Dodaj";
                    pw.Tipka.Click += new RoutedEventHandler(pw.dodaj_click);
                    pw.Show();
                    break;
                case Strani.Student:
                    VnosStudentaWindow vsw = new VnosStudentaWindow(this);
                    vsw.Tipka.Background = Brushes.Green;
                    vsw.Tipka.Content = "Dodaj";
                    vsw.Tipka.Click += new RoutedEventHandler(vsw.dodaj_click);
                    vsw.Show();
                    break;
                case Strani.Redovalnica:
                    PredmetStudentWindow psw = new PredmetStudentWindow(this);
                    psw.Tipka.Background = Brushes.Green;
                    psw.Tipka.Content = "Dodaj";
                    psw.Tipka.Click += new RoutedEventHandler(psw.dodaj_click);

                    psw.StudenComboBox.SelectedValuePath = "Key";
                    psw.StudenComboBox.DisplayMemberPath = "Value";

                    foreach (var student in servis.vrniVseStudente())
                    {
                        psw.StudenComboBox.Items.Add((new KeyValuePair<int, string>(student.Id, student.Ime+" "+student.Priimek)));
                    }

                    psw.PredmetComboBox.SelectedValuePath = "Key";
                    psw.PredmetComboBox.DisplayMemberPath = "Value";

                    foreach (var predmet in servis.vrniVsePredmete())
                    {
                        psw.PredmetComboBox.Items.Add((new KeyValuePair<string, string>(predmet.Kratica, predmet.Naziv)));
                    }

                    psw.Show();
                    break;
                default:
                    break;
            }
        }

        private void spremeni_click(object sender, RoutedEventArgs e)
        {
            switch (trenutnaStran)
            {
                case Strani.Predmet:

                    //izberemo trenutno vrstico in shranimo podatke iz nje
                    var izbranPredmet = (WpfApp1.SolaStoritev.Predmet)DataGridPodatki.SelectedItem;

                    //v primeru da je vrstica izbrana ustvarimo novo okno za spreminjanje izbrane vrstice
                    if (izbranPredmet != null) {
                        PredmetWindow pw = new PredmetWindow(this);
                        pw.Tipka.Background = Brushes.Orange;
                        pw.Tipka.Content = "Spremeni";
                        pw.Tipka.Click += new RoutedEventHandler(pw.spremeni_click);
                        pw.NazivTextBox.Text = izbranPredmet.Naziv;
                        pw.KraticaTextBox.Text = izbranPredmet.Kratica;
                        pw.EctsTextBox.Text = izbranPredmet.Ects.ToString();
                        pw.Show();
                    }
                    break;
                case Strani.Student:
                    var izbranStudent = (WpfApp1.SolaStoritev.Student)DataGridPodatki.SelectedItem;
                    if (izbranStudent != null)
                    {
                        VnosStudentaWindow vsw = new VnosStudentaWindow(this);
                        vsw.Tipka.Background = Brushes.Orange;
                        vsw.Tipka.Content = "Spremeni";
                        vsw.Tipka.Click += new RoutedEventHandler(vsw.spremeni_click);
                        vsw.TextBoxIme.Text = izbranStudent.Ime;
                        vsw.TextBoxPriimek.Text = izbranStudent.Priimek;
                        vsw.DatePickerDatum.SelectedDate = izbranStudent.DatumRojstva;
                        vsw.Show();
                    }

                    break;
                case Strani.Redovalnica:
                    var izbranaRedovalnica = (RedovalnicaPodatki)DataGridPodatki.SelectedItem;
                    if (izbranaRedovalnica != null)
                    {
                        PredmetStudentWindow psw = new PredmetStudentWindow(this);
                        psw.Tipka.Background = Brushes.Orange;
                        psw.Tipka.Content = "Spremeni";
                        psw.Tipka.Click += new RoutedEventHandler(psw.spremeni_click);
                        psw.StudenComboBox.IsEditable = false;
                        psw.PredmetComboBox.IsEditable = false;
                        psw.StudenComboBox.IsHitTestVisible = false;
                        psw.PredmetComboBox.IsHitTestVisible = false;
                        psw.StudenComboBox.Text=(izbranaRedovalnica.Ime + " " + izbranaRedovalnica.Priimek);
                        psw.PredmetComboBox.Text = (servis.vrniPredmet(izbranaRedovalnica.Kratica).Naziv);
                        psw.OcenaTextBox.Text = izbranaRedovalnica.Ocena.ToString();
                        psw.Show();
                    }
                    break;
                default:
                    break;
            }
        }

        private void odstrani_click(object sender, RoutedEventArgs e)
        {
            switch (trenutnaStran)
            {
                case Strani.Predmet:
                    var izbranPredmet = (WpfApp1.SolaStoritev.Predmet)DataGridPodatki.SelectedItem;
                    servis.izbrisiPredmet(izbranPredmet.Kratica);
                    predmet_load();
                    break;
                case Strani.Student:
                    var izbranStudent = (WpfApp1.SolaStoritev.Student)DataGridPodatki.SelectedItem;
                    servis.izbrisiStudenta(izbranStudent.Id);
                    student_load();
                    break;
                case Strani.Redovalnica:
                    var izbranaRedovalnica = (RedovalnicaPodatki)DataGridPodatki.SelectedItem;
                    var predmet = servis.vrniPredmetPoId(izbranaRedovalnica.Predmet_Id);
                    servis.odstraniStudentaIzPredmeta(izbranaRedovalnica.Student_Id, predmet.Kratica);
                    redovalnica_load();
                    break;
                default:
                    break;
            }
        }

        private void student_click(object sender, RoutedEventArgs e)
        {
            trenutnaStran = Strani.Student;
            student_load();
        }

        private void predmet_click(object sender, RoutedEventArgs e)
        {
            trenutnaStran = Strani.Predmet;
            predmet_load();
        }
        private void redovalnica_click(object sender, RoutedEventArgs e)
        {
            trenutnaStran = Strani.Redovalnica;
            redovalnica_load();
        }

        public void predmet_load()
        {
            DataGridPodatki.Columns.Clear();

            for (int i = 0; i < tabelaPredmet.Length; i++) {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = tabelaPredmet[i];
                textColumn.Binding = new Binding(tabelaPredmetBinding[i]);
                DataGridPodatki.Columns.Add(textColumn);
            }

            DataGridPodatki.Columns[0].Visibility = Visibility.Collapsed;

            DataGridPodatki.ItemsSource = servis.vrniVsePredmete();

        }

        public void student_load()
        {
            DataGridPodatki.Columns.Clear();

            for (int i = 0; i < tabelaStudent.Length; i++)
            {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = tabelaStudent[i];
                textColumn.Binding = new Binding(tabelaStudentBinding[i]);

                DataGridPodatki.Columns.Add(textColumn);
            }

            DataGridPodatki.Columns[0].Visibility = Visibility.Collapsed;

            DataGridPodatki.ItemsSource = servis.vrniVseStudente();

        }

        public void redovalnica_load()
        {

            List<RedovalnicaPodatki> podatkiRedovalnice = new List<RedovalnicaPodatki>();

            foreach (var zapis in servis.vrniVseStudentImaPredmete()) {
                var student = servis.vrniStudenta(zapis.Student_Id);
                var predmet = servis.vrniPredmetPoId(zapis.Predmet_Id);
                podatkiRedovalnice.Add(new RedovalnicaPodatki(zapis.Id, zapis.Student_Id, zapis.Predmet_Id, predmet.Kratica, student.Ime, student.Priimek, zapis.ocena));
            }

            DataGridPodatki.Columns.Clear();

            for (int i = 0; i < tabelaRedovalnica.Length; i++)
            {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = tabelaRedovalnica[i];
                textColumn.Binding = new Binding(tabelaRedovalnicaBinding[i]);

                DataGridPodatki.Columns.Add(textColumn);
            }

            //skrijemo stolpce z IDji
            DataGridPodatki.Columns[0].Visibility= Visibility.Collapsed;
            DataGridPodatki.Columns[1].Visibility = Visibility.Collapsed;
            DataGridPodatki.Columns[2].Visibility = Visibility.Collapsed;

            DataGridPodatki.ItemsSource = podatkiRedovalnice;

        }

    }

    class RedovalnicaPodatki {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public int Predmet_Id { get; set; }
        public string Kratica { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Ocena { get; set; }

        public RedovalnicaPodatki(int id, int student_Id, int predmet_Id, string kratica, string ime, string priimek, int ocena)
        {
            Id = id;
            Student_Id = student_Id;
            Predmet_Id = predmet_Id;
            Kratica = kratica;
            Ime = ime;
            Priimek = priimek;
            Ocena = ocena;
        }
    }

enum Strani { 
        Student,Predmet,Redovalnica
    }
}
