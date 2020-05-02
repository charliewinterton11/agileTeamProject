using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteProduct : System.Web.UI.Page
{
    Int32 ProductNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsProductCollection ProductBook = new clsProductCollection();
        ProductBook.ThisProduct.Find(ProductNo);
        ProductBook.Delete();
        Response.Redirect("ProductList.aspx");
    }
}