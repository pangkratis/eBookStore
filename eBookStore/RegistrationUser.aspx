<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistrationUser.aspx.cs"
    Inherits="eBookStore.RegistrationUser" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftContent" runat="server">
    &nbsp
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server" >
            <asp:Label ID="Label14" runat="server" Text="Εγγραφή Χρήστη"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Όνομα: "></asp:Label><asp:TextBox ID="TextBox1"
                runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Επώνυμο: "></asp:Label><asp:TextBox ID="TextBox2"
                runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label><asp:TextBox ID="TextBox3"
                runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Username: "></asp:Label><asp:TextBox
                ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Password: "></asp:Label><asp:TextBox
                ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Επιβεβαίωση Password: "></asp:Label><asp:TextBox
                ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Διεύθυνση: "></asp:Label><asp:TextBox
                ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Τηλέφωνο Επικοινωνίας: "></asp:Label><asp:TextBox
                ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="ΤΚ: "></asp:Label><asp:TextBox ID="TextBox9"
                runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Πόλη: "></asp:Label><asp:TextBox ID="TextBox10"
                runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Χώρα: "></asp:Label><asp:DropDownList
                ID="DropDownList1" runat="server">
                <asp:ListItem>Ελλάδα</asp:ListItem>
                <asp:ListItem>Βουλγαρία</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Φύλλο: "></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="group1" Text="M"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="group1" Text="F"></asp:RadioButton>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Αποδοχή Όρων: "></asp:Label><asp:CheckBox
                ID="CheckBox1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Εγγραφή" OnClick="RegistrationB_Click"/>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label24" runat="server" Text="Αποδοχή Τιμών: "></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Aποδοχή" />
        </asp:View>
        
    </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
