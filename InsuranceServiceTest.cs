using Assign_TestingS00165540;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_TestingS00165540
{

    [TestFixture]
    public class InsuranceServiceTests
    {
        [Test]
        public void CalcPremium_RuralBetween18And30_Returns5()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(25, "rural");

            // Assert
            Assert.AreEqual(5.0, premium);
        }

        [Test]
        public void CalcPremium_Rural31Plus_Returns3point5()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(35, "rural");

            // Assert
            Assert.AreEqual(2.5, premium);
        }

        [Test]
        public void CalcPremium_UrbanBetween18And35_Returns6()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(25, "urban");

            // Assert
            Assert.AreEqual(6.0, premium);
        }

        [Test]
        public void CalcPremium_Urban36Plus_Returns5()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(40, "urban");

            // Assert
            Assert.AreEqual(5.0, premium);
        }

        [Test]
        public void CalcPremium_50Plus_ReturnsDiscountedPremium()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(0.8); // 20% discount
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(50, "rural");

            // Assert
            Assert.AreEqual(2.0, premium); // discount applied to premium of 5.0
        }

        [Test]
        public void CalcPremium_RuralLessThan18_Returns0()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(15, "rural");

            // Assert
            Assert.AreEqual(0.0, premium);
        }

        [Test]
        public void CalcPremium_UrbanLessThan18_Returns0()
        {
            // Arrange
            var discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount()).Returns(1.0);
            var insuranceService = new InsuranceService(discountService.Object);

            // Act
            double premium = insuranceService.CalcPremium(17, "urban");

            // Assert
            Assert.AreEqual(0.0, premium);
        }

    }
}