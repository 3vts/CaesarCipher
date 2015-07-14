<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cipher
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
        Me.Encrypt = New System.Windows.Forms.Button()
        Me.Decrypt = New System.Windows.Forms.Button()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Encrypt
        '
        Me.Encrypt.Location = New System.Drawing.Point(21, 41)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Size = New System.Drawing.Size(75, 23)
        Me.Encrypt.TabIndex = 0
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = True
        '
        'Decrypt
        '
        Me.Decrypt.Location = New System.Drawing.Point(21, 70)
        Me.Decrypt.Name = "Decrypt"
        Me.Decrypt.Size = New System.Drawing.Size(75, 23)
        Me.Decrypt.TabIndex = 1
        Me.Decrypt.Text = "Decrypt"
        Me.Decrypt.UseVisualStyleBackColor = True
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(21, 15)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(75, 20)
        Me.Key.TabIndex = 4
        '
        'Cipher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 109)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.Decrypt)
        Me.Controls.Add(Me.Encrypt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(132, 147)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(132, 147)
        Me.Name = "Cipher"
        Me.Text = "Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Encrypt As System.Windows.Forms.Button
    Friend WithEvents Decrypt As System.Windows.Forms.Button
    Friend WithEvents Key As System.Windows.Forms.TextBox

End Class
