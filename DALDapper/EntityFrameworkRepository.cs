using DAL;
using Dapper;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace DALEntity
{


    public class EntityFrameworkRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        public Context _Context;

        public EntityFrameworkRepository()
        {
            _Context = new Context();
        }
            

        public void Create(T obj)
        {
            _Context.Set<T>().Add(obj);
            _Context.SaveChanges();
        }

        public void Delete(Student student, int Id)
        {
            
            _Context.Students.Remove(student);
            _Context.SaveChanges();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList()
        {
            return _Context.Set<T>().ToList();
        }

    }   
}