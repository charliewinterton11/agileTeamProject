using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing
{
    [TestClass]
    public class tstOrder
    {
        String CustomerFirstName = "Pual";
        String CustomerLastName = "Noodle";
        String OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder Order = new clsOrder();
            Assert.IsNotNull(Order);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }


        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderNo = TestData;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerNo = TestData;
            Assert.AreEqual(AnOrder.CustomerNo, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Today;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Bob";
            AnOrder.CustomerFirstName = TestData;
            Assert.AreEqual(AnOrder.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Ross";
            AnOrder.CustomerLastName = TestData;
            Assert.AreEqual(AnOrder.CustomerLastName, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
             
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.CustomerFirstName != "Joe")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
             
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.CustomerLastName != "Bloggs")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestCustomerNoFound()
        {
             
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.CustomerNo != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void TestOrderDateFound()
        {
             
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderDate != Convert.ToDateTime("15/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
             
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string  CustomerFirstName = "";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "a";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "aa";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(14, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(15, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(6, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "a";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "aa";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(14, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(15, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "";
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(6, 'a');
            Error = anOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
            Assert.AreNotEqual(Error, "");
        }


    }

}
