using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [ServiceContract]

    interface Istoritev
    {
        [OperationContract]
        int login(string ime, string geslo);
        [OperationContract]
        List<Student> vrniVseStudente();
        [OperationContract]
        List<Predmet> vrniVsePredmete();
        [OperationContract]
        Student vrniStudenta(int id);
        [OperationContract]
        Predmet vrniPredmet(string kratica);
        [OperationContract]
        Predmet vrniPredmetPoId(int id);
        [OperationContract]
        Predmet predmetKiImaNajvecStudentov();
        [OperationContract]
        Student najstarejsiStudent();
        [OperationContract]
        double povprecnaOcenaStudenta(int id);
        [OperationContract]
        bool dodajPredmet(string naziv, string kratica, int ects);
        [OperationContract]
        bool dodajStudenta(string ime, string priimek, DateTime datum);
        [OperationContract]
        bool izbrisiPredmet(string kratica);
        [OperationContract]
        bool izbrisiStudenta(int id);
        [OperationContract]
        bool spremeniPredmet(string kratica, string novaKratica, string naziv, int ects);
        [OperationContract]
        bool spremeniStudenta(int id, string ime, string priimek, DateTime dt);
        [OperationContract]
        bool dodajStudentuPredmet(int id, string kratica, int ocena);
        [OperationContract]
        bool odstraniStudentaIzPredmeta(int id, string kratica);
        [OperationContract]
        bool spremeniOcenoStudenta(int id, string kratica,int ocena);
        [OperationContract]
        List<StudentImaPredmet> vrniVseStudentImaPredmete();
    }
}
