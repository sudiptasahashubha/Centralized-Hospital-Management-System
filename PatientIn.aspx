<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientIn.aspx.cs" Inherits="Hospital_Management_Database.PatientIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: OneSlot;
            font-size: x-large;
        }
        .auto-style2 {
            margin-bottom: 0px;
        }
        .auto-style3 {
            margin-left: 55px;
        }
        .auto-style4 {
            text-align: center;
            color: #FF0000;
        }
        .auto-style5 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div class="auto-style4">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        Patient ID&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Height="16px" Width="123px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="18px" Width="131px"></asp:TextBox>
        <br />
        <br />
        Sex<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style3" Height="19px" Width="119px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Contact&nbsp; No&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" BackColor="#339933" CssClass="auto-style5" Font-Bold="True" ForeColor="White" Height="39px" Width="89px" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
