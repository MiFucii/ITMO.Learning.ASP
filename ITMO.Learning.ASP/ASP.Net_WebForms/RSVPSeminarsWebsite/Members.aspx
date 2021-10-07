<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="RSVPSeminarsWebsite.Members" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolderMain"
    runat="server">
    <div>
        <h2>Участники семинара</h2>
        <h3>Выступающие с докладом: </h3>
        <table>
            <thead>
                <tr>
                    <th>№</th>
                    <th>Имя</th>
                    <th>Фамилия</th>
                    <th>Название доклада</th>
                    <th>Аннотация</th>
                </tr>
            </thead>
            <tbody>
                <% =GetNoShowHtmlMemberReport() %>
            </tbody>
        </table>
        <hr />
        <h3>Слушатели: </h3>
        <table>
            <thead>
                <tr>
                    <th>№</th>
                    <th>Имя</th>
                    <th>Фамилия</th>
                </tr>
            </thead>
            <tbody>
                <% =GetNoShowHtmlMember() %>
            </tbody>
        </table>
    </div>
</asp:Content>
