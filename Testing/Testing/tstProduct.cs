using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class tstProduct
    {
        //Test data
        string ProductName = "Metal Gear Ray Figure";
        string ProductDescription = "A die-cast figurine of Metal Gear Ray from Metal Gear Solid 2.";
        string UnitPrice = "90.00";
        string StockAmount = "1";
        string DiscountPercentage = "0";


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
            Assert.AreEqual(AProduct.ProductNo, TestData);
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
            int TestData = 20;
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
            Int32 ProductNo = 32;
            Found = AProduct.Find(ProductNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockAmountFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 32;
            Found = AProduct.Find(ProductNo);
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
            Int32 ProductNo = 32;
            Found = AProduct.Find(ProductNo);
            if(AProduct.ProductNo != 32)
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
            Int32 ProductNo = 32;
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
            Int32 ProductNo = 32;
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
            Int32 ProductNo = 32;
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
            Int32 ProductNo = 32;
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
            Int32 ProductNo = 32;
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
            Int32 ProductNo = 32;
            Found = AProduct.Find(ProductNo);
            if (AProduct.DiscountActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct aProduct = new clsProduct();
            String Error = "";
            Error = aProduct.Valid(ProductName,
                                   ProductDescription,
                                   UnitPrice,
                                   StockAmount,
                                   DiscountPercentage);
         }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "a";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "aa";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(99, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(101, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(500, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(100, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(101, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(50, 'a');
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = (Int16.MaxValue/2).ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = (Int16.MaxValue-1).ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "";
            UnitPrice = Int16.MaxValue.ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "-1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
       }

        [TestMethod]
        public void UnitPriceMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "0";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string UnitPrice = "1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string StockAmount = (Int16.MaxValue/2).ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            
            string StockAmount = (Int16.MaxValue-1).ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string StockAmount = Int16.MaxValue.ToString();
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string StockAmount = "-1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string StockAmount = "0";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAmountMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string StockAmount = "1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "50";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "99";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "100";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "-1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "0";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentageMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string DiscountPercentage = "1";
            Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
            Assert.AreEqual(Error, "");
        }

    }
}

