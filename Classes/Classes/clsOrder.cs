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
            
            mOrderNo = 21;
            mCustomerNo = 3;
            mCustomerFirstName = "Test first name";
            mCustomerLastName = "Test last name";
            mOrderDate = Convert.ToDateTime("16/9/2015");
            mActive = true;
            return true;
        }
    }
}

    

