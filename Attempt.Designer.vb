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
        PictureBox6 = New PictureBox()
        Panel2 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(AttemptAccessDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AttemptAccessDataGrid
        ' 
        AttemptAccessDataGrid.BackgroundColor = Color.White
        AttemptAccessDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AttemptAccessDataGrid.Location = New Point(24, 70)
        AttemptAccessDataGrid.Margin = New Padding(3, 2, 3, 2)
        AttemptAccessDataGrid.Name = "AttemptAccessDataGrid"
        AttemptAccessDataGrid.RowHeadersWidth = 51
        AttemptAccessDataGrid.Size = New Size(437, 365)
        AttemptAccessDataGrid.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(488, 53)
        Panel2.TabIndex = 41
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New System.Drawing.Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(67, 14)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 31)
        Label2.TabIndex = 47
        Label2.Text = "Login Logs"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(9, 9)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(57, 38)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' Attempt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(488, 465)
        Controls.Add(AttemptAccessDataGrid)
        Controls.Add(Panel2)
        Controls.Add(PictureBox6)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Attempt"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Logs"
        CType(AttemptAccessDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AttemptAccessDataGrid As DataGridView
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
