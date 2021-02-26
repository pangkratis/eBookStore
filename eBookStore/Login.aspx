<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eBookStore.Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftContent" runat="server">
    &nbsp
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">



<span id="panel1">
    <asp:Panel ID="Panel1" runat="server">
        <p>Αποστολή συνθηματικού χρήστη</p>
        <asp:Label ID="Label1" runat="server" Text="Label">Email: </asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1"
            runat="server" Text="Αποστολή" />
    </asp:Panel>
</span>



<span id="panel2">
    <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="ErrorMsg" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td>Όνομα Χρήστη: </td>
            <td><asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Κωδικός: </td>
            <td><asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
    </table>
    
    <asp:Button ID="LogInSubmitB" runat="server" Text="Είσοδος" OnClick="LoginSubmitB_Click"/>
     <p>Ξεχάσατε τον κωδικό σας; Πατήστε <asp:LinkButton ID="LinkButton1" runat="server" OnClick="ForgetPass">Εδώ</asp:LinkButton> για να το στείλουμε στον email σας.</p>
     <p>Δεν έχετε εγγραφεί; Πατήστε <asp:LinkButton ID="LinkButton2" runat="server" OnClick="RegistrationB_Click">Εδώ</asp:LinkButton> για εγγραφή.</p>
    </asp:Panel>
</span>
</asp:Content>
