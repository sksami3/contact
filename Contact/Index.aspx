<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Contact.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<p>
            &nbsp;</p>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        Address&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Indert" OnClick="Button1_Click" Width="91px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" Width="84px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" Width="83px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" Width="76px" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Go Another Page" Width="124px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
