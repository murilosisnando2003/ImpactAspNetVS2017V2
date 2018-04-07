<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Tarefas_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <h1>Lista de Tarefas</h1>
    <hr />
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Create">Inserir</asp:LinkButton>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="Black" Width="100%" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
        <asp:BoundField DataField="Prioridade" HeaderText="Prioridade" SortExpression="Prioridade" />
        <asp:CheckBoxField DataField="Concluida" HeaderText="Concluida" SortExpression="Concluida" />
        <asp:BoundField DataField="Obervacao" HeaderText="Obervacao" SortExpression="Obervacao" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Selecionar" TypeName="Pessoal.Repositorios.SqlServer.TarefaRepositorio"></asp:ObjectDataSource>
</asp:Content>

