﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HighchartsWebForms._Default" %>
<%@ Register TagPrefix="hc" TagName="Chart" Src="~/Controls/HighchartsControl.ascx" %>
<%@ Register TagPrefix="hs" TagName="Chart" Src="~/Controls/HighstockControl.ascx" %>
<%@ Register TagPrefix="opt" TagName="Chart" Src="~/Controls/SetOptionsControl.ascx" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="head" runat="server">
    <!--if you have Highstock chart on the same site as Higcharts chart, then you don't need to use highcharts.js-->
    <script src="http://code.highcharts.com/highcharts.js"></script>
    <!--<script src="http://code.highcharts.com/stock/highstock.js"></script>-->
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <opt:Chart runat="server" />
    <hc:Chart runat="server"/>
    <br />
    <hr />
    <br />
    <%--<hs:Chart runat="server"/>--%>
</asp:Content>
