using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        { 
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        

        
        }
    }
}
