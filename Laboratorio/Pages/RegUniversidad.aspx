<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="RegUniversidad.aspx.cs" Inherits="Laboratorio.Pages.RegUniversidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <div class="row">
            <asp:Label ID="Label1" runat="server" CssClass="col-4" Text="Nombre de la universidad: "></asp:Label>
            <asp:TextBox ID="txtNombreUniversidad" CssClass="col-8" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Button ID="Guardar" runat="server" CssClass="btn-secondary col-6" Text="Registrar Universidad" OnClick="Guardar_Click" />
            <asp:Button ID="Cancelar" runat="server" CssClass="btn-secondary col-6" Text="Cancelar" />
        </div>
    </div>
</asp:Content>
