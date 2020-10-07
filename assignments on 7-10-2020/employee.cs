using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqjoins
{
    public class employee1
    {
        public int employeeID { get; set; }
        public string employeename { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }
    }
    class employee
    {
        static void Main(string[] args)
        {
            List<employee1> emplist = new List<employee1>()
            {
                new employee1() { employeeID = 1, employeename = "prathyusha", salary = 25000, designation = "project manager" },
                new employee1() { employeeID = 2, employeename = "firdos", salary = 22000, designation = "team leader" },
                new employee1() { employeeID = 3, employeename = "ramya", salary = 15000, designation = "analyst" },
                new employee1() { employeeID = 4, employeename = "sravani", salary = 30000, designation = "manager" },
             };

            List<employee1> emplist2 = new List<employee1>()
            {
                new employee1() { employeeID = 5, employeename = "prathyusha", salary = 20000, designation = "project manager" },
                new employee1() { employeeID = 2, employeename = "firdos", salary = 22000, designation = "team leader" },
                new employee1() { employeeID = 3, employeename = "ramya", salary = 25000, designation = "analyst" },
                new employee1() { employeeID = 4, employeename = "sravani", salary = 20000, designation = "manager" },
             };
            var innerJoinQuery = from e1 in emplist
                                 join e2 in emplist2
                                 on e1.employeeID equals e2.employeeID
                                 select new
                                 { EmployeeName = e1.employeename, EmployeeDesignation = e2.designation };



            foreach (var x in innerJoinQuery)

            {
                Console.WriteLine("Employee {0} designation  {1}", x.EmployeeName, x.EmployeeDesignation);
            }
            Console.ReadLine();
        }
    }
}
