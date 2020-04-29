using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class StudentImaPredmet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        public int Student_Id { get; set; }
        [DataMember]
        public int Predmet_Id { get; set; }
        [DataMember]
        public virtual Student Student { get; set; }
        [DataMember]
        public virtual Predmet Predmet { get; set; }
        [DataMember]
        public int ocena { get; set; }

        public StudentImaPredmet()
        {
        }

        public StudentImaPredmet(int studentId, int predmetId, Student student, Predmet predmet, int ocena)
        {
            Student_Id = studentId;
            Predmet_Id = predmetId;
            Student = student;
            Predmet = predmet;
            this.ocena = ocena;
        }
    }
}