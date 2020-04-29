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
    public class UporabniskiRacun
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Geslo { get; set; }
        [DataMember]
        public bool Admin { get; set; }

        public UporabniskiRacun()
        {
        }

        public UporabniskiRacun(string ime, string geslo, bool admin)
        {
            Ime = ime;
            Geslo = geslo;
            Admin = admin;
        }


    }
}