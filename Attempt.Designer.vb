<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attempt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attempt))
        AttemptAccessDataGrid = New DataGridView()
        Label1 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        lblLogin = New Label()
        picboxDashboardBack = New PictureBox()
        CType(AttemptAccessDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picboxDashboardBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AttemptAccessDataGrid
        ' 
        AttemptAccessDataGrid.BackgroundColor = Color.White
        AttemptAccessDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AttemptAccessDataGrid.Location = New Point(3, 2)
        AttemptAccessDataGrid.Margin = New Padding(3, 2, 3, 2)
        AttemptAccessDataGrid.Name = "AttemptAccessDataGrid"
        AttemptAccessDataGrid.RowHeadersWidth = 51
        AttemptAccessDataGrid.Size = New Size(437, 365)
        AttemptAccessDataGrid.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Drawing.Font("Gotham", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 34)
        Label1.TabIndex = 1
        Label1.Text = "Login Logs"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Dock = DockStyle.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Drawing.Image)
        PictureBox5.Location = New Point(0, 0)
        PictureBox5.Margin = New Padding(20, 50, 20, 20)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(495, 99)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-9, 324)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 85)
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(83, 228)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(53, 49)
        PictureBox6.TabIndex = 38
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-188, 379)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(375, 448)
        PictureBox7.TabIndex = 36
        PictureBox7.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(302, -31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(211, 460)
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(AttemptAccessDataGrid)
        Panel1.Location = New Point(25, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(443, 369)
        Panel1.TabIndex = 40
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Drawing.Font("Gotham", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(43, 16)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(80, 16)
        lblLogin.TabIndex = 42
        lblLogin.Text = "Dashboard"
        ' 
        ' picboxDashboardBack
        ' 
        picboxDashboardBack.BackgroundImage = CType(resources.GetObject("picboxDashboardBack.BackgroundImage"), Drawing.Image)
        picboxDashboardBack.BackgroundImageLayout = ImageLayout.Zoom
        picboxDashboardBack.Location = New Point(0, 2)
        picboxDashboardBack.Name = "picboxDashboardBack"
        picboxDashboardBack.Size = New Size(44, 43)
        picboxDashboardBack.TabIndex = 41
        picboxDashboardBack.TabStop = False
        ' 
        ' Attempt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(495, 525)
        Controls.Add(lblLogin)
        Controls.Add(picboxDashboardBack)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox5)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Attempt"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(AttemptAccessDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(picboxDashboardBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AttemptAccessDataGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents picboxDashboardBack As PictureBox
End Class
