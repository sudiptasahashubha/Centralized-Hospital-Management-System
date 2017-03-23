<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Hospital_Management_Database.Employee" %>

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
        .auto-style5 {
            margin-left: 75px;
        }
        .auto-style6 {
            margin-left: 72px;
        }
        .auto-style7 {
            margin-left: 155px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        Search Employee Using<br />
        <br />
        <br />
        Employee ID
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="28px" Width="101px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="34px" OnClick="Button1_Click" Text="Submit" Width="82px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style6" Height="35px" OnClick="Button2_Click" Text="Show All" Width="80px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style7" Width="765px">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
