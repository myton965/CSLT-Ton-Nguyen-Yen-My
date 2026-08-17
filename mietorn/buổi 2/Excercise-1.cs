using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mietorn.buổi_2
{
    internal class Excercise_1
    {
        public static void Main(string[] args)
        {
            int a = 6, b = 10;

            //1.to Add / Sum Two Numbers.
            Console.WriteLine(a + b);

            //2.to Swap Values of Two Variables.
            (a, b) = (b, a);
            Console.WriteLine($"a = {a}, b= {b}");

            //3.to Multiply two Floating Point Numbers
            float c = 2.5f, d = 4.5f;
            Console.WriteLine(c * d);

            //4.to convert feet to meter
            float feet = 10f;
            const float rate = 0.3048f;
            float metter = rate * feet;
            Console.WriteLine($"{feet} feet = {metter} metter.");

            //5.to convert Celsius to Fahrenheit and vice versa
            float cels = 27f;
            float fah = cels * 1.8f + 32;
            Console.WriteLine($"{cels}°C = {fah}F");

            //6.to find the Size of data types
            Console.WriteLine(sizeof(int)); //4 bytes
            Console.WriteLine(sizeof(double)); //8 bytes

            //7.to Print ASCII Value(tip: read character, print number of this char)
            char ch = 'A';
            Console.WriteLine((int)ch);

            //8.to Calculate Area of Circle
            double r = 5;
            Console.WriteLine(Math.PI * r * r);

            //9.to Calculate Area of Square
            double canh = 4;
            Console.WriteLine(canh * canh);

            //10.to convert days to years, weeks and days
            int days = 365;
            Console.WriteLine($"{days / 365} years, {(days % 365) / 7} weeks, {(days % 365) % 7} days");

        }
    }
}
