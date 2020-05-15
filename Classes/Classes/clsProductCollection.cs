using System;
using System.Collections.Generic;

namespace Classes
{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();
        clsProduct mThisProduct = new clsProduct();

        public List<clsProduct> ProductList 
        {
            get
            {
                return mProductList;
            }

            set
            {
                mProductList = value;
            }
        }

        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {

            }
        }

        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public clsProductCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblProduct_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockAmount", mThisProduct.StockAmount);
            DB.AddParameter("@UnitPrice", mThisProduct.UnitPrice);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@DiscountPercentage", mThisProduct.DiscountPercentage);
            DB.AddParameter("@DiscountActive", mThisProduct.DiscountActive);

            return DB.Execute("dbo.sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            DB.Execute("dbo.sproc_tblProduct_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            DB.AddParameter("@StockAmount", mThisProduct.StockAmount);
            DB.AddParameter("@UnitPrice", mThisProduct.UnitPrice);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@DiscountPercentage", mThisProduct.DiscountPercentage);
            DB.AddParameter("@DiscountActive", mThisProduct.DiscountActive);

            DB.Execute("dbo.sproc_tblProduct_Update");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("dbo.sproc_tblProduct_FilterByProductName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mProductList = new List<clsProduct>();
            while (Index < RecordCount)
            {
                clsProduct Product = new clsProduct();
                Product.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Product.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                Product.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                Product.UnitPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["UnitPrice"]);
                Product.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                Product.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                Product.DiscountPercentage = Convert.ToInt32(DB.DataTable.Rows[Index]["DiscountPercentage"]);
                Product.DiscountActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["DiscountActive"]);
                mProductList.Add(Product);
                Index++;
            }
        }
    }
}