using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_StaticDemo
{
    class Circle
    {
         int _radius;
         static float pi;

        static Circle()
        {
            pi = 3.14f;
        }


        public Circle(int radius)
        {
            _radius = radius;
        }

        public float CalculateArea()
        {
            return pi * this._radius * this. _radius;
        }


        public static void GetMessage()
        {

        }

    }


    static class Rectangle
    {
        //We cannot have non static fields and methods in a static class.
        public static void Area()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5); 
            float firstCircleArea = firstCircle.CalculateArea();
            Console.WriteLine(firstCircleArea);

            Circle secondCircle = new Circle(6);
            float secondCircleArea = secondCircle.CalculateArea();
            Console.WriteLine(secondCircleArea);

           

            Console.ReadLine();
        }
    }
}
