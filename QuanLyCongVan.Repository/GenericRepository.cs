using Microsoft.EntityFrameworkCore;
using QuanLyCongVan.IRepository;
using QuanLyCongVan.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCongVan.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected QuanLyCongVanContext db { get; set; }
        protected DbSet<T> table = null;

        public GenericRepository()
        {
            db = new QuanLyCongVanContext();
            table = db.Set<T>();
        }

        
        public GenericRepository(QuanLyCongVanContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public int Update(T item)
        {
            table.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            return db.SaveChanges();
        }

        public int Create(T item)
        {
            table.Add(item);
            return db.SaveChanges();
        }
    }
}

