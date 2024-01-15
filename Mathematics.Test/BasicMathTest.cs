
namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void AddNumbersTest()
        {
            var math = new BasicMath();
            var result = math.AddNumbers(1,2);
            Assert.True(result == 3,$"{result} is not equal to the number we were thinking");

        }

        [Fact]
        public void SubNumbersTest()
        {
            var math = new BasicMath();
            var result = math.SubNumbers(2, 1);
            Assert.True(result == 1, $"{result} is not equal to the number we were thinking");

        }

        [Fact]
        public void ListCountTest() 
        { 
            var math = new BasicMath();
            var list = new List<double>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            var result = math.listCount(list);
            Assert.True(result == 3, $"{result} should have been 3.");
        }


    }
}
