using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _01.HelloNameTest
{
    [TestClass]
    public class HelloNameTest
    {
        [TestMethod]
        public void StringTesting()
        {
            string name = "Ivan Ivanov";
            bool validName = HelloNameAndTest.Name(name);
            
            Assert.AreEqual(true, validName);
        }
    }
}
