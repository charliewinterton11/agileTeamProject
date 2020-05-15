<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset=”utf-8″>
    <meta http-equiv=”X-UA-Compatible” content=”IE=edge”>
    <meta name=”viewport” content=”width=device-width, initial-scale=1″>
    <link rel="stylesheet" href="css/bootstrap.css">
    <title>Product List</title>
</head>
<body>          
    <form id="form1" runat="server">
    <div class = "col-6 padding">
        <div class = "title">
            <asp:Label ID="lblTitle" runat="server" style="font-size: large">Product List</asp:label>
        </div>
        <div>
            <asp:ListBox ID="ProductListBox" runat="server" Height="244px" Width="441px"></asp:ListBox>
        </div>
        <div id="button-bar">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <div class ="error">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
        </div>
        <div>
            <asp:Label ID="lblSearchMessage" runat="server" Text="Search by Product Name:"></asp:Label>
            <asp:TextBox ID="txtNameSearch" runat="server" TextMode="Search"></asp:TextBox>
        </div>
        <div id="search-button-bar" class="text-right">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </div>
    </div>
    </form>    
</body>
</html>
