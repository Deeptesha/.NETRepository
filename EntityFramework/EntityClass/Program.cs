using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkLib;
namespace EntityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeeEntities())
            {
                var emp = new Emp1();
                //emp.Empid = 1;
                //emp.Name = "Emp1";
                //emp.Salary = 10000;
                //EmpObj.Emp1.Add(emp);
                //emp = new Emp1();
                //emp.Empid = 2;
                //emp.Name = "Emp2";
                //emp.Salary = 15000;
                //EmpObj.Emp1.Add(emp);
                //emp = new Emp1();
                //emp.Empid = 3;
                //emp.Name = "Emp3";
                //emp.Salary = 20000;
                //EmpObj.Emp1.Add(emp);

                //for (int i = 4; i < 8; i++)
                //{
                //    emp = new Emp1();
                //    emp.Empid = i;
                //    emp.Name = "Emp" + i;
                //    emp.Salary = 20000;
                //    EmpObj.Emp1.Add(emp);
                //    EmpObj.SaveChanges();
                //}
                //Emp1 emp1Obj = EmpObj.Emp1.First(i => i.Empid == 2);
                //emp1Obj.Name = "Emp2";
                //emp1Obj.Salary = 30000;
                //EmpObj.SaveChanges();

                //Emp1 emp1Obj = EmpObj.Emp1.First(i => i.Empid == 2);
                //EmpObj.Emp1.Remove(emp1Obj);
                //EmpObj.SaveChanges();
                //Console.WriteLine("Record Removed.");
                var EmpObj1 = EmpObj.Emp1;
                foreach (var item in EmpObj1)
                {
                    Console.WriteLine("ID: {0}", item.Empid);
                    Console.WriteLine("Name: {0}", item.Name);
                    Console.WriteLine("Salary: {0}", item.Salary);
                }

            }
            Console.Read();
        }
    }
}
