using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = 3.141592653M;
            decimal r = 3.5M;
            decimal h = 4.75M;
            decimal v = pi * r * r * h;
            decimal s = 2 * pi * r * (r + h);
            Console.WriteLine(v);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
