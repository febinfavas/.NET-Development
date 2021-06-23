<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Casino.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 669px;
            height: 450px;
            text-align: center;
            margin-left: 40px;
        }
        .auto-style2 {
            text-decoration: underline;
        }
        .auto-style3 {
            color: #003300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <h2><strong><span class="auto-style2"><span class="auto-style3">WELCOME TO THE CHALLENGE!!!</span></h2>
            <br />
            <br />
            </span>Click on the Images For Different Challenges</strong><br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="145px" ImageUrl="~/images/dhoni.jpg" Width="175px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="145px" ImageUrl="~/images/kohli.jpg" Width="175px" OnClick="ImageButton2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="145px" ImageUrl="~/images/sanju.jpg" Width="175px" OnClick="ImageButton3_Click" />
            <br />
            Casino Challenge&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Currnecy Cunvertor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Birthday Card Maker</div>
    </form>
</body>
</html>
