<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorIn.aspx.cs" Inherits="Hospital_Management_Database.DoctorIn" %>

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
        .auto-style5 {}
    </style>
   
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        Doctor ID&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Doctor Name&nbsp; &nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sex&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style3" Height="26px" Width="142px">
            <asp:ListItem Value="0">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        NID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Contact No&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" CssClass="auto-style4" Height="20px" Width="150px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Monthly Salary&nbsp; <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style5" Height="17px" Width="150px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Specialized Field&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="-1">Choose</asp:ListItem>
            <asp:ListItem Value="0">Medicine</asp:ListItem>
            <asp:ListItem Value="1">Heart Disease</asp:ListItem>
            <asp:ListItem Value="2">Surgery</asp:ListItem>
            <asp:ListItem Value="3">Neurology</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="31px" OnClick="Button1_Click" Text="Submit" Width="75px" BackColor="#006600" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
