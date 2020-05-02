using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        Classes.clsProductCollection Products = new Classes.clsProductCollection();
        ProductListBox.DataSource = Products.ProductList;
        ProductListBox.DataValueField = "ProductNo";
        ProductListBox.DataTextField = "ProductName";
        ProductListBox.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNo"] = -1;
        Response.Redirect("ProductForm.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if(ProductListBox.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(ProductListBox.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("DeleteProduct.aspx");
        }
        else
        {
            lblError.Text = "Please select a product to delete.";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if(ProductListBox.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(ProductListBox.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("ProductForm.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        Products.ReportByProductName(txtNameSearch.Text);
        ProductListBox.DataSource = Products.ProductList;
        ProductListBox.DataValueField = "ProductNo";
        ProductListBox.DataTextField = "ProductName";
        ProductListBox.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        Products.ReportByProductName("");
        txtNameSearch.Text = "";
        ProductListBox.DataSource = Products.ProductList;
        ProductListBox.DataValueField = "ProductNo";
        ProductListBox.DataTextField = "ProductName";
        ProductListBox.DataBind();

    }
}