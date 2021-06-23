<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MyFirstWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>myFirstApp</title>
    <style type="text/css">
        .auto-style1 {
            width: 271px;
            height: 171px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: #000066; text-align: center;";>Welcome to My First Web App</h1>
            <p style="text-align: center;">
                <img alt="feb" class="auto-style1" src="images/feb.jpg" />
                <br />
                <asp:Label ID="lblStatus" runat="server"></asp:Label>   
            </p>
        </div>
        <hr />
           
        <div>   
            <br />
            <br />
            Enter First Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirst" runat="server" Height="16px" Width="120px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="firstNameRequiredFieldValidator" runat="server" ControlToValidate="txtFirst" ErrorMessage="First Name Shouldn't be Empty!!"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Last Name:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtLast" runat="server" Height="16px" Width="120px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="lastNameRequiredFieldValidator" runat="server" ErrorMessage="Last Name Shouldn't be Empty!!" ControlToValidate="txtLast"></asp:RequiredFieldValidator>
            <br />
            <br />
            Password :&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="passTextBox" runat="server" Height="16px" Width="120px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passRequiredFieldValidator" runat="server" ControlToValidate="passTextBox" ErrorMessage="Shouldn't be Empty!!"></asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password :
            <asp:TextBox ID="confirmpassTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="confirmpassRequiredFieldValidator" runat="server" ControlToValidate="confirmpassTextBox" ErrorMessage="Shouldn't be Empty!!"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="conformpassCompareValidator1" runat="server" ControlToCompare="passTextBox" ControlToValidate="confirmpassTextBox" ErrorMessage="Don't Match !!"></asp:CompareValidator>
            <br />
            <br />
            Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Enter Valid Email !!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Age :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mobileTextBox" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="mobileRangeValidator" runat="server" ControlToValidate="mobileTextBox" ErrorMessage="Enter a Valid Age !!" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" />
            <br />
            <br />
            <hr />
            <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
            <br />
        </div>
    </form>
    <p>
        Click Here to goto
        <a href="mypage.aspx">Employee</a></p>
</body>
</html>
