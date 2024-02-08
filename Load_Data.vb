Imports System.Data.Odbc

Public Class Load_Data
    Dim rowCount As Integer
    Public disable As Color = Color.FromArgb(0, 0, 4)
    Public add As Color = Color.FromArgb(0, 123, 255)
    Public edit As Color = Color.FromArgb(40, 167, 69)
    Public delete As Color = Color.FromArgb(220, 53, 69)
    Public Function load_petugas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM petugas ORDER BY id_petugas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "petugas")
            DataPetugas.DataGridPetugas.DataSource = DS.Tables("petugas")
            DataPetugas.DataGridPetugas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_jurusan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM jurusan ORDER BY id_jurusan ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")
            DataJurusan.DataGridJurusan.DataSource = DS.Tables("jurusan")
            DataJurusan.DataGridJurusan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_kelas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas ORDER BY id_kelas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")
            DataKelas.DataGridKelas.DataSource = DS.Tables("kelas")
            DataKelas.DataGridKelas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_siswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa ORDER BY nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataSiswa.DataGridSiswa.DataSource = DS.Tables("siswa")
            DataSiswa.DataGridSiswa.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_trSiswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT siswa.nisn, siswa.nis, siswa.nama,
                siswa.id_kelas, kelas.nama_kelas, siswa.alamat, siswa.no_telp, siswa.id_spp, spp.tahun 
                FROM siswa INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas INNER JOIN spp
                ON siswa.id_spp = spp.id_spp ORDER BY siswa.nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataTransaksi.DataGridSiswa.DataSource = DS.Tables("siswa")
            DataTransaksi.DataGridSiswa.ReadOnly = True
            DataTransaksi.DataGridSiswa.Columns("id_kelas").Visible = False
            DataTransaksi.DataGridSiswa.Columns("id_spp").Visible = False
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_angkatan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT tahun FROM spp ORDER BY tahun ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "spp")
            Dashboard.DataGridAngkatan.DataSource = DS.Tables("spp")
            Dashboard.DataGridAngkatan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_transaksi(_nisn As String)
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT a.id_pembayaran, a.nama_petugas,
                a.nisn, a.tgl_bayar, a.bulan_dibayar, a.jumlah_bayar, b.tahun 
                FROM pembayaran a JOIN spp b ON a.id_spp = b.id_spp
                WHERE a.nisn = {_nisn} ORDER BY a.tgl_bayar ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")
            DataTransaksi.DataGridTransaksi.DataSource = DS.Tables("pembayaran")
            DataTransaksi.DataGridTransaksi.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_riwayat()
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT a.tgl_bayar, a.id_pembayaran,
                a.nisn, c.nama, a.bulan_dibayar, b.tahun, a.jumlah_bayar, a.nama_petugas
                FROM pembayaran a JOIN spp b USING(id_spp) JOIN siswa c USING(nisn)
                ORDER BY a.id_pembayaran ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")
            DataLaporan.DataGridLaporan.DataSource = DS.Tables("pembayaran")
            DataLaporan.DataGridLaporan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function


    Public Function getKelas(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM kelas WHERE id_kelas = {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "kelas")

            If DS.Tables("kelas").Rows.Count > 0 Then
                DataTransaksi.lbNamaKelas.Text = DS.Tables("kelas").Rows(0)("nama_kelas").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Function

    Public Function getAngkatan(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM spp WHERE id_spp= {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "spp")

            If DS.Tables("spp").Rows.Count > 0 Then
                DataTransaksi.lbTahunAngkatan.Text = DS.Tables("spp").Rows(0)("tahun").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Function
End Class
