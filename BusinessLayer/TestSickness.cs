using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestingLayer
{
    class TestSickness
    {
        private HospitalDBContext dbContext;
        private CRUDContext<Sickness, int> SicknessContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new HospitalDBContext(builder.Options);
            SicknessContext = new CRUDContext<Sickness, int>(dbContext.Sicknesses, dbContext);
        }

        [Test]
        public void TestCreateSickness()
        {
            int SicknessBefore = SicknessContext.ReadAll().Count();

            SicknessContext.Create(new Sickness("covid",6,"temperature,breathing hard"));

            int SicknessAfter = SicknessContext.ReadAll().Count();

            Assert.IsTrue(SicknessBefore != SicknessAfter);
        }

        [Test]
        public void TestReadSickness()
        {
            SicknessContext.Create(new Sickness("pleague", 7, "death"));

            Sickness sick = SicknessContext.Read(1);

            Assert.That(sick != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdateSickness()
        {
            SicknessContext.Create(new Sickness("measles", 5, "pimples"));

            Sickness sick = SicknessContext.Read(1);

            sick.Name = "Measles";
            sick.Level = 4;

            SicknessContext.Update(sick);

            Sickness sick1 = SicknessContext.Read(1);

            Assert.IsTrue(sick1.Name == "Measles" && sick1.Level == 4, "Sickness Update() does not work!");
        }

        [Test]
        public void TestDeleteSickness()
        {
            SicknessContext.Create(new Sickness("nausea", 1, "feeling bad"));

            int sickBefore = SicknessContext.ReadAll().Count();

            SicknessContext.Delete(1);

            int sickAfter = SicknessContext.ReadAll().Count();

            Assert.AreNotEqual(sickBefore, sickAfter);
        }
    }
}
