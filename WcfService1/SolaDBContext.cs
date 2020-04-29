using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class SolaDBContext:DbContext
    {
        public DbSet<Predmet> predmeti { get; set; }
        public DbSet<Student> studenti { get; set; }
        public DbSet<StudentImaPredmet> studentiImajoPredmete { get; set; }
        public DbSet<UporabniskiRacun> uporabniskiRacuni { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                .HasMany(a => a.studentImaPredmete)
                .WithRequired(uc => uc.Student)
                .HasForeignKey(uc => uc.Student_Id)
                .WillCascadeOnDelete(true); // and this works

            modelBuilder.Entity<Predmet>()
                .HasMany(a => a.studentiImajoPredmet)
                .WithRequired(uc => uc.Predmet)
                .HasForeignKey(uc => uc.Predmet_Id)
                .WillCascadeOnDelete(true); // and this works
        }
    }
}
