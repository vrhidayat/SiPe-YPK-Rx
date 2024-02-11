Imports System.Data.Odbc

Public Class DataPetugas
    Dim _id, _username, _password, _nama, _level As String

    Sub formKosong()
        tbIdPetugas.Text = "auto"
        tbUsername.Clear()
        tbPassword.Clear()
        tbNamaPetugas.Clear()
        cbLevel.SelectedIndex = -1
    End Sub

    Sub formNormal()
        tbIdPetugas.Enabled = False
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        tbNamaPetugas.Enabled = False
        cbLevel.Enabled = False
    End Sub
    Public Function load_petugas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM petugas ORDER BY id_petugas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "petugas")
            DataGridPetugas.DataSource = DS.Tables("petugas")
            DataGridPetugas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function
    Private Sub DataPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False

        formNormal()
        load_petugas()
    End Sub
    Private Sub tbCariData_TextChanged(sender As Object, e As EventArgs) Handles tbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM petugas WHERE username like '%" & tbCariData.Text & "%' OR nama_petugas like '%" & tbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridPetugas.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            tbUsername.Enabled = True
            tbPassword.Enabled = True
            tbNamaPetugas.Enabled = True
            cbLevel.Enabled = True

            btnBatal.Visible = True
            DataGridPetugas.Enabled = False
            tbCariData.Enabled = False
            btnTambah.Text = "Simpan"
        ElseIf btnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO petugas(username, password, nama_petugas, level) VALUES (?,?,?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    '.Parameters.AddWithValue("@id_kelas", tbi.Text)
                    .Parameters.AddWithValue("@username", tbUsername.Text)
                    .Parameters.AddWithValue("@password", tbPassword.Text)
                    .Parameters.AddWithValue("@nama_petugas", tbNamaPetugas.Text)
                    .Parameters.AddWithValue("@level", cbLevel.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                load_petugas()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                btnTambah.Text = "Tambah"
                btnBatal.Visible = False
                DataGridPetugas.Enabled = True
                tbCariData.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DataGridPetugas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridPetugas.SelectionChanged
        Dim i As Integer = DataGridPetugas.CurrentRow.Index
        _id = Convert.ToString(DataGridPetugas.Item(0, i).Value)
        _username = Convert.ToString(DataGridPetugas.Item(1, i).Value)
        _password = Convert.ToString(DataGridPetugas.Item(2, i).Value)
        _nama = Convert.ToString(DataGridPetugas.Item(3, i).Value)
        _level = Convert.ToString(DataGridPetugas.Item(4, i).Value)
    End Sub

    Private Sub DataGridPetugas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPetugas.CellDoubleClick
        tbUsername.Enabled = True
        tbPassword.Enabled = True
        tbNamaPetugas.Enabled = True
        cbLevel.Enabled = True

        tbIdPetugas.Text = _id
        tbUsername.Text = _username
        tbPassword.Text = _password
        tbNamaPetugas.Text = _nama
        cbLevel.SelectedItem = _level

        DataGridPetugas.Enabled = False
        tbCariData.Enabled = False
        btnTambah.Visible = False
        btnEdit.Visible = True
        btnHapus.Visible = True
        btnBatal.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = $"UPDATE petugas set username= ?, password= ?, nama_petugas=?, level=? WHERE id_petugas = '{tbIdPetugas.Text}'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@username", tbUsername.Text)
                    .Parameters.AddWithValue("@password", tbPassword.Text)
                    .Parameters.AddWithValue("@nama_petugas", tbNamaPetugas.Text)
                    .Parameters.AddWithValue("@level", cbLevel.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_petugas()
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnTambah.Visible = True
                btnBatal.Visible = False
            End If

            closeConn()
            DataGridPetugas.Enabled = True
            tbCariData.Enabled = True
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Konfirmasi As String

        Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion,
       "Informasi")
        If Konfirmasi = vbYes Then
            Try
                Call openConn()
                SQLDelete = "DELETE FROM petugas WHERE id_petugas ='" & tbIdPetugas.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                Call formKosong()
                load_petugas()
                btnTambah.Visible = True
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
            End Try
        Else
            tbUsername.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        formKosong()
        formNormal()
        btnTambah.Visible = True
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False
        DataGridPetugas.Enabled = True
        tbCariData.Enabled = True
    End Sub
End Class