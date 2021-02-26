<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="RegUniversidad.aspx.cs" Inherits="Laboratorio.Pages.RegUniversidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:TextBox ID="txtNombreUniversidad" CssClass="col" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Button ID="Button1" runat="server" CssClass="row btn-secondary" Text="Registrar Universidad" />
        </div>
    </div>
</asp:Content>
