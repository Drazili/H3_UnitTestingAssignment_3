using NUnit.Framework;
using UnitTestingAssignment_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment_3.Tests
{
    [TestFixture()]
    public class WheelTests
    {
        Wheel testWheel;

        [SetUp]
        public void SetUp()
        {
            testWheel = new Wheel("Brand", "Name", 100, 5);
        }

        [Test()]
        public void GetTest()
        {
            Assert.That(testWheel.GetBrand(), Is.EqualTo("Brand"));
            Assert.That(testWheel.GetName(), Is.EqualTo("Name"));
            Assert.That(testWheel.GetRadius(), Is.EqualTo(100));
            Assert.That(testWheel.GetWidth(), Is.EqualTo(5));
        }
        [Test()]
        public void SetBrandTest()
        {
            testWheel.SetBrand("Brand 2");
            Assert.That(testWheel.GetBrand(), Is.EqualTo("Brand 2"));
        }
        [Test()]
        public void SetNameTest()
        {
            testWheel.SetName("Name 2");
            Assert.That(testWheel.GetName(), Is.EqualTo("Name 2"));
        }
        [Test()]
        public void SetRadiusTest()
        {
            testWheel.SetRadius(200);
            Assert.That(testWheel.GetRadius(), Is.EqualTo(200));
        }
        [Test()]
        public void SetWidthTest()
        {
            testWheel.SetWidth(10);
            Assert.That(testWheel.GetWidth(), Is.EqualTo(10));
        }
    }
}