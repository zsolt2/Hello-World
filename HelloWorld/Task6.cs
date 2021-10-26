using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Task6 : Task
    {
        public Task6() : base("../Inputs/6/input") { }
        public override void Run()
        {
            this.readLines();
            Dictionary<char, int>[] chars = new Dictionary<char, int>[this.lines[0].Length];
            for (int i = 0; i < chars.Length; i++ )
            {
                chars[i] = new Dictionary<char, int>();
            }

            foreach (string s in this.lines)
            {
                int i = 0;
                foreach( char c in s)
                {
                    try
                    {
                        chars[i][c] = chars[i][c] + 1;
                        
                    }
                    catch (KeyNotFoundException)
                    {
                        chars[i][c] = 1;
                    }
                    i++;
                }
            }
            string code = "";
            foreach(var dict in chars)
            {
                KeyValuePair<char, int> min = dict.ElementAt(0);
                foreach( var kvp in dict)
                {
                    if (min.Value > kvp.Value)
                    {
                        min = kvp;
                    }
                }
                code += min.Key;
            }
            Console.WriteLine("Code: "+ code);
        }
    }
}
