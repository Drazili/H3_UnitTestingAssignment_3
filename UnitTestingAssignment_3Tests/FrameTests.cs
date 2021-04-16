using NUnit.Framework;
using UnitTestingAssignment_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment_3.Tests
{
    [TestFixture()]
    public class FrameTests
    {
        Frame testFrame;

        [SetUp]
        public void SetUp()
        {
            testFrame = new Frame("Brand", "Name", "Material");
        }

        [Test()]
        public void GetTest()
        {
            Assert.That(testFrame.GetBrand(), Is.EqualTo("Brand"));
            Assert.That(testFrame.GetName(), Is.EqualTo("Name"));
            Assert.That(testFrame.GetMaterial(), Is.EqualTo("Material"));
        }
        [Test()]
        public void SetBrandTest()
        {
            testFrame.SetBrand("Brand 2");
            Assert.That(testFrame.GetBrand(), Is.EqualTo("Brand 2"));
        }
        [Test()]
        public void SetNameTest()
        {
            testFrame.SetName("Name 2");
            Assert.That(testFrame.GetName(), Is.EqualTo("Name 2"));
        }
        [Test()]
        public void SetMaterialTest()
        {
            testFrame.SetMaterial("Material 2");
            Assert.That(testFrame.GetMaterial(), Is.EqualTo("Material 2"));
        }
    }
}