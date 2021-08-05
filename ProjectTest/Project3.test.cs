using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Project1test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIsPrime()
        {
            Project_Eulers.Project3 uut = new Project_Eulers.Project3();
            Assert.IsTrue(uut.IsPrime(5));
        }
        
        [Test]
        public void TestIsNotPrime()
        {
            Project_Eulers.Project3 uut = new Project_Eulers.Project3();
            Assert.IsFalse(uut.IsPrime(20));
        }
        
        [Test]
        public void TestEulerExample()
        {

            Project_Eulers.Project3 uut = new Project_Eulers.Project3();
            var factors = uut.factors(13195);
            Assert.AreEqual(4, factors.Count);
            Assert.Contains(5, factors);
            Assert.Contains(7, factors);
            Assert.Contains(13,factors); 
            Assert.Contains(29,factors);

        }
    }
}
