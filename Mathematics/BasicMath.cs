namespace Mathematics
{
    public class BasicMath
    {
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double SubNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public double MulNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivNumbers(double num1, double num2)
        {
            return num1 / num2;
        }

        public int listCount(List<double> list)
        {
            return list.Count;
        }
       
        public double listSum(List<double> list)
        {
            return list.Sum();
        }
    }
}