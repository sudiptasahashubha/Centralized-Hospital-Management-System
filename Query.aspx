<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="Hospital_Management_Database.Query" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-weight: 700;
            background-color: #FFFFFF;
            font-size: x-large;
        }
        #form1 {
            background-color: #FFFFFF;
        }
        .align-center {
            color: #CCFFCC;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {
            color: #FF0000;
            font-family: oneSlot;
            font-size: x-large;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <h3 class="auto-style5">What Do You Want To Know About </h3>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Doctor" Height="36px" Width="72px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" CssClass="auto-style2" Height="36px" OnClick="Button7_Click" Text="Speciality wise Doctor" Width="162px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Patient" Height="38px" Width="74px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Medicine" Height="38px" Width="85px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Disease" Height="36px" Width="84px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Record" Height="38px" Width="81px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" CssClass="auto-style4" Height="36px" OnClick="Button9_Click" Text="Search Doctor's Patients" Width="167px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Employees" Width="144px" Height="38px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" CssClass="auto-style3" Height="35px" OnClick="Button8_Click" Text="Job-Field Wise Employees" Width="184px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    <div>
    
    </div>
    </form>
</body>
</html>
