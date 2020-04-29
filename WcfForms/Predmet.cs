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
    public partial class Predmet : Form
    {
        SolaStoritev.IstoritevClient servis;

        public Predmet()
        {
            InitializeComponent();
            servis = new SolaStoritev.IstoritevClient();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Naziv";
            dataGridView1.Columns[2].Name = "Kratica";
            dataGridView1.Columns[3].Name = "ECTS";

            updateGridView();
        }

        public void updateGridView()
        {

            dataGridView1.Rows.Clear();

            foreach (var p in servis.vrniVsePredmete())
            {
                string[] niz = { p.Id.ToString(), p.Naziv,p.Kratica,p.Ects.ToString()};
                dataGridView1.Rows.Add(niz);
            }
        }

        private void ButtonDodaj_Click_1(object sender, EventArgs e)
        {
            servis.dodajPredmet(textBoxNaziv.Text, textBoxKratica.Text, int.Parse(textBoxEcts.Text));
            updateGridView();
        }

        private void ButtonSpremeni_Click_1(object sender, EventArgs e)
        {
            servis.spremeniPredmet(textBoxId.Text, textBoxKratica.Text, textBoxNaziv.Text, int.Parse(textBoxEcts.Text));
            updateGridView();
        }

        private void ButtonOdstrani_Click_1(object sender, EventArgs e)
        {
            servis.izbrisiPredmet(textBoxId.Text);
            updateGridView();
        }
    }
}
