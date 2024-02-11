Imports System.Data.Odbc

Public Class DataLaporan
    Public Sub load_laporan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT a.tgl_bayar, a.id_pembayaran,
                a.nisn, c.nama, a.bulan_dibayar, b.tahun, a.jumlah_bayar, a.nama_petugas
                FROM pembayaran a JOIN spp b USING(id_spp) JOIN siswa c USING(nisn)
                ORDER BY a.id_pembayaran ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")
            DataGridLaporan.DataSource = DS.Tables("pembayaran")
            DataGridLaporan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub

    Private Sub DataLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_laporan()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            openConn()
            SQLInsert = "SELECT a.tgl_bayar, a.id_pembayaran,
                a.nisn, c.nama, a.bulan_dibayar, b.tahun, a.jumlah_bayar, a.nama_petugas
                FROM pembayaran a JOIN spp b ON a.id_spp = b.id_spp
                 JOIN siswa c ON a.nisn = c.nisn
                WHERE a.tgl_bayar BETWEEN ? AND ?"
            CMD = New OdbcCommand(SQLInsert, Conn)
            With CMD
                .Parameters.AddWithValue("@date1", DateAdd(DateInterval.Day, -1, dtpStart.Value))
                .Parameters.AddWithValue("@date2", dtpEnd.Value)
            End With
            DA = New OdbcDataAdapter(CMD)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS)
            DataGridLaporan.DataSource = DS.Tables(0)
            DataGridLaporan.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load_laporan()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim CReport As New CRView
        CReport.dtpStart.Value = dtpStart.Value
        CReport.dtpEnd.Value = dtpEnd.Value

        Call CReport.PrintBasedDate()
        CReport.ShowDialog()
    End Sub
End Class