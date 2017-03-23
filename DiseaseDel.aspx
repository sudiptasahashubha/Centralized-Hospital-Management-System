<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseDel.aspx.cs" Inherits="Hospital_Management_Database.DiseaseDel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: oneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Delete Disease Whose<br />
        <br />
        Disease Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Height="19px" Width="135px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="41px" OnClick="Button1_Click" Text="Delete" Width="71px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Height="37px" OnClick="Button2_Click" Text="Delete All" Width="89px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
