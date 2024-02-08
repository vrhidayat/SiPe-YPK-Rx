<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridAngkatan = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbJumlahAngkatan = New System.Windows.Forms.Label()
        Me.lbAngkatan = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbJumlahKelas = New System.Windows.Forms.Label()
        Me.lbKelas = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbJumlahJurusan = New System.Windows.Forms.Label()
        Me.lbJurusan = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbJumlahPetugas = New System.Windows.Forms.Label()
        Me.lbPetugas = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbJumlahSiswa = New System.Windows.Forms.Label()
        Me.lbSiswa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNow = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbTotalTerima = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbTotalBulanTerima = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbTotalTahunTerima = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbTotalTransaksi = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbTotalBulanTransaksi = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lbTotalTahunTransaksi = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridAngkatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridAngkatan)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(33, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 405)
        Me.Panel1.TabIndex = 0
        '
        'DataGridAngkatan
        '
        Me.DataGridAngkatan.AllowUserToAddRows = False
        Me.DataGridAngkatan.AllowUserToDeleteRows = False
        Me.DataGridAngkatan.AllowUserToOrderColumns = True
        Me.DataGridAngkatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAngkatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAngkatan.Location = New System.Drawing.Point(13, 287)
        Me.DataGridAngkatan.Name = "DataGridAngkatan"
        Me.DataGridAngkatan.ReadOnly = True
        Me.DataGridAngkatan.RowHeadersVisible = False
        Me.DataGridAngkatan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridAngkatan.Size = New System.Drawing.Size(162, 105)
        Me.DataGridAngkatan.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(29, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Data Angkatan"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lbJumlahAngkatan)
        Me.Panel6.Controls.Add(Me.lbAngkatan)
        Me.Panel6.Location = New System.Drawing.Point(13, 199)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(162, 40)
        Me.Panel6.TabIndex = 5
        '
        'lbJumlahAngkatan
        '
        Me.lbJumlahAngkatan.AutoSize = True
        Me.lbJumlahAngkatan.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJumlahAngkatan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJumlahAngkatan.Location = New System.Drawing.Point(9, 12)
        Me.lbJumlahAngkatan.Name = "lbJumlahAngkatan"
        Me.lbJumlahAngkatan.Size = New System.Drawing.Size(16, 16)
        Me.lbJumlahAngkatan.TabIndex = 1
        Me.lbJumlahAngkatan.Text = "0"
        '
        'lbAngkatan
        '
        Me.lbAngkatan.AutoSize = True
        Me.lbAngkatan.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbAngkatan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbAngkatan.Location = New System.Drawing.Point(75, 12)
        Me.lbAngkatan.Name = "lbAngkatan"
        Me.lbAngkatan.Size = New System.Drawing.Size(75, 16)
        Me.lbAngkatan.TabIndex = 0
        Me.lbAngkatan.Text = "Angkatan"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbJumlahKelas)
        Me.Panel5.Controls.Add(Me.lbKelas)
        Me.Panel5.Location = New System.Drawing.Point(13, 153)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(162, 40)
        Me.Panel5.TabIndex = 4
        '
        'lbJumlahKelas
        '
        Me.lbJumlahKelas.AutoSize = True
        Me.lbJumlahKelas.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJumlahKelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJumlahKelas.Location = New System.Drawing.Point(9, 12)
        Me.lbJumlahKelas.Name = "lbJumlahKelas"
        Me.lbJumlahKelas.Size = New System.Drawing.Size(16, 16)
        Me.lbJumlahKelas.TabIndex = 1
        Me.lbJumlahKelas.Text = "0"
        '
        'lbKelas
        '
        Me.lbKelas.AutoSize = True
        Me.lbKelas.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbKelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbKelas.Location = New System.Drawing.Point(105, 12)
        Me.lbKelas.Name = "lbKelas"
        Me.lbKelas.Size = New System.Drawing.Size(45, 16)
        Me.lbKelas.TabIndex = 0
        Me.lbKelas.Text = "Kelas"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbJumlahJurusan)
        Me.Panel4.Controls.Add(Me.lbJurusan)
        Me.Panel4.Location = New System.Drawing.Point(13, 107)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(162, 40)
        Me.Panel4.TabIndex = 3
        '
        'lbJumlahJurusan
        '
        Me.lbJumlahJurusan.AutoSize = True
        Me.lbJumlahJurusan.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJumlahJurusan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJumlahJurusan.Location = New System.Drawing.Point(9, 12)
        Me.lbJumlahJurusan.Name = "lbJumlahJurusan"
        Me.lbJumlahJurusan.Size = New System.Drawing.Size(16, 16)
        Me.lbJumlahJurusan.TabIndex = 1
        Me.lbJumlahJurusan.Text = "0"
        '
        'lbJurusan
        '
        Me.lbJurusan.AutoSize = True
        Me.lbJurusan.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJurusan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJurusan.Location = New System.Drawing.Point(89, 12)
        Me.lbJurusan.Name = "lbJurusan"
        Me.lbJurusan.Size = New System.Drawing.Size(61, 16)
        Me.lbJurusan.TabIndex = 0
        Me.lbJurusan.Text = "Jurusan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbJumlahPetugas)
        Me.Panel3.Controls.Add(Me.lbPetugas)
        Me.Panel3.Location = New System.Drawing.Point(13, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(162, 40)
        Me.Panel3.TabIndex = 2
        '
        'lbJumlahPetugas
        '
        Me.lbJumlahPetugas.AutoSize = True
        Me.lbJumlahPetugas.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJumlahPetugas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJumlahPetugas.Location = New System.Drawing.Point(9, 12)
        Me.lbJumlahPetugas.Name = "lbJumlahPetugas"
        Me.lbJumlahPetugas.Size = New System.Drawing.Size(16, 16)
        Me.lbJumlahPetugas.TabIndex = 1
        Me.lbJumlahPetugas.Text = "0"
        '
        'lbPetugas
        '
        Me.lbPetugas.AutoSize = True
        Me.lbPetugas.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbPetugas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbPetugas.Location = New System.Drawing.Point(85, 12)
        Me.lbPetugas.Name = "lbPetugas"
        Me.lbPetugas.Size = New System.Drawing.Size(65, 16)
        Me.lbPetugas.TabIndex = 0
        Me.lbPetugas.Text = "Petugas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbJumlahSiswa)
        Me.Panel2.Controls.Add(Me.lbSiswa)
        Me.Panel2.Location = New System.Drawing.Point(13, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 40)
        Me.Panel2.TabIndex = 0
        '
        'lbJumlahSiswa
        '
        Me.lbJumlahSiswa.AutoSize = True
        Me.lbJumlahSiswa.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbJumlahSiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbJumlahSiswa.Location = New System.Drawing.Point(9, 12)
        Me.lbJumlahSiswa.Name = "lbJumlahSiswa"
        Me.lbJumlahSiswa.Size = New System.Drawing.Size(16, 16)
        Me.lbJumlahSiswa.TabIndex = 1
        Me.lbJumlahSiswa.Text = "0"
        '
        'lbSiswa
        '
        Me.lbSiswa.AutoSize = True
        Me.lbSiswa.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbSiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbSiswa.Location = New System.Drawing.Point(102, 12)
        Me.lbSiswa.Name = "lbSiswa"
        Me.lbSiswa.Size = New System.Drawing.Size(48, 16)
        Me.lbSiswa.TabIndex = 0
        Me.lbSiswa.Text = "Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(248, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang!"
        '
        'lbNow
        '
        Me.lbNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbNow.AutoSize = True
        Me.lbNow.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.lbNow.Location = New System.Drawing.Point(487, 44)
        Me.lbNow.Name = "lbNow"
        Me.lbNow.Size = New System.Drawing.Size(196, 14)
        Me.lbNow.TabIndex = 2
        Me.lbNow.Text = "Saturday, 27 Januari 2024 23:01:24"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Turquoise
        Me.Panel7.Controls.Add(Me.lbTotalTerima)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Location = New System.Drawing.Point(253, 94)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 86)
        Me.Panel7.TabIndex = 3
        '
        'lbTotalTerima
        '
        Me.lbTotalTerima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTerima.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalTerima.Name = "lbTotalTerima"
        Me.lbTotalTerima.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalTerima.TabIndex = 2
        Me.lbTotalTerima.Text = "0"
        Me.lbTotalTerima.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Penerimaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Wheat
        Me.Panel8.Controls.Add(Me.lbTotalBulanTerima)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(253, 194)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 86)
        Me.Panel8.TabIndex = 4
        '
        'lbTotalBulanTerima
        '
        Me.lbTotalBulanTerima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalBulanTerima.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalBulanTerima.Name = "lbTotalBulanTerima"
        Me.lbTotalBulanTerima.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalBulanTerima.TabIndex = 2
        Me.lbTotalBulanTerima.Text = "0"
        Me.lbTotalBulanTerima.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Penerimaan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Bulanan"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Plum
        Me.Panel9.Controls.Add(Me.lbTotalTahunTerima)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Location = New System.Drawing.Point(253, 294)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 86)
        Me.Panel9.TabIndex = 5
        '
        'lbTotalTahunTerima
        '
        Me.lbTotalTahunTerima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTahunTerima.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalTahunTerima.Name = "lbTotalTahunTerima"
        Me.lbTotalTahunTerima.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalTahunTerima.TabIndex = 2
        Me.lbTotalTahunTerima.Text = "0"
        Me.lbTotalTahunTerima.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Penerimaan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Total Tahunan"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel10.Controls.Add(Me.lbTotalTransaksi)
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Location = New System.Drawing.Point(490, 94)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 86)
        Me.Panel10.TabIndex = 5
        '
        'lbTotalTransaksi
        '
        Me.lbTotalTransaksi.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTransaksi.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalTransaksi.Name = "lbTotalTransaksi"
        Me.lbTotalTransaksi.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalTransaksi.TabIndex = 2
        Me.lbTotalTransaksi.Text = "0"
        Me.lbTotalTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Transaksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Total"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel11.Controls.Add(Me.lbTotalBulanTransaksi)
        Me.Panel11.Controls.Add(Me.Label16)
        Me.Panel11.Controls.Add(Me.Label17)
        Me.Panel11.Location = New System.Drawing.Point(490, 194)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(200, 86)
        Me.Panel11.TabIndex = 5
        '
        'lbTotalBulanTransaksi
        '
        Me.lbTotalBulanTransaksi.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalBulanTransaksi.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalBulanTransaksi.Name = "lbTotalBulanTransaksi"
        Me.lbTotalBulanTransaksi.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalBulanTransaksi.TabIndex = 2
        Me.lbTotalBulanTransaksi.Text = "0"
        Me.lbTotalBulanTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 18)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Transaksi"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 14)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Total Bulanan"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Orange
        Me.Panel12.Controls.Add(Me.lbTotalTahunTransaksi)
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.Label20)
        Me.Panel12.Location = New System.Drawing.Point(490, 294)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(200, 86)
        Me.Panel12.TabIndex = 5
        '
        'lbTotalTahunTransaksi
        '
        Me.lbTotalTahunTransaksi.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTahunTransaksi.Location = New System.Drawing.Point(90, 58)
        Me.lbTotalTahunTransaksi.Name = "lbTotalTahunTransaksi"
        Me.lbTotalTahunTransaksi.Size = New System.Drawing.Size(100, 23)
        Me.lbTotalTahunTransaksi.TabIndex = 2
        Me.lbTotalTahunTransaksi.Text = "0"
        Me.lbTotalTahunTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 18)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Transaksi"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 14)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Total Tahunan"
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 449)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.lbNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridAngkatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbJumlahAngkatan As Label
    Friend WithEvents lbAngkatan As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbJumlahKelas As Label
    Friend WithEvents lbKelas As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbJumlahJurusan As Label
    Friend WithEvents lbJurusan As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbJumlahPetugas As Label
    Friend WithEvents lbPetugas As Label
    Friend WithEvents lbJumlahSiswa As Label
    Friend WithEvents lbSiswa As Label
    Friend WithEvents DataGridAngkatan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbNow As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbTotalTerima As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbTotalBulanTerima As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lbTotalTahunTerima As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbTotalTransaksi As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbTotalBulanTransaksi As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lbTotalTahunTransaksi As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
End Class
