
namespace Mathematics
{
    public class AdvMath
    {
        public double CalcArea(double height, double width) //height * width
        {
            return height * width;
        }


        public double ListAvg(List<double> list) //list of doubles, averaged
        {
            return list.Average();
        }


        public double ValSquared(double num1) // val multiplied by itself
        {
            return Math.Pow(num1, 2); 
            
        }


        public double PythagTheorem(double num1, double num2)
        {
            //c^2 = a^2 + b^2
            double result = Math.Pow(num1, 2) + Math.Pow(num2, 2);
            
            //Square root of c
            return Math.Sqrt(result);
        }





    }
}
