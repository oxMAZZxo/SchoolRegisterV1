<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FormSort = New System.Windows.Forms.ComboBox()
        Me.StudentGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentSignInButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LoadOldData = New System.Windows.Forms.Button()
        Me.StatusSort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSort
        '
        Me.FormSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSort.FormattingEnabled = True
        Me.FormSort.Items.AddRange(New Object() {"All"})
        Me.FormSort.Location = New System.Drawing.Point(13, 47)
        Me.FormSort.Name = "FormSort"
        Me.FormSort.Size = New System.Drawing.Size(105, 33)
        Me.FormSort.TabIndex = 0
        '
        'StudentGrid
        '
        Me.StudentGrid.AllowUserToAddRows = False
        Me.StudentGrid.AllowUserToDeleteRows = False
        Me.StudentGrid.AllowUserToResizeColumns = False
        Me.StudentGrid.AllowUserToResizeRows = False
        Me.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.StudentGrid.Location = New System.Drawing.Point(13, 86)
        Me.StudentGrid.Name = "StudentGrid"
        Me.StudentGrid.ReadOnly = True
        Me.StudentGrid.Size = New System.Drawing.Size(1239, 538)
        Me.StudentGrid.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Form"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Current Hub"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'StudentSignInButton
        '
        Me.StudentSignInButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentSignInButton.Location = New System.Drawing.Point(1082, 13)
        Me.StudentSignInButton.Name = "StudentSignInButton"
        Me.StudentSignInButton.Size = New System.Drawing.Size(169, 33)
        Me.StudentSignInButton.TabIndex = 2
        Me.StudentSignInButton.Text = "Student Sign In"
        Me.StudentSignInButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(1151, 630)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(100, 40)
        Me.LogOutButton.TabIndex = 3
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(696, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(12, 630)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 39)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save Data"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(590, 630)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 40)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LoadOldData
        '
        Me.LoadOldData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadOldData.Location = New System.Drawing.Point(112, 630)
        Me.LoadOldData.Name = "LoadOldData"
        Me.LoadOldData.Size = New System.Drawing.Size(122, 39)
        Me.LoadOldData.TabIndex = 7
        Me.LoadOldData.Text = "Load Old Data"
        Me.LoadOldData.UseVisualStyleBackColor = True
        '
        'StatusSort
        '
        Me.StatusSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatusSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusSort.FormattingEnabled = True
        Me.StatusSort.Items.AddRange(New Object() {"All", "Show Not In", "Show On Time", "Show Late"})
        Me.StatusSort.Location = New System.Drawing.Point(124, 47)
        Me.StatusSort.Name = "StatusSort"
        Me.StatusSort.Size = New System.Drawing.Size(148, 33)
        Me.StatusSort.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Form Sort"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Status Sort"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusSort)
        Me.Controls.Add(Me.LoadOldData)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.StudentSignInButton)
        Me.Controls.Add(Me.StudentGrid)
        Me.Controls.Add(Me.FormSort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Mode"
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSort As System.Windows.Forms.ComboBox
    Friend WithEvents StudentGrid As System.Windows.Forms.DataGridView
    Private WithEvents LogOutButton As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents StudentSignInButton As System.Windows.Forms.Button
    Private WithEvents SaveButton As Button
    Private WithEvents SearchButton As Button
    Private WithEvents LoadOldData As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents StatusSort As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
End Class
