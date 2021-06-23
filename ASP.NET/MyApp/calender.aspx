<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender.aspx.cs" Inherits="MyApp.calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="WelcomeLbl" runat="server"></asp:Label>
            </h1>
            
            Select Player :-<br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Players</asp:ListItem>
                <asp:ListItem>Dhoni</asp:ListItem>
                <asp:ListItem>Kohli</asp:ListItem>
                <asp:ListItem>Sanju</asp:ListItem>
            </asp:DropDownList>
            
            <br />
            <br />
            <asp:Image ID="ImagePlayer" runat="server" Height="106px" />
            <br />
            <br />
            <asp:Label ID="playerLbl" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="navLabel1" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
