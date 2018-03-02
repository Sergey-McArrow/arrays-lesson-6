using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 7.3");
            int[] numbers = new int[5];
            int[] srebmun = new int[5];

            int iii = 1;
            int qqq = 4;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = iii;
                iii++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            for (int i = 0; i < srebmun.Length; i++)
            {
                srebmun[i] = numbers[qqq];
                qqq--;
            }
            for (int i = 0; i < srebmun.Length; i++)
            {
                Console.WriteLine(srebmun[i]);
            }

            Console.WriteLine("Task 7.4");
            int[] students = new int[int.Parse(Console.ReadLine())];
            Random heightOfStudents = new Random();
            int allHeight = 0;
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = heightOfStudents.Next(130, 220);

            }
            for (int i = 0; i < students.Length; i++)
            {
                allHeight = allHeight + students[i];
            }
            Console.WriteLine($"Avarane height of students = {allHeight / students.Length} sm.");

            Console.WriteLine("Task 7.8");
            int[] N = new int[int.Parse(Console.ReadLine())];
            Random valuesOfN = new Random();

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = valuesOfN.Next(1, 100);
                if (N[i] % 2 == 0)
                {
                    Console.WriteLine($"Even: {N[i]}");
                }
                else
                    Console.WriteLine($"Odd: {N[i]}");

            }

            





            }
    }
}
