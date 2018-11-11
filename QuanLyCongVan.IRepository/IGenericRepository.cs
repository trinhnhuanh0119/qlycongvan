using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Update(T item);
        int Delete(int id);
        int Create(T item);
       
    }
}
