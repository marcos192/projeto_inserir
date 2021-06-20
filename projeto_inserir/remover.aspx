﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="remover.aspx.cs" Inherits="projeto_inserir.remover" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center text-black">
        <h2>Remover Cliente</h2>
    </div>
   <div class="row" style="margin-top:15px">
        <div class="col-md-12">
            <label>Nome:</label>
            <asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtNome"
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-7">
            <label>Login:</label>
            <asp:RequiredFieldValidator ID="rfvLogin" ControlToValidate="txtLogin"
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtLogin" runat="server" MaxLength="10" CssClass="form-control"></asp:TextBox>
        </div>

       


        <div class="col-md-5">
            <label>Nível:</label>
            <asp:RequiredFieldValidator ID="rfvNivel" ControlToValidate="ddlNivel"
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlNivel" runat="server" CssClass="form-control">
                <asp:ListItem Selected="True" Value=""></asp:ListItem>
                <asp:ListItem Value="A">Administrador</asp:ListItem>
                <asp:ListItem Value="O">Operador</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnDeletar" class="btn btn-dark" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnVoltar" class="btn btn-dark" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-12 text-right">
            <asp:Label ID="lblResultado" CssClass="text-danger" runat="server"></asp:Label>
        </div>
    </div>


</asp:Content>
