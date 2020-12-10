Imports System.Data.Odbc

Public Class Penjualan
    Sub Bersihkan()
        ComboBox1.Text = ""
        LBLNamaCustomer.Text = ""
        LBLTotalHarga.Text = 0
        LBLTotalBarang.Text = 0
        LBLKembali.Text = 0
        TXTDibayar.Clear()
        DGV.Rows.Clear()
        ComboBox1.Focus()
    End Sub

    Sub FakturOtomatis()
        CMD = New OdbcCommand("select faktur from tabelpenjualan order by faktur desc", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            LBLFaktur.Text = Format(Today, "ddMMyy") + "0001"
        Else
            If Microsoft.VisualBasic.Left(DR.Item("faktur"), 6) = Format(Today, "ddMMyy") Then
                LBLFaktur.Text = DR.Item("faktur") + 1
            Else
                LBLFaktur.Text = Format(Today, "ddMMyy") + "0001"
            End If
        End If

    End Sub
    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call FakturOtomatis()
        LBLTanggal.Text = Format(Today, "yyyy-MM-dd")
        Call Bersihkan()
        CMD = New OdbcCommand("Select kode_customer from tabelcustomer", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item("kode_customer"))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tabelcustomer where kode_customer='" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            LBLNamaCustomer.Text = DR.Item("nama_customer")
        End If
    End Sub

    Sub HitungBarang()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(3).Value
        Next
        LBLTotalBarang.Text = hitung
    End Sub

    Sub HitungHarga()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(4).Value
        Next
        LBLTotalHarga.Text = hitung
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then

            For barisatas As Integer = 0 To DGV.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To DGV.RowCount - 1
                    If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                        DGV.Rows(barisatas).Cells(3).Value = DGV.Rows(barisatas).Cells(3).Value + 1
                        DGV.Rows(barisatas).Cells(4).Value = DGV.Rows(barisatas).Cells(2).Value * DGV.Rows(barisatas).Cells(3).Value

                        Call HitungHarga()
                        Call HitungBarang()

                        SendKeys.Send("{UP}")
                        DGV.Rows(barisbawah).Cells(0).Value = ""
                        Exit Sub
                    End If
                Next
            Next


            CMD = New OdbcCommand("select * from tabelbarang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = DR.Item("nama_barang")
                DGV.Rows(e.RowIndex).Cells(2).Value = DR.Item("harga_jual")
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Else
                MsgBox("kode tidak terdaftar")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
            End If

        End If
        If e.ColumnIndex = 3 Then
            Try
                CMD = New OdbcCommand("select * from tabelbarang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DGV.Rows(e.RowIndex).Cells(3).Value > DR.Item("stok") Then
                    MsgBox("stok hanya ada " & DR.Item("stok") & "")
                    SendKeys.Send("{UP}")
                    DGV.Rows(e.RowIndex).Cells(3).Value = DR.Item("stok")
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                Else
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                End If


                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Catch ex As Exception
                MsgBox("Harus angka")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            End Try
            DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
        End If

        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"

        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Call HitungBarang()
        Call HitungHarga()
    End Sub

    Private Sub BTNTutup_Click(sender As Object, e As EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub BTNBatal_Click(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Call Bersihkan()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGV.Rows.Remove(DGV.CurrentRow)
            Call HitungBarang()
            Call HitungHarga()
        End If
        If e.KeyChar = Chr(13) Then
            TXTDibayar.Focus()
        End If
    End Sub

    Private Sub TXTdibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TXTDibayar.Text) < Val(LBLTotalHarga.Text) Then
                MsgBox("Pembayaran kurang")
                BTNSimpan.Enabled = False
                Exit Sub
            ElseIf Val(TXTDibayar.Text) >= Val(LBLTotalHarga.Text) Then
                LBLKembali.Text = Val(TXTDibayar.Text) - Val(LBLTotalHarga.Text)
                BTNSimpan.Enabled = True
                BTNSimpan.Focus()
            End If
        End If

        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGV_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            DGV.Rows.Remove(DGV.CurrentRow)
            Call HitungHarga()
        End If
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or TXTDibayar.Text = "" Then
            MsgBox("Transaksi belum lengkap")
            Exit Sub
        End If
        Dim simpanpenjualan As String = "insert into tabelpenjualan values('" & LBLFaktur.Text & "','" & LBLTanggal.Text & "','" & ComboBox1.Text & "','" & LBLTotalHarga.Text & "','" & TXTDibayar.Text & "','" & LBLKembali.Text & "','" & MenuUtama.Panel1.Text & "')"
        CMD = New OdbcCommand(simpanpenjualan, CONN)
        CMD.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.RowCount - 2
            Dim simpandetail As String = "insert into tabeldetailjual values ('" & LBLFaktur.Text & "', '" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(2).Value & "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(4).Value & "')"
            CMD = New OdbcCommand(simpandetail, CONN)
            CMD.ExecuteNonQuery()

            CMD = New OdbcCommand("select * from tabelbarang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()


            If DR.HasRows Then
                Dim kurangistok As String = "update tabelbarang set stok='" & DR.Item("stok") - DGV.Rows(baris).Cells(3).Value & "' where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
                CMD = New OdbcCommand(kurangistok, CONN)
                CMD.ExecuteNonQuery()
            End If
        Next

        If MessageBox.Show("cetak faktur...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Cetak.Show()
            Cetak.CRV.SelectionFormula = "{tabelpenjualan.faktur}='" & LBLFaktur.Text & "'"
            Cetak.CRV.ReportSource = "faktur.rpt"
            Cetak.CRV.RefreshReport()
        End If

        Call Bersihkan()
        Call FakturOtomatis()
    End Sub

End Class