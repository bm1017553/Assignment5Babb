using System.ComponentModel.DataAnnotations;
using CustomerDatabase;
using Xunit;

namespace CustomerDatabase.Tests
{
    public class ReturnCustomerName
    {
        [Theory]
        [InlineData(Customer.LastName)]
        public void CustomerLastNameReturn(Models.Customer.LastName?)
        {

            if (Customer.LastName == Customer.LastName)
            {
                return true;
            }

            var result = _dbResult.Return(value);

            Assert.True(result, value);
        }
    }
}