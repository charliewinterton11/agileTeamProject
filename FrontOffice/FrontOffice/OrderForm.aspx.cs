using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderForm : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            if(OrderNo != -1)
            {
                DisplayOrder();
            }
        }
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        
        String CustomerNo = txtCustomerNo.Text;
        String CustomerFirstName = txtCustomerFirstName.Text;
        String CustomerLastName = txtCustomerLastName.Text;
        String OrderDate = txtOrderDate.Text;
        String Error = "";
        Error = AnOrder.Valid(CustomerFirstName, CustomerLastName, OrderDate);
        if (Error == "")
        {
            AnOrder.OrderNo = Convert.ToInt32(OrderNo);
            AnOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AnOrder.CustomerFirstName = CustomerFirstName;
            AnOrder.CustomerLastName = CustomerLastName;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            clsOrderCollection OrderList = new clsOrderCollection();
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", AnOrder.CustomerNo);
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            if (DB.Count == 1 && OrderNo == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
                Response.Redirect("OrderList.aspx");
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
           
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void FindBtn_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AnOrder.Find(OrderNo);
        if (Found == true)
        {
            txtCustomerFirstName.Text = AnOrder.CustomerFirstName;
            txtCustomerLastName.Text = AnOrder.CustomerLastName;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
        }

    }

    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNo);
        txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        txtCustomerNo.Text = OrderBook.ThisOrder.CustomerNo.ToString();
        txtCustomerFirstName.Text = OrderBook.ThisOrder.CustomerFirstName;
        txtCustomerLastName.Text = OrderBook.ThisOrder.CustomerLastName;
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        Active.Checked = OrderBook.ThisOrder.Active;

    }

    
}

