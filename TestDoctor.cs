using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingLayer
{
    class TestDoctor
    {
        private HospitalDBContext dbContext;
        private CRUDContext<Doctor,int> DoctorContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new HospitalDBContext(builder.Options);
            DoctorContext = new CRUDContext<Doctor, int>(dbContext.Doctors,dbContext);
        }

        [Test]
        public void TestCreateDoctor()
        {
            int docsBefore = DoctorContext.ReadAll().Count();

            DoctorContext.Create(new Doctor("Gosho","Ivanov",41,18));

            int docsAfter = DoctorContext.ReadAll().Count();

            Assert.IsTrue(docsBefore != docsAfter);
        }

        [Test]
        public void TestReadDoctor()
        {
            DoctorContext.Create(new Doctor("Petq", "Videva", 29, 3));

            Doctor doc = DoctorContext.Read(1);

            Assert.That(doc != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdateDoctor()
        {
            DoctorContext.Create(new Doctor("Olga", "Kazakovich", 61, 35));

            Doctor doc = DoctorContext.Read(1);

            doc.Name = "Ollga";
            doc.Age = 62;

            DoctorContext.Update(doc);

            Doctor doc1 = DoctorContext.Read(1);

            Assert.IsTrue(doc1.Name == "Ollga" && doc1.Age ==62, "Doctor Update() does not work!");
        }

        [Test]
        public void TestDeleteDoctor()
        {
            DoctorContext.Create(new Doctor("Emil", "Srebrev", 34, 9));

            int docsBefore = DoctorContext.ReadAll().Count();

            DoctorContext.Delete(1);

            int docsAfter = DoctorContext.ReadAll().Count();

            Assert.AreNotEqual(docsBefore, docsAfter);
        }
    }
}
