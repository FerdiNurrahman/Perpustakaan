Public Class BerandaPub
    Inherits System.Web.UI.Page

    Dim dtBuku As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtBuku = New DataTable

        dtBuku.Columns.Add("kode")
        dtBuku.Columns.Add("Judul")
        dtBuku.Columns.Add("Kategori")
        dtBuku.Columns.Add("Pengarang")
        dtBuku.Columns.Add("Penerbit")
        dtBuku.Columns.Add("Tahun Terbit")
        dtBuku.Columns.Add("Stok")

        ' Menambahkan data buku pertama
        dtBuku.Rows.Add()
        dtBuku.Rows(0).Item("kode") = "B001"
        dtBuku.Rows(0).Item("Judul") = "Pemrograman Visual Basic"
        dtBuku.Rows(0).Item("Kategori") = "Teknologi Informasi"
        dtBuku.Rows(0).Item("Pengarang") = "Agus"
        dtBuku.Rows(0).Item("Penerbit") = "Penerbit Teknologi"
        dtBuku.Rows(0).Item("Tahun Terbit") = "2022"
        dtBuku.Rows(0).Item("Stok") = "15"

        ' Menambahkan data buku kedua
        dtBuku.Rows.Add()
        dtBuku.Rows(1).Item("kode") = "B002"
        dtBuku.Rows(1).Item("Judul") = "Belajar Python"
        dtBuku.Rows(1).Item("Kategori") = "Sipil"
        dtBuku.Rows(1).Item("Pengarang") = "Oky"
        dtBuku.Rows(1).Item("Penerbit") = "Penerbit Coding"
        dtBuku.Rows(1).Item("Tahun Terbit") = "2021"
        dtBuku.Rows(1).Item("Stok") = "10"


    End Sub

    Protected Sub LBSearch_Click(sender As Object, e As EventArgs) Handles LBSearch.Click
        If ddKategori.Visible = True Then
            ddKategori.Visible = False
        Else
            ddKategori.Visible = True
        End If
    End Sub

    Protected Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim cari As String = txtCari.Text.ToLower
        Dim ketemu As Boolean = False
        Dim indeks As Integer 'mengetahui indeks baris datatable yang terakhir

        'Mempersiapkan datatable unt tempat data-data yang cocok dengan pencarian
        Dim dtHasil As New DataTable
        dtHasil.Columns.Add("Kode")
        dtHasil.Columns.Add("Judul")
        dtHasil.Columns.Add("Kategori")
        dtHasil.Columns.Add("Pengarang")
        dtHasil.Columns.Add("Penerbit")
        dtHasil.Columns.Add("Tahun Terbit")
        dtHasil.Columns.Add("Stok")

        'Mempersiapkan variabel untuk penampungan sementara agar kode program tidak terlalu panjang
        Dim kode, judul, kategori, pengarang, penerbit, tahun, stok As String

        'Filter Kategori dari ddKategori
        Dim pilihKategori As String = "0" 'diberi 0 jika ddKategori tidak digunakan
        If ddKategori.Visible = True Then
            pilihKategori = ddKategori.SelectedValue.ToString
        End If

        'Jika tidak menggunakan advanced search
        'Or -- pilih kategori --
        If pilihKategori = "0" Then

            'Jika txtCari tidak diisi
            If cari = "" Then
                gvSearch.DataSource = dtBuku
                gvSearch.DataBind()
                gvSearch.Visible = True

            Else
                'Jika txtCari diisi:
                For Each baris As DataRow In dtBuku.Rows
                    kode = baris.Item("Kode").ToString
                    judul = baris.Item("Judul").ToString
                    kategori = baris.Item("Kategori").ToString
                    pengarang = baris.Item("Pengarang").ToString
                    penerbit = baris.Item("Penerbit").ToString
                    tahun = baris.Item("Tahun Terbit").ToString
                    stok = baris.Item("Stok").ToString

                    If judul.ToLower.Contains(cari) Or kategori.ToLower.Contains(cari) Or
                        pengarang.ToLower.Contains(cari) Or penerbit.ToLower.Contains(cari) Or
                        tahun.ToLower.Contains(cari) Then
                        ketemu = True

                        dtHasil.Rows.Add()
                        indeks = dtHasil.Rows.Count - 1 'indeks dtHasil yang terakhir
                        dtHasil.Rows(indeks).Item("Kode") = kode
                        dtHasil.Rows(indeks).Item("Judul") = judul
                        dtHasil.Rows(indeks).Item("Kategori") = kategori
                        dtHasil.Rows(indeks).Item("Pengarang") = pengarang
                        dtHasil.Rows(indeks).Item("Penerbit") = penerbit
                        dtHasil.Rows(indeks).Item("Tahun Terbit") = tahun
                        dtHasil.Rows(indeks).Item("Stok") = stok
                    End If
                Next

                'Cek jika ketemu = true, maka tampilkan dtHasil
                If ketemu = True Then
                    gvSearch.DataSource = dtHasil
                    gvSearch.DataBind()
                    gvSearch.Visible = True
                Else
                    MsgBox("Maaf, buku yang Anda cari tidak ditemukan", MsgBoxStyle.Information, "Informasi")
                    gvSearch.Visible = False
                End If
            End If

        Else
            'Di bawah ini jika advanced search digunakan
            'Dan kategori dipilih
            For Each baris As DataRow In dtBuku.Rows
                kode = baris.Item("Kode").ToString
                judul = baris.Item("Judul").ToString
                kategori = baris.Item("Kategori").ToString
                pengarang = baris.Item("Pengarang").ToString
                penerbit = baris.Item("Penerbit").ToString
                tahun = baris.Item("Tahun Terbit").ToString
                stok = baris.Item("Stok").ToString

                If pilihKategori = kategori Then

                    'Jika txtCari tidak diisi
                    If cari = "" Then
                        ketemu = True

                        dtHasil.Rows.Add()
                        indeks = dtHasil.Rows.Count - 1 'indeks dtHasil yang terakhir
                        dtHasil.Rows(indeks).Item("Kode") = kode
                        dtHasil.Rows(indeks).Item("Judul") = judul
                        dtHasil.Rows(indeks).Item("Kategori") = kategori
                        dtHasil.Rows(indeks).Item("Pengarang") = pengarang
                        dtHasil.Rows(indeks).Item("Penerbit") = penerbit
                        dtHasil.Rows(indeks).Item("Tahun Terbit") = tahun
                        dtHasil.Rows(indeks).Item("Stok") = stok

                    Else
                        'Di bawah ini jika txtCari diisi
                        If judul.ToLower.Contains(cari) Or kategori.ToLower.Contains(cari) Or
                            pengarang.ToLower.Contains(cari) Or penerbit.ToLower.Contains(cari) Or
                            tahun.ToLower.Contains(cari) Then
                            ketemu = True

                            dtHasil.Rows.Add()
                            indeks = dtHasil.Rows.Count - 1 'indeks dtHasil yang terakhir
                            dtHasil.Rows(indeks).Item("Kode") = kode
                            dtHasil.Rows(indeks).Item("Judul") = judul
                            dtHasil.Rows(indeks).Item("Kategori") = kategori
                            dtHasil.Rows(indeks).Item("Pengarang") = pengarang
                            dtHasil.Rows(indeks).Item("Penerbit") = penerbit
                            dtHasil.Rows(indeks).Item("Tahun Terbit") = tahun
                            dtHasil.Rows(indeks).Item("Stok") = stok
                        End If
                    End If
                End If
            Next

            'Cek jika ketemu = true, maka tampilkan dtHasil
            If ketemu = True Then
                gvSearch.DataSource = dtHasil
                gvSearch.DataBind()
                gvSearch.Visible = True
            Else
                MsgBox("Maaf, buku yang Anda cari tidak ditemukan", MsgBoxStyle.Information, "Informasi")
                gvSearch.Visible = False
            End If
        End If
    End Sub
End Class