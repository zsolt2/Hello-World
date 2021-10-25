using System;
using HelloWorld.Task_5;

namespace HelloWorld.Task_5
{
    class Task5 : Task
    {
        public Task5() : base("/Inputs/5/input") { }
        public override void Run()
        {
            int suffix = 0;
            string password = "";
            string prefix = "wtnhxymk";
            for (int i = 0; i < 8; i++)
            {
                string hash;
                do
                {
                    string input = prefix + suffix.ToString();
                    hash = MD5.getMD5hash(input);
                    suffix++;
                } while (!hash.StartsWith("00000"));
                Console.WriteLine(hash);
                password += hash[5];
            }
            Console.WriteLine("Password: " + password);
        }
    }
}
