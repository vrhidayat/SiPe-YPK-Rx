Imports System.Data.Odbc

Public Class DataKelas
    Dim _id, _nama, _jurusan As String
    Sub formKosong()
        TbIdKelas.Text = "auto"
        TbNamaKelas.Clear()
        cbJurusan.DataSource = Nothing
    End Sub

    Sub formNormal()
        tbIdKelas.Enabled = False
        tbNamaKelas.Enabled = False
        cbJurusan.Enabled = False
    End Sub
    Sub getJurusan()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM jurusan", Conn)
            DS = New DataSet
            DA.Fill(DS, "jurusan")
            cbJurusan.DataSource = DS.Tables("jurusan")
            cbJurusan.DisplayMember = "nama_jurusan"
            cbJurusan.ValueMember = "id_jurusan"
            cbJurusan.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub tbCariData_TextChanged(sender As Object, e As EventArgs) Handles tbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas WHERE nama_kelas like '%" & tbCariData.Text & "%' OR kompetensi_keahlian like '%" & tbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridKelas.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            tbNamaKelas.Enabled = True
            cbJurusan.Enabled = True
            btnBatal.Visible = True
            DataGridKelas.Enabled = False
            tbCariData.Enabled = False
            getJurusan()
            btnTambah.Text = "Simpan"
        ElseIf btnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO kelas(nama_kelas, id_jurusan) VALUES (?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    '.Parameters.AddWithValue("@id_kelas", tbi.Text)
                    .Parameters.AddWithValue("@nama_kelas", tbNamaKelas.Text)
                    .Parameters.AddWithValue("@id_jurusan", cbJurusan.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                load_kelas()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                btnTambah.Text = "Tambah"
                btnBatal.Visible = False
                DataGridKelas.Enabled = True
                tbCariData.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DataGridKelas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridKelas.SelectionChanged
        Dim i As Integer = DataGridKelas.CurrentRow.Index
        _id = Convert.ToString(DataGridKelas.Item(0, i).Value)
        _nama = Convert.ToString(DataGridKelas.Item(1, i).Value)
        _jurusan = DataGridKelas.Item(2, i).Value
    End Sub

    Private Sub DataGridKelas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKelas.CellDoubleClick
        tbIdKelas.Text = _id
        tbNamaKelas.Text = _nama
        cbJurusan.SelectedValue = _jurusan

        tbIdKelas.Enabled = True
        tbNamaKelas.Enabled = True
        cbJurusan.Enabled = True

        DataGridKelas.Enabled = False
        tbCariData.Enabled = False
        btnTambah.Visible = False
        btnEdit.Visible = True
        btnHapus.Visible = True
        btnBatal.Visible = True
        getJurusan()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            openConn()

            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE kelas set nama_kelas= ?, id_jurusan= ? WHERE id_kelas like '" & tbIdKelas.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_kelas", tbNamaKelas.Text)
                    .Parameters.AddWithValue("@id_jurusan", cbJurusan.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_kelas()
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnTambah.Visible = True
                btnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridKelas.Enabled = True
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
                SQLDelete = "DELETE FROM kelas WHERE id_kelas ='" & tbIdKelas.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                load_kelas()
                btnTambah.Visible = True
                btnEdit.Visible = False
                btnHapus.Visible = False
                btnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridKelas.Enabled = True
                tbCariData.Enabled = True
            End Try
        Else
            tbNamaKelas.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        formKosong()
        formNormal()
        btnTambah.Visible = True
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False
        DataGridKelas.Enabled = True
        tbCariData.Enabled = True
    End Sub

    Public Function load_kelas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas ORDER BY id_kelas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")
            DataGridKelas.DataSource = DS.Tables("kelas")
            DataGridKelas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function
    Private Sub DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnBatal.Visible = False

        formNormal()
        load_kelas()
    End Sub
End Class