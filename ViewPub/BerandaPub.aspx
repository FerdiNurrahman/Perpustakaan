<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BerandaPub.aspx.vb" Inherits="Perpustakaan.BerandaPub" %>

<%@ Register Tagprefix="uc" Tagname="Header" src="~/Controls/Header.ascx" %>
<%@ Register Tagprefix="uc" Tagname="Footer" src="~/Controls/Footer.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Perpustakaan Politala</title>
    <link href="../warna/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <uc:Header runat="server" />
    <form id="form1" runat="server">
        <div class="auto-style">
            <div style="height: 650px">
                <br/>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <center>
                    <asp:Label ID="Label3" runat="server" Font-Names="calibri" Text="PENCARIAN SUMBER"></asp:Label>
                </center>
                <br />
                <center>
                    <asp:Label ID="Label4" runat="server" Font-Italic="false" Font-Names="calibri" Font-Size="Small" Text="masukkan satu atau lebih kata kunci dari judul, pengarang, atau subyek"></asp:Label>
                </center>
                <center>
                    <asp:DropDownList ID="ddKategori" runat="server" Visible="False">
                        <asp:ListItem Value="0">--Pilih Kategori--</asp:ListItem>
                        <asp:ListItem Value="Komputer">Komputer</asp:ListItem>
                        <asp:ListItem>Bisnis</asp:ListItem>
                        <asp:ListItem>Pertanian</asp:ListItem>
                        <asp:ListItem>Otomotif</asp:ListItem>
                        <asp:ListItem>Alat Berat</asp:ListItem>
                        <asp:ListItem>Peternakan</asp:ListItem>
                        <asp:ListItem>Sipil</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtCari" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnCari" runat="server" Font-Names="calibri" Text="CARI" />
                </center>
                <br />
                <center>
                    <asp:LinkButton ID="LBSearch" runat="server" Font-Italic="True" Font-Size="Small">Advance Search</asp:LinkButton>
                    <br />
                    <asp:GridView ID="gvSearch" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Visible="False">
                        <HeaderStyle BackColor="#999999" BorderStyle="Dashed" />
                    </asp:GridView>
                </center>
            </div>
            <p>
                &nbsp;</p>
        </div>
    </form>
    <uc:Footer runat="server" />
</body>
</html>
