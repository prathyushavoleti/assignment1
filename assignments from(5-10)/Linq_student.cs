using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace list1
{
    class Linq_student
    {
        public class student
        {
        public int studentID { get; set; }
        public string branchname { get; set; }
        public string studentname { get; set; }
    
            }
    static void Main(string[] args)
        {
            List<student> stlist = new List<student>()
            {
                new student() { studentID = 1, studentname = "prathyusha", branchname="ECE"  },
                new student() { studentID = 2, studentname = "sravani", branchname="CSE"  },
                new student() { studentID = 3, studentname = "firdos", branchname="MECH"  },
            };
            var st1 = stlist.Where(s => s.studentID >= 1).Select(s => s).Where(s => s.studentname == "prathyusha").Select(s => s.branchname);

            var st2 = stlist.Where(s => s.studentID == 3).Select(s => s).Where(s => s.studentname != "prathyusha").Select(s => s.branchname);
            var st3 = stlist.Where(s => s.studentID >= 2).Select(s => s).Where(s => s.studentname == "firdos").Select(s => s.branchname);

            var studentwthece = from s in stlist where (s.studentID==1) select new { Studentname = s.studentname };
            studentwthece.ToList().ForEach(s => Console.WriteLine(s.Studentname));//stored information converted to list
            Console.WriteLine();
            //group by execution
            var stgroupbybatch = from s in stlist
                                       group s by s.studentID into sb
                                       orderby sb.Key
                                       select new { sb.Key, sb };
            Console.WriteLine();
            Console.WriteLine("group by query");
            var searchbyid = from s in stlist
                             where s.branchname =="MECH"//first query
                             where s.studentname == "firdos"//second query
                            
                             group s by s.studentID into sb
                             orderby sb.Key
                             select new { sb.Key, sb };

            foreach (var w in searchbyid)
            {
                Console.WriteLine(w.Key);
            }
            Console.WriteLine();


            //sorting
            var sortingofemployee = from s in stlist
                                    orderby s.studentID, s.studentname
                                    select new
                                    {
                                        Studentname = s.studentname,
                                        StudentID = s.studentID
                                    };
            sortingofemployee.ToList().ForEach(s => Console.WriteLine("studentname:{0}", s.Studentname + "," + "studentid" + s.StudentID));


            foreach (var x in stgroupbybatch)
            {
                Console.WriteLine(x.Key);
            }
            Console.WriteLine();

            foreach (var a in st1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            foreach (var b in st2)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

            foreach (var c in st3)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
