<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientF))
        btnAddClient = New Button()
        lblClientName = New Label()
        txtClientName = New TextBox()
        lblRegion = New Label()
        cmbRegion = New ComboBox()
        ClientDataGrid = New DataGridView()
        btnSaveChanges = New Button()
        btnCancel = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        rdbtnClientName = New RadioButton()
        rdbtnRegion = New RadioButton()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(ClientDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddClient
        ' 
        btnAddClient.BackColor = Color.Navy
        btnAddClient.FlatAppearance.BorderSize = 0
        btnAddClient.FlatStyle = FlatStyle.Flat
        btnAddClient.ForeColor = Color.White
        btnAddClient.Location = New Point(25, 296)
        btnAddClient.Name = "btnAddClient"
        btnAddClient.Size = New Size(371, 32)
        btnAddClient.TabIndex = 0
        btnAddClient.Text = "Add Client"
        btnAddClient.UseVisualStyleBackColor = False
        ' 
        ' lblClientName
        ' 
        lblClientName.AutoSize = True
        lblClientName.Location = New Point(25, 80)
        lblClientName.Name = "lblClientName"
        lblClientName.Size = New Size(133, 18)
        lblClientName.TabIndex = 1
        lblClientName.Text = "Client's Full Name"
        ' 
        ' txtClientName
        ' 
        txtClientName.Location = New Point(25, 108)
        txtClientName.Multiline = True
        txtClientName.Name = "txtClientName"
        txtClientName.Size = New Size(371, 84)
        txtClientName.TabIndex = 2
        ' 
        ' lblRegion
        ' 
        lblRegion.AutoSize = True
        lblRegion.Location = New Point(25, 208)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New Size(58, 18)
        lblRegion.TabIndex = 4
        lblRegion.Text = "Region"
        ' 
        ' cmbRegion
        ' 
        cmbRegion.AllowDrop = True
        cmbRegion.FormattingEnabled = True
        cmbRegion.Items.AddRange(New Object() {"AU", "NZ", "PH", "HK", "UK", "US"})
        cmbRegion.Location = New Point(25, 229)
        cmbRegion.Name = "cmbRegion"
        cmbRegion.Size = New Size(371, 26)
        cmbRegion.TabIndex = 5
        ' 
        ' ClientDataGrid
        ' 
        ClientDataGrid.BackgroundColor = Color.White
        ClientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ClientDataGrid.Location = New Point(408, 106)
        ClientDataGrid.Name = "ClientDataGrid"
        ClientDataGrid.RowHeadersWidth = 51
        ClientDataGrid.Size = New Size(657, 298)
        ClientDataGrid.TabIndex = 6
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.YellowGreen
        btnSaveChanges.FlatAppearance.BorderSize = 0
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.ForeColor = Color.White
        btnSaveChanges.Location = New Point(25, 296)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(371, 32)
        btnSaveChanges.TabIndex = 7
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        btnSaveChanges.Visible = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(25, 372)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(371, 32)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        btnCancel.Visible = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(25, 334)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(371, 32)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        btnDelete.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(408, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 18)
        Label1.TabIndex = 10
        Label1.Text = "Sort By:"
        ' 
        ' rdbtnClientName
        ' 
        rdbtnClientName.AutoSize = True
        rdbtnClientName.Checked = True
        rdbtnClientName.Location = New Point(496, 78)
        rdbtnClientName.Name = "rdbtnClientName"
        rdbtnClientName.Size = New Size(112, 22)
        rdbtnClientName.TabIndex = 11
        rdbtnClientName.TabStop = True
        rdbtnClientName.Text = "Client Name"
        rdbtnClientName.UseVisualStyleBackColor = True
        ' 
        ' rdbtnRegion
        ' 
        rdbtnRegion.AutoSize = True
        rdbtnRegion.Location = New Point(639, 78)
        rdbtnRegion.Name = "rdbtnRegion"
        rdbtnRegion.Size = New Size(76, 22)
        rdbtnRegion.TabIndex = 12
        rdbtnRegion.Text = "Region"
        rdbtnRegion.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(998, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(67, 67)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Drawing.Font("Arial Black", 24.0F, FontStyle.Bold)
        Label2.Location = New Point(25, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 45)
        Label2.TabIndex = 14
        Label2.Text = "Add Client"
        ' 
        ' ClientF
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1098, 432)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(rdbtnRegion)
        Controls.Add(rdbtnClientName)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnSaveChanges)
        Controls.Add(ClientDataGrid)
        Controls.Add(cmbRegion)
        Controls.Add(lblRegion)
        Controls.Add(txtClientName)
        Controls.Add(lblClientName)
        Controls.Add(btnAddClient)
        Controls.Add(btnCancel)
        DoubleBuffered = True
        Font = New Drawing.Font("Arial", 12.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MaximumSize = New Size(1114, 471)
        MinimizeBox = False
        Name = "ClientF"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        CType(ClientDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddClient As Button
    Friend WithEvents lblClientName As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents ClientDataGrid As DataGridView
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbtnClientName As RadioButton
    Friend WithEvents rdbtnRegion As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
