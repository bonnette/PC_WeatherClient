﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_frm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_frm))
        Me.temp_txt = New System.Windows.Forms.TextBox()
        Me.wind_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.time_txt = New System.Windows.Forms.TextBox()
        Me.intemp_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wdir_lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.humi_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.press_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.wg_txt = New System.Windows.Forms.TextBox()
        Me.wthrdata_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'temp_txt
        '
        Me.temp_txt.BackColor = System.Drawing.SystemColors.Control
        Me.temp_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.temp_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temp_txt.Location = New System.Drawing.Point(11, 135)
        Me.temp_txt.Name = "temp_txt"
        Me.temp_txt.Size = New System.Drawing.Size(71, 17)
        Me.temp_txt.TabIndex = 98
        Me.temp_txt.TabStop = False
        '
        'wind_txt
        '
        Me.wind_txt.BackColor = System.Drawing.SystemColors.Control
        Me.wind_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wind_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wind_txt.Location = New System.Drawing.Point(268, 135)
        Me.wind_txt.Name = "wind_txt"
        Me.wind_txt.Size = New System.Drawing.Size(63, 17)
        Me.wind_txt.TabIndex = 96
        Me.wind_txt.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Outdoor Temperature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Wind Speed"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(424, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Time"
        '
        'time_txt
        '
        Me.time_txt.BackColor = System.Drawing.SystemColors.Control
        Me.time_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.time_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_txt.Location = New System.Drawing.Point(426, 236)
        Me.time_txt.Name = "time_txt"
        Me.time_txt.Size = New System.Drawing.Size(71, 17)
        Me.time_txt.TabIndex = 92
        Me.time_txt.TabStop = False
        '
        'intemp_txt
        '
        Me.intemp_txt.BackColor = System.Drawing.SystemColors.Control
        Me.intemp_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.intemp_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intemp_txt.Location = New System.Drawing.Point(11, 212)
        Me.intemp_txt.Name = "intemp_txt"
        Me.intemp_txt.Size = New System.Drawing.Size(74, 17)
        Me.intemp_txt.TabIndex = 95
        Me.intemp_txt.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "In-Box Temperature"
        '
        'wdir_lbl
        '
        Me.wdir_lbl.AutoSize = True
        Me.wdir_lbl.Location = New System.Drawing.Point(337, 139)
        Me.wdir_lbl.Name = "wdir_lbl"
        Me.wdir_lbl.Size = New System.Drawing.Size(49, 13)
        Me.wdir_lbl.TabIndex = 10
        Me.wdir_lbl.Text = "Direction"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Humidity"
        '
        'humi_txt
        '
        Me.humi_txt.BackColor = System.Drawing.SystemColors.Control
        Me.humi_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.humi_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.humi_txt.Location = New System.Drawing.Point(166, 135)
        Me.humi_txt.Name = "humi_txt"
        Me.humi_txt.Size = New System.Drawing.Size(71, 17)
        Me.humi_txt.TabIndex = 97
        Me.humi_txt.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Pressure"
        '
        'press_txt
        '
        Me.press_txt.BackColor = System.Drawing.SystemColors.Control
        Me.press_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.press_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.press_txt.Location = New System.Drawing.Point(165, 212)
        Me.press_txt.Name = "press_txt"
        Me.press_txt.Size = New System.Drawing.Size(74, 17)
        Me.press_txt.TabIndex = 94
        Me.press_txt.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Wind Gust"
        '
        'wg_txt
        '
        Me.wg_txt.BackColor = System.Drawing.SystemColors.Control
        Me.wg_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wg_txt.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wg_txt.Location = New System.Drawing.Point(267, 212)
        Me.wg_txt.Name = "wg_txt"
        Me.wg_txt.Size = New System.Drawing.Size(63, 17)
        Me.wg_txt.TabIndex = 93
        Me.wg_txt.TabStop = False
        '
        'wthrdata_txt
        '
        Me.wthrdata_txt.BackColor = System.Drawing.SystemColors.Control
        Me.wthrdata_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wthrdata_txt.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wthrdata_txt.Location = New System.Drawing.Point(11, 29)
        Me.wthrdata_txt.Multiline = True
        Me.wthrdata_txt.Name = "wthrdata_txt"
        Me.wthrdata_txt.Size = New System.Drawing.Size(478, 65)
        Me.wthrdata_txt.TabIndex = 0
        Me.wthrdata_txt.TabStop = False
        Me.wthrdata_txt.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   Wait 10 Seconds for first data to arrive"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 15)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Incomming Weather Data"
        '
        'Main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 261)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.wthrdata_txt)
        Me.Controls.Add(Me.wg_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.press_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.humi_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.wdir_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.intemp_txt)
        Me.Controls.Add(Me.time_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wind_txt)
        Me.Controls.Add(Me.temp_txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_frm"
        Me.Text = "Weather Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents temp_txt As TextBox
    Friend WithEvents wind_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents time_txt As TextBox
    Friend WithEvents intemp_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents wdir_lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents humi_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents press_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents wg_txt As TextBox
    Friend WithEvents wthrdata_txt As TextBox
    Friend WithEvents Label8 As Label
End Class
