using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductForm : System.Web.UI.Page
{
    Int32 ProductNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
        if(IsPostBack == false)
        {
            if(ProductNo != -1)
            {
                DisplayProduct();
            }
        }
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
            AProduct.ProductNo = ProductNo;
            AProduct.ProductName = ProductName;
            AProduct.ProductDescription = ProductDescription;
            AProduct.UnitPrice = Convert.ToInt32(UnitPrice);
            AProduct.StockAmount = Convert.ToInt32(StockAmount);
            AProduct.DiscountPercentage = Convert.ToDouble(DiscountPercentage);
            AProduct.Active = Active.Checked;
            clsProductCollection Products = new clsProductCollection();

            if(ProductNo == -1)
            {
                Products.ThisProduct = AProduct;
                Products.Add();
            }
            else
            {
                Products.ThisProduct.Find(ProductNo);
                Products.ThisProduct = AProduct;
                Products.Update();
            }
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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

    void DisplayProduct()
    {
        clsProductCollection ProductBook = new clsProductCollection();
        ProductBook.ThisProduct.Find(ProductNo);
        //display data from product object in the form for editing.
        txtProductNo.Text = ProductBook.ThisProduct.ProductNo.ToString();
        txtProductName.Text = ProductBook.ThisProduct.ProductName;
        txtProductDescription.Text = ProductBook.ThisProduct.ProductDescription;
        txtUnitPrice.Text = ProductBook.ThisProduct.UnitPrice.ToString();
        txtStockAmount.Text = ProductBook.ThisProduct.StockAmount.ToString();
        txtDiscountPercentage.Text = ProductBook.ThisProduct.DiscountPercentage.ToString();
        Active.Text = ProductBook.ThisProduct.Active.ToString();
    }

}