using System;
using System.Text;

namespace HelloWorld.Task_5
{
    class Task5 : Task
    {
        public Task5() : base("/Inputs/5/input") { }
        public override void Run()
        {
            int suffix = 0;
            StringBuilder password = new StringBuilder("XXXXXXXX");
            string prefix = "wtnhxymk";
            while (password.ToString().Contains('X'))
            {
                string hash;
                do
                {
                    string input = prefix + suffix.ToString();
                    hash = MD5.getMD5hash(input);
                    suffix++;
                } while (!hash.StartsWith("00000"));
                Console.WriteLine(hash);
                int position = 8;

                char c = hash[5].ToString()[0];
                if ( char.IsDigit(c) )
                    position = int.Parse(c.ToString());
                
                if (position <= 7 && password[position] == 'X' )
                {
                    password[position] = hash[6];
                    Console.WriteLine(password);
                }
               
                
            }
            Console.WriteLine("Password: " + password.ToString().ToLower());
        }
    }
}
