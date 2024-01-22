using Mathematics;
using System;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;



        static void Main()
        {
            string[] args =  Environment.GetCommandLineArgs();
            //foreach (var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            AreArgumentsValid(args);

            var math = new BasicMath();
            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {math.SubNumbers(_num1, _num2)}");
                    break;
                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {math.MulNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {math.DivNumbers(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul or Div");
                    break;
            }

            Console.ReadLine();
        }


        //public static void AreArgumentsValid(string[] args) 
        //{
        //    double num1;
        //    double num2;
        //    if (Double.TryParse(args[2], out num1)) 
        //    { 
        //        _num1 = num1;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Unable to parse {args[2]}.");
        //    }

        //    if (Double.TryParse(args[3], out num2))
        //    {
        //        _num2 = num2;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Unable to parse {args[3]}.");
        //    }
        //}

        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower(); 
            _num1 = NumParser(args[2]);
            _num2 = NumParser(args[3]);
            Console.WriteLine("All Arguments are valid!");
            //Console.ReadLine();
        }

        public static double NumParser(string arg)
        {
            double number;
            if (Double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }
            return 0;
        }
    }
} 