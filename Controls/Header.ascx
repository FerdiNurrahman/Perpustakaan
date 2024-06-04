<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Header.ascx.vb" Inherits="Perpustakaan.header" %>
<div class="header">
    <div class="logo">
    <asp:Label ID="Label1" runat="server" Text="PERPUSTAKAAN" Font-Size="X-Large"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Politeknik Negeri Tanah Laut"></asp:Label>
    </div>
<div class ="navigation">
    <ul>
        <li><a href="BerandaPub.aspx">Beranda</a></li>
         <li><a href="KoleksiPub.aspx">Koleksi</a></li>
         <li><a href="#">Layanan</a></li>
         <li><a href="ProfilPustakawan.aspx">Profil Perpustakaan</a></li>
         <li><a href="KontakKamiPub.aspx">Kontak Kami</a></li>
    </ul>
</div>
<div class ="login">
<a href="" class="login-link">Login</a>    
</div>    
</div>