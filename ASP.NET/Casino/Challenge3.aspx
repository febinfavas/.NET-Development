<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge3.aspx.cs" Inherits="Casino.Challenge3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
            text-decoration: underline;
            font-size: x-large;
            width: 745px;
        }
        .auto-style3 {
            width: 314px;
            height: 484px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3" style="background-color: #00FFFF; font-family: SimSun">
            <p class="auto-style2">
                <strong><em style="background-color: #00FF00">BirthDay Card Maker</em></strong></p>
            Choose background colour:<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Choose a font:<asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
            <br />
            <br />
            Give font size:<br />
            <asp:TextBox ID="sizeTextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Enter the Greetings:<br />
            <asp:TextBox ID="greetingTextBox2" runat="server" Height="78px" TextMode="MultiLine" Width="187px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
            <br />
            
        </div>
        <asp:Panel ID="Panel1" runat="server" Width="331px" Height="387px" HorizontalAlign="Center" h>
            <br />
            <asp:Label ID="greetingLabel1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="119px" ImageUrl="~/images/dhoni.jpg" />
        </asp:Panel>
    </form>
</body>
</html>
