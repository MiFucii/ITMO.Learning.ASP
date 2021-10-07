<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="StudentPerformanceWebsite.Edit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Редактирование:</h1>
    <asp:GridView ID="gvStudentEdit" runat="server" BorderColor="#123c69" BorderStyle="Solid" 
        BorderWidth="2px" CellPadding="5" CellSpacing="0" GridLines="Horizontal" AutoGenerateColumns ="False" ShowFooter="True" 
        ShowHeaderWhenEmpty="True" OnRowCommand="gvStudentEdit_RowCommand" OnRowEditing="gvStudentEdit_RowEditing" OnRowCancelingEdit="gvStudentEdit_RowCancelingEdit"
          OnRowUpdating="gvStudentEdit_RowUpdating" OnRowDeleting="gvStudentEdit_RowDeleting" Width="100%">

        <FooterStyle BackColor="#948473" ForeColor="Black" />
        <HeaderStyle BackColor="#948473" Font-Bold="True" ForeColor="#F0F0F0"/>        
        <RowStyle BackColor="#EDC7B7" ForeColor="Black" HorizontalAlign="Center" />
        

        <Columns>
            <asp:TemplateField HeaderText="Имя" HeaderStyle-Width="14%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("Name") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbName" Text='<%# Eval("Name") %>' runat="server" Width="95%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbNameFooter" runat="server" Width="95%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Фамилия" HeaderStyle-Width="14%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("LastName") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbLastName" Text='<%# Eval("LastName") %>' runat="server" Width="97%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbLastNameFooter" runat="server" Width="97%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" HeaderStyle-Width="26%">
                <ItemTemplate>
                    <asp:Label ID="lbEmail" Text='<%# Eval("Email") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbEmail" Enabled ="false" Text='<%# Eval("Email") %>' runat="server" Width="97%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbEmailFooter" runat="server" Width="97%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Основы программирования" HeaderStyle-Width="10%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("BasicsProgramingСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbBP" Text='<%# Eval("BasicsProgramingСourse") %>' runat="server" Width="95%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbBPFooter" runat="server" Width="95%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="C#" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("C_Сourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbCcs" Text='<%# Eval("C_Сourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbCcsFooter" runat="server" Width="90%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Asp.Net" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("AspNetСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbAspNet" Text='<%# Eval("AspNetСourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbAspNetFooter" runat="server" Width="90%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ado.Net" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("AdoNetСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbAdoNet" Text='<%# Eval("AdoNetСourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbAdoNetFooter" runat="server" Width="90%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Java" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("JavaСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbJava" Text='<%# Eval("JavaСourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbJavaFooter" runat="server" Width="90%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Python" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("PythonСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbPython" Text='<%# Eval("PythonСourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbPythonFooter" runat="server" Width="90%" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Web" HeaderStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("WebСourse") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbWeb" Text='<%# Eval("WebСourse") %>' runat="server" Width="90%"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbWebFooter" runat="server" Width="90%"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Итоговая оценка" HeaderStyle-Width="14%">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("FinalGrade") %>' runat="server"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width ="20px" >
                <ItemTemplate>
                    <asp:ImageButton ImageUrl="~/img/Edit.png" runat="server" CommandName="Edit" ToolTip="Изменить" Width="20px" Height="20px"/>
                    <asp:ImageButton ImageUrl="~/img/Delete.png" runat="server" CommandName="Delete" ToolTip="Удалить" Width="20px" Height="20px"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:ImageButton ImageUrl="~/img/Save.png" runat="server" CommandName="Update" ToolTip="Сохранить" Width="20px" Height="20px"/>
                    <asp:ImageButton ImageUrl="~/img/Cancel.png" runat="server" CommandName="Cancel" ToolTip="Отмена" Width="20px" Height="20px"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:ImageButton ImageUrl="~/img/Add.png" runat="server" CommandName="Add" ToolTip="Добавить" Width="20px" Height="20px"/>
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lbSuccessMessage" Text="" runat="server" ForeColor="#009933" Font-Size="Medium" />
    <asp:Label ID="lbErrorMessage" Text="" runat="server" ForeColor="#ff0000" Font-Size="Medium" />

</asp:Content>
