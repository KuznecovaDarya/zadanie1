using System;
using static System.Console;
using static System.Convert;
using MyLibrary;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lib1.stpow("ha", 4));
            Console.WriteLine(lib1.rev("hello"));
            Console.WriteLine(lib1.remov("aHeallao","a"));
            Console.WriteLine(lib1.leng("Hello, friends!"));
        }
    }
}
