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
            AreArgumentsValid(args);

            var math = new BasicMath();
            var advmath = new AdvMath();
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
                case "area":
                    Console.WriteLine($"Height of {_num1} * Width of {_num2} = an Area of {advmath.CalcArea(_num1, _num2)}");
                    break;
                case "squ":
                    Console.WriteLine($"{_num1} Squared = {advmath.ValSquared(_num1)}");
                    break;
                case "pythag":
                    Console.WriteLine($"Pythagorean Theorem for {_num1} and {_num2} = {advmath.PythagTheorem(_num1, _num2)}");
                    break;
                case "avg":
                    Console.WriteLine("Enter a comma-separated list of numbers:");
                    string input = Console.ReadLine();
                    string[] inputArray = input.Split(',');
                    List<double> numsToAvg = inputArray.Select(double.Parse).ToList();// creates a list of doubles
                    Console.WriteLine($"Average of {string.Join(", ", numsToAvg)} = {advmath.ListAvg(numsToAvg)}");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul, Div, Area, Avg, Squ, or Pythag");
                    break;
            }

            Console.ReadLine();
        }



        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            _num1 = NumParser(args[2]);

            if (_operand == "squ")
            {
                _num2 = 0;
            }
            else
            {
                _num2 = NumParser(args[3]);
            }

            Console.WriteLine("All Arguments are valid!");
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