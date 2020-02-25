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
        public bool Find(int StockAmount)
        {
            DataConnection DB = new DataConnection();
            DB.AddParameter("@ProductNo", ProductNo);
            DB.Execute("sproc_tblProduct_FilterByProductNo");
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

    }
}
