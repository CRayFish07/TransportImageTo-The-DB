﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="TestWeb.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox3" runat="server" textMode="MultiLine" Height="154px" Width="239px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="调用" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
