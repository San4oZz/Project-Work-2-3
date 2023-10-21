using ModelLayer;
using DALEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public Context() : base("DbConnection") { }
        public DbSet<Student> Students { get; set; }
    }
}
