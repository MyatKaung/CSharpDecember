using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
    
   
        string GetEvenOddDesc(int x)
        {
            if (x % 2 == 0)
            {
                return EVENODD.EVEN;
            }
            else
            {
                return EVENODD.ODD;
            }
        }

        class EVENODD
        {
            public const string EVEN = "Even";
            public const string ODD = "Odd";
        }

        void WriteSquare()
        {
            Console.WriteLine(Square(3));
            Console.WriteLine(Square(4));
            Console.WriteLine(Square(5));

            int Square(int z) // Local Method
            {
                return z * z;
            }
        }
        static void Main(string[] args)
        {
            // Creating Types
            // Class, Inheritance, Object, Struct, AM(AS), Interface, Enums, Generic

            // Class

            SmartPhone smartPhone = new SmartPhone(); // Object Instantiate
            smartPhone.ScreenType = ScreenTypes.LCD;
            smartPhone.ScreenSizeW = 4.2;
            smartPhone.ScreenSizeH = 2.1;
            smartPhone.RAM = "DDR4 4G";


            // AM (public,private,internal,protected)
            smartPhone.ShowInfo();


            Program p = new Program();
            string res = p.GetEvenOddDesc(50);
            Console.WriteLine(res);


            p.WriteSquare();

            // a.orderstatus="Order Confirm"
            // b.orderstatus="Order Confirm"

        }



        class ScreenTypes
        {
            public const string OLED = "OLED";
            public const string LED = "LED";
            public const string LCD = "LCD";
        }


        class SmartPhone
        {
            // Info
            public string ScreenType; // Fields
            public double ScreenSizeW;
            public double ScreenSizeH;
            public string RAM { get; set; } // Properties
            string CPU;
            string Storage;

            public const string OS = "Android 15"; // read-only

            // Function(Method)
            // Call, Messaging, CameraShoot

            public void ShowInfo()
            {
                Console.WriteLine(ScreenType);
                Console.WriteLine(ScreenSizeW);
                Console.WriteLine(ScreenSizeH);
                Console.WriteLine(RAM);
                Console.WriteLine(OS);
            }

            // AM_Optional_Return_MethodName(Parameter)

        }

        class Dog
        {
            string Name;
            int Legs;
            int TailLenght;

            // Bark, Bite,
        }

        class Person
        {
            string Name;
            double Height;
            DateTime DOB;
            string Gender;
            string FatherName;
            string Nationality;
        }
    }
}