<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TestControl.ascx.cs" Inherits="WebApplication15.Controls.TestControl" %>
<%--<asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
<asp:UpdatePanel ID="updatePanelId" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
      <%--<select name='minValue' id="yearfrom">
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
    </select>--%>
        
        <asp:Button ID="ButtonId" runat="server" Text="Update"/>
        <div id="chart1"></div>
        <asp:Literal ID="LiteralId" runat="server"></asp:Literal>
        
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="ButtonId" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>





