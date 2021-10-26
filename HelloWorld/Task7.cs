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
            Regex regFindTLS = new Regex(@"^.*(?!.*(.)\1{3})(.)(.)(\3)(\2).*$");
            foreach ( var s in this.lines)
            {
                
                var insideStrings = regInsideBrackets.Split(s);
                var outsideStrings = regOutsideBracket.Split(s);

                bool drop = false;
                foreach( var inside in insideStrings)
                {
                    if (regFindTLS.IsMatch(inside))
                    {
                        drop = true;
                        break;
                    }
                }
                if (drop)
                    continue;
                foreach( var outside in outsideStrings)
                {

                }
            }
        }
    }
}
