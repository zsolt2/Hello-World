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
            int[] leftEdge = { 1, 2, 5, 10, 13 };
            int[] rightEdge = { 1, 4, 9, 12, 13 };
            int[] upperEdge = { 1, 2, 4, 5, 9};
            int[] bottomEdge = { 5, 9, 10, 12, 13 };

            foreach (string s in this.lines)
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'L':
                            if ( Array.IndexOf(leftEdge, num) == -1 )
                                num--;
                            break;
                        case 'R':
                            if (Array.IndexOf(rightEdge, num) == -1)
                                num++;
                            break;
                        case 'D':
                            if (Array.IndexOf(bottomEdge, num) == -1)
                                num += (num == 1 | num == 11) ? 2 : 4;
                            break;
                        case 'U':
                            if (Array.IndexOf(upperEdge, num) == -1)
                                num -= (num == 3 | num == 13) ? 2 : 4;
                            break;
                    }
                    
                }
                code += string.Format("{0:X}", num);
            }
            Console.WriteLine("Task 2 part 2:" + code);
        }
    }
}
