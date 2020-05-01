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
        String ProductName = txtProductName.Text;
        String ProductDescription = txtProductDescription.Text;
        String UnitPrice = txtUnitPrice.Text;
        String StockAmount = txtStockAmount.Text;
        String DiscountPercentage = txtDiscountPercentage.Text;
        String Error = "";
        Error = AProduct.Valid(ProductName, ProductDescription, UnitPrice, StockAmount, DiscountPercentage);
        if(Error == "")
        {
            AProduct.ProductNo = Convert.ToInt32(txtProductNo.Text);
            AProduct.ProductName = txtProductName.Text;
            AProduct.ProductDescription = txtProductDescription.Text;
            AProduct.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            AProduct.StockAmount = Convert.ToInt32(txtStockAmount.Text);
            AProduct.DiscountPercentage = Convert.ToDouble(txtDiscountPercentage.Text);
            AProduct.Active = Active.Checked;

        }

        Session["AProduct"] = AProduct;
        Response.Redirect("ProductViewer.aspx");
    }

    protected void Find_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        Int32 ProductNo;
        Boolean Found = false;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        Found = AProduct.Find(ProductNo);
        if(Found == true)
        {
            txtProductName.Text = AProduct.ProductName;
            txtProductDescription.Text = AProduct.ProductDescription;
            txtUnitPrice.Text = AProduct.UnitPrice.ToString();
            txtStockAmount.Text = AProduct.StockAmount.ToString();
        }
    }
}