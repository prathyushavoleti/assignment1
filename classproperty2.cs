using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproperty2
{
    class marks
    {
        private string name;
        private string branch;
        private string semester;
        private int cmc_marks;
        private int emi_marks;
        private int sc_marks;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public int Cmcmarks
        {
            get { return cmc_marks; }
            set { cmc_marks = value; }
        }
        public int Emimarks
        {
            get { return emi_marks; }
            set { emi_marks = value; }
        }
        public int Scmarks
        {
            get { return sc_marks; }
            set { sc_marks = value; }
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            marks m = new marks();
            m.Name = "prathyusha";
            Console.WriteLine(m.Name);
            m.Branch = "ECE";
            Console.WriteLine(m.Branch);
            m.Semester = "final sem";
            Console.WriteLine(m.Semester);
            m.Cmcmarks = 89;
            Console.WriteLine(m.Cmcmarks);
            m.Emimarks = 81;
            Console.WriteLine(m.Emimarks);
            m.Scmarks = 86;
            Console.WriteLine(m.Scmarks);
            int total = m.Cmcmarks + m.Emimarks + m.Scmarks;

            
            Console.WriteLine("total marks obtained:{0}",total );
       
            Console.ReadLine();

        }
    }
}
