using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Task2 : Task
    {
        public Task2(): base("../Inputs/2/input"){}
        public override void Run()
        {
            this.readLines();
            string code="";
            int num = 5;
            foreach (string s in this.lines)
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'L':
                            if (num % 3 != 1)
                                num--;
                            break;
                        case 'R':
                            if (num % 3 != 0)
                                num++;
                            break;
                        case 'D':
                            if (num < 7)
                                num += 3;
                            break;
                        case 'U':
                            if (num > 3)
                                num -= 3;
                            break;
                    }
                }
                code = code + num.ToString();
                
            }
            Console.WriteLine("Task 2 part 1: " + code);
        }
    }
}
