<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineDel.aspx.cs" Inherits="Hospital_Management_Database.MedicineDel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            text-align: center;
            font-family: oneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style4 {}
    </style>
</head>
<body class="auto-style3">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Delete Medicine Whose<br />
        <br />
        Medicine Name&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Height="19px" Width="113px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        &nbsp;
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="36px" OnClick="Button1_Click" Text="Delete" Width="68px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        &nbsp;<br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" Height="37px" OnClick="Button2_Click" Text="Delete All" Width="76px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
    
    </div>
    </form>
</body>
</html>
