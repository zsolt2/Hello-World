using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            this.text =  System.IO.File.ReadAllText(this.filePath);
        }

        protected void readLines()
        {
            this.lines =  System.IO.File.ReadAllLines(this.filePath);
        }
        
    }
}
