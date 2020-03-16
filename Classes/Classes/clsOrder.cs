using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes;

namespace Classes
{


    public class clsOrder
    {


        private Int32 mOrderNo;

        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }


        private Int32 mCustomerNo;

        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }


        private string mCustomerFirstName;

        public string customerFirstName
        {
            get
            {
                return mCustomerFirstName;
            }
            set
            {
                mCustomerFirstName = value;
            }
        }



        private string mCustomerLastName;

        public string customerLastName
        {
            get
            {
                return mCustomerLastName;
            }
            set
            {
                mCustomerLastName = value;
            }
        }



        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }


        private Boolean mActive;

        public Boolean Active
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

        public bool Find(int OrderNo)
        {
            DataConnection DB = new DataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    

