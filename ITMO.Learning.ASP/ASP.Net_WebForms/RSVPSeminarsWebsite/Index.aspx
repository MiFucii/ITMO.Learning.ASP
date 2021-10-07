<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RSVPSeminarsWebsite.Index" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div>
        <div class="rek">
            <h3>Вы приглашены на наш семинар</h3>
            <h3>Подтвердите свое согласие, пройдя регистрацию:</h3>
            <p>Поля отмеченные * обязательны для заполнения.</p>
        </div>
            <div>
                <table class="RegistrationTable">
                    <tr>
                        <td>Ваше имя*:</td>
                        <td colspan="3">
                            <asp:TextBox ID="tbName"
                                runat="server" BorderStyle="Solid" MaxLength="30" Width="220px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ControlToValidate="tbName" Display="Dynamic" ForeColor="#CC0000">!</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Ваша фамилия*:</td>
                        <td colspan="3">
                            <asp:TextBox ID="tbLastName" runat="server" BorderStyle="Solid" MaxLength="30" Width="220px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ControlToValidate="tbLastName" Display="Dynamic" ForeColor="#CC0000">!</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Ваш email*:</td>
                        <td colspan="3">
                            <asp:TextBox ID="tbEmail"
                                runat="server" BorderStyle="Solid" MaxLength="40" Width="220px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ForeColor="#CC0000">!</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">!</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Ваш телефон*:</td>
                        <td colspan="3">
                            <asp:TextBox ID="tbPhone" placeholder="+70001112233"
                                runat="server" BorderStyle="Solid" Width="220px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" ControlToValidate="tbPhone" Display="Dynamic" ForeColor="#CC0000">!</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" ControlToValidate="tbPhone" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="^((\+7|8)+([0-9]){10})$">!</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Вы будете делать доклад?</td>
                        <td colspan="3">
                            <asp:CheckBox ID="CheckBoxYN" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">Введите информацию о 1 докладе:</td>
                        <td colspan="2">Введите информацию о 2 докладе:</td>
                    </tr>
                    <tr>
                        <td>Название доклада:</td>
                        <td>
                            <asp:TextBox ID="tbReportName1" runat="server" BorderStyle="Solid" MaxLength="50" Width="300px"></asp:TextBox>
                        </td>
                        <td>Название доклада:</td>
                        <td>
                            <asp:TextBox ID="tbReportName2" runat="server" BorderStyle="Solid" MaxLength="50" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Аннотация:</td>
                        <td>
                            <asp:TextBox ID="Annotation1" runat="server" BorderStyle="Solid" MaxLength="50" Width="300px"></asp:TextBox>
                        </td>
                        <td>Аннотация:</td>
                        <td>
                            <asp:TextBox ID="Annotation2" runat="server" BorderStyle="Solid" MaxLength="50" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
			            <td colspan="4">
            <button type="submit">Отправить ответ на приглашение</button>
                        </td>
		</tr>

                </table>
            </div>
        <div>
        </div>
    </div>
</asp:Content>
