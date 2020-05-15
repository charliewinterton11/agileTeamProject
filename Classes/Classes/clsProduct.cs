using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    public class clsProduct
    {
        //Fields, Properties
        private Int32 mProductNo;
        private String mProductName;
        private String mProductDescription;
        private double mUnitPrice;
        private bool mInStock;
        private Int32 mStockAmount;
        private Int32 mDiscountPercentage;
        private bool mDiscountActive;
        private bool mActive;

        public Int32 ProductNo
        {
            get
            {
                return mProductNo;
            }
            set
            {
                mProductNo = value;
            }
        }

        public String ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public String ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }
        public double UnitPrice
        {
            get
            {
                return mUnitPrice;

            }
            set
            {
                mUnitPrice = value;
            }
        }
        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        public int StockAmount
        {
            get
            {
                return mStockAmount;
            }
            set
            {
                mStockAmount = value;
            }
        }

        public int DiscountPercentage {
            get
            {
                return mDiscountPercentage;
            }
            set
            {
                mDiscountPercentage = value;
            }
        }

        public bool DiscountActive
        {
            get
            {
                return mDiscountActive;
            }
            set
            {
                mDiscountActive = value;
            }
        }


        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        //Methods
        public bool Find(int ProductNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", ProductNo);
            DB.Execute("dbo.sproc_tblProduct_FilterByProductNo");
            if(DB.Count == 1)
            {
                 mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                 mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                 mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                 mUnitPrice = Convert.ToDouble(DB.DataTable.Rows[0]["UnitPrice"]);
                 mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                 mStockAmount = Convert.ToInt32(DB.DataTable.Rows[0]["StockAmount"]);
                 mDiscountPercentage = Convert.ToInt32(DB.DataTable.Rows[0]["DiscountPercentage"]);
                 mDiscountActive = Convert.ToBoolean(DB.DataTable.Rows[0]["DiscountActive"]);
                 return true;
            }
            else
            {
                return false;
            }
          }

        public string Valid(string productName,
                            string productDescription,
                            string unitPrice,
                            string stockAmount,
                            string discountPercentage)
        {
            String Error = "";
            Regex regex = new Regex("^[a-zA-Z0-9 '.-]*$");
            double unitPriceParse = 0;
            int stockAmountParse = 0;
            int discountPercentageParse = 0;

            if (!regex.IsMatch(productName))
            {
                Error += "Product name contains special characters.";
            }

            if (!regex.IsMatch(productDescription))
            {
                Error += "Product description contains special characters.";
            }

            if (!Double.TryParse(unitPrice, out unitPriceParse))
            {
                Error += "Unit price contains special characters.";
            }

            if (!Int32.TryParse(stockAmount, out stockAmountParse))
            {
                Error += "Stock amount contains special characters.";
            }

            if (!Int32.TryParse(discountPercentage, out discountPercentageParse))
            {
                Error += "Discount percentage contains special characters.";
            }

            if (productName.Length == 0)
            {
                Error += "Product name is blank.";
            }

            if (productName.Length > 100)
            {
                Error += "Product name should be between 1 and 100 characters. ";
            }

            if (productDescription.Length > 100)
            {
                Error += "Product description should be between 0 and 100 characters. ";
            }

            if (string.IsNullOrEmpty(productDescription))
            {
                Error += "Product description is blank. ";
            }

            if (string.IsNullOrEmpty(unitPrice))
            {
                Error += "Unit price is blank.";
            }

            if (unitPriceParse < 0)
            {
                Error += "Unit price is negative. ";
            }

            if (unitPriceParse > 999999999)
            {
                Error += "Unit price should be between 0 and 999999999, to two decimal places.";
            }

            if (stockAmountParse< 0)
            {
                Error += "Stock amount is negative.";
            }

            if (string.IsNullOrEmpty(stockAmount))
            {
                Error += "Stock amount is blank.";
            }

            if (string.IsNullOrEmpty(discountPercentage))
            {
                Error += "Discount percentage is blank.";
            }

            if (discountPercentageParse > 100 || discountPercentageParse < 0)
            {
                Error += "Discount percentage should be between 0 and 100, to 2 decimal places.";
            }

            if (discountPercentageParse < 0)
            {
                Error += "Discount percentage should be between 0 and 100, to 2 decimal places.";
            }

            return Error;
        }

    }
}
