Imports System.Data.Odbc

Public Class CRView
    Sub PrintBasedDate()
        Dim rpt As New Report

        Dim fromDate = Format(dtpStart.Value, "dd/MM/yyyy").ToString
        Dim toDate = Format(dtpEnd.Value, "dd/MM/yyyy").ToString

        Try
            openConn()
            SQLInsert = $"SELECT a.tgl_bayar, a.id_pembayaran,
                a.nisn, c.nama, a.bulan_dibayar, b.tahun, a.jumlah_bayar, a.nama_petugas
                FROM pembayaran a JOIN spp b ON a.id_spp = b.id_spp
                 JOIN siswa c ON a.nisn = c.nisn
                WHERE (a.tgl_bayar BETWEEN ('{fromDate}') AND ('{toDate}'))"
            CMD = New OdbcCommand(SQLInsert, Conn)
            DA = New OdbcDataAdapter(CMD)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS)

            rpt.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = rpt
            closeConn()

            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class