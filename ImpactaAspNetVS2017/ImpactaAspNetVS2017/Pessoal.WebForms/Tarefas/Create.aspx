<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Tarefas_Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Nova Tarefa</h1>
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="danger" />
     <hr />
    <table class="nav-justified">
        <tr>
            <td style="width: 100px">Nome</td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server" Width="333px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeTextBox" CssClass="danger" ErrorMessage="O nome é obrigatório" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px; height: 16px">Prioridade</td>
            <td style="height: 16px">
                <asp:DropDownList ID="prioridadeDropDownList" AppendDataBoundItems="true" runat="server" DataSourceID="ObjectDataSource1">
                    <asp:ListItem Text="Selecione" Value="0"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="prioridadeDropDownList" ErrorMessage="Selecione uma prioridade." SetFocusOnError="True">Selecione uma prioridade.</asp:RequiredFieldValidator>
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
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 100px"><strong>
                <asp:Button ID="Button1" runat="server" style="font-weight: bold" Text="Gravar" Width="83px" />
                </strong></td>
            <td>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.WebForms.Helper"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
   
</asp:Content>

