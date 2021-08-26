using NUnit.Framework;
using Project4;
using System.Collections.Generic;

namespace ProjectTest
{
    public class Tests
    {


        //[Test]
        //public void TestToStringIsWhatIExpect()
        //{
        //    var list = new List<char>();
        //    list.Add('c');
        //    list.Add('b');
        //    Assert.AreEqual("cb", list.ToString());
            
        //}

        [Test]
        public void TestPrime()
        {
            Program p = new Program();
            Assert.IsTrue(p.IsPrime(333));
        }
        [Test]
        public void TestPrimeFalse()
        {
            Program p = new Program();
            Assert.IsFalse(p.IsPrime(303));
        }
        [Test]
        public void TestPalidrome()
        {
            Program p = new Program();
            Assert.IsTrue(p.IsPalidrome(9009));
        }
        [Test]
        public void TestPalidromeFalse()
        {
            Program p = new Program();
            Assert.IsFalse(p.IsPalidrome(9000));
        }
    }
}