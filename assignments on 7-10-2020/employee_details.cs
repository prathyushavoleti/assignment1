using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_assignment
{

    public class employee
    {
        public int employeeID { get; set; }
        public string employeename { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }
    }
    class employee_details
    {
        static void Main(string[] args)
        {
            List<employee> emplist = new List<employee>()
            {
                new employee() { employeeID = 1, employeename = "prathyusha", salary = 25000, designation = "project manager" },
                new employee() { employeeID = 2, employeename = "firdos", salary = 22000, designation = "team leader" },
                new employee() { employeeID = 3, employeename = "ramya", salary = 15000, designation = "analyst" },
                new employee() { employeeID = 4, employeename = "sravani", salary = 30000, designation = "manager" },
             };
            var emp1= emplist.Where(e => e.salary > 18000).Select(e => e).Where(e => e.employeeID == 1).Select(s => s.employeename);
            var emp2 = emplist.Where(e => e.salary == 22000).Select(e => e).Where(e => e.employeeID == 2).Select(s => s.employeename);
            var emp3 = emplist.Where(e => e.salary >= 18000).Select(e => e).Where(e => e.employeeID == 1).Select(s => s.employeename);
            var emp4 = emplist.Where(e => e.salary <= 18000).Select(e => e).Where(e => e.employeeID >= 1).Select(s => s.employeename);
            var emp5 = emplist.Where(e => e.salary == 18000).Select(e => e).Where(e => e.employeeID < 1).Select(s => s.employeename);
            var emp6 = emplist.Where(e => e.salary == 30000).Select(e => e).Where(e => e.employeeID <= 1).Select(s => s.employeename);
            var emp7 = emplist.Where(e => e.salary == 25000).Select(e => e).Where(e => e.employeeID == 1).Select(s => s.employeename);
            var emp8 = emplist.Where(e => e.salary > 20000).Select(e => e).Where(e => e.employeeID != 1).Select(s => s.employeename);
            var emp9 = emplist.Where(e => e.salary != 15000).Select(e => e).Where(e => e.employeeID <= 1).Select(s => s.employeename);
           var youngestemployee= from e in emplist where (e.salary > 12000 && e.salary < 25000 ) select new { Employeename = e.employeename};
          youngestemployee.ToList().ForEach(e => Console.WriteLine(e.Employeename));//stored information converted to list
            foreach(var a in emp1)
            {
                Console.WriteLine(a);
            }
            foreach (var b in emp2)
            {
                Console.WriteLine(b);
            }
            foreach (var c in emp3)
            {
                Console.WriteLine(c);
            }
            foreach (var d in emp4)
            {
                Console.WriteLine(d);
            }
            foreach (var e in emp5)
            {
                Console.WriteLine(e);
            }
            foreach (var f in emp6)
            {
                Console.WriteLine(f);
            }
            foreach (var g in emp7)
            {
                Console.WriteLine(g);
            }
            foreach (var h in emp8)
            {
                Console.WriteLine(h);
            }
            foreach (var i in emp9)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
