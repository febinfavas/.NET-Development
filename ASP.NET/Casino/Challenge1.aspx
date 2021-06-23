<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge1.aspx.cs" Inherits="Casino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1"><strong><em>Casino Challenge</em></strong></span><br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="80px" Width="80px" />
            &nbsp;<asp:Image ID="Image2" runat="server" Height="80px" Width="80px" />
            &nbsp;<asp:Image ID="Image3" runat="server" Height="80px" Width="80px" />
            <br />
            <br />
            Your Bet:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pull The Lever!" />
            <br />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelPrice" runat="server"></asp:Label>
            <br />
            <br />
            1 Kohli&nbsp;&nbsp;&nbsp; :-&nbsp;&nbsp;&nbsp; x2 Your Bet<br />
            2 Kohli&nbsp;&nbsp;&nbsp; :-&nbsp;&nbsp;&nbsp; x3 Your Bet<br />
            3 Kohli&nbsp;&nbsp;&nbsp; :-&nbsp;&nbsp;&nbsp; x4 Your Bet<br />
            3 Dhoni&nbsp;&nbsp; :-&nbsp;&nbsp;&nbsp; JackPot!!!&nbsp; x100 Your Bet</div>
    </form>
</body>
</html>
