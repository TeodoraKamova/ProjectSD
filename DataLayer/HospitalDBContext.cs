using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class HospitalDBContext : DbContext
    {
        public HospitalDBContext()
        {

        }

        public HospitalDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySQL(@"Server=127.0.0.1;Port=3306;Database=HospitalDB;Uid=root;Pwd=root;");
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=HospitallDB;Uid=root;Pwd=root;");
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Sickness> Sicknesses { get; set; }

    }
}
