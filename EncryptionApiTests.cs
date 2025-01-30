using Xunit;
using EncryptionApi.Services;

namespace EncryptionApi.Tests
{
    public class EncryptionServiceTests
    {
        private readonly EncryptionService _service;    
        public EncryptionServiceTests()
        {
            _service = new EncryptionService();
        }

        [Fact]
        public void EncryptToRovarspraket_ShouldEncrypt()
        {
            //Arrange
            string input = "hej";
            string expected = "hohejoj";

            //Act
            string result = _service.EncryptToRovarspraket(input);

            //Assert
            Assert.Equal(expected, result);

        }
        
        [Fact]
        public void DecryptFromRovarspraket_ShouldDekrypt()
        {
            //Arrange
            string input = "hohejoj";
            string expected = "hej";

            //Act
            string result = _service.DecryptFromRovarspraket(input);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}
