using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Task 1:");
            foreach (var emp in LinqTasks.Task1())
            {
                Console.WriteLine(emp.Ename);
            }
            
            // Task 2
            Console.WriteLine("\nTask 2:");
            foreach (var emp in LinqTasks.Task2())
            {
                Console.WriteLine(emp.Ename);
            }
            
            // Task 3
            Console.WriteLine("\nTask 3:");
            Console.WriteLine(LinqTasks.Task3());
            
            // Task 4
            Console.WriteLine("\nTask 4:");
            foreach (var emp in LinqTasks.Task4())
            {
                Console.WriteLine(emp.Ename);
            }
            
            // Task 5
            Console.WriteLine("\nTask 5:");
            foreach (var item in LinqTasks.Task5())
            {
                Console.WriteLine($"{item}");
            }
            
            // Task 6
            Console.WriteLine("\nTask 6:");
            foreach (var item in LinqTasks.Task6())
            {
                Console.WriteLine($"{item}");
            }
            
            // Task 7
            Console.WriteLine("\nTask 7:");
            foreach (var jobGroup in LinqTasks.Task7())
            {
                Console.WriteLine($"{jobGroup}");
            }
            
            // Task 8
            Console.WriteLine("\nTask 8:");
            Console.WriteLine(LinqTasks.Task8());
            
            // Task 9
            Console.WriteLine("\nTask 9:");
            var task9Result = LinqTasks.Task9();
            if (task9Result != null)
            {
                Console.WriteLine(task9Result.Ename);
            }
            
            // Task 10
            Console.WriteLine("\nTask 10:");
            foreach (var item in LinqTasks.Task10())
            {
                Console.WriteLine($"{item}");
            }

            // Task 11
            Console.WriteLine("\nTask 11:");
            foreach (var item in LinqTasks.Task11())
            {
                Console.WriteLine($"{item}");
            }

            // Task 12
            Console.WriteLine("\nTask 12:");
            foreach (var emp in LinqTasks.Task12())
            {
                Console.WriteLine(emp.Ename);
            }

            // Task 13
            Console.WriteLine("\nTask 13:");
            int[] sampleArray = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            Console.WriteLine(LinqTasks.Task13(sampleArray));

            // Task 14
            Console.WriteLine("\nTask 14:");
            foreach (var dept in LinqTasks.Task14())
            {
                Console.WriteLine(dept.Dname);
            }

            // Task 15
            Console.WriteLine("\nTask 15:");
            foreach (var item in LinqTasks.Task15())
            {
                Console.WriteLine($"{item}");
            }

            // Task 16
            Console.WriteLine("\nTask 16:");
            foreach (var item in LinqTasks.Task16())
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
