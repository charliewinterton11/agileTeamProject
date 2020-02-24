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
        private Int32 mStockAmount;


        public bool Active { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
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
        public double DiscountAmount { get; set; }

        //Methods
        public bool Find(int StockAmount)
        {
            mStockAmount = 13;
            return true;
        }
    }
}
