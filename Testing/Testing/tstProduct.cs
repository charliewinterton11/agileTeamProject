﻿using System;
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
        public void DiscountAmountPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Double TestData = 20;
            AProduct.DiscountAmount = TestData;
            Assert.AreEqual(AProduct.DiscountAmount, TestData);
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
            if(AProduct.StockAmount != 13)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }

}
