<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StudentPerformanceWebsite.Index" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Просмотр:</h1>
    <table class="StudentsTable">
        <thead>
            <tr>
                <th rowspan="2">№</th>
                <th rowspan="2">Имя</th>
                <th rowspan="2">Фамилия</th>
                <th colspan="7">Оценка по курсу</th>
                <th rowspan="2">Итоговая оценка</th>
            </tr>
            <tr>
                <th>Основы программирования</th>
                <th>C#</th>
                <th>ASP.Net</th>
                <th>ADO.Net</th>
                <th>Java</th>
                <th>Python</th>
                <th>Web</th>
            </tr>
        </thead>
        <tbody>
            <% =GetHtmlStudentsTable() %>
        </tbody>
    </table>
</asp:Content>
