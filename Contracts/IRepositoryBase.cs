using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Contracts
{
    public interface IRepositoryBase<T> where T : class 
    {
        ICollection<T> FindAll();
        T FindById(int Id);
        bool IsExist(int Id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();

    }
}

