<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordIn.aspx.cs" Inherits="Hospital_Management_Database.RecordIn" %>

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
            margin-right: 0px;
        }
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
        .auto-style6 {}
        .auto-style7 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        &nbsp;Patient Id&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server" CssClass="auto-style5" Height="26px" Width="129px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Doctor Id&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="24px" Width="123px">
        </asp:DropDownList>
        <br />
        <br />
        Disease Id&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style3" Height="21px" Width="126px">
        </asp:DropDownList>
        <br />
        <br />
        Medicine Id&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style4" Height="19px" Width="126px">
        </asp:DropDownList>
        <br />
        <br />
        Duration Id&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList5" runat="server" CssClass="auto-style6" Height="24px" Width="123px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" BackColor="#339933" CssClass="auto-style7" Font-Bold="True" ForeColor="White" Height="41px" Width="104px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView3" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
