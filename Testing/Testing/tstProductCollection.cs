using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace Testing
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection Products = new clsProductCollection();
            Assert.IsNotNull(Products);
        }

        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection Products = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestProduct = new clsProduct();
            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            TestList.Add(TestProduct);
            Products.ProductList = TestList;
            Assert.AreEqual(Products.ProductList, TestList);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection Products = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            Products.ThisProduct = TestProduct;
            Assert.AreEqual(Products.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductCollection Products = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestProduct = new clsProduct();
            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            TestList.Add(TestProduct);
            Products.ProductList = TestList;
            Assert.AreEqual(Products.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection Products = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;

            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            Products.ThisProduct = TestProduct;
            PrimaryKey = Products.Add();
            TestProduct.ProductNo = PrimaryKey;
            Assert.AreEqual(Products.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductCollection Products = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;

            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            Products.ThisProduct = TestProduct;
            PrimaryKey = Products.Add();
            TestProduct.ProductNo = PrimaryKey;
            Products.ThisProduct.Find(PrimaryKey);
            Products.Delete();
            Boolean Found = Products.ThisProduct.Find(PrimaryKey);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection Products = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;

            TestProduct.ProductName = "Metal Gear Ray Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
            TestProduct.UnitPrice = 90.00;
            TestProduct.InStock = true;
            TestProduct.StockAmount = 1;
            TestProduct.DiscountPercentage = 0;
            TestProduct.DiscountActive = false;

            Products.ThisProduct = TestProduct;
            PrimaryKey = Products.Add();
            TestProduct.ProductNo = PrimaryKey;

            TestProduct.ProductName = "Metal Gear Solid Snake Figure";
            TestProduct.ProductDescription = "A die-cast figurine of Solid Snake from Metal Gear Solid.";
            TestProduct.UnitPrice = 60.00;
            TestProduct.InStock = false;
            TestProduct.StockAmount = 0;
            TestProduct.DiscountPercentage = 20;
            TestProduct.DiscountActive = true;

            Products.ThisProduct = TestProduct;
            Products.Update();
            Products.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(Products.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsProductCollection Products = new clsProductCollection();
            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByProductName("");
            Assert.AreEqual(Products.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByProductName("abcdefg");
            Assert.AreEqual(0, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductNameFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            Boolean OK = true;
            FilteredProducts.ReportByProductName("abcdef");
            if(FilteredProducts.Count == 2)
            {
                if(FilteredProducts.ProductList[0].ProductNo != 37)
                {
                    OK = false;
                }
                if (FilteredProducts.ProductList[1].ProductNo != 38)
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
