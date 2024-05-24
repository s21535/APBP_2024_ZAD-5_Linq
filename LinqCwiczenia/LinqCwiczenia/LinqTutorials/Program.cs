using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();

            int count = 1;
            foreach (var element in LinqTasks.Task6())
            {
                Console.WriteLine(count + ": " + element);
                count++;
            }
            
        }
    }
}
