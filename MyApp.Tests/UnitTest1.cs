namespace MyApp.Tests;

public class UnitTest1
{
     [Fact]
        public void Add_ShouldReturnSum()
        {
            var calc = new Calculator();
            Assert.Equal(7, calc.Add(3, 4));
        }

        [Fact]
        public void Subtract_ShouldReturnDifference()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Subtract(7, 2));
        }
}
