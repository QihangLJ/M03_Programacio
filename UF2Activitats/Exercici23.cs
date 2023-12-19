using System;
namespace MyProgram
{
    public class ProgramCode
    {
        public static void Main(string[] args)
        {
            const string MsgMenu = "Selecciona una figura geometrica: \nA) Quadrat \nB) Rectangle \nC) Cercle \nD) Pentagon";
            const string MsgInvalid = "Opcio invalid!";
            const string MsgEnterValue = "Introdueix un valor:";
            const string MsgArea = "L'area de la figura es {0}.";

            decimal numOne, numTwo, result = 0;
            char menuSelection;
            bool menuSelected = true;

            Console.WriteLine(MsgMenu);
            menuSelection = Convert.ToChar(Console.ReadLine());


            switch (menuSelection)
            {
                case 'A':
                case 'a':
                    Console.WriteLine(MsgEnterValue);
                    numOne = Convert.ToDecimal(Console.ReadLine());
                    result = SquareArea(numOne);
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine(MsgEnterValue);
                    numOne = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(MsgEnterValue);
                    numTwo = Convert.ToDecimal(Console.ReadLine());
                    result = RectangleArea(numOne, numTwo);
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine(MsgEnterValue);
                    numOne = Convert.ToDecimal(Console.ReadLine());
                    result = CircleArea(numOne);
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine(MsgEnterValue);
                    numOne = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(MsgEnterValue);
                    numTwo = Convert.ToDecimal(Console.ReadLine());
                    result = PentagonArea(numOne, numTwo);
                    break;
                default:
                    Console.WriteLine(MsgInvalid);
                    menuSelected = false;
                    break;
            }

            if (menuSelected)
            {
                Console.WriteLine(MsgArea, result);
            }

        }
        public static decimal SquareArea(decimal side)
        {
            return side * side;
        }
        public static decimal RectangleArea(decimal sideOne, decimal sideTwo)
        {
            return sideOne * sideTwo;
        }
        public static decimal CircleArea(decimal radius)
        {
            return (decimal)Math.PI * radius * radius;
        }
        public static decimal PentagonArea(decimal perimeter, decimal apothem)
        {
            return (perimeter * apothem) / 2;
        }
    }
}
