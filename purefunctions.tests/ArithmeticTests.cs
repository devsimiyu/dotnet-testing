using purefunctions.console;

namespace purefunctions.tests
{
    public class ArithmeticTests
    {
        [Fact]
        public void ShouldAddIntegers()
        {
            var arithmetic = new Arithmetic();
            var got = arithmetic.Add(2, 3);
            var expect = 5;

            Assert.Equal(expect, got);
        }
    }
}
