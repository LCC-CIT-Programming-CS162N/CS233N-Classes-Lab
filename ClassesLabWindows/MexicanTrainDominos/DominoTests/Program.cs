using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DominoClasses;

namespace DominoTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestDominoConstructors();
            TestDominoToString();
            TestDominoPropertyGetters();
            TestDominoPropertySetters();
            TestDominoFlip();
            TestDominoScore();
            TestDominoIsDouble();

            Console.ReadLine();
        }

        static void TestDominoConstructors()
        {
            Domino d1 = new Domino();
            Domino d2 = new Domino(12, 6);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values (0, 0). " + d1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 12, 6 " + d2.ToString());
            Console.WriteLine();
        }

        static void TestDominoToString()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 12, 6 " + d1.ToString());
            Console.WriteLine("Expecting 12, 6 " + d1);
            Console.WriteLine();
        }

        static void TestDominoPropertyGetters()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Side 1.  Expecting 12. " + d1.Side1);
            Console.WriteLine("Side 2.  Expecting 6. " + d1.Side2);
            Console.WriteLine();
        }

        static void TestDominoPropertySetters()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing setters");
            d1.Side1 = 4;
            d1.Side2 = 5;
            Console.WriteLine("Expecting 4, 5 " + d1);
            Console.WriteLine();
        }

        static void TestDominoScore()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing Score");
            Console.WriteLine("Score.  Expecting 18. " + d1.Score);
            Console.WriteLine();
        }

        static void TestDominoIsDouble()
        {
            Domino d1 = new Domino(12, 12);
            Domino d2 = new Domino(12, 6);

            Console.WriteLine("Testing IsDouble");
            Console.WriteLine("12 and 12.  Expecting true. " + d1.IsDouble());
            Console.WriteLine("12 and 6.  Expecting false. " + d2.IsDouble());
            Console.WriteLine();
        }

        static void TestDominoFlip()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing Flip");
            Console.WriteLine("Before.  Expecting 12, 6. " + d1);
            d1.Flip();
            Console.WriteLine("After.  Expecting 6, 12. " + d1);
            Console.WriteLine();
        }
    }
}
