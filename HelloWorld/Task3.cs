using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Task3 : Task
    {
        public Task3(): base("../Inputs/3/input") { }
        public override void Run()
        {
            this.readLines();
            int possibleTriangles = 0;
            foreach ( string s in this.lines)
            {
                string trimmed = s.Trim();
                Regex regex = new Regex(@"[ ]{2,}");    // Regex to match more than two occurences of space 
                var sides = regex.Replace(trimmed, @" ").Split(' ');
                
                
                int a = int.Parse(sides[0]);
                int b = int.Parse(sides[1]);
                int c = int.Parse(sides[2]);
                if (isTriangle(a, b, c))
                    possibleTriangles++;
            }
            Console.WriteLine("Task 3 part 1: " + possibleTriangles);
        }

        private bool isTriangle(int a, int b, int c)
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
