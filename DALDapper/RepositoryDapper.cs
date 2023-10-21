using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dapper;
using ModelLayer;
using System.Configuration;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;

namespace DAL
{
    
    public class RepositoryDapper<T> : IRepository<T> where T : class, IDomainObject, new()
    {

        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Professional\\Desktop\\Project Work 2.1\\Project Work 2\\DALDapper\\StudentsDb.mdf;Integrated Security=True";
        public IDbConnection db;
       public RepositoryDapper() => db = new SqlConnection(connectionString);

        public void Delete(Student student, int Id)
        {

            var SqlQuery = "DELETE FROM Students WHERE Id=@Id";
            db.Execute(SqlQuery, new { Id });

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
            return db.Query<T>("SELECT * FROM Students").ToList();
        }


        public void Create(T t)
        {
            var sqlQuery = "INSERT INTO Students (Name, [Group], Speciality)" + " VALUES (@Name, @Group, @Speciality); SELECT CAST (SCOPE_IDENTITY() as int)";
            int studentId = db.Query<int>(sqlQuery, t).FirstOrDefault();
            t.Id = studentId;
        }

    }
}
