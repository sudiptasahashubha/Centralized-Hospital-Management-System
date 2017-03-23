<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeIn.aspx.cs" Inherits="Hospital_Management_Database.EmployeeIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            margin-left: 16px;
        }
        .auto-style3 {
            text-align: center;
            color: #FF0000;
            font-family: oneSlot;
            font-size: x-large;
        }
        .auto-style4 {}
        .auto-style5 {
            margin-left: 71px;
        }
        .auto-style6 {
            margin-left: 51px;
        }
        .auto-style7 {
            margin-left: 48px;
        }
        .auto-style8 {
            margin-left: 35px;
        }
        .auto-style9 {}
    </style>
</head>
<body class="auto-style3">
    <form id="form1" runat="server">
    <div>
    
        <br />
        &nbsp;
        Employee Id&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Height="22px" Width="166px"></asp:TextBox>
        <br />
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="23px" Width="159px"></asp:TextBox>
        <br />
        <br />
        &nbsp;Job-Field&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Height="22px" Width="163px">
            <asp:ListItem>Clerk</asp:ListItem>
            <asp:ListItem>Nurse</asp:ListItem>
            <asp:ListItem>Receptionist</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Sex&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style5" Height="23px" Width="113px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        NID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style7"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        Contact No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style8"></asp:TextBox>
        <br />
        <br />
        Monthly Salary<asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style6" Height="22px" Width="136px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style9" Height="36px" OnClick="Button1_Click" Text="Submit" Width="94px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
