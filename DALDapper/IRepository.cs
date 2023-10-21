using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelLayer;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> : IDisposable
      where T : class
    {
        IEnumerable<T> GetList();
        T GetById(int Id);
        void Create(T obj);

        
        void Delete(Student student, int Id);
        
       

    }
}
