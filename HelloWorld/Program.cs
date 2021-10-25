using System;
using System.IO;
using HelloWorld.Task_5;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);
            
            TaskInterface task;
            task = new Task5();
            task.Run();
        }
    }
}
