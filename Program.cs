using System;
using SimpleTCP;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // string server = args[0];
            // int port = Convert.ToInt32(args[1]);
            // string filename = args[2];
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
