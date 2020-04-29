using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Storitev1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Storitev1.svc or Storitev1.svc.cs at the Solution Explorer and start debugging.
    public class Storitev1 : Istoritev
    {

        public Storitev1()
        {

        }

        public bool dodajPredmet(string naziv,string kratica,int ects)
        {
            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    Predmet predmet = new Predmet(naziv, kratica, ects);
                    sdbc.predmeti.Add(predmet);
                    sdbc.SaveChanges();
                }

                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }

        }

        public bool dodajStudenta(string ime,string priimek,DateTime datum)
        {

            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    Student student = new Student(ime, priimek, datum);
                    sdbc.studenti.Add(student);
                    sdbc.SaveChanges();
                }
                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }
        }


        public bool dodajStudentuPredmet(int id,string kratica,int ocena)
        {

            try
            {
                StudentImaPredmet sip;

                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Student student = sdbc.studenti.Where(x => x.Id == id).First();
                    Predmet predmet = sdbc.predmeti.Where(x => x.Kratica == kratica).First();
                    sip = new StudentImaPredmet(student.Id,predmet.Id,student, predmet, ocena);
                    sdbc.studentiImajoPredmete.Add(sip);
                    sdbc.SaveChanges();
                }

                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }

        }

        public bool izbrisiPredmet(string kratica)
        {
            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    Predmet predmet = sdbc.predmeti.Where(x => x.Kratica == kratica).First();
                    sdbc.predmeti.Remove(predmet);
                    sdbc.SaveChanges();
                }

                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }
        }

        public bool izbrisiStudenta(int id)
        {

            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Student student = sdbc.studenti.Where(x => x.Id == id).First();
                    sdbc.studenti.Remove(student);
                    sdbc.SaveChanges();
                }

                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }
        }

        public int login(string ime, string geslo)
        {
            int status = 0;
            List<UporabniskiRacun> racuni=null;

            UporabniskiRacun ur=null;
           

            using (SolaDBContext sdbc = new SolaDBContext()) {
                 racuni = (from racun in sdbc.uporabniskiRacuni
                                       where racun.Ime == ime && racun.Geslo == geslo
                                       select racun).ToList();
            }

            if (racuni.Count > 0) {
                ur = racuni.First();
            }


            //če uporabniški račun obstaja vrne 1, če je račun admin vrne 2, v nasprotnem primeru če račun ni pravilen vrne 0
            if (ur != null) {
                status = 1;
                if (ur.Admin == true) status = 2;
            }

            return status;
        }

        public Student najstarejsiStudent()
        {
            Student st;
            using (SolaDBContext sdbc = new SolaDBContext()) {
                sdbc.Configuration.ProxyCreationEnabled = false;
                st = (from student in sdbc.studenti
                      where sdbc.studenti.Min(x => x.DatumRojstva) == student.DatumRojstva
                      select student).First();
            }
            return st;
        }

        public bool odstraniStudentaIzPredmeta(int id,string kratica)
        {
            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Student student = sdbc.studenti.Where(x => x.Id == id).First();
                    Predmet predmet = sdbc.predmeti.Where(x => x.Kratica == kratica).First();
                    StudentImaPredmet sip = sdbc.studentiImajoPredmete.Where(x => x.Student.Id == student.Id && x.Predmet.Id == predmet.Id).First();
                    sdbc.studentiImajoPredmete.Remove(sip);
                    sdbc.SaveChanges();
                }
                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }
        }

        public double povprecnaOcenaStudenta(int id)
        {

            double rez;
            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                Student student = sdbc.studenti.Where(x => x.Id == id).First();
                rez = (from sip in sdbc.studentiImajoPredmete
                       where sip.Student.Id == student.Id
                       select sip.ocena).Average();
            }

            return rez;
        }

        public Predmet predmetKiImaNajvecStudentov()
        {
            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                var predmeti = sdbc.studentiImajoPredmete.GroupBy(x => x.Predmet)
                                                 .OrderByDescending(gp => gp.Count())
                                                 .Select(g => g.Key).ToList();
                return predmeti.First();
            }
        }

        public bool spremeniPredmet(string kratica,string novaKratica,string naziv,int ects)
        {
            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Predmet predmet = sdbc.predmeti.Where(x => x.Kratica == kratica).First();
                    if (novaKratica != "") predmet.Kratica = novaKratica;
                    if (naziv != "") predmet.Naziv = naziv;
                    if (ects != 0) predmet.Ects = ects;
                    sdbc.SaveChanges();
                }
                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }


        }

        public bool spremeniStudenta(int id,string ime,string priimek,DateTime dt)
        {
            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Student student = sdbc.studenti.Where(x => x.Id == id).First();
                    if (ime != "") student.Ime = ime;
                    if (priimek != "") student.Priimek = priimek;
                    if (dt.Year != 9999) student.DatumRojstva = dt;
                    sdbc.SaveChanges();
                }
                return true;
            }
            catch (EntityException ex)
            {
                return false;
            }

        }

        public Predmet vrniPredmet(string kratica)
        {
            Predmet predmet;
            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                return (from predmeti in sdbc.predmeti
                           where predmeti.Kratica == kratica
                           select predmeti).ToList().First();
            }
            //return predmet;
        }

        public Predmet vrniPredmetPoId(int id)
        {
            Predmet predmet;
            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                return (from predmeti in sdbc.predmeti
                        where predmeti.Id == id
                        select predmeti).ToList().First();
            }
            //return predmet;
        }

        public Student vrniStudenta(int id)
        {
            Student student;
            using (SolaDBContext sdbc = new SolaDBContext()) {
                sdbc.Configuration.ProxyCreationEnabled = false;
                student = (from st in sdbc.studenti
                           where st.Id == id
                           select st).First();
            }

            return student;
        }

        public List<Predmet> vrniVsePredmete()
        {
            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                return sdbc.predmeti.ToList();
            }
        }

        public List<Student> vrniVseStudente()
        {

            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                return sdbc.studenti.ToList();
            }
        }
        public List<StudentImaPredmet> vrniVseStudentImaPredmete()
        {

            using (SolaDBContext sdbc = new SolaDBContext())
            {
                sdbc.Configuration.ProxyCreationEnabled = false;
                return sdbc.studentiImajoPredmete.ToList();
            }
        }


        public bool spremeniOcenoStudenta(int id, string kratica, int ocena)
        {

            try
            {
                using (SolaDBContext sdbc = new SolaDBContext())
                {
                    sdbc.Configuration.ProxyCreationEnabled = false;
                    Student student = sdbc.studenti.Where(x => x.Id == id).First();
                    Predmet predmet = sdbc.predmeti.Where(x => x.Kratica == kratica).First();
                    sdbc.studentiImajoPredmete.Where(x => x.Student_Id == student.Id && x.Predmet_Id == predmet.Id).First().ocena = ocena;
                    sdbc.SaveChanges();

                    return true;
                }
            }
            catch (EntityException ex)
            {
                return false;
            }


        }
    }
}
