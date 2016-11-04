<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPageSeperated.aspx.cs" Inherits="WebPageSeperated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Welcome to prac1</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
&nbsp;<asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;
            <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="=Base10:"></asp:Label>
            <asp:TextBox ID="BaseTenResult" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="=Base2:"></asp:Label>
            <asp:TextBox ID="BaseTwoResult" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Count" runat="server" OnClick="Count_Click" Text="Count" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Num of 0:"></asp:Label>
            <asp:TextBox ID="NumOfZero" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Num of 1:"></asp:Label>
            <asp:TextBox ID="NumOfOne" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
