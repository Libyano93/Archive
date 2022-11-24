<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainPage))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddNewFolder = New System.Windows.Forms.ToolStripButton()
        Me.btnAddNewFile = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnExpandAll = New System.Windows.Forms.ToolStripButton()
        Me.btnCollaps = New System.Windows.Forms.ToolStripButton()
        Me.btnSendMail = New System.Windows.Forms.ToolStripButton()
        Me.btnDeletedPin = New System.Windows.Forms.ToolStripButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P_Side = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddNewUser = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnUserRoles = New System.Windows.Forms.Button()
        Me.P_Tail = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.P_Side.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(630, 42)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(630, 640)
        Me.Panel3.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.WebBrowser1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 42)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(630, 598)
        Me.Panel7.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(630, 598)
        Me.WebBrowser1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNewFolder, Me.btnAddNewFile, Me.btnRefresh, Me.btnExpandAll, Me.btnCollaps, Me.btnSendMail, Me.btnDeletedPin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(374, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddNewFolder
        '
        Me.btnAddNewFolder.AutoSize = False
        Me.btnAddNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddNewFolder.Image = Global.Electronic_Archives_System.My.Resources.Resources.folder_add
        Me.btnAddNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewFolder.Name = "btnAddNewFolder"
        Me.btnAddNewFolder.Size = New System.Drawing.Size(35, 35)
        Me.btnAddNewFolder.Text = "إضافة مجلد "
        '
        'btnAddNewFile
        '
        Me.btnAddNewFile.AutoSize = False
        Me.btnAddNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddNewFile.Image = Global.Electronic_Archives_System.My.Resources.Resources.book_add
        Me.btnAddNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewFile.Name = "btnAddNewFile"
        Me.btnAddNewFile.Size = New System.Drawing.Size(35, 35)
        Me.btnAddNewFile.Text = "إضافة ملف "
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = Global.Electronic_Archives_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(35, 35)
        Me.btnRefresh.Text = "تحديث"
        '
        'btnExpandAll
        '
        Me.btnExpandAll.AutoSize = False
        Me.btnExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExpandAll.Image = Global.Electronic_Archives_System.My.Resources.Resources.ExpandFieldPivotTable_16x16
        Me.btnExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExpandAll.Name = "btnExpandAll"
        Me.btnExpandAll.Size = New System.Drawing.Size(35, 35)
        Me.btnExpandAll.Text = "توسعة الشجرة"
        '
        'btnCollaps
        '
        Me.btnCollaps.AutoSize = False
        Me.btnCollaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCollaps.Image = Global.Electronic_Archives_System.My.Resources.Resources.CollapseFieldPivotTable_16x16
        Me.btnCollaps.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCollaps.Name = "btnCollaps"
        Me.btnCollaps.Size = New System.Drawing.Size(35, 35)
        Me.btnCollaps.Text = "طي الشجرة"
        '
        'btnSendMail
        '
        Me.btnSendMail.AutoSize = False
        Me.btnSendMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSendMail.Image = Global.Electronic_Archives_System.My.Resources.Resources.email_add
        Me.btnSendMail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(35, 35)
        Me.btnSendMail.Text = "إرسال ملف"
        '
        'btnDeletedPin
        '
        Me.btnDeletedPin.AutoSize = False
        Me.btnDeletedPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletedPin.Image = Global.Electronic_Archives_System.My.Resources.Resources.Trash_16x16
        Me.btnDeletedPin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeletedPin.Name = "btnDeletedPin"
        Me.btnDeletedPin.Size = New System.Drawing.Size(35, 35)
        Me.btnDeletedPin.Text = "سلة المحذوفات"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ToolStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(376, 40)
        Me.Panel5.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 29)
        Me.TextBox1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 31)
        Me.Panel6.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 73)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(378, 563)
        Me.TreeView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 73)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 640)
        Me.Panel1.TabIndex = 0
        '
        'P_Side
        '
        Me.P_Side.BackColor = System.Drawing.Color.SteelBlue
        Me.P_Side.Controls.Add(Me.Label2)
        Me.P_Side.Controls.Add(Me.btnAddNewUser)
        Me.P_Side.Controls.Add(Me.btnSettings)
        Me.P_Side.Controls.Add(Me.btnBackup)
        Me.P_Side.Controls.Add(Me.btnAbout)
        Me.P_Side.Controls.Add(Me.btnClose)
        Me.P_Side.Controls.Add(Me.Panel10)
        Me.P_Side.Controls.Add(Me.Panel9)
        Me.P_Side.Controls.Add(Me.Panel8)
        Me.P_Side.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_Side.Location = New System.Drawing.Point(0, 0)
        Me.P_Side.Name = "P_Side"
        Me.P_Side.Size = New System.Drawing.Size(120, 668)
        Me.P_Side.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 53)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "المستخدم الحالي" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "مدير النظام" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.user_add_icon
        Me.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.BorderSize = 0
        Me.btnAddNewUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewUser.Location = New System.Drawing.Point(5, 266)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.Size = New System.Drawing.Size(110, 52)
        Me.btnAddNewUser.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAddNewUser, "حسابات المستخدمين")
        Me.btnAddNewUser.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.Electronic_Archives_System.My.Resources.Resources._1309721023_setting_tools
        Me.btnSettings.Location = New System.Drawing.Point(2, 328)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(110, 49)
        Me.btnSettings.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSettings, "إعدادات الاتصال بالسيرفر")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Image = Global.Electronic_Archives_System.My.Resources.Resources.database_go
        Me.btnBackup.Location = New System.Drawing.Point(4, 382)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(110, 49)
        Me.btnBackup.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnBackup, "النسخ الاحتياطي")
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Image = Global.Electronic_Archives_System.My.Resources.Resources.Information_48x48
        Me.btnAbout.Location = New System.Drawing.Point(5, 437)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(110, 49)
        Me.btnAbout.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAbout, "حول البرنامج")
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.Windows_Turn_Off_icon_3_
        Me.btnClose.Location = New System.Drawing.Point(6, 500)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 45)
        Me.btnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnClose, "إغلاق البرنامج")
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.pictureBox2)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 546)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(120, 122)
        Me.Panel10.TabIndex = 2
        '
        'pictureBox2
        '
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(0, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(120, 88)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 20
        Me.pictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "12:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 45)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(120, 126)
        Me.Panel9.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.flat_seo_30_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 126)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnUserRoles)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 45)
        Me.Panel8.TabIndex = 0
        '
        'btnUserRoles
        '
        Me.btnUserRoles.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUserRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserRoles.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.BorderSize = 0
        Me.btnUserRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserRoles.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserRoles.ForeColor = System.Drawing.Color.White
        Me.btnUserRoles.Image = Global.Electronic_Archives_System.My.Resources.Resources._1322323808_group_key
        Me.btnUserRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserRoles.Location = New System.Drawing.Point(0, 0)
        Me.btnUserRoles.Name = "btnUserRoles"
        Me.btnUserRoles.Size = New System.Drawing.Size(120, 45)
        Me.btnUserRoles.TabIndex = 4
        Me.btnUserRoles.Text = "الصلاحيات"
        Me.btnUserRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnUserRoles, "صلاحيات المستخدمين")
        Me.btnUserRoles.UseVisualStyleBackColor = False
        '
        'P_Tail
        '
        Me.P_Tail.BackColor = System.Drawing.SystemColors.Control
        Me.P_Tail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P_Tail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Tail.Location = New System.Drawing.Point(120, 642)
        Me.P_Tail.Name = "P_Tail"
        Me.P_Tail.Size = New System.Drawing.Size(1020, 26)
        Me.P_Tail.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(120, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 642)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 5
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1140, 668)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.P_Tail)
        Me.Controls.Add(Me.P_Side)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmMainPage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامج الارشيف الالكتروني"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.P_Side.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnDeletedPin As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSendMail As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCollaps As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExpandAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddNewFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddNewFolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents P_Side As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewUser As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents P_Tail As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnUserRoles As System.Windows.Forms.Button

End Class
