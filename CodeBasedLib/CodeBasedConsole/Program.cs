using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBasedLib;

namespace CodeBasedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptobj = new Department { Id = 1, Name = "IT", Location = "Pune" };
                dept.Departments.Add(deptobj);
                dept.SaveChanges();
                Console.WriteLine("Record inserted.");
                
            }

            Console.ReadLine();
        }
    }
}
