using System;
using System.Collections.Generic;

namespace Classes
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
       
        public Int32 Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                ///space
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }



        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
            }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnOrder.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();


                DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
                DB.AddParameter("@CustomerFirstName", mThisOrder.CustomerFirstName);
                DB.AddParameter("@CustomerLastName", mThisOrder.CustomerLastName);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@Active", mThisOrder.Active);
                return DB.Execute("sproc_tblOrder_Insert");
            
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("dbo.sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@CustomerFirstName", mThisOrder.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisOrder.CustomerLastName);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.Execute("sproc_tblOrder_Update");

        }

        public void ReportByCustomerLastName(string CustomerLastName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerLastName", CustomerLastName);
            DB.Execute("sproc_tblOrder_FilterByCustomerLastName");
            PopulateArray(DB);
        }
    }
       
    }

