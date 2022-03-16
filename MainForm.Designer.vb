<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.numRecLbl = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.gradeLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstStudentFiles = New System.Windows.Forms.ListBox()
        Me.readFileBtn = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'numRecLbl
        '
        Me.numRecLbl.AutoSize = True
        Me.numRecLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numRecLbl.Location = New System.Drawing.Point(164, 219)
        Me.numRecLbl.Name = "numRecLbl"
        Me.numRecLbl.Size = New System.Drawing.Size(15, 16)
        Me.numRecLbl.TabIndex = 15
        Me.numRecLbl.Text = "0"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(10, 256)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(51, 17)
        Me.LblTime.TabIndex = 14
        Me.LblTime.Text = "Label5"
        '
        'gradeLbl
        '
        Me.gradeLbl.AutoSize = True
        Me.gradeLbl.BackColor = System.Drawing.Color.PaleGreen
        Me.gradeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeLbl.Location = New System.Drawing.Point(223, 120)
        Me.gradeLbl.Name = "gradeLbl"
        Me.gradeLbl.Size = New System.Drawing.Size(76, 25)
        Me.gradeLbl.TabIndex = 12
        Me.gradeLbl.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Letter Grade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Number of Records:"
        '
        'lstStudentFiles
        '
        Me.lstStudentFiles.FormattingEnabled = True
        Me.lstStudentFiles.Location = New System.Drawing.Point(12, 55)
        Me.lstStudentFiles.Name = "lstStudentFiles"
        Me.lstStudentFiles.Size = New System.Drawing.Size(165, 160)
        Me.lstStudentFiles.TabIndex = 9
        '
        'readFileBtn
        '
        Me.readFileBtn.BackColor = System.Drawing.Color.SandyBrown
        Me.readFileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readFileBtn.Location = New System.Drawing.Point(12, 14)
        Me.readFileBtn.Name = "readFileBtn"
        Me.readFileBtn.Size = New System.Drawing.Size(165, 27)
        Me.readFileBtn.TabIndex = 8
        Me.readFileBtn.Text = "&Read From Student File"
        Me.readFileBtn.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 290)
        Me.Controls.Add(Me.numRecLbl)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.gradeLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStudentFiles)
        Me.Controls.Add(Me.readFileBtn)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers | CPT-206-Test-2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numRecLbl As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents gradeLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstStudentFiles As ListBox
    Friend WithEvents readFileBtn As Button
    Friend WithEvents Timer2 As Timer
End Class
