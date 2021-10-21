using System;
using System.Collections;
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
            var places = new List<( int, int ) >();
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
                for (int i = 0; i < steps; i++)
                {
                    places.Add((x, y));
                    switch (facing)
                    {
                        case Facing.NORTH:
                            y += 1;
                            break;
                        case Facing.WEST:
                            x -= 1;
                            break;
                        case Facing.SOUTH:
                            y -= 1;
                            break;
                        case Facing.EAST:
                            x += 1;
                            break;
                    }
                    if (places.Contains((x, y)))
                    {
                        int val = Math.Abs(x) + Math.Abs(y);
                        Console.WriteLine("Task 2. solution: " + val);
                        return;
                    }
                }
            }
            
            
        }
    }
}
