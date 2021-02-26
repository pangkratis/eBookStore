<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productinfo.aspx.cs"
    Inherits="eBookStore.Productinfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftContent" runat="server">
    &nbsp
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        
    </asp:PlaceHolder>
    </ br>
    <table>
        <th>Ποσότητα</th>
        <tr><td> <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox> </td>
        <td><asp:Button ID="Button1" runat="server" Text="Button" OnClick="AddCartB_Click"/></td></tr>
        
    </table>
    
</asp:Content>

