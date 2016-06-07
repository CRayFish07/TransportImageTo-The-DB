<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="TestInter.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="安全码："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="编      号："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Style="margin-bottom: 1px" Width="145px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="调用" OnClick="Button1_Click" Style="height: 21px; width: 40px" />
        </div>
        <div>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div>
              <asp:Image ID="Image1" runat="server" />
        </div>
    </form>
</body>
</html>
