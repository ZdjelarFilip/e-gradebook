using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SolaStoritev.IstoritevClient servis = new SolaStoritev.IstoritevClient();

                string ime = textBox1.Text;
                string geslo = textBox2.Text;

                //pridobimo podatke iz strežnike o prijavi
                int status = servis.login(ime, geslo);

            if (status == 0)
            {
                label4.Text = "Neuspešna prijava";
            }
            else {
                label4.Text = "Uspešna prijava";
                Meni m = new Meni();
                m.Show();
                this.Hide();
            }
        }
    }
}
