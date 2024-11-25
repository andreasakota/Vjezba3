using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;       
            this.grade = grade;
        }

        public override string ToString()
        {
            return name + " " + grade;

        }

        public static bool CompareName(object a, object b)
        {
            if ( a is Student studentA && b is Student studentB )
            {
                return studentA.name.CompareTo(studentB.name) < 0;
            }

            throw new ArgumentException("Object must be of type Student.");
        }

        public static bool CompareGrade(object a, object b)
        {
            if ( a is Student studentA && (b is Student studentB) )
            {
                return studentA.grade > studentB.grade;
            }
            throw new ArgumentException("Object must be of type Student.");
        }
    }
}
