using ConcreteClassLib;
using NUnit.Framework.Legacy;
using static ConcreteClassLib.Class1;

namespace TestProjectTriangle
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewResidentialTest1()
        {

            double squareMeters = 10;

            double expected = 300;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.NewResidential,squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void NewResidentialTest2()
        {

            double squareMeters = 0;

            double expected = 0;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.NewResidential, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void NewResidentialTest3()
        {

            double squareMeters = 400;

            double expected = 12000;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.NewResidential, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ExistingResidentialTest4()
        {

            double squareMeters = 10;

            double expected = 250;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.ExistingResidential, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ExistingResidentialTest5()
        {

            double squareMeters = 0;

            double expected = 0;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.ExistingResidential, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ExistingResidentialTest6()
        {
            double squareMeters = 400;

            double expected = 10000;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.ExistingResidential, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }


        [Test]
        public void CommercialTest7()
        {
            double squareMeters = 10;

            double expected = 200;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void CommercialTest8()
        {

            double squareMeters = 0;

            double expected = 0;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void CommerciaTest9()
        {
            double squareMeters = 400;

            double expected = 8000;

            //Act
            double actual = Class1.ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, squareMeters);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

    }
}


