<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProfilPustakawan.aspx.vb" Inherits="Perpustakaan.ProfilPustakawan" %>

<%@ Register Tagprefix="uc" Tagname="Header" src="~/Controls/Header.ascx" %>
<%@ Register Tagprefix="uc" Tagname="Footer" src="~/Controls/Footer.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profil Pustakawan</title>
    <link href="../warna/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <uc:Header runat="server" />
    <form id="form1" runat="server">
        <div>
            <h2 style="font-weight: lighter; margin-left: 20px">Profil Pustakawan</h2>
            <asp:Table runat="server" Style="border-collapse: collapse; text-align: center; margin-left:20px">
                <asp:TableRow>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">NAMA</span><br/>Mina Wati Dewi
                    </asp:TableCell>
                    <asp:TableCell Style="border: none; width: 25px;"></asp:TableCell>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">NAMA</span><br/>Admin
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">LOKASI</span><br/>Pustakawan
                    </asp:TableCell>
                    <asp:TableCell Style="border: none; width: 25px;"></asp:TableCell>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">LOKASI</span><br/>Pustakawan
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">SUREL</span><br/>Minawatidewi959@yahoo.co.id
                    </asp:TableCell>
                    <asp:TableCell Style="border: none; width: 25px;"></asp:TableCell>
                    <asp:TableCell Style="border: 1px solid #ccc; width: 250px;">
                        <span style="font-size: x-small;">SUREL</span><br/>perpustakaan@politala.ac.id
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
    <uc:Footer runat="server" />
</body>
</html>
