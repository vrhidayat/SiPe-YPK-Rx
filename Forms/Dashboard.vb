Imports System.Data.Odbc

Public Class Dashboard
    Dim loadData As New Load_Data
    Dim rowCount As Integer

    Public Function load_angkatan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT tahun FROM spp ORDER BY tahun ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "spp")
            DataGridAngkatan.DataSource = DS.Tables("spp")
            DataGridAngkatan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function
    Public Function count_siswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(nisn) FROM siswa", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")

            rowCount = Convert.ToInt32(DS.Tables("siswa").Rows(0)(0))

            lbJumlahSiswa.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_petugas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_petugas) FROM petugas", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "petugas")

            rowCount = Convert.ToInt32(DS.Tables("petugas").Rows(0)(0))

            lbJumlahPetugas.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_jurusan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_jurusan) FROM jurusan", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")

            rowCount = Convert.ToInt32(DS.Tables("jurusan").Rows(0)(0))

            lbJumlahJurusan.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_kelas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_kelas) FROM kelas", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")

            rowCount = Convert.ToInt32(DS.Tables("kelas").Rows(0)(0))

            lbJumlahKelas.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_angkatan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_spp) FROM spp", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "spp")

            rowCount = Convert.ToInt32(DS.Tables("spp").Rows(0)(0))

            lbJumlahAngkatan.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TTransaksi()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(*) FROM pembayaran", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            lbTotalTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TBulanTransaksi()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(*) FROM pembayaran WHERE MONTH(tgl_bayar) = MONTH(NOW())", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            lbTotalBulanTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TTahunTransaksi(year As String)
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT COUNT(*) FROM pembayaran WHERE YEAR(tgl_bayar) = {year}", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            lbTotalTahunTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function sum_TTerima()
        Try
            openConn()
            Dim query As String = "SELECT SUM(jumlah_bayar) FROM pembayaran"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    lbTotalTerima.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    lbTotalTerima.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function

    Public Function sum_TBulanTerima()
        Try
            openConn()
            Dim query As String = "SELECT SUM(jumlah_bayar) FROM pembayaran WHERE MONTH(tgl_bayar) = MONTH(NOW())"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    lbTotalBulanTerima.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    lbTotalBulanTerima.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function

    Public Function sum_TTahunTerima(year As String)
        Try
            openConn()
            Dim query As String = $"SELECT SUM(jumlah_bayar) FROM pembayaran WHERE YEAR(tgl_bayar) = {year}"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    lbTotalTahunTerima.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    lbTotalTahunTerima.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function
    Private Sub DataGridAngkatan_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridAngkatan.SelectionChanged
        Try
            Dim i As Integer = DataGridAngkatan.CurrentRow.Index
            Dim selectedYear As String = Convert.ToString(DataGridAngkatan.Item(0, i).Value)

            ' Call the count_TTahunTransaksi function with the selected year
            count_TTahunTransaksi(selectedYear)
            sum_TTahunTerima(selectedYear)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count_siswa()
        count_petugas()
        count_jurusan()
        count_kelas()
        count_angkatan()
        load_angkatan()

        count_TTransaksi()
        count_TBulanTransaksi()

        sum_TTerima()
        sum_TBulanTerima()

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FT As DateTime = New DateTime()
        lbNow.Text = FT.Now.ToString("F")
    End Sub
End Class