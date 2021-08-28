using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp58
{
    class Car
    {
        string color = "red";
        int model = 345737;

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public static void Brake()
        {
            Console.WriteLine("Brake");
        }
            static void Main(string[] args)
            {
                Car myObj = new Car();
                myObj.Drive();
                Car.Brake();
            }
     
    }
}
