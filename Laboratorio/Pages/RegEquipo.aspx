<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="RegEquipo.aspx.cs" Inherits="Laboratorio.Pages.RegEquipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <div class="row">
            <asp:TextBox ID="txtNombreEquipo" runat="server" CssClass="col"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <br />
        <div class="row">
            <asp:Button ID="btnRegEquipo" runat="server" Text="Registrar Equipo" OnClick="btnRegEquipo_Click" />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
                <asp:ImageField DataImageUrlField="Imagen" ControlStyle-CssClass="img-thumbnail img-fluid" ItemStyle-Height="125" HeaderStyle-Width="125" HeaderText="Imagen" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre Equipo" ReadOnly="True" />
                <asp:ButtonField Text="Ver Jugadores" ControlStyle-CssClass="btn-info" ButtonType="Button"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>