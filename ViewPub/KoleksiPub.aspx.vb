Imports System.Web.UI.DataVisualization.Charting

Public Class KoleksiPub
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'mengisi pie chart
        Dim kat As String() = {"Fiksi", "Sains", "Teknik", "Komputer", "Umum"}
        Dim jml_kat As Integer() = {245, 148, 164, 420, 89}

        'membuat series baru
        Dim pie_series As New Series("Koleksi")
        pie_series.ChartType = SeriesChartType.Pie

        'menambah data point ke series
        For i = 0 To kat.Length - 1
            Dim pie_datapoint As New DataPoint
            pie_datapoint.AxisLabel = kat(i)
            pie_datapoint.YValues = New Double() {jml_kat(i)}
            pie_datapoint.Label = kat(i) & ": #VAL " & vbCrLf & "(#PERCENT{P0})"
            pie_series.Points.Add(pie_datapoint)
        Next

        'konfigurasi chart
        ChrPie.Width = 309
        ChrPie.Height = 300
        ChrPie.Series.Clear() 'hapus semua series yang ada
        ChrPie.Series.Add(pie_series)
    End Sub
    Protected Sub ChrPie_Load(sender As Object, e As EventArgs) Handles ChrPie.Load
        'Mengisi Bar Chart
        Dim bulan As String() = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        Dim peminjaman As Integer() = {10, 15, 8, 12, 20, 18, 25, 30, 22, 17, 12, 28}

        'tambah series baru
        Dim bar_series As New Series()
        bar_series.Name = "Peminjaman"
        bar_series.ChartType = SeriesChartType.Column

        'menambahkan data ke series
        For i = 0 To 11
            Dim bar_datapoint As New DataPoint
            bar_datapoint.AxisLabel = bulan(i)
            bar_datapoint.YValues = New Double() {peminjaman(i)}
            bar_datapoint.Label = peminjaman(i)
            bar_series.Points.Add(bar_datapoint)
        Next

        ChrBar.Width = 1200
        ChrBar.ChartAreas("ChartArea1").AxisX.LabelStyle.Interval = 1
        ChrBar.Series.Clear()
        ChrBar.Series.Add(bar_series)
    End Sub
End Class
