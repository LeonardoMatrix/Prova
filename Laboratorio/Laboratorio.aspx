<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Laboratorio.aspx.cs" Inherits="Laboratorio.Laboratorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
 <form id="form1" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Cadastro Laboratorio</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>
        <div class="form-group">
            <label for="nome">Nome:</label>
            <asp:TextBox class="form-control" name="txtNome" ID="txtNome"
                runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="qtdcomputadores">QtdComputadores:</label>
            <asp:TextBox class="form-control" name="txtQtdComputadores" ID="txtQtdComputadores"
                runat="server"></asp:TextBox>
        </div>

     <div class="form-group">
            <label for="qtdalunos">QtdAlunos:</label>
            <asp:TextBox class="form-control" name="txtQtdAlunos" ID="txtQtdAlunos"
                runat="server"></asp:TextBox>
        </div>

     <div class="form-group">
            <label for="projetor">Projetor:</label>
            <br />
            <br />
            <asp:CheckBox ID="cbxProjetor" runat="server" />
            <br />
        </div>

     <div class="form-group">
            <label for="software1">Software1:</label>
            <asp:TextBox class="form-control" name="txtSoftware1" ID="txtSoftware1"
                runat="server"></asp:TextBox>
        </div>

     <div class="form-group">
            <label for="software2">Software2:</label>
            <asp:TextBox class="form-control" name="txtSoftware2" ID="txtSoftware2"
                runat="server"></asp:TextBox>
        </div>

     <div class="form-group">
            <label for="software3">Software3:</label>
            <asp:TextBox class="form-control" name="txtSoftware3" ID="txtSoftware3"
                runat="server"></asp:TextBox>
        </div>

      <div class="form-group">
            <label for="sistemaOperacional">SistemaOperacional:</label>
            <asp:TextBox class="form-control" name="txtSistemaOperacional" ID="txtSistemaOperacional"
                runat="server"></asp:TextBox>
        </div>

        <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar"
            OnClick="btnCadastrar_Click" />
    </form>
    <br />
    <% if (!String.IsNullOrEmpty(lblmsg.Text))
        {%>
    <div class="alert alert-success">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong>
    </div>
    <%} %>
</asp:Content>
