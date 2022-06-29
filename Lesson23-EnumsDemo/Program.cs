using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_EnumsDemo
{
    enum Level
    {
        Low =5 ,
        Medium =7 ,
        High
    }

    enum Gender
    {
        Male,
        Female
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level level = Level.Low;

            int levelValue = (int)Level.Medium;

            Console.WriteLine(level);
            Console.WriteLine(levelValue);

            Gender gender = Gender.Male;

            switch (gender)
            {
                case Gender.Male:
                    Console.WriteLine("Male candidate");
                    break;
                case Gender.Female:
                    Console.WriteLine("Female Candidate");
                    break;

                default:
                    Console.WriteLine("Unknown gender");
                    break;
    
            }



            Console.ReadLine();

        }
    }
}
