﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    class CRUDContext<T, K> : IDB<T, K> where T : class
    {
        private DbSet<T> dbSet;
        private HospitalDBContext context;

        public CRUDContext(DbSet<T> dbSet, HospitalDBContext context)
        {
            this.dbSet = dbSet;
            this.context = context;
        }


        public void Create(T item)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Doctor":
                    break;
                case "Patient":
                    break;
                case "Sickness":
                    break;
                default:
                    throw new ArgumentException("Type not suported!");
            }

            dbSet.Add(item);
            context.SaveChanges();
        }

        public void Delete(K key)
        {
            dbSet.Remove((T)Read(key));
            context.SaveChanges();
        }

        public T Read(K key)
        {
            switch (dbSet.EntityType.Name)
            {
                case "Doctor":
                    return context.Doctors.Include(d => d.Patients).SingleOrDefault(d => d.Id == Convert.ToInt32(key)) as T;
                case "Patient":
                    return context.Patients.Include(p => p.Doctor).Include(p => p.Sickness).SingleOrDefault(p => p.Id == Convert.ToInt32(key)) as T;
                case "Sickness":
                    return context.Sicknesses.Include(s => s.Patients).SingleOrDefault(s => s.Id == Convert.ToInt32(key)) as T;
                default:
                    throw new ArgumentException("Type not suported!");
            }
        }

        public IEnumerable<T> ReadAll()
        {
            try
            {
                switch (dbSet.EntityType.ShortName())
                {
                    case "Doctor":
                        return context.Doctors.Include(d => d.Patients).ToList() as IEnumerable<T>;
                    case "Patient":
                        return context.Patients.Include(p => p.Doctor).Include(p => p.Sickness).ToList() as IEnumerable<T>;
                    case "Sickness":
                        return context.Sicknesses.Include(s => s.Patients).ToList() as IEnumerable<T>;
                    default:
                        throw new ArgumentException("Type not suported!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T item)
        {
            dbSet.Update(item);
            context.SaveChanges();
        }
    }
}
