<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
       
    <asp:Label ID="Label1" runat="server" Text="Label">AGE</asp:Label>

   
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label">Location</asp:Label>
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
   <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />
    </asp:Content>
