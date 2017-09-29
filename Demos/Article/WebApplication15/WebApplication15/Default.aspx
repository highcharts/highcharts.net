<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication15._Default" %>
<%@ Register TagPrefix="tc" TagName="Chart" Src="~/Controls/TestControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="http://code.highcharts.com/stock/highstock.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    
    <select name='minValue' id="yearfrom">
        <option value='2001' selected="selected">2001</option>
        <option value='2002'>2002</option>
        <option value='2003'>2003</option>
        <option value='2004'>2004</option>
        <option value='2005'>2005</option>
        <option value='2006'>2006</option>
        <option value='2007'>2007</option>
        <option value='2008'>2008</option>
        <option value='2009'>2009</option>
        <option value='2010'>2010</option>
        <option value='2011'>2011</option>
        <option value='2012'>2012</option>
        <option value='2013'>2013</option>
        <option value='2014'>2014</option>
        <option value='2015'>2015</option>
    </select>

    <tc:Chart runat="server"></tc:Chart>
</asp:Content>
