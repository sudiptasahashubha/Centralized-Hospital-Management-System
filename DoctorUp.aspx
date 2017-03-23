<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorUp.aspx.cs" Inherits="Hospital_Management_Database.DoctorUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            text-align: center;
            font-family: oneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
        .auto-style6 {
            font-family: oneSlot;
        }
        .auto-style7 {
            margin-left: 137px;
        }
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server">
    <div>
    
        Doctor Id&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style6" Height="20px" Width="122px">
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        New Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;
        New NID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" Width="122px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        New Contact No&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3" Height="22px" Width="159px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        New Monthly Salary&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style4" Height="22px" Width="163px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        New Specialized Feild
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style5" Height="24px" Width="178px">
            <asp:ListItem Value="0">Choose</asp:ListItem>
            <asp:ListItem Value="Medicine">Medicine</asp:ListItem>
            <asp:ListItem>Surgery</asp:ListItem>
            <asp:ListItem>Neurology</asp:ListItem>
            <asp:ListItem>Cardiology</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" BackColor="#339933" CssClass="auto-style7" Font-Bold="True" ForeColor="White" Height="39px" Width="94px" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
