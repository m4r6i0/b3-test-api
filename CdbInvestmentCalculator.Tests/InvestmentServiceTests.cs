using CdbInvestmentCalculator.Api.Models;
using CdbInvestmentCalculator.Api.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CdbInvestmentCalculator.Tests
{
    [TestClass]
    public class InvestmentServiceTests
    {
        [TestMethod]
        public void CalculateCdb_ValidInput_ReturnsCorrectGrossAndNetAmount()
        {
            // Arrange
            var service = new InvestmentService();
            var request = new InvestmentRequest { InitialAmount = 1000, Months = 12 };

            // Act
            var result = service.CalculateCdb(request);

            // Assert
            Assert.IsTrue(result.GrossAmount > 0);
            Assert.IsTrue(result.NetAmount > 0);
        }

        [TestMethod]
        public void CalculateCdb_SixMonths_CorrectTaxRate()
        {
            // Arrange
            var service = new InvestmentService();
            var request = new InvestmentRequest { InitialAmount = 1000, Months = 6 };

            // Act
            var result = service.CalculateCdb(request);

            // Assert
            var expectedNetAmount = result.GrossAmount - (result.GrossAmount - request.InitialAmount) * 0.225m;
            Assert.AreEqual(expectedNetAmount, result.NetAmount);
        }
    }
}
