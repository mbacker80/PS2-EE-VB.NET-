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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load To RAM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(590, 12)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOut.Size = New System.Drawing.Size(727, 696)
        Me.txtOut.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Fastest/Slowest"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Run"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtIn
        '
        Me.txtIn.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIn.Location = New System.Drawing.Point(12, 12)
        Me.txtIn.Multiline = True
        Me.txtIn.Name = "txtIn"
        Me.txtIn.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtIn.Size = New System.Drawing.Size(247, 696)
        Me.txtIn.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(357, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 30)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exec 1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(358, 185)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 30)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Set Pos 00100000"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(358, 221)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 30)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "asm test"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1329, 768)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmMain"
        Me.Text = "Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtIn As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
