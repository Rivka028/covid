<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
        <div>
            <asp:LinqDataSource ID="ldsClients" runat="server" ContextTypeName="CovidLINQDataContext" EnableInsert="True" EntityTypeName="" TableName="Clients"></asp:LinqDataSource>
            <asp:DetailsView ID="dvClients" runat="server" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="ldsClients" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DefaultMode="Insert">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <Fields>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="FullName" HeaderText="שם מלא" SortExpression="FullName" />
                    <asp:BoundField DataField="TAZ" HeaderText="מספר זהות" SortExpression="TAZ" />
                    <asp:BoundField DataField="Address" HeaderText="כתובת" SortExpression="Address" />
                    <asp:BoundField DataField="BirthDate" HeaderText="תאריך לידה" SortExpression="BirthDate" />
                    <asp:BoundField DataField="Phone" HeaderText="טלפון" SortExpression="Phone" />
                    <asp:BoundField DataField="Mobile" HeaderText="נייד" SortExpression="Mobile" />
                    <asp:BoundField DataField="Vac1Date" HeaderText="תאריך חיסון ראשון" SortExpression="Vac1Date" />
                    <asp:BoundField DataField="Vac1Mnf" HeaderText="יצרן חיסון ראשון" SortExpression="Vac1Mnf" />
                    <asp:BoundField DataField="Vac2Date" HeaderText="תאריך חיסון שני" SortExpression="Vac2Date" />
                    <asp:BoundField DataField="Vac2Mnf" HeaderText="יצרן חיסון שני" SortExpression="Vac2Mnf" />
                    <asp:BoundField DataField="Vac3Date" HeaderText="תאריך חיסון שלישי" SortExpression="Vac3Date" />
                    <asp:BoundField DataField="Vac3Mnf" HeaderText="יצרן חיסון שלישי" SortExpression="Vac3Mnf" />
                    <asp:BoundField DataField="Vac4Date" HeaderText="תאריך חיסון רביעי" SortExpression="Vac4Date" />
                    <asp:BoundField DataField="Vac4Mnf" HeaderText="יצרן חיסון רביעי" SortExpression="Vac4Mnf" />
                    <asp:BoundField DataField="PozitiveDate" HeaderText="תאריך בדיקה חיובית" SortExpression="PozitiveDate" />
                    <asp:BoundField DataField="RecoveryDate" HeaderText="תאריך החלמה" SortExpression="RecoveryDate" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            </asp:DetailsView>
        </div>
        <br />
        <asp:GridView ID="gvClients" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="ldsClients">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
                <asp:BoundField DataField="TAZ" HeaderText="TAZ" SortExpression="TAZ" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                <asp:BoundField DataField="Vac1Date" HeaderText="Vac1Date" SortExpression="Vac1Date" />
                <asp:BoundField DataField="Vac1Mnf" HeaderText="Vac1Mnf" SortExpression="Vac1Mnf" />
                <asp:BoundField DataField="Vac2Date" HeaderText="Vac2Date" SortExpression="Vac2Date" />
                <asp:BoundField DataField="Vac2Mnf" HeaderText="Vac2Mnf" SortExpression="Vac2Mnf" />
                <asp:BoundField DataField="Vac3Date" HeaderText="Vac3Date" SortExpression="Vac3Date" />
                <asp:BoundField DataField="Vac3Mnf" HeaderText="Vac3Mnf" SortExpression="Vac3Mnf" />
                <asp:BoundField DataField="Vac4Date" HeaderText="Vac4Date" SortExpression="Vac4Date" />
                <asp:BoundField DataField="Vac4Mnf" HeaderText="Vac4Mnf" SortExpression="Vac4Mnf" />
                <asp:BoundField DataField="PozitiveDate" HeaderText="PozitiveDate" SortExpression="PozitiveDate" />
                <asp:BoundField DataField="RecoveryDate" HeaderText="RecoveryDate" SortExpression="RecoveryDate" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
