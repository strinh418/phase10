<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameRunner.aspx.cs" Inherits="PhaseTen.GameRunner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Phase Ten Game</p>
        <p>
            Player 1 Hand</p>
        <p>
            Player 2 Hand</p>
        <p>
            Player 3 Hand</p>
        <p>
            Player 4 Hand&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="DeckPile" runat="server" Height="100px" ImageUrl="~/Cards/BackCard.png" Width="70px" />
        </p>
        <p>
            Player 5 Hand&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:ImageButton ID="DiscardedPile" runat="server" Height="100px" Width="70px" OnClick="DiscardedPile_Click"  />
        </p>
        <p>
            <asp:Image ID="Card1" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card2" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card3" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card4" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card5" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card6" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card7" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card8" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card9" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card10" runat="server" Height="100px" Width="70px" />
            <asp:Image ID="Card11" runat="server" Height="100px" Visible="False" Width="70px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
