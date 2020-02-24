using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        AProduct = (clsProduct)Session["AProduct"];
        Response.Write(AProduct.ProductName);
        Response.Write(AProduct.ProductDescription);
        Response.Write(AProduct.UnitPrice);
        Response.Write(AProduct.StockAmount);
        Response.Write(AProduct.Active);



    }
}