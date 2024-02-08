Imports FontAwesome.Sharp

Public Class MainLayout
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New FlowLayoutPanel()
        leftBorderBtn.Size = New Size(7, 35)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'leftborder
            leftBorderBtn.BackColor = Color.White
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only one form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContent.Controls.Add(childForm)
        PanelContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender)
        OpenChildForm(New Dashboard)
    End Sub

    Private Sub btnJurusan_Click(sender As Object, e As EventArgs) Handles btnJurusan.Click
        ActivateButton(sender)
        OpenChildForm(New DataJurusan)
    End Sub

    Private Sub btnKelas_Click(sender As Object, e As EventArgs) Handles btnKelas.Click
        ActivateButton(sender)
        OpenChildForm(New DataKelas)
    End Sub

    Private Sub BtnSiswa_Click(sender As Object, e As EventArgs) Handles BtnSiswa.Click
        ActivateButton(sender)
        OpenChildForm(New DataSiswa)
    End Sub

    Private Sub BtnPetugas_Click(sender As Object, e As EventArgs) Handles BtnPetugas.Click
        ActivateButton(sender)
        OpenChildForm(New DataPetugas)
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        ActivateButton(sender)
        OpenChildForm(New DataTransaksi)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ActivateButton(sender)
        OpenChildForm(New DataLaporan)
    End Sub

End Class