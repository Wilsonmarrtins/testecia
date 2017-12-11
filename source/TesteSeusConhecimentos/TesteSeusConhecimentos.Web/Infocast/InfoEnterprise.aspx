<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InfoEnterprise.aspx.cs" Inherits="TesteSeusConhecimentos.Web.Infocast.InfoEnterprise" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-width">
        <h2 id="formStatus2" runat="server">Nova Empresa</h2>
        <div class="form-group">
            <asp:Label ID="lbEndereco" runat="server" Text="Label">Endereço:</asp:Label>
            <asp:TextBox ID="txtEndereco" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lbCidade" runat="server" Text="Label">Cidade:</asp:Label>
            <asp:TextBox ID="txtCidade" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lbEstado" runat="server" Text="Label">Estado:</asp:Label>
            <asp:TextBox ID="txtEstado" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lbCep" runat="server" Text="Label">Cep:</asp:Label>
            <asp:TextBox ID="TxtCep" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lbAtividadeEmpresa" runat="server" Text="Label">Atividade Empresa:</asp:Label>
            <asp:TextBox ID="txtAtividadeEmpresa" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            
            <asp:Button ID="btncadastrar" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" />
            
        </div>
    </div>
</asp:Content>
