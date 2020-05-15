using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clsOrder AnOrder = new clsOrder();
        //AnOrder = (clsOrder)Session["AnOrder"];
        //Response.Write(AnOrder.CustomerLastName);
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.CustomerFirstName = txtCustomerFirstName.Text;
        AnOrder.CustomerLastName = txtCustomerLastName.Text;
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate);
        Session["AnOrder"] = AnOrder;
        Response.Write("OrderViewer.aspx");
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

    
}

