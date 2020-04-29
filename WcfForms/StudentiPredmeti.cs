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
    public partial class StudentiPredmeti : Form
    {

        SolaStoritev.IstoritevClient servis;
        public StudentiPredmeti()
        {
            InitializeComponent();

            servis = new SolaStoritev.IstoritevClient();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Ocena";
            dataGridView1.Columns[2].Name = "Predmet_ID";
            dataGridView1.Columns[3].Name = "Student_ID";

            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "Ime";
            dataGridView2.Columns[2].Name = "Priimek";
            dataGridView2.Columns[3].Name = "Datum rojstva";

            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "ID";
            dataGridView3.Columns[1].Name = "Naziv";
            dataGridView3.Columns[2].Name = "Kratica";
            dataGridView3.Columns[3].Name = "ECTS";

            updateGridView();
            updateGridViewPredmeti();
            updateGridViewStudenti();
        }

        public void updateGridView()
        {

            dataGridView1.Rows.Clear();

            foreach (var sip in servis.vrniVseStudentImaPredmete())
            {
                string[] niz = { sip.Id.ToString(), sip.ocena.ToString(), sip.Predmet_Id.ToString(), sip.Student_Id.ToString() };
                dataGridView1.Rows.Add(niz);
            }
        }

        public void updateGridViewPredmeti()
        {

            dataGridView3.Rows.Clear();

            foreach (var p in servis.vrniVsePredmete())
            {
                string[] niz = { p.Id.ToString(), p.Naziv, p.Kratica, p.Ects.ToString() };
                dataGridView3.Rows.Add(niz);
            }
        }

        public void updateGridViewStudenti()
        {

            dataGridView2.Rows.Clear();

            foreach (var student in servis.vrniVseStudente())
            {
                string[] niz = { student.Id.ToString(), student.Ime, student.Priimek, student.DatumRojstva.ToString() };
                dataGridView2.Rows.Add(niz);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            servis.dodajStudentuPredmet(int.Parse(textBoxIdStudenta.Text), textBoxKratica.Text, int.Parse(textBoxOcena.Text));
            updateGridView();
        }

        private void buttonOdstrani_Click(object sender, EventArgs e)
        {
            servis.odstraniStudentaIzPredmeta(int.Parse(textBoxIdStudenta.Text), textBoxKratica.Text);
            updateGridView();
        }
    }
}
