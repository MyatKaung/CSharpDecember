using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Reference Types ---
            // string, object
            string s = "Hello" + "World";
            object obj = 12.5;

            // --- Pointer Operators (Note: Require 'unsafe' context in C#) ---
            // Address Operator (&)
            // Indirection Operator (*)

            // --- Operators (CPU - Central Processing Unit) ---
            // ALU (Arithmetic Logic Unit)
            // CU (Control Unit)
            // Branch

            // AO (+, -, *, /, %) - Returns Value
            // CO (<, >, <=, >=, ==) - Returns bool
            // LO (&&, ||, !) - Decision
            // BO (&, |, ^) - Bitwise Operations


            int x = 37;
            int y = 23;
            //int month = 2;
            //int year = 1700; 

            // Bitwise (BO), Arithmetic (AO), Comparison (CO), and Logical (LO) Operators
            Console.WriteLine(x + y);    // 60
            Console.WriteLine(x < y);    // False

            // This logic uses the standard Remainder (%) and Logical (&&, ||) operators
            //if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
            //{
            //    Console.WriteLine("Leap Year");
            //}
            //else
            //{
            //    Console.WriteLine("Not Leap Year");
            //}

            // --- Bitwise Operations (BO) ---
            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);

            // 00100101 - 37 
            // 00010111 - 23
            //-------------------
            // 00000101  (x&y)
            // 00110111  (x|y)
            // 00110010  (xcapy)



            char h = 'j';

            // The || operator means "OR"
            if (h == 'a' || h == 'e' || h == 'i' || h == 'o' || h == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Not Vowel");
            }


                switch (h)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Not Vowel");
                        break;
                }

            // day, month, year
            // 2, 10, 2025
            //tomorrow? 3,Oct,2025
            // without DateTime 
            int day=27;
            int month = 2;
            int year = 2025;

            int total_num_days;



            if (month==2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    total_num_days = 29;
                }
                else
                {
                    total_num_days = 28;
                }

            }

            else if (month ==4 || month ==6 || month == 9 || month == 11)
            {
                total_num_days = 30;
            }

            else
            {
                total_num_days = 31;
            }


            if (day >= total_num_days)
            {
                day = 1;
                month = month + 1;
            }

            else
            {
                day = day + 1;
            }

            if (month > 12)
            {
                month = 1;
                year = year + 1;

            }


            string monthNameMapping ="";
            switch (month)
            {
                case 1: monthNameMapping = "Jan"; break;
                case 2: monthNameMapping = "Feb"; break;
                case 3: monthNameMapping = "Mar"; break;
                case 4: monthNameMapping = "Apr"; break;
                case 5: monthNameMapping = "May"; break;
                case 6: monthNameMapping = "Jun"; break;
                case 7: monthNameMapping = "Jul"; break;
                case 8: monthNameMapping = "Aug"; break;
                case 9: monthNameMapping = "Sep"; break;
                case 10: monthNameMapping = "Oct"; break;
                case 11: monthNameMapping = "Nov"; break;
                case 12: monthNameMapping = "Dec"; break;
            }


            Console.WriteLine("Tomorrow is: " + day + " " + monthNameMapping + " " + year);





        }
    }
}
