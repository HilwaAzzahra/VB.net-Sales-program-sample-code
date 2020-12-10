Public Class LaporanPenjualan

    Private Sub LaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.Format = DateTimePickerFormat.Custom
        DTP1.CustomFormat = "yyyy-MM-dd"

        DTP2.Format = DateTimePickerFormat.Custom
        DTP2.CustomFormat = "yyyy-MM-dd"

        DTP3.Format = DateTimePickerFormat.Custom
        DTP3.CustomFormat = "yyyy-MM-dd"

        DTP4.Format = DateTimePickerFormat.Custom
        DTP4.CustomFormat = "MM-yyyy"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "({tabelpenjualan.tanggal}) = '" & DTP1.Text & "'"
        CRV.ReportSource = "LaporanHarian.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "ToText{tabelpenjualan.tanggal} in Date ('" & DTP2.Text & "') to Date ('" & DTP3.Text & "')"
        CRV.ReportSource = "LaporanMingguan.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CRV.SelectionFormula = "month({tabelpenjualan.tanggal}) = (" & Month(DTP4.Text) & ") and year({tabelpenjualan.tanggal}) = (" & Year(DTP4.Text) & ")"
        CRV.ReportSource = "LaporanBulanan.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CRV.ReportSource = "Grafik1.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CRV.ReportSource = "Grafik2.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub DTP4_ValueChanged(sender As Object, e As EventArgs) Handles DTP4.ValueChanged

    End Sub
End Class