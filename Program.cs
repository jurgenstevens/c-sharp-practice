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
            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 25;
            //Console.WriteLine("There once was a man named " + characterName + ".");
            //Console.WriteLine("He was " + characterAge + " years old.");
            //characterName = "Mike";
            //Console.WriteLine("He really liked the name " + characterName + ".");
            //Console.WriteLine("But didn't like being " + characterAge + ".");
            //string phrase = "Hello world.";
            //// can only be one character
            //char grade = 'A';
            //// int == numbers, duh
            //int age = 31;
            //// decimals can be stored as a float, a double, or a decimal. Go with double
            //double gpa = 3.2;
            //bool hired = true;
            //Console.WriteLine(phrase + " I'm " + age); // Hello world. I'm 31
            //Console.WriteLine(phrase.Length); // 12
            //Console.WriteLine(phrase.ToUpper()); // HELLO WORLD.
            //Console.WriteLine(phrase.ToLower()); // hello world.
            //Console.WriteLine(phrase.Contains("ello")); // true
            //Console.WriteLine(phrase[4]); // o
            //Console.WriteLine(phrase.IndexOf("world")); // 6
            //Console.WriteLine(phrase.IndexOf("z")); // -1 - non-existent
            //Console.WriteLine(phrase.Substring(6)); // world.
            //Console.WriteLine(phrase.Substring(6, 4)); // worl
            // C# goes by PEMDAS rules with math
            Console.WriteLine(9 * 9); // you can do math - 81
            Console.WriteLine(5 % 2); // get remainder with modulus - 1
            Console.WriteLine((4 + 2) * 5); // 30
            Console.WriteLine(5 + 8.1); // 13.1
            Console.WriteLine(5 / 2.0); // 10.0 - you get decimal back
            //int num = 6;
            //num++; // 7
            //num--; //5
            Console.WriteLine(Math.Abs(-40)); // 40
            Console.WriteLine(Math.Sqrt(36)); // 6
            Console.WriteLine(Math.Pow(3, 2)); // 9

            // INPUT
            Console.Write("Enter your name: ");
            // pauses to read input from Write above to define name variable
            string name = Console.ReadLine();

            // another input
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            // logging the input
            Console.WriteLine("Hello " + name + " you are " + age);
            // Hello Jurgen you are 31
            Console.ReadLine();
        }
    }

}

