using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Task1 : Task
    {
        private enum Facing { NORTH, WEST, SOUTH, EAST};
        public Task1() : base("../Inputs/1/input")
        {
            
        }
        public override void Run()
        {
            this.readAllText();
            string[] commands = this.text.Split(", ");
            Facing facing = Facing.NORTH;
            int x, y;
            x = y = 0;

           foreach( string c in commands)
            {
                char dir = c[0];
                int steps = int.Parse(c[1..]);
                if(dir == 'R')
                {
                    if (++facing > Facing.EAST) 
                        facing = Facing.NORTH;
                } else if (dir == 'L')
                {
                    if (--facing < Facing.NORTH)
                        facing = Facing.EAST;
                }
                Console.WriteLine(dir + " " + steps + " " + facing);
                switch (facing)
                {
                    case Facing.NORTH:
                        y += steps;
                        break;
                    case Facing.WEST:
                        x -= steps;
                        break;
                    case Facing.SOUTH:
                        y -= steps;
                        break;
                    case Facing.EAST:
                        x += steps;
                        break;
                }
            }
            int val = Math.Abs(x) + Math.Abs(y);
            Console.WriteLine("Task 1. solution: " + val);
        }
    }
}
