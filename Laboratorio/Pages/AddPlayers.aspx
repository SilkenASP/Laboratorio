<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="AddPlayers.aspx.cs" Inherits="Laboratorio.Pages.AddPlayers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <div class="row">
            <asp:Label ID="Label4" runat="server" Text="Nombre:" CssClass="col-2"></asp:Label>
            <asp:TextBox ID="txtNombreJugador" runat="server" CssClass="col"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label5" runat="server" Text="Edad:" CssClass="col-2"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server" CssClass="col-4"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label1" runat="server" Text="Estatura:" CssClass="col-2"></asp:Label>
            <asp:TextBox ID="txtEstatura" runat="server" CssClass="col-4"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label2" runat="server" Text="Peso:" CssClass="col-2"></asp:Label>
            <asp:TextBox ID="txtPeso" runat="server" CssClass="col-4"></asp:TextBox>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label3" runat="server" Text="Posicion:" CssClass="col-2"></asp:Label>
            <asp:DropDownList ID="dropPoscicion" CssClass="col" runat="server">
                <asp:ListItem>Base-BA</asp:ListItem>
                <asp:ListItem>Escolta-E</asp:ListItem>
                <asp:ListItem>Alero-SF</asp:ListItem>
                <asp:ListItem>Ala-Pívot-AP</asp:ListItem>
                <asp:ListItem>Pívot-C</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="Label6" runat="server" Text="Universidad:" CssClass="col-2"></asp:Label>
            <asp:DropDownList ID="dropUniversidades" CssClass="col"  runat="server" AppendDataBoundItems="true"></asp:DropDownList>
            <asp:ImageButton id="imgButtonEditUniversities" runat="server" ImageUrl="~/Images/edit.svg" Height="50" Width="50" OnClick="imgButtonEditUniversities_Click" />
        </div>
        <br />
        <div class="row">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <br />
        <div class="row">
            <asp:Button ID="btnRegJugador" runat="server" Text="Registrar Equipo" CssClass="col-6" OnClick="btnRegJugador_Click" />
        </div>

        <br />
        <asp:Label ID="lblErrorMinMax" CssClass="text-danger" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblErroPos" CssClass="text-danger" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:ImageField DataImageUrlField="Fotografia" ControlStyle-CssClass="img-thumbnail img-fluid" ItemStyle-Height="125" HeaderStyle-Width="125" HeaderText="Imagen" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre Equipo" ReadOnly="True" />
                <asp:BoundField DataField="Posicion" HeaderText="POS" ReadOnly="True" />
                <asp:BoundField DataField="Edad" HeaderText="EDAD" ReadOnly="True" />
                <asp:BoundField DataField="EstaturaMetros" HeaderText="EST" ReadOnly="True" />
                <asp:BoundField DataField="Peso" HeaderText="P" ReadOnly="True" />
                <asp:BoundField DataField="Universidad" HeaderText="UNIVERSIDAD" ReadOnly="True" />
                <asp:ButtonField Text="Ver Informacion" ControlStyle-CssClass="btn-info" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
