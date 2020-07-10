using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pg203lambda
{
    class Program
    {
        class Employee
        {
            public int EID { get; set; }
            public string EmFirName { get; set; }
            public string EmLasName { get; set; }

        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee() { EID = 1, EmFirName="Joe", EmLasName="Smith"},
                new Employee() { EID = 2, EmFirName="Steve", EmLasName="Smither"},
                new Employee() { EID = 3, EmFirName="Ram",EmLasName="Smithst"},
                new Employee() { EID = 4, EmFirName="Joe", EmLasName="Smitherson"},
                new Employee() { EID = 10, EmFirName="Sara", EmLasName="Saunders"},
                new Employee() { EID = 6, EmFirName="Ida", EmLasName="Jim"},
                new Employee() { EID = 8, EmFirName="Ready",EmLasName="Made"},
                new Employee() { EID = 9, EmFirName="Style", EmLasName="Stiles"},
                new Employee() { EID = 7, EmFirName="Cri", EmLasName="Lyn"},
                new Employee() { EID = 5, EmFirName="Style", EmLasName="More"},
            };

            ////Adding to list the foreach way.//
            List<Employee> employeeJoe = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.EmFirName == "Joe")
                {
                    employeeJoe.Add(emp);
                    Console.WriteLine(emp.EmFirName + " " + emp.EmLasName);
                }
            }

            ////Adding to list the lambda way.//
            //List<Employee> employeeJoe1 = employees.Where(x => x.EmFirName == "Joe").ToList();
            //foreach (Employee emp in employeeJoe1)
            //{
            //    Console.WriteLine(emp.EmLasName); 
            //}

            //Adding all employees with ID number greater than 5. 
            //List<Employee> empId = employees.Where(x => x.EID > 5).ToList();
            //foreach (Employee emp in empId)
            //{
            //    Console.WriteLine(emp.EmLasName + " " + emp.EID);
            //}

            Console.ReadLine();
        }
    }
}
