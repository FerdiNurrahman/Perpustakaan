<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KoleksiPub.aspx.vb" Inherits="Perpustakaan.KoleksiPub" %>


<%@ Register Tagprefix="uc" Tagname="Header" src="~/Controls/Header.ascx" %>
<%@ Register Tagprefix="uc" Tagname="Footer" src="~/Controls/Footer.ascx" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Koleksi</title>
    <link href="../warna/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <uc:Header runat="server" />
    <form id="form1" runat="server">
        <div>
           <h2 style="font-weight: lighter; margin-left: 20px">Koleksi</h2>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Jumlah koleksi Per Kategori"></asp:Label>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Chart ID="ChrPie" runat="server">
            <series>
                <asp:Series ChartType="Pie" Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        </p>
        <br />
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="Jumlah koleksi Tahun 2013"></asp:Label>
        </p>
        <p>
            <asp:Chart ID="ChrBar" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </p>
    </form>
    <br />
    <br />
    <br />
    <uc:Footer runat="server" />
    </body>
</html>
