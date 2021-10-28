using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Task7 : Task
    {
        public Task7() : base("../Inputs/7/input") { }
        public override void Run()
        {
            this.readLines();
            int supporstTLS = 0;
            Regex regInsideBrackets = new Regex(@"\[.*?\]");
            Regex regOutsideBracket = new Regex(@"^.*?\[|\].*?\[|\].*?$");
            Regex regFindTLS = new Regex(@"(.)((?!\1).)\2\1"); // source of this regex: https://eddmann.com/posts/advent-of-code-2016-day-7-internet-protocol-version-7/
            foreach ( var s in this.lines)
            {
                
                var outsideStrings = regInsideBrackets.Split(s);
                var insideStrings = regOutsideBracket.Split(s);

                bool notTLS = false;
                foreach( var inside in insideStrings)
                {
                    if (regFindTLS.IsMatch(inside))
                    {
                        notTLS = true;
                        break;
                    }
                }
                if (notTLS)
                    continue;
                foreach( var outside in outsideStrings)
                {
                    Console.WriteLine(outside);
                    if (regFindTLS.IsMatch(outside))
                    {
                        supporstTLS++;
                        break;
                    }
                }
            }
            Console.WriteLine(supporstTLS);
        }
    }
}
