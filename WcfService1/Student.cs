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
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Priimek { get; set; }
        [DataMember]
        public DateTime DatumRojstva { get; set; }
        [DataMember]
        public virtual ICollection<StudentImaPredmet> studentImaPredmete { get; set; }

        public Student()
        {
            studentImaPredmete = new HashSet<StudentImaPredmet>();
        }

        public Student(string ime, string priimek, DateTime datumRojstva)
        {
            Ime = ime;
            Priimek = priimek;
            DatumRojstva = datumRojstva;
        }


    }
}