using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Boolean: " + LinqTasks.Task8());

            int count = 1;
            foreach (var element in LinqTasks.Task7())
            {
                Console.WriteLine(count + ": " + element);
                count++;
            }
            
        }
    }
}
