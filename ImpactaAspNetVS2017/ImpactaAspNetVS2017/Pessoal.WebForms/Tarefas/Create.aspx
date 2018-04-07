<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Tarefas_Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Nova Tarefa</h1>
     <hr />
    <table class="nav-justified">
        <tr>
            <td style="width: 100px">Nome</td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server" Width="333px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px; height: 16px">Prioridade</td>
            <td style="height: 16px">
                <asp:DropDownList ID="prioridadeDropDownList" runat="server" DataSourceID="ObjectDataSource1">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.WebForms.Helper"></asp:ObjectDataSource>
            </td>
            <td style="height: 16px"></td>
        </tr>
        <tr>
            <td style="width: 100px">Concluida</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px">Observação</td>
            <td>
                <asp:TextBox ID="observacaoTextBox" runat="server" Rows="5" TextMode="MultiLine" Width="333px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
   
</asp:Content>

