<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicine.aspx.cs" Inherits="Hospital_Management_Database.Medicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: OneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style5 {}
        .auto-style6 {}
        .auto-style7 {
            margin-left: 334px;
        }
        .auto-style8 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style2">Search Medicine Using</span><br />
        <br />
        Medicine Name&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style6" Height="27px" Width="136px">
        </asp:DropDownList>
        &nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="34px" OnClick="Button1_Click" Text="Submit" Width="71px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style8" Height="35px" OnClick="Button2_Click" Text="Show All" Width="82px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style7" Width="482px">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
