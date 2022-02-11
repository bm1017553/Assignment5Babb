using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class DbTest_IsDbReturn
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var customer = new Customer();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}