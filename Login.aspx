<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SalajeetOnline.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lEmail" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
    <asp:Label ID="lPassword" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>

</asp:Content>

