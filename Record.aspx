<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Record.aspx.cs" Inherits="Hospital_Management_Database.Record" %>

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
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Search Using <br />
        <br />
        Duration Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style3" Height="28px" Width="139px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" CssClass="auto-style4" Height="34px" Text="Submit" Width="78px" OnClick="Button1_Click" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" CssClass="auto-style4" Height="34px" Text="Show All" Width="78px" OnClick="Button2_Click" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style5" Width="643px">
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
