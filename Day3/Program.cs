using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Vietnam", "Thailand", "Singapore", "Philippines", "Malaysia", "Indonesia", "Myanmar", "Cambodia", "Laos", "Brunei", "Timor-Leste" };
            int limit = countries.Length;
            for (int i=0; i<limit; i++)
            {
                for (int j=i+1; j<limit; j++)
                {
                    if (countries[j][0] < countries[i][0])
                    {
                        string temp = countries[i];
                        countries[i] = countries[j];
                        countries[j] = temp;

                    }
                }
            }

            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
