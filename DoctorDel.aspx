<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorDel.aspx.cs" Inherits="Hospital_Management_Database.DoctorDel" %>

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
        Delete Doctor Whose<br />
        <br />
        Doctor Id
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="22px" Width="87px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" CssClass="auto-style3" Height="38px" OnClick="Button1_Click" Text="Delete" Width="80px" BackColor="#339933" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style4" Height="36px" OnClick="Button2_Click" Text="Delete All" Width="85px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
    
    </div>
    </form>
</body>
</html>
