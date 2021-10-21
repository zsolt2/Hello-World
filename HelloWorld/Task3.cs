using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Task3 : Task
    {
        public Task3() : base("../Inputs/3/input") { }
        public override void Run()
        {
            this.readLines();
            int possibleTriangles = 0;
            string[][] buffer = new string[3][];
            int i = 0;
            foreach (string s in this.lines)
            {
                string trimmed = s.Trim();
                Regex regex = new Regex(@"[ ]{2,}");    // Regex to match more than two occurences of space 
                var sides = regex.Replace(trimmed, @" ").Split(' ');

                buffer[i++] = sides;

                if (i == 3)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int a = int.Parse(buffer[0][k]);
                        int b = int.Parse(buffer[1][k]);
                        int c = int.Parse(buffer[2][k]);
                        if (isTriangle(a, b, c))
                            possibleTriangles++;
                    }
                    i = 0;
                }
            }
            Console.WriteLine("Task 3 part 2: " + possibleTriangles);
        }

        private bool isTriangle(int a, int b, int c)
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
