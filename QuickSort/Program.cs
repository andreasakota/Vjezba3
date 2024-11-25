using System.ComponentModel.DataAnnotations;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Ivo", 4.1),
                new Student("Ana", 4.9),
                new Student("Iva", 4.3),
                new Student("Bob", 4.5),
                new Student("Joe", 4.7),
                new Student("Tom", 4.4),
                new Student("Iko", 4.6),
            };

            Console.WriteLine("Original array: ");
            DisplayArray(students);

            Quick.Partition(students, 0, students.Length - 1, Student.CompareName);
            Console.WriteLine("\nPartitioned by name:");
            DisplayArray(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareName);
            Console.WriteLine("\nSorted by name:");
            DisplayArray(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareGrade);
            Console.WriteLine("\nSorted by grade:");
            DisplayArray(students);
        }

        static void DisplayArray(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
