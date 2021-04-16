using NUnit.Framework;
using UnitTestingAssignment_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment_3.Tests
{
    [TestFixture()]
    public class InventoryTests
    {
        Inventory Inventory;
        List<Bicycle> testBicycles;
        Bicycle testBicycle1;
        Wheel[] testWheels1;
        Frame testFrame1;
        Bicycle testBicycle2;
        Wheel[] testWheels2;
        Frame testFrame2;

        [SetUp]
        public void SetUp()
        {
            testFrame1 = new Frame("Frame Brand", "Frame Name", "Frame Material");
            testWheels1 = new Wheel[2] { new Wheel("Wheel 1 Brand", "Wheel 1 Name", 111, 11), new Wheel("Wheel 2 Brand", "Wheel 2 Name", 222, 22) };
            testBicycle1 = new Bicycle(testWheels1, testFrame1, true, 100.00);
            testFrame2 = new Frame("Frame Brand", "Frame Name", "Frame Material");
            testWheels2 = new Wheel[2] { new Wheel("Wheel 3 Brand", "Wheel 3 Name", 333, 33), new Wheel("Wheel 4 Brand", "Wheel 4 Name", 333, 33) };
            testBicycle2 = new Bicycle(testWheels2, testFrame2, false, 199.99);
            testBicycles = new List<Bicycle> {testBicycle1, testBicycle2 };
            Inventory = new Inventory(testBicycles);
        }
        [Test()]
        public void AddTest()
        {
            var bicycle = new Bicycle(testWheels1, testFrame2, false, 69.420);
            Inventory.AddBicycle(bicycle);
            Assert.That(Inventory.GetBicycles()[2].GetPrice, Is.EqualTo(69.420));
        }
        [Test()]
        public void GetTest()
        {
            Assert.That(Inventory.GetBicycles().Count, Is.EqualTo(2));
        }
        [Test()]
        public void SetTest()
        {
            var bicycle = new Bicycle(testWheels1, testFrame2, false, 69.420);
            Assert.That(Inventory.GetBicycles()[0].GetPrice, Is.EqualTo(100.00));
            Inventory.SetBicycle(0, bicycle);
            Assert.That(Inventory.GetBicycles()[0].GetPrice, Is.EqualTo(69.420));
        }
        [Test()]
        public void DeleteTest()
        {
            var bicycle = new Bicycle(testWheels1, testFrame2, false, 69.420);
            Assert.That(Inventory.GetBicycles()[0].GetPrice, Is.EqualTo(100.00));
            Inventory.SetBicycle(0, bicycle);
            Assert.That(Inventory.GetBicycles()[0].GetPrice, Is.EqualTo(69.420));
            Inventory.DelBicycle(bicycle);
            Assert.That(Inventory.GetBicycles()[0].GetPrice, Is.EqualTo(199.99));
        }
    }
}