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
    public partial class Student : Form
    {
        SolaStoritev.IstoritevClient servis;

        public Student()
        {
            InitializeComponent();
            servis = new SolaStoritev.IstoritevClient();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Ime";
            dataGridView1.Columns[2].Name = "Priimek";
            dataGridView1.Columns[3].Name = "Datum rojstva";

            updateGridView();
        }

        public void updateGridView() {

            dataGridView1.Rows.Clear();

            foreach (var student in servis.vrniVseStudente())
            {
                string[] niz = { student.Id.ToString(), student.Ime, student.Priimek, student.DatumRojstva.ToString() };
                dataGridView1.Rows.Add(niz);
            }
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {

            servis.dodajStudenta(textBoxIme.Text, textBoxPriimek.Text, dateTimePickerDatum.Value);
            updateGridView();
        }

        private void ButtonSpremeni_Click(object sender, EventArgs e)
        {
            servis.spremeniStudenta(int.Parse(textBoxId.Text),textBoxIme.Text,textBoxPriimek.Text, dateTimePickerDatum.Value);
            updateGridView();
        }

        private void ButtonOdstrani_Click(object sender, EventArgs e)
        {
            servis.izbrisiStudenta(int.Parse(textBoxId.Text));
            updateGridView();
        }
    }
}
