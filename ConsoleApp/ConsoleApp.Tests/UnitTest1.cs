using Xunit;

namespace ConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddCustomer()
        {
            double expeted = 6;

            double actual = 3 + 2;

            Assert.Equal(expeted, actual);
        }
    }
}