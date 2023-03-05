<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnUserInput = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lstContainer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnUserInput
        '
        Me.btnUserInput.Location = New System.Drawing.Point(54, 259)
        Me.btnUserInput.Name = "btnUserInput"
        Me.btnUserInput.Size = New System.Drawing.Size(65, 23)
        Me.btnUserInput.TabIndex = 17
        Me.btnUserInput.Text = "User Input"
        Me.btnUserInput.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(54, 74)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 23)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(54, 230)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(65, 23)
        Me.btnDoUntil.TabIndex = 15
        Me.btnDoUntil.Text = "Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(54, 201)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(65, 23)
        Me.btnDoWhile.TabIndex = 14
        Me.btnDoWhile.Text = "Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(54, 172)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(65, 23)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5 - Clear"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(54, 130)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 23)
        Me.btn4.TabIndex = 12
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(54, 101)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 23)
        Me.btn3.TabIndex = 11
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(54, 49)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 23)
        Me.btn1.TabIndex = 10
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lstContainer
        '
        Me.lstContainer.FormattingEnabled = True
        Me.lstContainer.Location = New System.Drawing.Point(222, 44)
        Me.lstContainer.Name = "lstContainer"
        Me.lstContainer.Size = New System.Drawing.Size(126, 238)
        Me.lstContainer.TabIndex = 18
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 355)
        Me.Controls.Add(Me.lstContainer)
        Me.Controls.Add(Me.btnUserInput)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Name = "frmMain"
        Me.Text = "Loop Tests"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUserInput As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents lstContainer As ListBox
End Class
