<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppAuth.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>

        </div>
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        </p>
        <asp:Label ID="LabelStatus" runat="server"></asp:Label>
    </form>
</body>
</html>
