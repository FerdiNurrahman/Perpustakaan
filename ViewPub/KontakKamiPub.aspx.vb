Imports System.IO

Public Class KontakKamiPub
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim alamat As String = Server.MapPath("~/pengaturan.txt")

            If File.Exists(alamat) Then
                Dim arrText As String() = File.ReadAllLines(alamat)
                Dim teks As String = ""

                For Each row In arrText
                    teks += row & "<br />"
                Next
                LblInformasi.Text = teks
            Else
                LblInformasi.Text = "File Tidak Ditemukan Tod"
            End If
        End If
    End Sub

End Class
