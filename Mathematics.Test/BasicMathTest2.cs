
namespace Mathematics.Test
{
    public class BasicMathTest2
    {
        [Fact]
        public void MulNumbersTest()
        {
            var math = new BasicMath();
            var result = math.MulNumbers(1, 2);
            Assert.True(result == 2, $"{result} is not equal to the number we were thinking");

        }

        [Fact]
        public void DivNumbersTest()
        {
            var math = new BasicMath();
            var result = math.DivNumbers(2, 1);
            Assert.True(result == 2, $"{result} is not equal to the number we were thinking");

        }

        [Fact]
        public void ListSumTest()
        {
            var math = new BasicMath();
            var list = new List<double>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            var result = math.listSum(list);
            Assert.True(result == 12, $"{result} should have been 12.");
        }
    }
}
