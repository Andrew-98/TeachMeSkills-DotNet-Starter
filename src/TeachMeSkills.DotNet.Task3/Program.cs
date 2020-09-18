using System;

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal pi = 3.141592653M;
            decimal r = 8.75M;
            decimal s = pi * r * r;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
