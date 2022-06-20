using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestingLayer
{
    class TestPatient
    {
        private HospitalDBContext dbContext;
        private CRUDContext<Patient, int> PatientContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new HospitalDBContext(builder.Options);
            PatientContext = new CRUDContext<Patient, int>(dbContext.Patients, dbContext);
        }

        [Test]
        public void TestCreatePatient()
        {
            int patBef = PatientContext.ReadAll().Count();
            PatientContext.Create(new Patient("Zaharinka", "Elkova", 42,BloodTypes.B,null));

            int patAft = PatientContext.ReadAll().Count();

            Assert.IsTrue(patBef != patAft);
        }

        [Test]
        public void TestReadPatient()
        {
            PatientContext.Create(new Patient("Ico","Sapunov",45, BloodTypes.O, null));

            Patient pat = PatientContext.Read(1);

            Assert.That(pat != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdatePatient()
        {
            PatientContext.Create(new Patient("Mara", "Chushkova", 51, BloodTypes.A,null));

            Patient pat = PatientContext.Read(1);

            pat.Name = "Mimi";
            pat.BloodType = BloodTypes.B;

            PatientContext.Update(pat);

            Patient pat1 = PatientContext.Read(1);

            Assert.IsTrue(pat1.Name == "Mimi" && pat1.BloodType == BloodTypes.B, "Patient Update() does not work!");
        }

        [Test]
        public void TestDeletePatient()
        {
            PatientContext.Create(new Patient("Riki", "Masata", 42,BloodTypes.B, null));

            int patkBefore = PatientContext.ReadAll().Count();

            PatientContext.Delete(1);

            int patAfter = PatientContext.ReadAll().Count();

            Assert.AreNotEqual(patkBefore, patAfter);
        }
    }
}
