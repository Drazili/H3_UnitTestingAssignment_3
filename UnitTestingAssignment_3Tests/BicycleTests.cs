using NUnit.Framework;
using UnitTestingAssignment_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment_3.Tests
{
    [TestFixture()]
    public class BicycleTests
    {
        Bicycle testBicycle;
        Wheel[] testWheels;
        Frame testFrame;

        [SetUp]
        public void SetUp()
        {
            testFrame = new Frame("Frame Brand", "Frame Name", "Frame Material");
            testWheels = new Wheel[2] { new Wheel("Wheel 1 Brand", "Wheel 1 Name", 111, 11), new Wheel("Wheel 2 Brand", "Wheel 2 Name", 222, 22) };
            testBicycle = new Bicycle(testWheels, testFrame, true, 100.00);
        }

        [Test()]
        public void GetTest()
        {
            var wheels = testBicycle.GetWheels();
            Assert.That(wheels[0].GetBrand(), Is.EqualTo("Wheel 1 Brand"));
            Assert.That(wheels[1].GetName(), Is.EqualTo("Wheel 2 Name"));

            var frame = testBicycle.GetFrame();
            Assert.That(frame.GetMaterial(), Is.EqualTo("Frame Material"));

            Assert.That(testBicycle.GetElectric, Is.True);
            Assert.That(testBicycle.GetPrice, Is.EqualTo(100.00));
        }
        [Test()]
        public void SetWheelsTest()
        {
            var wheels = new Wheel[2] { new Wheel("Wheelie 1 Brand", "Wheelie 1 Name", 333, 33), new Wheel("Wheelie 2 Brand", "Wheelie 2 Name", 444, 44) };
            testBicycle.SetWheels(wheels);
            Assert.That(testBicycle.GetWheels()[0].GetBrand(), Is.EqualTo("Wheelie 1 Brand"));
        }
        [Test()]
        public void SetFrameTest()
        {
            var frame = new Frame("Frame Brand 2", "Frame Name 2", "Frame Material 2");
            testBicycle.SetFrame(frame);
            Assert.That(testBicycle.GetFrame().GetName(), Is.EqualTo("Frame Name 2"));
        }
        [Test()]
        public void SetElectricTest()
        {
            testBicycle.SetElectric(false);
            Assert.That(testBicycle.GetElectric, Is.False);
        }
        [Test()]
        public void SetPriceTest()
        {
            testBicycle.SetPrice(199.99);
            Assert.That(testBicycle.GetPrice, Is.EqualTo(199.99));
        }
    }
}