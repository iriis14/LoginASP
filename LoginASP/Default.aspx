<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="aspnetTitle">LOGIN</h1>
        

        <div class="row">
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            <div class="col">
                <asp:TextBox ID="txtBoxUserName" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <div class="col">
                <asp:TextBox ID="txtBoxPassword" TextMode="Password" runat="server"></asp:TextBox>
            </div>
        </div>

        <p></p>

        <div class="col">
            <asp:Button ID="butEnter" runat="server" Text="Enter" OnClick="butEnter_Click" />
        </div>

        <p></p>

        <div class="col">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
        <p></p>
    </section>
</main>

</asp:Content>
