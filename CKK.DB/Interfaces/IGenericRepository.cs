using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
