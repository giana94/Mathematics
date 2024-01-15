
namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void CalcAreaTest()
        {
            var math = new AdvMath();
            var result = math.CalcArea(3, 4);
            Assert.True(result == 12, $"{result} is not equal to the number we were thinking");

        }

        [Fact]
        public void ListAvgTest()
        {
            var math = new AdvMath();
            var list = new List<double>();
            list.Add(3);
            list.Add(5);
            list.Add(7);
            var result = math.ListAvg(list);
            Assert.True(result == 5, $"{result} should have been 5.");
        }

        [Fact]
        public void ValSquaredTest() 
        {
            var math = new AdvMath();
            var result = math.ValSquared(3);
            Assert.True(result == 9, $"{result} should be 9.");
        }

        [Fact]
        public void PythagTheoremTest()
        {
            var math = new AdvMath();
            var result = math.PythagTheorem(3, 4);
            Assert.True(result == 5, $"{result} should have been 5.");
        }



    }
}
