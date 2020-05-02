using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private double mDiscountPercentage;
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

        public double DiscountPercentage {
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
                 mDiscountPercentage = Convert.ToDouble(DB.DataTable.Rows[0]["DiscountPercentage"]);
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
            int dcpint = 0;
            int upint = 0;
            int saint = 0;
            Int32.TryParse(discountPercentage, out dcpint);
            Int32.TryParse(unitPrice, out upint);
            Int32.TryParse(stockAmount, out saint);

            if (productName.Length == 0)
            {
                Error = Error + "Product name is blank: ";
            }

            if (productName.Length > 100)
            {
                Error = Error + "Product name should be between 1 and 100 characters. ";
            }

            if (productDescription.Length > 100)
            {
                Error = Error + "Product description should be between 0 and 100 characters. ";
            }

            if (productDescription.Length == 0)
            {
                Error = Error + "Product description is blank. ";
            }

            if (unitPrice.Length == 0)
            {
                Error = Error + "Unit price is blank. ";
            }

            if (upint < 0)
            {
                Error = Error + "Unit price should not be negative. ";
            }

            if (upint > 999999999)
            {
                Error = Error + "Unit price should be between 0 and 999999999, to two decimal places. ";
            }

            if (saint < 0)
            {
                Error = Error + "Stock amount should not be negative. ";
            }

            if (stockAmount.Length == 0)
            {
                Error = Error + "Stock amount is blank. ";
            }

            if (discountPercentage.Length == 0)
            {
                Error = Error + "Discount percentage is blank. ";
            }

            if (dcpint > 100)
            {
                Error = Error + "Discount percentage should be between 0 and 100, to 2 decimal places. ";
            }

            if (dcpint < 0)
            {
                Error = Error + "Discount percentage should be between 0 and 100, to 2 decimal places. ";
            }

            return Error;
        }

    }
}
