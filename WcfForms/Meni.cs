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
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Predmet predmetForm = new Predmet();
            predmetForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StudentiPredmeti spForm = new StudentiPredmeti();
            spForm.Show();
        }
    }
}
