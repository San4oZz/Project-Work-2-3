using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DAL;
using DALEntity;
using System.Data.SqlClient;



namespace Logic
{
    public class BusLogic
    { public IRepository<Student> repository { set; get; }
        public BusLogic(IRepository<Student> Repository)
        {
            repository = Repository;
        }
        //private IRepository<Student> repository;


      /*  public BusLogic()
        {
            repository = new RepositoryDapper<Student>();
        }
      */
        
        public void AddStudent(string name, string speciality, string group)
        {
            Student student = new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            };
            repository.Create(student);
          
            

        }
        public void DeleteStudent(int index)
        {
            List<Student> students = (List<Student>)repository.GetList();
            repository.Delete(students[index - 1], students[index - 1].Id);

        }
        
        public Dictionary<string, int> Gystogramme()
        {
            Dictionary<string, int> SpecialitiesStudent = new Dictionary<string, int>();
            List<Student> students = (List<Student>)repository.GetList();
            foreach (Student student in students)
            {
                if (SpecialitiesStudent.ContainsKey(student.Speciality))
                {
                    SpecialitiesStudent[student.Speciality] += 1;
                }
                else
                {
                    SpecialitiesStudent[student.Speciality] = 1;
                }
            }
            
            return SpecialitiesStudent;


        }
        public List<string> GetAll()
        {
            List<string> s = new List<string>();
            List<Student> students = (List<Student>)repository.GetList();
            foreach (Student student in students)
            {
                s.Add(student.Name + "\t" + student.Speciality + "\t" + student.Group);
            }
            return s;
        }
    }
}
