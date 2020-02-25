using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct order = new clsProduct();
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void PropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = true;
            AProduct.Active = TestData;
            Assert.AreEqual(AProduct.Active, TestData);
        }

        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 5;
            AProduct.ProductNo = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Antique Paint Brush";
            AProduct.ProductName = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Wooden art utensil";
            AProduct.ProductDescription = TestData;
            Assert.AreEqual(AProduct.ProductDescription, TestData);
        }

        [TestMethod]
        public void UnitPricePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Double TestData = 5.50;
            AProduct.UnitPrice = TestData;
            Assert.AreEqual(AProduct.UnitPrice, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = false;
            AProduct.InStock = TestData;
            Assert.AreEqual(AProduct.InStock, TestData);
        }

        [TestMethod]
        public void StockAmountPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 3;
            AProduct.StockAmount = TestData;
            Assert.AreEqual(AProduct.StockAmount, TestData);
        }

        [TestMethod]
        public void DiscountPercentagePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Double TestData = 20;
            AProduct.DiscountPercentage = TestData;
            Assert.AreEqual(AProduct.DiscountPercentage, TestData);
        }

        [TestMethod]
        public void DiscountActivePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = false;
            AProduct.DiscountActive = TestData;
            Assert.AreEqual(AProduct.InStock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 StockAmount = 3;
            Found = AProduct.Find(StockAmount);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockAmountFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockAmount = 13;
            Found = AProduct.Find(StockAmount);
            if (AProduct.StockAmount != 13)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestProductNoFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if(AProduct.StockAmount != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.ProductName != "Sega Megadrive")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.ProductDescription != "Retro games console")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.UnitPrice != 32.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountPercentageFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.DiscountPercentage != 25)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountActiveFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 5;
            Found = AProduct.Find(ProductNo);
            if (AProduct.DiscountActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

}

