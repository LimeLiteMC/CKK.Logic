using System;
using System.Collections.Generic;

namespace CKK.DB.Interfaces
{
    public interface IGenericRepository<T>
    {
        T GetByID(int id);
        List<T> GetAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
