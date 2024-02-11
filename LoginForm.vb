Imports System.Data.Odbc

Public Class LoginForm
    Private Property attempts As Integer
    Public Property userRole As String

    Private Sub checkLogin()
        Try
            Call openConn()
            'CMD = New OdbcCommand("SELECT * FROM users WHERE username = '" + tbusername.Text + "' AND password = '" + tbpassword.Text + "'", Conn)
            CMD = New OdbcCommand("SELECT * FROM petugas WHERE username = ? AND password = ?", Conn)
            'Assign parameters
            With CMD
                .Parameters.AddWithValue("@username", tbUsername.Text)
                .Parameters.AddWithValue("@password", tbPassword.Text)
            End With
            'Execute command
            Dim dr As OdbcDataReader = CMD.ExecuteReader()
            'Check if record exists
            If dr.HasRows Then
                dr.Read()
                'Reset attempts
                attempts = 0
                If Not dr.HasRows = 0 Then
                    If dr.Item("level") = "admin" And dr.Item("username") = tbUsername.Text Then
                        MessageBox.Show($"Welcome {dr.Item("nama_petugas")}!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        With MainLayout
                            Me.Hide()
                            .Show()
                            .lbUserName.Text = dr.Item("nama_petugas")
                            .lbUserLvl.Text = dr.Item("level")
                        End With
                    ElseIf dr.Item("level") = "petugas" And dr.Item("username") = tbUsername.Text Then
                        MessageBox.Show($"Welcome {dr.Item("nama_petugas")}!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        With MainLayout
                            Me.Hide()
                            .Show()
                            .lbUserName.Text = dr.Item("nama_petugas")
                            .lbUserLvl.Text = dr.Item("level")
                            .btnJurusan.Visible = False
                            .btnKelas.Visible = False
                            .BtnSiswa.Visible = False
                            .BtnPetugas.Visible = False
                        End With
                    Else
                        'Error message
                        MessageBox.Show("Incorrect username or password.")
                        tbUsername.Clear()
                        tbPassword.Clear()
                    End If
                Else
                    'Increment attempts
                    attempts += 1
                    'Check attempts limit
                    If attempts >= 3 Then
                        'Disable login button
                        btnLogin.Enabled = False
                        'Display message
                        MessageBox.Show("Too many failed attempts. Please try again later.")
                        tbPassword.Clear()
                        tbUsername.Clear()
                    Else
                        'Error message
                        MessageBox.Show("Incorrect username or password. Attempt " & attempts & " of 3.")
                        tbUsername.Clear()
                        tbPassword.Clear()
                    End If
                End If
            End If
            closeConn()
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        End Try
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If tbUsername.Text = "" Then
                MsgBox("Nama User tidak boleh kosong", MsgBoxStyle.Exclamation, "Kosong!")
                tbUsername.Focus()
            ElseIf tbPassword.Text = "" Then
                MsgBox("Nama Password tidak boleh kosong", MsgBoxStyle.Exclamation, "Kosong!")
                tbPassword.Focus()
            Else
                Call checkLogin()
            End If
        Catch ex As Exception
            MsgBox("err:" + ex.Message)
        End Try
        tbUsername.Clear()
        tbPassword.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Pesan As String
        Pesan = MsgBox("Anda Yakin Mau Keluar ?", vbQuestion + vbYesNo, "QUESTION")
        If Pesan = vbYes Then
            Me.Close()
            Application.Exit()
        Else
            tbPassword.Focus()
        End If
    End Sub
End Class
