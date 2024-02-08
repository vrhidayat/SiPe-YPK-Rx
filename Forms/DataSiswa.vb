Imports System.Data.Odbc

Public Class DataSiswa
    Dim _nisn, _nis, _nama, _id_kelas, _alamat, _no_telp, _id_spp As String

    Sub formKosong()
        'Membuat Sub Prosedure untuk Mengosongkan Object
        tbNISNold.Clear()
        tbNISN.Clear()
        tbNIS.Clear()
        TbNamaSiswa.Clear()
        cbKelas.DataSource = Nothing
        cbAngkatan.DataSource = Nothing
        tbAlamat.Clear()
        tbNoTelp.Clear()
    End Sub

    Sub formNormal()
        tbNISN.Enabled = False
        tbNIS.Enabled = False
        tbNamaSiswa.Enabled = False
        cbKelas.Enabled = False
        cbAngkatan.Enabled = False
        tbAlamat.Enabled = False
        tbNoTelp.Enabled = False
    End Sub

    Sub formOpen()
        tbNISN.Enabled = True
        tbNIS.Enabled = True
        tbNamaSiswa.Enabled = True
        cbKelas.Enabled = True
        cbAngkatan.Enabled = True
        tbAlamat.Enabled = True
        tbNoTelp.Enabled = True
    End Sub

    Sub getKelas()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM kelas", Conn)
            DS = New DataSet
            DA.Fill(DS, "kelas")
            cbKelas.DataSource = DS.Tables("kelas")
            cbKelas.DisplayMember = "nama_kelas"
            cbKelas.ValueMember = "id_kelas"
            cbKelas.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Sub getSPP()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM spp", Conn)
            DS = New DataSet
            DA.Fill(DS, "spp")
            cbAngkatan.DataSource = DS.Tables("spp")
            cbAngkatan.DisplayMember = "tahun"
            cbAngkatan.ValueMember = "id_spp"
            cbKelas.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
    Public Function load_siswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa ORDER BY nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataGridSiswa.DataSource = DS.Tables("siswa")
            DataGridSiswa.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function
    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa WHERE nisn like '%" & tbCariData.Text & "%' OR nis like '%" & tbCariData.Text & "%' OR nama like '%" & tbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridSiswa.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            formOpen()
            btnBatal.Visible = True
            DataGridSiswa.Enabled = False
            tbCariData.Enabled = False
            btnTambah.Text = "Simpan"
            openConn()
            getKelas()
            getSPP()
        ElseIf btnTambah.Text = "Simpan" Then
            Try
                SQLInsert = "INSERT INTO siswa VALUES (?,?,?,?,?,?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    .Parameters.AddWithValue("@nisn", tbNISN.Text)
                    .Parameters.AddWithValue("@nis", tbNIS.Text)
                    .Parameters.AddWithValue("@nama", tbNamaSiswa.Text)
                    .Parameters.AddWithValue("@id_kelas", cbKelas.SelectedItem)
                    .Parameters.AddWithValue("@no_telp", tbNoTelp.Text)
                    .Parameters.AddWithValue("@id_spp", cbAngkatan.SelectedItem)
                    .Parameters.AddWithValue("@alamat", tbAlamat.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                formNormal()
                load_siswa()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                btnTambah.Text = "Tambah"
                btnBatal.Visible = False
                DataGridSiswa.Enabled = True
                tbCariData.Enabled = True
            End Try
        End If
    End Sub
    Private Sub DataGridSiswa_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridSiswa.SelectionChanged
        Dim i As Integer = DataGridSiswa.CurrentRow.Index
        _nisn = Convert.ToString(DataGridSiswa.Item(0, i).Value)
        _nis = Convert.ToString(DataGridSiswa.Item(1, i).Value)
        _nama = Convert.ToString(DataGridSiswa.Item(2, i).Value)
        _id_kelas = DataGridSiswa.Item(3, i).Value
        _alamat = Convert.ToString(DataGridSiswa.Item(4, i).Value)
        _no_telp = Convert.ToString(DataGridSiswa.Item(5, i).Value)
        _id_spp = DataGridSiswa.Item(6, i).Value
    End Sub

    Private Sub DataGridSiswa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSiswa.CellDoubleClick
        getSPP()
        getKelas()
        tbNISN.Text = _nisn
        tbNISNold.Text = _nisn
        tbNIS.Text = _nis
        tbNamaSiswa.Text = _nama
        cbKelas.SelectedValue = _id_kelas
        tbAlamat.Text = _alamat
        tbNoTelp.Text = _no_telp
        cbAngkatan.SelectedValue = _id_spp

        formOpen()

        DataGridSiswa.Enabled = False
        tbCariData.Enabled = False
        btnTambah.Visible = False
        btnEdit.Visible = True
        btnHapus.Visible = True
        btnBatal.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update this data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE siswa set nisn= ?, nis= ?, nama=?, id_kelas=?, alamat=?, no_telp=?, id_spp=? WHERE nisn like '" & tbNISNold.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nisn", tbNISN.Text)
                    .Parameters.AddWithValue("@nis", tbNIS.Text)
                    .Parameters.AddWithValue("@nama", tbNamaSiswa.Text)
                    .Parameters.AddWithValue("@id_kelas", cbKelas.SelectedValue)
                    .Parameters.AddWithValue("@alamat", tbAlamat.Text)
                    .Parameters.AddWithValue("@no_telp", tbNoTelp.Text)
                    .Parameters.AddWithValue("@id_spp", cbAngkatan.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_siswa()
                formNormal()
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnTambah.Visible = True
                btnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridSiswa.Enabled = True
            tbCariData.Enabled = True
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Konfirmasi As String

        Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion,
       "Informasi")
        If Konfirmasi = vbYes Then
            Try
                Call openConn()
                SQLDelete = "DELETE FROM siswa WHERE nisn ='" & tbNISNold.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                formNormal()
                load_siswa()
                btnTambah.Visible = True
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridSiswa.Enabled = True
                tbCariData.Enabled = True
            End Try
        Else
            tbNISN.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        formKosong()
        formNormal()
        btnTambah.Visible = True
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False
        DataGridSiswa.Enabled = True
        tbCariData.Enabled = True
    End Sub

    Private Sub DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False

        tbNISNold.Visible = False

        formNormal()
        load_siswa()
    End Sub
End Class