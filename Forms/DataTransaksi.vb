Imports System.Data.Odbc

Public Class DataTransaksi
    Dim _nisn, _nama, _kelas, _angkatan, _petugas As String

    Sub reset()
        lbNoTransaksi.Text = "-"
        lbNISN.Text = "-"
        lbNama.Text = "-"
        lbKelas.Text = "-"
        lbNamaKelas.Text = "-"
        lbAngkatan.Text = "-"
        lbTahunAngkatan.Text = "-"
        lbPetugas.Text = "-"
        dtpTanggal.Text = Today
        cbBulan.SelectedIndex = -1
        tbJumlah.Clear()
    End Sub
    Public Sub getKelas(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM kelas WHERE id_kelas = {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "kelas")

            If DS.Tables("kelas").Rows.Count > 0 Then
                lbNamaKelas.Text = DS.Tables("kelas").Rows(0)("nama_kelas").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Sub

    Public Sub getAngkatan(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM spp WHERE id_spp= {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "spp")

            If DS.Tables("spp").Rows.Count > 0 Then
                lbTahunAngkatan.Text = DS.Tables("spp").Rows(0)("tahun").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Sub
    Sub buatIdTransaksi()
        Try
            Call openConn()
            CMD =
                New OdbcCommand("SELECT MAX(id_pembayaran) FROM pembayaran", Conn)
            Dim Hasil As String = ""
            Dim maxTRNS As Object = CMD.ExecuteScalar

            'fungsi if 2018+04+006
            If maxTRNS Is DBNull.Value Then
                Hasil = "TRNS" + "0001"
                lbNoTransaksi.Text = Hasil
            Else
                Dim lastNumber As Integer = Integer.Parse(maxTRNS.ToString().Substring(4))
                If lastNumber >= "9999" Then
                    Hasil = "TRNS" + "0001"
                Else
                    Dim nextNumber As Integer = lastNumber + 1
                    Hasil = "TRNS" + nextNumber.ToString("0000")
                End If
            End If
            lbNoTransaksi.Text = Hasil
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call closeConn()
        End Try
    End Sub
    Public Sub load_trSiswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT siswa.nisn, siswa.nis, siswa.nama,
                siswa.id_kelas, kelas.nama_kelas, siswa.alamat, siswa.no_telp, siswa.id_spp, spp.tahun 
                FROM siswa INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas INNER JOIN spp
                ON siswa.id_spp = spp.id_spp ORDER BY siswa.nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataGridSiswa.DataSource = DS.Tables("siswa")
            DataGridSiswa.ReadOnly = True
            DataGridSiswa.Columns("id_kelas").Visible = False
            DataGridSiswa.Columns("id_spp").Visible = False
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub
    Public Sub load_transaksi(_nisn As String)
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT a.id_pembayaran, a.nama_petugas,
                a.nisn, a.tgl_bayar, a.bulan_dibayar, a.jumlah_bayar, b.tahun 
                FROM pembayaran a JOIN spp b ON a.id_spp = b.id_spp
                WHERE a.nisn = {_nisn} ORDER BY a.tgl_bayar ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")
            DataGridTransaksi.DataSource = DS.Tables("pembayaran")
            DataGridTransaksi.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub
    Private Sub DataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_trSiswa()
    End Sub
    Private Sub DataGridSiswa_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridSiswa.SelectionChanged
        Try
            Dim i As Integer = DataGridSiswa.CurrentRow.Index
            Dim selectedYear As String = Convert.ToString(DataGridSiswa.Item(0, i).Value)

            _nisn = Convert.ToString(DataGridSiswa.Item(0, i).Value)
            _nama = Convert.ToString(DataGridSiswa.Item(2, i).Value)
            _kelas = Convert.ToString(DataGridSiswa.Item(3, i).Value)
            _angkatan = Convert.ToString(DataGridSiswa.Item(7, i).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridSiswa_Click(sender As Object, e As EventArgs) Handles DataGridSiswa.Click
        buatIdTransaksi()
        getKelas(_kelas)
        getAngkatan(_angkatan)
        lbNISN.Text = _nisn
        lbNama.Text = _nama
        lbKelas.Text = _kelas
        lbAngkatan.Text = _angkatan
        lbPetugas.Text = MainLayout.lbUserName.Text
        lbStsByrNama.Text = _nama
        load_transaksi(_nisn)
        Try
            openConn()
            DA = New OdbcDataAdapter($"SELECT nominal FROM spp WHERE id_spp={_angkatan}", Conn)
            DS = New DataSet
            DA.Fill(DS)
            If DS.Tables.Count > 0 AndAlso DS.Tables(0).Rows.Count > 0 Then
                ' Assuming "nominal" is the column name from the query result
                tbJumlah.Text = DS.Tables(0).Rows(0)("nominal").ToString()
            End If
        Catch ex As Exception
            closeConn()
        End Try
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA =
                New OdbcDataAdapter($"SELECT siswa.nisn, siswa.nis, siswa.nama,
                siswa.id_kelas, kelas.nama_kelas, siswa.alamat, siswa.no_telp, siswa.id_spp, spp.tahun 
                FROM siswa INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas INNER JOIN spp
                ON siswa.id_spp = spp.id_spp WHERE siswa.nisn like '%{TbCariData.Text}%' 
                OR siswa.nis LIKE '%{TbCariData.Text}%' OR siswa.nama LIKE '%{TbCariData.Text}%'
                OR kelas.nama_kelas LIKE '%{TbCariData.Text}%' OR spp.tahun LIKE '%{TbCariData.Text}%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridSiswa.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lbNoTransaksi.Text = "-"
        lbNISN.Text = "-"
        lbNama.Text = "-"
        lbKelas.Text = "-"
        lbNamaKelas.Text = "-"
        lbAngkatan.Text = "-"
        lbTahunAngkatan.Text = "-"
        lbPetugas.Text = "-"
        dtpTanggal.Text = Today
        cbBulan.SelectedIndex = -1
        tbJumlah.Clear()
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Try
            openConn()
            SQLInsert = "INSERT INTO pembayaran VALUES (?,?,?,?,?,?,?)"
            CMD = New OdbcCommand(SQLInsert, Conn)
            With CMD
                .Parameters.AddWithValue("@id_pembayaran", lbNoTransaksi.Text)
                .Parameters.AddWithValue("@nama_petugas", lbPetugas.Text)
                .Parameters.AddWithValue("@nisn", lbNISN.Text)
                .Parameters.AddWithValue("@tgl_bayar", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@bulan_dibayar", cbBulan.SelectedItem)
                .Parameters.AddWithValue("@jumlah_bayar", tbJumlah.Text)
                .Parameters.AddWithValue("@id_spp", lbAngkatan.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Data Tersimpan")
            'reset()
            load_transaksi(_nisn)
        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
End Class