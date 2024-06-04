<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KontakKamiPub.aspx.vb" Inherits="Perpustakaan.KontakKamiPub" %>

<%@ Register Tagprefix="uc" Tagname="Header" src="~/Controls/Header.ascx" %>
<%@ Register Tagprefix="uc" Tagname="Footer" src="~/Controls/Footer.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Kami</title>
    <link href="../warna/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <uc:Header runat="server" />
    <form id="form1" runat="server">
        <div>
           <h2 style="font-weight: lighter; margin-left: 20px">Kontak Kami</h2>
        </div>
    <uc:Footer runat="server" />
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblInformasi" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    </body>
</html>
