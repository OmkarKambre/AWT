<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Session_practice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox runat="server" ID="tb1"/>
            <br/>
            <br/>
            Password:<asp:TextBox runat="server" ID="tb2"/>
            <br/>
            <br/>
            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="click Here"/>
        </div>
    </form>
</body>
</html>
