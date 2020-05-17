using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{   [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerFirstName = "First Name";
            TestItem.CustomerLastName = "Last Name";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }



        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Active = true;
            TestOrder.OrderNo = 1;
            TestOrder.CustomerNo = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.CustomerFirstName = "First Name";
            TestOrder.CustomerLastName = "Last Name";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerFirstName = "First Name";
            TestItem.CustomerLastName = "Last Name";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 2;
            TestItem.Active = true;
            TestItem.OrderNo = 2;
            TestItem.CustomerNo = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerFirstName = "Joe";
            TestItem.CustomerLastName = "Bloggs";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerFirstName = "First";
            TestItem.CustomerLastName = "Last";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 2;
            TestItem.CustomerFirstName = "OldFirst";
            TestItem.CustomerLastName = "OldLast";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            TestItem.Active = false;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 4;
            TestItem.CustomerFirstName = "First";
            TestItem.CustomerFirstName = "Last";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByCustomerLastNameOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerLastName("XXXXX");
            Assert.AreEqual(0, FilteredOrders.Count);

        }
        [TestMethod]
        public void ReportByCustomerLastNameNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerLastName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);

        }

        [TestMethod]
        public void ReportByCustomerLastNameTestDataFound()
        {
            clsOrderCollection filteredOrders = new clsOrderCollection();
            Boolean OK = true;
            filteredOrders.ReportByCustomerLastName("Ingus");
            if (filteredOrders.Count == 2)
            {
                if (filteredOrders.OrderList[0].OrderNo != 1)
                {
                    OK = false;
                }

                if (filteredOrders.OrderList[1].OrderNo != 62)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    



    }

}
