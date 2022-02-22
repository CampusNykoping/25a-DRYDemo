using DRYDemoLibrary;

using Xunit;

namespace DRYDemoLibraryTest
{
    public class DRYDemoLibraryTest
    {
        //[Fact]
        [Theory]
        [InlineData("Claes", "Engelin", "ClaeEnge")]
        [InlineData("Tim", "Engelin", "TimXEnge")]
        [InlineData("Tim", "En", "TimXEnXX")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName).Substring(0, expectedStart.Length);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}