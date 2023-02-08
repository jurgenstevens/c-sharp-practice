// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
// Everything within static void Main is what is gets executed
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old.");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName + ".");
            Console.WriteLine("But didn't like being " + characterAge + ".");



            Console.ReadLine();
        }
    }

}

