<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPFirst.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Калькулятор</title>
</head>
<body style="height: 326px">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button3" runat="server" Text="%" Width="100px" OnClick="Meth_Click" />
            <asp:Button ID="ButAC" runat="server" Text="АС" Width="100px" OnClick="AC_Click" />
            <br />
       
        <asp:Button ID="But7" runat="server" Text="7" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="But8" runat="server" Text="8" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="But9" runat="server" Text="9" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="ButDiv" runat="server" Text="/"  Width="100px" OnClick="Meth_Click" />
       
            <br />
       
            <asp:Button ID="But4" runat="server" Text="4" Width="100px" OnClick="CommonBtn_Click" Height="25px" />
            <asp:Button ID="But5" runat="server" Text="5" Width="100px" OnClick="CommonBtn_Click" />
            <asp:Button ID="But6" runat="server" Text="6" Width="100px" OnClick="CommonBtn_Click" />
            <asp:Button ID="ButTimes" runat="server" Text="X" Width="100px" OnClick="Meth_Click" />
       
            <br />
       
        <asp:Button ID="But1" runat="server" Text="1" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="But2" runat="server" Text="2" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="But3" runat="server" Text="3" Width="100px" OnClick="CommonBtn_Click" />
        <asp:Button ID="ButMinus" runat="server" Text="-" Width="100px" OnClick="Meth_Click" />
        
            <br />
        
            <asp:Button ID="ButZero" runat="server" Text="0" Width="100px" OnClick="CommonBtn_Click" />
            <asp:Button ID="ButDot" runat="server" Text="." Width="100px" OnClick="ButDot_Click" />
            <asp:Button ID="ButEqv" runat="server" Text="=" Width="100px" OnClick="ButEqv_Clicks"  />
            <asp:Button ID="ButPlus" runat="server" Text="+" Width="100px" OnClick="Meth_Click" />
        
             </div>
        <asp:TextBox ID="TextBoxMain" runat="server" BorderStyle="Double" OnInit="Page_Load"></asp:TextBox>
        =
        <asp:Label ID="LabelRes" runat="server" BorderStyle="Double"></asp:Label>
    </form>
</body>
</html>
