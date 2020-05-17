<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 454px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 425px; width: 405px"></asp:ListBox>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 103px; top: 453px; position: absolute" Text="Delete" />
        
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 599px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 58px; top: 454px; position: absolute" Text="Edit" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 509px; position: absolute" Text="Enter a customer's last name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 197px; top: 509px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; top: 544px; position: absolute; left: 80px" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 144px; top: 544px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
