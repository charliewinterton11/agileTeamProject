using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void OK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        AProduct.ProductName = txtProductName.Text;
        AProduct.ProductDescription = txtProductDescription.Text;
        AProduct.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
        AProduct.StockAmount = Convert.ToInt32(txtStockAmount.Text);
        AProduct.Active = Active.Checked;


        Session["AProduct"] = AProduct;
        Response.Redirect("ProductViewer.aspx");
    }
}