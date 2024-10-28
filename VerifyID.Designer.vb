<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyIDForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerifyIDForm))
        txtVerifyID = New TextBox()
        btnVerifyID = New Button()
        lblTip = New Label()
        picboxLoginBack = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        picboxMenu = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtVerifyID
        ' 
        txtVerifyID.Anchor = AnchorStyles.None
        txtVerifyID.BorderStyle = BorderStyle.FixedSingle
        txtVerifyID.Font = New System.Drawing.Font("Gotham", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVerifyID.ForeColor = Color.DarkGray
        txtVerifyID.Location = New Point(67, 159)
        txtVerifyID.Name = "txtVerifyID"
        txtVerifyID.Size = New Size(156, 27)
        txtVerifyID.TabIndex = 1
        txtVerifyID.Text = "Employee ID"
        txtVerifyID.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnVerifyID
        ' 
        btnVerifyID.Anchor = AnchorStyles.None
        btnVerifyID.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnVerifyID.Font = New System.Drawing.Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerifyID.ForeColor = Color.Transparent
        btnVerifyID.Location = New Point(95, 214)
        btnVerifyID.Name = "btnVerifyID"
        btnVerifyID.Size = New Size(107, 46)
        btnVerifyID.TabIndex = 1
        btnVerifyID.Text = "Verify"
        btnVerifyID.UseVisualStyleBackColor = False
        ' 
        ' lblTip
        ' 
        lblTip.Anchor = AnchorStyles.None
        lblTip.AutoSize = True
        lblTip.BackColor = Color.Transparent
        lblTip.Cursor = Cursors.Help
        lblTip.Font = New System.Drawing.Font("Gotham", 7.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTip.ForeColor = SystemColors.ActiveCaptionText
        lblTip.Location = New Point(95, 194)
        lblTip.Margin = New Padding(5)
        lblTip.Name = "lblTip"
        lblTip.Size = New Size(107, 12)
        lblTip.TabIndex = 27
        lblTip.Text = "ID Format: TBR-XXX"
        lblTip.Visible = False
        ' 
        ' picboxLoginBack
        ' 
        picboxLoginBack.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        picboxLoginBack.BackgroundImage = CType(resources.GetObject("picboxLoginBack.BackgroundImage"), Drawing.Image)
        picboxLoginBack.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginBack.Cursor = Cursors.Hand
        picboxLoginBack.Location = New Point(3, 3)
        picboxLoginBack.Margin = New Padding(3, 4, 3, 4)
        picboxLoginBack.Name = "picboxLoginBack"
        picboxLoginBack.Size = New Size(37, 33)
        picboxLoginBack.TabIndex = 29
        picboxLoginBack.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Drawing.Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(99, 95)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(94, 56)
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel4.BackgroundImageLayout = ImageLayout.Zoom
        Panel4.Controls.Add(picboxMenu)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(299, 84)
        Panel4.TabIndex = 42
        ' 
        ' picboxMenu
        ' 
        picboxMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picboxMenu.BackColor = Color.Transparent
        picboxMenu.BackgroundImage = CType(resources.GetObject("picboxMenu.BackgroundImage"), Drawing.Image)
        picboxMenu.BackgroundImageLayout = ImageLayout.Zoom
        picboxMenu.Location = New Point(1414, 10)
        picboxMenu.Margin = New Padding(70, 30, 30, 30)
        picboxMenu.Name = "picboxMenu"
        picboxMenu.Padding = New Padding(30, 0, 0, 0)
        picboxMenu.Size = New Size(66, 38)
        picboxMenu.TabIndex = 34
        picboxMenu.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 5)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(299, 75)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' VerifyIDForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(299, 289)
        Controls.Add(btnVerifyID)
        Controls.Add(txtVerifyID)
        Controls.Add(picboxLoginBack)
        Controls.Add(PictureBox3)
        Controls.Add(lblTip)
        Controls.Add(Panel4)
        Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(77))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "VerifyIDForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Verify ID"
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(picboxMenu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtVerifyID As TextBox
    Friend WithEvents btnVerifyID As Button
    Friend WithEvents lblTip As Label
    Friend WithEvents picboxLoginBack As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
