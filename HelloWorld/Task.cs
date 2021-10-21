using System;
using System.IO;

namespace HelloWorld
{
    
    abstract class Task : TaskInterface
    {

        protected string text;
        protected string[] lines;
        protected string filePath;
        public abstract void Run();
        public Task(string filePath)
        {
            this.filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+ "\\" + filePath;
        }
        protected void readAllText() 
        {
            try
            {
                this.text = System.IO.File.ReadAllText(this.filePath);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }   
        }

        protected void readLines()
        {
            try
            {
                this.lines = System.IO.File.ReadAllLines(this.filePath);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }
        }
        
    }
}
