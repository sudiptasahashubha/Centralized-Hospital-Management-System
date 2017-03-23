<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="Hospital_Management_Database.Doctor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-family: OneSlot;
            color: #FF3300;
            text-align: center;
        }
        .auto-style2 {
            margin-left: 1px;
        }
        .auto-style3 {}
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            margin-left: 265px;
            margin-right: 0px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <span class="auto-style4">Search Doctor Using<br />
        </span>
        <br />
        <br />
        Doctor ID&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="27px" Width="126px">
            <asp:ListItem Value="-1">Choose ID</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Height="38px" OnClick="Button1_Click" Text="Submit" Width="94px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" CssClass="auto-style3" Height="41px" OnClick="Button2_Click" Text="Show All" Width="99px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CaptionAlign="Top" CssClass="auto-style5" Height="28px" Visible="False" Width="513px">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
