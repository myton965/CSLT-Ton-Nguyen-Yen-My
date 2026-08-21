using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mietorn.Buổi_3
{
    internal class Excercise
    {
        public static void Main12(string[] args)
        {
            //1. Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit:
            Console.WriteLine("Enter Celsius: ");
            int cels = int.Parse(Console.ReadLine());
            int kelvin = cels + 273;
            int fahrenheit = (cels * 18 / 10 + 32);
            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit={fahrenheit}");

            //2. Create a program in C# for calculate the surface and volume of a sphere, given its radius:
            Console.Write("Enter radius: ");
            double radius= double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * pi * radius * radius;
            double volume = (4 /3) * pi * radius * radius * radius;
            Console.WriteLine($"surface={surface}");
            Console.WriteLine($"volume={volume}");

            //3 Write a program in C# that calculates the result of adding, subtract, multiplying and dividing two numbers entered by the user:
            Console.Write("Enter first number: ");
            int a= int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}x{b}={a * b}");
            Console.WriteLine($"{a}/{b}={a/b}");
            Console.WriteLine($"{a} mod {b}={a % b}");




        }
    }
}
