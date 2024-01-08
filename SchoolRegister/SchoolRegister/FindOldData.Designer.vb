<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindOldData
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
        Me.StudentGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Day = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Month = New System.Windows.Forms.TextBox()
        Me.Year = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.FileNotFoundLabel = New System.Windows.Forms.Label()
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentGrid
        '
        Me.StudentGrid.AllowUserToAddRows = False
        Me.StudentGrid.AllowUserToDeleteRows = False
        Me.StudentGrid.AllowUserToResizeColumns = False
        Me.StudentGrid.AllowUserToResizeRows = False
        Me.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.StudentGrid.Location = New System.Drawing.Point(12, 124)
        Me.StudentGrid.Name = "StudentGrid"
        Me.StudentGrid.ReadOnly = True
        Me.StudentGrid.Size = New System.Drawing.Size(760, 469)
        Me.StudentGrid.TabIndex = 25
        Me.StudentGrid.Visible = False
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
        Me.Column5.HeaderText = "Time Signed In"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Last Hub"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Day
        '
        Me.Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Day.Location = New System.Drawing.Point(13, 62)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(75, 56)
        Me.Day.TabIndex = 0
        Me.Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 51)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "DD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 51)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "MM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 51)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "YYYY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Month
        '
        Me.Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Month.Location = New System.Drawing.Point(103, 62)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(75, 56)
        Me.Month.TabIndex = 31
        Me.Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Year
        '
        Me.Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year.Location = New System.Drawing.Point(191, 62)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(139, 56)
        Me.Year.TabIndex = 32
        Me.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindButton
        '
        Me.FindButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 64.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindButton.Location = New System.Drawing.Point(336, 12)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(226, 106)
        Me.FindButton.TabIndex = 33
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(568, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(204, 106)
        Me.CloseButton.TabIndex = 34
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'FileNotFoundLabel
        '
        Me.FileNotFoundLabel.AutoSize = True
        Me.FileNotFoundLabel.BackColor = System.Drawing.SystemColors.Control
        Me.FileNotFoundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNotFoundLabel.Location = New System.Drawing.Point(12, 283)
        Me.FileNotFoundLabel.Name = "FileNotFoundLabel"
        Me.FileNotFoundLabel.Size = New System.Drawing.Size(768, 102)
        Me.FileNotFoundLabel.TabIndex = 35
        Me.FileNotFoundLabel.Text = "File Doesn't Exist!"
        Me.FileNotFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FileNotFoundLabel.Visible = False
        '
        'FindOldData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.FileNotFoundLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Month)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.StudentGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FindOldData"
        Me.Text = "FindOldData"
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Private WithEvents StudentGrid As DataGridView
    Private WithEvents Day As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Month As TextBox
    Private WithEvents Year As TextBox
    Private WithEvents FindButton As Button
    Private WithEvents CloseButton As Button
    Private WithEvents FileNotFoundLabel As Label
End Class
