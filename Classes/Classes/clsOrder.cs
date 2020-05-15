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

        public string CustomerFirstName
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

        public string CustomerLastName
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
            clsDataConnection DB = new clsDataConnection();
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

        public string Valid(string CustomerFirstName, string CustomerLastName, string OrderDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (CustomerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            
            if (CustomerFirstName.Length > 15)
            {
                //record the error
                Error = Error + "First name must be less than 15 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            
            //is the town blank
            if (CustomerLastName.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (CustomerLastName.Length > 20)
            {
                //record the error
                Error = Error + "Last name be less than 15 characters : ";
            }
            //return any error messages
            return Error;
        }



        }



    }