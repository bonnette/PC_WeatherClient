<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ip_txt = New System.Windows.Forms.TextBox()
        Me.su_ok_btn = New System.Windows.Forms.Button()
        Me.su_cancel_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weather Pi IP Address"
        '
        'ip_txt
        '
        Me.ip_txt.Location = New System.Drawing.Point(168, 36)
        Me.ip_txt.Name = "ip_txt"
        Me.ip_txt.Size = New System.Drawing.Size(137, 20)
        Me.ip_txt.TabIndex = 1
        '
        'su_ok_btn
        '
        Me.su_ok_btn.Location = New System.Drawing.Point(86, 78)
        Me.su_ok_btn.Name = "su_ok_btn"
        Me.su_ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.su_ok_btn.TabIndex = 6
        Me.su_ok_btn.Text = "OK"
        Me.su_ok_btn.UseVisualStyleBackColor = True
        '
        'su_cancel_btn
        '
        Me.su_cancel_btn.Location = New System.Drawing.Point(168, 78)
        Me.su_cancel_btn.Name = "su_cancel_btn"
        Me.su_cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.su_cancel_btn.TabIndex = 7
        Me.su_cancel_btn.Text = "Cancel"
        Me.su_cancel_btn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 133)
        Me.Controls.Add(Me.su_cancel_btn)
        Me.Controls.Add(Me.su_ok_btn)
        Me.Controls.Add(Me.ip_txt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ip_txt As TextBox
    Friend WithEvents su_ok_btn As Button
    Friend WithEvents su_cancel_btn As Button
End Class
