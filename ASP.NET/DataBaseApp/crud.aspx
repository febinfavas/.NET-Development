<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="DataBaseApp.crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CRUD Application:<br />
            <br />
            <br />
            <br />
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1" ForeColor="#333333" Height="132px" Width="256px">
                <EditItemTemplate>
                    CustomerID:
                    <asp:Label ID="CustomerIDLabel1" runat="server" Text='<%# Eval("CustomerID") %>' />
                    <br />
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    CustomerID:
                    <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                    <br />
                    FirstName:
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:Label ID="CreditLimitLabel" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:FormView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [CustomerTable] WHERE [CustomerID] = @original_CustomerID AND [FirstName] = @original_FirstName AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([CreditLimit] = @original_CreditLimit) OR ([CreditLimit] IS NULL AND @original_CreditLimit IS NULL))" InsertCommand="INSERT INTO [CustomerTable] ([FirstName], [LastName], [CreditLimit]) VALUES (@FirstName, @LastName, @CreditLimit)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [CustomerTable]" UpdateCommand="UPDATE [CustomerTable] SET [FirstName] = @FirstName, [LastName] = @LastName, [CreditLimit] = @CreditLimit WHERE [CustomerID] = @original_CustomerID AND [FirstName] = @original_FirstName AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([CreditLimit] = @original_CreditLimit) OR ([CreditLimit] IS NULL AND @original_CreditLimit IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_CustomerID" Type="Int32" />
                    <asp:Parameter Name="original_FirstName" Type="String" />
                    <asp:Parameter Name="original_LastName" Type="String" />
                    <asp:Parameter Name="original_CreditLimit" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="CreditLimit" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="CreditLimit" Type="Decimal" />
                    <asp:Parameter Name="original_CustomerID" Type="Int32" />
                    <asp:Parameter Name="original_FirstName" Type="String" />
                    <asp:Parameter Name="original_LastName" Type="String" />
                    <asp:Parameter Name="original_CreditLimit" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <span class="auto-style1">Band Tour<br />
            </span><span class="auto-style2">Tour Number</span><br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="TourNumber" DataValueField="TourNumber">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dropdown %>" ProviderName="<%$ ConnectionStrings:dropdown.ProviderName %>" SelectCommand="SELECT DISTINCT [TourNumber] FROM [Tours]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="TourNumber,ShowDate" DataSourceID="SqlDataSource3" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="TourNumber" HeaderText="TourNumber" ReadOnly="True" SortExpression="TourNumber" />
                    <asp:BoundField DataField="ShowDate" DataFormatString="{0:d}" HeaderText="ShowDate" ReadOnly="True" SortExpression="ShowDate" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:dropdown %>" DeleteCommand="DELETE FROM [Tours] WHERE [TourNumber] = ? AND [ShowDate] = ? AND [City] = ? AND [State] = ? AND (([ZipCode] = ?) OR ([ZipCode] IS NULL AND ? IS NULL)) AND [VenueName] = ? AND (([TicketLink] = ?) OR ([TicketLink] IS NULL AND ? IS NULL)) AND (([Cost] = ?) OR ([Cost] IS NULL AND ? IS NULL)) AND (([Time] = ?) OR ([Time] IS NULL AND ? IS NULL)) AND (([Notes] = ?) OR ([Notes] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [Tours] ([TourNumber], [ShowDate], [City], [State], [ZipCode], [VenueName], [TicketLink], [Cost], [Time], [Notes]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:dropdown.ProviderName %>" SelectCommand="SELECT * FROM [Tours] WHERE ([TourNumber] = ?) ORDER BY [ShowDate]" UpdateCommand="UPDATE [Tours] SET [City] = ?, [State] = ?, [ZipCode] = ?, [VenueName] = ?, [TicketLink] = ?, [Cost] = ?, [Time] = ?, [Notes] = ? WHERE [TourNumber] = ? AND [ShowDate] = ? AND [City] = ? AND [State] = ? AND (([ZipCode] = ?) OR ([ZipCode] IS NULL AND ? IS NULL)) AND [VenueName] = ? AND (([TicketLink] = ?) OR ([TicketLink] IS NULL AND ? IS NULL)) AND (([Cost] = ?) OR ([Cost] IS NULL AND ? IS NULL)) AND (([Time] = ?) OR ([Time] IS NULL AND ? IS NULL)) AND (([Notes] = ?) OR ([Notes] IS NULL AND ? IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_TourNumber" Type="Int16" />
                    <asp:Parameter Name="original_ShowDate" Type="DateTime" />
                    <asp:Parameter Name="original_City" Type="String" />
                    <asp:Parameter Name="original_State" Type="String" />
                    <asp:Parameter Name="original_ZipCode" Type="String" />
                    <asp:Parameter Name="original_ZipCode" Type="String" />
                    <asp:Parameter Name="original_VenueName" Type="String" />
                    <asp:Parameter Name="original_TicketLink" Type="String" />
                    <asp:Parameter Name="original_TicketLink" Type="String" />
                    <asp:Parameter Name="original_Cost" Type="String" />
                    <asp:Parameter Name="original_Cost" Type="String" />
                    <asp:Parameter Name="original_Time" Type="String" />
                    <asp:Parameter Name="original_Time" Type="String" />
                    <asp:Parameter Name="original_Notes" Type="String" />
                    <asp:Parameter Name="original_Notes" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TourNumber" Type="Int16" />
                    <asp:Parameter Name="ShowDate" Type="DateTime" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="ZipCode" Type="String" />
                    <asp:Parameter Name="VenueName" Type="String" />
                    <asp:Parameter Name="TicketLink" Type="String" />
                    <asp:Parameter Name="Cost" Type="String" />
                    <asp:Parameter Name="Time" Type="String" />
                    <asp:Parameter Name="Notes" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="TourNumber" PropertyName="SelectedValue" Type="Int16" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="ZipCode" Type="String" />
                    <asp:Parameter Name="VenueName" Type="String" />
                    <asp:Parameter Name="TicketLink" Type="String" />
                    <asp:Parameter Name="Cost" Type="String" />
                    <asp:Parameter Name="Time" Type="String" />
                    <asp:Parameter Name="Notes" Type="String" />
                    <asp:Parameter Name="original_TourNumber" Type="Int16" />
                    <asp:Parameter Name="original_ShowDate" Type="DateTime" />
                    <asp:Parameter Name="original_City" Type="String" />
                    <asp:Parameter Name="original_State" Type="String" />
                    <asp:Parameter Name="original_ZipCode" Type="String" />
                    <asp:Parameter Name="original_ZipCode" Type="String" />
                    <asp:Parameter Name="original_VenueName" Type="String" />
                    <asp:Parameter Name="original_TicketLink" Type="String" />
                    <asp:Parameter Name="original_TicketLink" Type="String" />
                    <asp:Parameter Name="original_Cost" Type="String" />
                    <asp:Parameter Name="original_Cost" Type="String" />
                    <asp:Parameter Name="original_Time" Type="String" />
                    <asp:Parameter Name="original_Time" Type="String" />
                    <asp:Parameter Name="original_Notes" Type="String" />
                    <asp:Parameter Name="original_Notes" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <span class="auto-style1">Calender<br />
            </span><span class="auto-style2">Start Date:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            End Date:-&nbsp; </span>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <span class="auto-style1">
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style2" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="auto-style2" DataKeyNames="IDNumber,JournalDate" DataSourceID="SqlDataSource4">
                <Columns>
                    <asp:BoundField DataField="IDNumber" HeaderText="IDNumber" ReadOnly="True" SortExpression="IDNumber" />
                    <asp:BoundField DataField="JournalDate" HeaderText="JournalDate" ReadOnly="True" SortExpression="JournalDate" />
                    <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:dropdown %>" ProviderName="<%$ ConnectionStrings:dropdown.ProviderName %>" SelectCommand="SELECT * FROM [ArtistJournal] WHERE (([JournalDate] &gt;= ?) AND ([JournalDate] &lt;= ?))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="JournalDate" PropertyName="Text" Type="DateTime" />
                    <asp:ControlParameter ControlID="TextBox2" Name="JournalDate2" PropertyName="Text" Type="DateTime" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            </span>
        </div>
    </form>
</body>
</html>
