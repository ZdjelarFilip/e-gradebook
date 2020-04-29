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
    public class Predmet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public string Kratica{get; set;}
        [DataMember]
        public int Ects { get; set; }
        [DataMember]
        public virtual ICollection<StudentImaPredmet> studentiImajoPredmet { get; set; }

        public Predmet()
        {
            studentiImajoPredmet = new HashSet<StudentImaPredmet>();
        }

        public Predmet(string naziv, string kratica, int ects)
        {
            Naziv = naziv;
            Kratica = kratica;
            Ects = ects;
        }

    }
}