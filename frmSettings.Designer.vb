﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComport = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboComPort = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.pbxUsername = New System.Windows.Forms.PictureBox()
        Me.txtPortBaudRate = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReadTimeout = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tctIncorrectEquivalent = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorrectEquivalent = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(321, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 81)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Book", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(417, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 36)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Application Settings"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(43, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(950, 2)
        Me.Label2.TabIndex = 49
        '
        'lblComport
        '
        Me.lblComport.BackColor = System.Drawing.Color.Transparent
        Me.lblComport.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComport.ForeColor = System.Drawing.Color.White
        Me.lblComport.Location = New System.Drawing.Point(81, 155)
        Me.lblComport.Margin = New System.Windows.Forms.Padding(0)
        Me.lblComport.Name = "lblComport"
        Me.lblComport.Size = New System.Drawing.Size(418, 42)
        Me.lblComport.TabIndex = 48
        Me.lblComport.Text = "Computer port"
        Me.lblComport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PeachPuff
        Me.Label1.Location = New System.Drawing.Point(418, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 47)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Arduino-based waste material detector bin with fingerprint identification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboComPort
        '
        Me.comboComPort.ForeColor = System.Drawing.Color.DarkOrange
        Me.comboComPort.FormattingEnabled = True
        Me.comboComPort.Location = New System.Drawing.Point(94, 210)
        Me.comboComPort.Name = "comboComPort"
        Me.comboComPort.Size = New System.Drawing.Size(390, 29)
        Me.comboComPort.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(81, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(418, 57)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 31)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Data bits"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataBits
        '
        Me.txtDataBits.BackColor = System.Drawing.Color.White
        Me.txtDataBits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDataBits.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataBits.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtDataBits.Location = New System.Drawing.Point(94, 308)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(390, 19)
        Me.txtDataBits.TabIndex = 2
        '
        'pbxUsername
        '
        Me.pbxUsername.BackColor = System.Drawing.Color.White
        Me.pbxUsername.Location = New System.Drawing.Point(81, 289)
        Me.pbxUsername.Name = "pbxUsername"
        Me.pbxUsername.Size = New System.Drawing.Size(418, 56)
        Me.pbxUsername.TabIndex = 55
        Me.pbxUsername.TabStop = False
        '
        'txtPortBaudRate
        '
        Me.txtPortBaudRate.BackColor = System.Drawing.Color.White
        Me.txtPortBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPortBaudRate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPortBaudRate.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtPortBaudRate.Location = New System.Drawing.Point(94, 401)
        Me.txtPortBaudRate.Name = "txtPortBaudRate"
        Me.txtPortBaudRate.Size = New System.Drawing.Size(390, 19)
        Me.txtPortBaudRate.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(81, 382)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(81, 348)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 31)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Port Baud rate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReadTimeout
        '
        Me.txtReadTimeout.BackColor = System.Drawing.Color.White
        Me.txtReadTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReadTimeout.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadTimeout.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtReadTimeout.Location = New System.Drawing.Point(554, 216)
        Me.txtReadTimeout.Name = "txtReadTimeout"
        Me.txtReadTimeout.Size = New System.Drawing.Size(390, 19)
        Me.txtReadTimeout.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(541, 197)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox4.TabIndex = 61
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(541, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Read timeout"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSaveSettings.FlatAppearance.BorderSize = 2
        Me.btnSaveSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings.Location = New System.Drawing.Point(763, 460)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(196, 59)
        Me.btnSaveSettings.TabIndex = 5
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(541, 460)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(204, 59)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tctIncorrectEquivalent
        '
        Me.tctIncorrectEquivalent.BackColor = System.Drawing.Color.White
        Me.tctIncorrectEquivalent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tctIncorrectEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tctIncorrectEquivalent.ForeColor = System.Drawing.Color.DarkOrange
        Me.tctIncorrectEquivalent.Location = New System.Drawing.Point(554, 399)
        Me.tctIncorrectEquivalent.Name = "tctIncorrectEquivalent"
        Me.tctIncorrectEquivalent.Size = New System.Drawing.Size(390, 19)
        Me.tctIncorrectEquivalent.TabIndex = 63
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(541, 380)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox5.TabIndex = 67
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(541, 352)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(418, 25)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Incorrect Equivalent"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorrectEquivalent
        '
        Me.txtCorrectEquivalent.BackColor = System.Drawing.Color.White
        Me.txtCorrectEquivalent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorrectEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectEquivalent.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtCorrectEquivalent.Location = New System.Drawing.Point(554, 308)
        Me.txtCorrectEquivalent.Name = "txtCorrectEquivalent"
        Me.txtCorrectEquivalent.Size = New System.Drawing.Size(390, 19)
        Me.txtCorrectEquivalent.TabIndex = 62
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(541, 289)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox6.TabIndex = 65
        Me.PictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(541, 255)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(414, 31)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Correct Equivalent"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSaveSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1062, 574)
        Me.Controls.Add(Me.tctIncorrectEquivalent)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCorrectEquivalent)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.txtReadTimeout)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPortBaudRate)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataBits)
        Me.Controls.Add(Me.pbxUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboComPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblComport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblComport As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboComPort As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDataBits As TextBox
    Friend WithEvents pbxUsername As PictureBox
    Friend WithEvents txtPortBaudRate As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReadTimeout As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tctIncorrectEquivalent As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorrectEquivalent As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
End Class
