using Xunit;
using pipelines_dotnet_core_docker.Models;

namespace Tests 
{
    public class UnitTests
    {
        [Fact]
        public void ShouldPassOnly()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldFail()
        {
            Assert.NotEqual("some","any");
        }

        [Fact]
        public void ShouldGetFullName()
        {
            var customer = new CustomerModel
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Assert.Equal("John Doe", customer.GetFullName());
        }
    }
}