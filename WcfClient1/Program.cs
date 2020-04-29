using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            int privilegij=0;

            SolaServis.IstoritevClient servis = new SolaServis.IstoritevClient();

            do
            {
                string ime;
                string geslo;
                Console.WriteLine("Vnesite uporabniško ime");
                ime=Console.ReadLine();
                Console.WriteLine("Vnesite uporabniško geslo");
                geslo = Console.ReadLine();

                //pridobimo podatke iz strežnike o prijavi
                int status = servis.login(ime, geslo);
                privilegij = status;

                if (privilegij == 0) {
                    Console.WriteLine("Napačni podatki poizkusite ponovno");
                }

                //if()
            } while (privilegij < 1);

            int izbranServis;

            Console.WriteLine("Uspešna prijava");
            do
            {
                Console.WriteLine("Izberite metodo");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1.- vrniVseStudente()");
                Console.WriteLine("2.- vrniVsePredmete();");
                Console.WriteLine("3.- vrniStudenta(int id)");
                Console.WriteLine("4.- predmetKiImaNajvecStudentov()");
                Console.WriteLine("5.- najstarejsiStudent()");
                Console.WriteLine("6.- povprecnaOcenaStudenta(int id)");
                Console.WriteLine("7.- dodajPredmet(string naziv, string kratica, int ects");
                Console.WriteLine("8.- dodajStudenta(string ime, string priimek, DateTime datum)");
                Console.WriteLine("9.- izbrisiPredmet(string kratica)");
                Console.WriteLine("10.- izbrisiStudenta(int id)");
                Console.WriteLine("11.- spremeniPredmet(string kratica, string novaKratica, string naziv, int ects)");
                Console.WriteLine("12.- spremeniStudenta(int id, string ime, string priimek, DateTime dt)");
                Console.WriteLine("13.- dodajStudentuPredmet(int id, string kratica, int ocena)");
                Console.WriteLine("14.- odstraniStudentaIzPredmeta(int id, string kratica)");

                izbranServis = int.Parse(Console.ReadLine());

                switch (izbranServis)
                {
                    case 1:
                        if (privilegij == 2)
                        {
                            vrniVseStudente(ref servis);
                        }
                        else {
                            Console.WriteLine("Nimate potrebnega privilegija");
                        }
                        break;
                    case 2:
                        if (privilegij == 2)
                        {
                            vrniVsePredmete(servis);
                        }
                        else
                        {
                            Console.WriteLine("Nimate potrebnega privilegija");
                        }
                        break;
                    case 3:
                        vrniStudenta(servis);
                        break;
                    case 4:
                        predmetKiImaNajvecStudentov(servis);
                        break;
                    case 5:
                        najstarejsiStudent(servis);
                        break;
                    case 6:
                        povprecnaOcenaStudenta(servis);
                        break;
                    case 7:
                        dodajPredmet(servis);
                        break;
                    case 8:
                        dodajStudenta(servis);
                        break;
                    case 9:
                        izbrisiPredmet(servis);
                        break;
                    case 10:
                        izbrisiStudenta(servis);
                        break;
                    case 11:
                        spremeniPredmet(servis);
                        break;
                    case 12:
                        spremeniStudenta(servis);
                        break;
                    case 13:
                        dodajStudentuPredmet(servis);
                        break;
                    case 14:
                        odstraniStudentaIzPredmeta(servis);
                        break;

                    default:
                        Console.WriteLine("Izbran servis ne obstaja");
                        break;
                }
            } while (true);
            Console.ReadLine();
        }

        public static void vrniVseStudente(ref SolaServis.IstoritevClient servis) {

            Console.WriteLine("Izpis vseh studentov");

            foreach (var student in servis.vrniVseStudente()) {      
                Console.WriteLine(student.Ime + " " + student.Priimek);
            }
        }
        public static void vrniVsePredmete(SolaServis.IstoritevClient servis) {

            Console.WriteLine("Izpis vseh predmetov");

            foreach (var predmet in servis.vrniVsePredmete())
            {
                Console.WriteLine(predmet.Naziv);
            }
        }
        public static void vrniStudenta(SolaServis.IstoritevClient servis) {
            int id;
            Console.WriteLine("Vpisite ID studenta");
            id=int.Parse(Console.ReadLine());
            var student = servis.vrniStudenta(id);
            Console.WriteLine(student.Ime + " " + student.Priimek);
        }
        public static void predmetKiImaNajvecStudentov(SolaServis.IstoritevClient servis) {
            var predmet = servis.predmetKiImaNajvecStudentov();
            Console.WriteLine(predmet.Naziv);

        }
        public static void najstarejsiStudent(SolaServis.IstoritevClient servis) {
            var student = servis.najstarejsiStudent();
            Console.WriteLine(student.Ime + " " + student.Priimek);
        }
        public static void povprecnaOcenaStudenta(SolaServis.IstoritevClient servis) {
            int id;
            Console.WriteLine("Vpisite ID studenta");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine(servis.povprecnaOcenaStudenta(id));
        }

        public static void dodajPredmet(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi naziv:");
            string naziv = Console.ReadLine();
            Console.WriteLine("Vnesi kratico:");
            string kratica = Console.ReadLine();
            Console.WriteLine("Vnesi ects:");
            int ects = int.Parse(Console.ReadLine());

            if (servis.dodajPredmet(naziv, kratica, ects))
            {
                Console.WriteLine("Vnos je bil uspešen");
            }
            else
            {
                Console.WriteLine("Vnos ni bil uspešen");
            }
        }
        public static void dodajStudenta(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi priimek:");
            string priimek = Console.ReadLine();
            Console.WriteLine("Vnesi datum:");
            string datumStringa = Console.ReadLine();
            string[] datuma = datumStringa.Split('-');

            if (servis.dodajStudenta(ime, priimek, new DateTime(int.Parse(datuma[0]), int.Parse(datuma[1]), int.Parse(datuma[2]))))
            {
                Console.WriteLine("Vnos je bil uspešen");
            }
            else
            {
                Console.WriteLine("Vnos ni bil uspešen");
            }
        }
        public static void izbrisiPredmet(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi kratico predmeta:");
            string kratica = Console.ReadLine();
            
            if (servis.izbrisiPredmet(kratica))
            {
                Console.WriteLine("Odstranjevanje je bilo uspešno");
            }
            else
            {
                Console.WriteLine("Odstranjevanje ni bilo uspešno");
            }
        }
        public static void izbrisiStudenta(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi id studenta:");
            int ids = int.Parse(Console.ReadLine());

            if (servis.izbrisiStudenta(ids))
            {
                Console.WriteLine("Odstranjevanje je bilo uspešno");
            }
            else
            {
                Console.WriteLine("Odstranjevanje ni bilo uspešno");
            }
        }
        public static void spremeniPredmet(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi kratico:");
            string kratica = Console.ReadLine();
            Console.WriteLine("Vnesi novo kratico:");
            string novaKratica = Console.ReadLine();
            Console.WriteLine("Vnesi naziv:");
            string nazivv = Console.ReadLine();
            Console.WriteLine("Vnesi ects:");
            int ectss = int.Parse(Console.ReadLine());
            

            if (servis.spremeniPredmet(kratica, novaKratica, nazivv, ectss))
            {
                Console.WriteLine("Sprememba je bila uspešna");
            }
            else
            {
                Console.WriteLine("Sprememba ni bila uspešna");
            }
        }
        public static void spremeniStudenta(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi id:");
            int idd = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi ime");
            string imee = Console.ReadLine();
            Console.WriteLine("Vnesi priimek:");
            string priimekk = Console.ReadLine();
            Console.WriteLine("Vnesi datum(leto-mesec-dan):");
            string datumString = Console.ReadLine();
            string[] datum = datumString.Split('-');
            DateTime sestavljenDatum;
            if (datum.ToList().Count < 3) {
                sestavljenDatum = new DateTime(9999,9,9);
            }
            else {
                sestavljenDatum = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2]));
            }


            if (servis.spremeniStudenta(idd, imee, priimekk, sestavljenDatum))
            {
                Console.WriteLine("Sprememba je bila uspešna");
            }
            else
            {
                Console.WriteLine("Sprememba ni bila uspešna");
            }
        }
        public static void dodajStudentuPredmet(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi kratico");
            string kratica = Console.ReadLine();
            Console.WriteLine("Vnesi naziv:");
            int ocena = int.Parse(Console.ReadLine());

            if (servis.dodajStudentuPredmet(id, kratica, ocena))
            {
                Console.WriteLine("Vnos je bil uspešen");
            }
            else
            {
                Console.WriteLine("Vnos ni bil uspešen");
            }
        }
        public static void odstraniStudentaIzPredmeta(SolaServis.IstoritevClient servis) {
            Console.WriteLine("Vnesi id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi kratico");
            string kratica = Console.ReadLine();

            if (servis.odstraniStudentaIzPredmeta(id, kratica))
            {
                Console.WriteLine("Odstranjevanje je bilo uspešno");
            }
            else
            {
                Console.WriteLine("Odstranjevanje ni bilo uspešno");
            }
        }
    }
}
