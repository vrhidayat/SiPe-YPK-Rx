Imports System.Data.Odbc

Public Class DataJurusan
    Dim _id, _nama As String
    Sub formKosong()
        tbIdJurusan.Text = "auto"
        tbNamaJurusan.Clear()
    End Sub

    Sub formNormal()
        tbIdJurusan.Enabled = False
        tbNamaJurusan.Enabled = False
    End Sub

    Public Function load_jurusan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM jurusan ORDER BY id_jurusan ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")
            DataGridJurusan.DataSource = DS.Tables("jurusan")
            DataGridJurusan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Private Sub cbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter($"SELECT * FROM jurusan WHERE nama_jurusan like '%{tbCari.Text}%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridJurusan.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            tbNamaJurusan.Enabled = True
            btnBatal.Visible = True
            DataGridJurusan.Enabled = False
            tbCari.Enabled = False
            btnTambah.Text = "Simpan"
        ElseIf btnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO jurusan(nama_jurusan) VALUES (?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_jurusan", tbNamaJurusan.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan")
                formKosong()
                formNormal()
                load_jurusan()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                btnTambah.Text = "Tambah"
                btnBatal.Visible = False
                DataGridJurusan.Enabled = True
                tbCari.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DataGridJurusan_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridJurusan.SelectionChanged
        Dim i As Integer = DataGridJurusan.CurrentRow.Index
        _id = Convert.ToString(DataGridJurusan.Item(0, i).Value)
        _nama = Convert.ToString(DataGridJurusan.Item(1, i).Value)
    End Sub

    Private Sub DataGridJurusan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJurusan.CellDoubleClick
        tbIdJurusan.Text = _id
        tbNamaJurusan.Text = _nama

        tbNamaJurusan.Enabled = True

        DataGridJurusan.Enabled = False
        tbCari.Enabled = False
        btnTambah.Visible = False
        btnEdit.Visible = True
        btnHapus.Visible = True
        btnBatal.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE jurusan set nama_jurusan= ? WHERE id_jurusan like '" & tbIdJurusan.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_jurusan", tbNamaJurusan.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_jurusan()
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnTambah.Visible = True
                btnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridJurusan.Enabled = True
            tbCari.Enabled = True
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Konfirmasi As String

        Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion,
       "Informasi")
        If Konfirmasi = vbYes Then
            Try
                Call openConn()
                SQLDelete = "DELETE FROM jurusan WHERE id_jurusan='" & tbIdJurusan.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                formNormal()
                load_jurusan()
                btnTambah.Visible = True
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridJurusan.Enabled = True
                tbCari.Enabled = True
            End Try
        Else
            tbNamaJurusan.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        formKosong()
        formNormal()
        btnTambah.Visible = True
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False
        DataGridJurusan.Enabled = True
        tbCari.Enabled = True
    End Sub

    Private Sub DataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False

        formNormal()
        load_jurusan()
    End Sub
End Class