<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUp.aspx.cs" Inherits="Hospital_Management_Database.EmployeeUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #FF0000;
            font-size: x-large;
            font-family: OneSlot;
        }
        .auto-style2 {
            font-family: oneSlot;
            font-size: large;
        }
        .auto-style4 {}
        .auto-style5 {}
        .auto-style6 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        Employee Id&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style5" Height="19px" Width="152px">
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;New Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;New Job-Field&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style4" Height="19px" Width="156px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>Clerk</asp:ListItem>
            <asp:ListItem>Nurse</asp:ListItem>
            <asp:ListItem>Receptionist</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        New NID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;New Contact No <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;New Salary&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#339933" CssClass="auto-style6" Font-Bold="True" ForeColor="White" Height="29px" Width="76px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
