using System.ComponentModel.DataAnnotations;
using Xunit;
using Assignment5Babb.GroceryDelivery.Models.Customer;

namespace DbTesting
{
    public class DbTestingTests
    {
        [Theory]
        [InlineData(Customer.LastName)]
        public void CustomerLastNameReturn(Customer.LastName?)
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