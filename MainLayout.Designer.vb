<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainLayout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLaporan = New FontAwesome.Sharp.IconButton()
        Me.btnTransaksi = New FontAwesome.Sharp.IconButton()
        Me.BtnPetugas = New FontAwesome.Sharp.IconButton()
        Me.BtnSiswa = New FontAwesome.Sharp.IconButton()
        Me.btnKelas = New FontAwesome.Sharp.IconButton()
        Me.btnJurusan = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbUserLvl = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLaporan)
        Me.PanelMenu.Controls.Add(Me.btnTransaksi)
        Me.PanelMenu.Controls.Add(Me.BtnPetugas)
        Me.PanelMenu.Controls.Add(Me.BtnSiswa)
        Me.PanelMenu.Controls.Add(Me.btnKelas)
        Me.PanelMenu.Controls.Add(Me.btnJurusan)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(172, 540)
        Me.PanelMenu.TabIndex = 0
        '
        'btnLaporan
        '
        Me.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLaporan.IconChar = FontAwesome.Sharp.IconChar.FileText
        Me.btnLaporan.IconColor = System.Drawing.Color.White
        Me.btnLaporan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLaporan.IconSize = 32
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(0, 375)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(172, 35)
        Me.btnLaporan.TabIndex = 7
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        Me.btnTransaksi.IconColor = System.Drawing.Color.White
        Me.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTransaksi.IconSize = 32
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 340)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTransaksi.Size = New System.Drawing.Size(172, 35)
        Me.btnTransaksi.TabIndex = 6
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'BtnPetugas
        '
        Me.BtnPetugas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPetugas.FlatAppearance.BorderSize = 0
        Me.BtnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetugas.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPetugas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnPetugas.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.BtnPetugas.IconColor = System.Drawing.Color.White
        Me.BtnPetugas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnPetugas.IconSize = 32
        Me.BtnPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPetugas.Location = New System.Drawing.Point(0, 305)
        Me.BtnPetugas.Name = "BtnPetugas"
        Me.BtnPetugas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnPetugas.Size = New System.Drawing.Size(172, 35)
        Me.BtnPetugas.TabIndex = 5
        Me.BtnPetugas.Text = "Petugas"
        Me.BtnPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPetugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPetugas.UseVisualStyleBackColor = True
        '
        'BtnSiswa
        '
        Me.BtnSiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSiswa.FlatAppearance.BorderSize = 0
        Me.BtnSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiswa.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSiswa.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.BtnSiswa.IconColor = System.Drawing.Color.White
        Me.BtnSiswa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSiswa.IconSize = 32
        Me.BtnSiswa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSiswa.Location = New System.Drawing.Point(0, 270)
        Me.BtnSiswa.Name = "BtnSiswa"
        Me.BtnSiswa.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnSiswa.Size = New System.Drawing.Size(172, 35)
        Me.BtnSiswa.TabIndex = 4
        Me.BtnSiswa.Text = "Siswa"
        Me.BtnSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSiswa.UseVisualStyleBackColor = True
        '
        'btnKelas
        '
        Me.btnKelas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKelas.FlatAppearance.BorderSize = 0
        Me.btnKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKelas.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKelas.IconChar = FontAwesome.Sharp.IconChar.BuildingUser
        Me.btnKelas.IconColor = System.Drawing.Color.White
        Me.btnKelas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnKelas.IconSize = 32
        Me.btnKelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKelas.Location = New System.Drawing.Point(0, 235)
        Me.btnKelas.Name = "btnKelas"
        Me.btnKelas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnKelas.Size = New System.Drawing.Size(172, 35)
        Me.btnKelas.TabIndex = 3
        Me.btnKelas.Text = "Kelas"
        Me.btnKelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKelas.UseVisualStyleBackColor = True
        '
        'btnJurusan
        '
        Me.btnJurusan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJurusan.FlatAppearance.BorderSize = 0
        Me.btnJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJurusan.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJurusan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnJurusan.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.btnJurusan.IconColor = System.Drawing.Color.White
        Me.btnJurusan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnJurusan.IconSize = 32
        Me.btnJurusan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJurusan.Location = New System.Drawing.Point(0, 200)
        Me.btnJurusan.Name = "btnJurusan"
        Me.btnJurusan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnJurusan.Size = New System.Drawing.Size(172, 35)
        Me.btnJurusan.TabIndex = 2
        Me.btnJurusan.Text = "Jurusan"
        Me.btnJurusan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJurusan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJurusan.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 165)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(172, 35)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 165)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbUserLvl)
        Me.Panel1.Controls.Add(Me.lbUserName)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(30, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 100)
        Me.Panel1.TabIndex = 0
        '
        'lbUserLvl
        '
        Me.lbUserLvl.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lbUserLvl.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserLvl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbUserLvl.Location = New System.Drawing.Point(20, 75)
        Me.lbUserLvl.Name = "lbUserLvl"
        Me.lbUserLvl.Size = New System.Drawing.Size(72, 19)
        Me.lbUserLvl.TabIndex = 9
        Me.lbUserLvl.Text = "Level"
        Me.lbUserLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbUserName
        '
        Me.lbUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lbUserName.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbUserName.Location = New System.Drawing.Point(0, 60)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(113, 15)
        Me.lbUserName.TabIndex = 8
        Me.lbUserName.Text = "Name"
        Me.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox1.IconSize = 52
        Me.IconPictureBox1.Location = New System.Drawing.Point(30, 3)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(52, 54)
        Me.IconPictureBox1.TabIndex = 7
        Me.IconPictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(172, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(739, 52)
        Me.Panel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(66, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SMKS YPK PURWAKARTA | SPP PAYMENTS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SiPe_YPK_Rx.My.Resources.Resources.LogoYPK
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.SiPe_YPK_Rx.My.Resources.Resources.LogoYPK
        Me.PictureBox2.Location = New System.Drawing.Point(21, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 37)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(172, 52)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(739, 488)
        Me.PanelContent.TabIndex = 2
        '
        'MainLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 540)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "MainLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainLayout"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTransaksi As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPetugas As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSiswa As FontAwesome.Sharp.IconButton
    Friend WithEvents btnKelas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnJurusan As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbUserLvl As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelContent As Panel
    Friend WithEvents Button1 As Button
End Class
