using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using System.Data.SqlClient;
using Ninject;

namespace Project_Work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            BusLogic logical = ninjectKernel.Get<BusLogic>();
            //BusLogic logical = new BusLogic();
            Console.WriteLine("Нажмите 1, если хотите добавить студента; нажмите 2, если хотите удалить студента");

            Dictionary<string, int> gitso = new Dictionary<string, int>();
            PrintStudent(logical);
            while (true)
            {

                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Как зовут студента?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Какая специальность у студента?");
                        string specility = Console.ReadLine();
                        Console.WriteLine("Какая группа у студента?");
                        string group = Console.ReadLine();
                        logical.AddStudent(name, specility, group);
                        gitso = logical.Gystogramme();
                        PrintStudent(logical);
                        Console.WriteLine();
                        Gistogramme(gitso);
                        
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите номер студента для удаления");
                        int index = Convert.ToInt32(Console.ReadLine());
                        logical.DeleteStudent(index);
                        gitso = logical.Gystogramme();
                        PrintStudent(logical);
                        Console.WriteLine();
                        Gistogramme(gitso);
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет, введите еще раз");
                        break;
                }
            }
        }

        static void PrintStudent(BusLogic logical)
        {
            int k = 1;
            foreach (string s in logical.GetAll())
            {
                Console.WriteLine(Convert.ToString(k) + " " + s);
                k++;
            }
        }
        static void Gistogramme(Dictionary<string, int> gitso)
        {
            foreach (string s in gitso.Keys)
            {
                string kkkk = "";
                for (int i = 0; i < gitso[s]; i++)
                {
                    kkkk += "==";
                }
                Console.WriteLine(kkkk + "\t" + s);
            }
        }
    }

   
}
