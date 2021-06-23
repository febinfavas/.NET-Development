<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="MyFirstWebApp.mypage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information </h2>
        </div>
        <div class="auto-style1">
            Name :&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="nameLabel" runat="server"></asp:Label>
            <br />
            <br />
            Select the Office :&nbsp;
            <asp:DropDownList ID="officeDropdown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select City</asp:ListItem>
                <asp:ListItem>Kochi</asp:ListItem>
                <asp:ListItem>Trivandram</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:Label ID="officeLabel" runat="server"></asp:Label>
            <br />
            <br />
            Department :<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Sales</asp:ListItem>
                <asp:ListItem>Testing</asp:ListItem>
                <asp:ListItem>Developing</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Qualifications :&nbsp; <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Bachelors</asp:ListItem>
                <asp:ListItem>Masters</asp:ListItem>
                <asp:ListItem>PhD</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:Button ID="empBtn" runat="server" OnClick="empBtn_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="empStatusLabel" runat="server"></asp:Label>
        </div>
    </form>
    <br />
    <br />
    <br />
    <br />
    click here for <a href="index.aspx">Home</a><br />

</body>
</html>
