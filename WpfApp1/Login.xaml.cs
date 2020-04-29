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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void prijava_click(object sender, RoutedEventArgs e) {

            SolaStoritev.IstoritevClient servis = new SolaStoritev.IstoritevClient();

            string ime = TextBoxUporabniskoIme.Text;
            string geslo = PasswordBoxGeslo.Password;

            //pridobimo podatke iz strežnike o prijavi
            int status = servis.login(ime, geslo);

            if (status == 0 || PogojBox.IsChecked==false)
            {
                MessageBox.Show("Neuspešna prijava!", "Prijava");
            }
            else
            {
                GlavniWindow gw = new GlavniWindow();
                gw.Show();
                this.Hide();
            }

            #region
            //Copyrighted : LIPFY; FERI 2020
            #endregion
        }
    }
}
