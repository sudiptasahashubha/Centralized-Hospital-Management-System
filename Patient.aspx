<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="Hospital_Management_Database.Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style3 {
            font-family: OneSlot;
            color: #FF0000;
            text-align: center;
            font-size: x-large;
        }
        .auto-style4 {}
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</head>
<body class="auto-style3">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Search Patient using <br />
        <br />
        Patient ID&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" Height="28px" Width="152px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="SubmitPatient" runat="server" CssClass="auto-style4" Height="37px" OnClick="SubmitPatient_Click" Text="Submit" Width="72px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        &nbsp;
        <asp:Button ID="SubmitPatient0" runat="server" CssClass="auto-style4" Height="38px" OnClick="SubmitPatient2_Click" Text="Show All" Width="73px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style5" Visible="False" Width="370px">
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
