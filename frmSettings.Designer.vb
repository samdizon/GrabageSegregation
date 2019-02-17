<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.txtBoxCorrectEquivalent = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblCorrectEquivalent = New System.Windows.Forms.Label()
        Me.txtboxIncorrectEquivalent = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.PictureBox1.Location = New System.Drawing.Point(353, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 69)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Book", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(449, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 24)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Application Settings"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(309, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 10)
        Me.Label2.TabIndex = 49
        '
        'lblComport
        '
        Me.lblComport.BackColor = System.Drawing.Color.Transparent
        Me.lblComport.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComport.ForeColor = System.Drawing.Color.White
        Me.lblComport.Location = New System.Drawing.Point(114, 242)
        Me.lblComport.Margin = New System.Windows.Forms.Padding(0)
        Me.lblComport.Name = "lblComport"
        Me.lblComport.Size = New System.Drawing.Size(418, 30)
        Me.lblComport.TabIndex = 48
        Me.lblComport.Text = "Computer port"
        Me.lblComport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PeachPuff
        Me.Label1.Location = New System.Drawing.Point(450, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 35)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Arduino-based waste material detector bin with fingerprint identification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboComPort
        '
        Me.comboComPort.ForeColor = System.Drawing.Color.DarkOrange
        Me.comboComPort.FormattingEnabled = True
        Me.comboComPort.Location = New System.Drawing.Point(127, 285)
        Me.comboComPort.Name = "comboComPort"
        Me.comboComPort.Size = New System.Drawing.Size(390, 29)
        Me.comboComPort.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(114, 283)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(418, 45)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(114, 342)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 19)
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
        Me.txtDataBits.Location = New System.Drawing.Point(127, 383)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(390, 19)
        Me.txtDataBits.TabIndex = 2
        '
        'pbxUsername
        '
        Me.pbxUsername.BackColor = System.Drawing.Color.White
        Me.pbxUsername.Location = New System.Drawing.Point(114, 376)
        Me.pbxUsername.Name = "pbxUsername"
        Me.pbxUsername.Size = New System.Drawing.Size(418, 44)
        Me.pbxUsername.TabIndex = 55
        Me.pbxUsername.TabStop = False
        '
        'txtPortBaudRate
        '
        Me.txtPortBaudRate.BackColor = System.Drawing.Color.White
        Me.txtPortBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPortBaudRate.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPortBaudRate.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtPortBaudRate.Location = New System.Drawing.Point(127, 476)
        Me.txtPortBaudRate.Name = "txtPortBaudRate"
        Me.txtPortBaudRate.Size = New System.Drawing.Size(390, 19)
        Me.txtPortBaudRate.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(114, 469)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(418, 44)
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(114, 435)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 19)
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
        Me.txtReadTimeout.Location = New System.Drawing.Point(576, 291)
        Me.txtReadTimeout.Name = "txtReadTimeout"
        Me.txtReadTimeout.Size = New System.Drawing.Size(390, 19)
        Me.txtReadTimeout.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(563, 284)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(418, 44)
        Me.PictureBox4.TabIndex = 61
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(563, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 13)
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
        Me.btnSaveSettings.Location = New System.Drawing.Point(786, 545)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(196, 47)
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
        Me.btnCancel.Location = New System.Drawing.Point(564, 545)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(204, 47)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtBoxCorrectEquivalent
        '
        Me.txtBoxCorrectEquivalent.BackColor = System.Drawing.Color.White
        Me.txtBoxCorrectEquivalent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCorrectEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCorrectEquivalent.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtBoxCorrectEquivalent.Location = New System.Drawing.Point(577, 381)
        Me.txtBoxCorrectEquivalent.Name = "txtBoxCorrectEquivalent"
        Me.txtBoxCorrectEquivalent.Size = New System.Drawing.Size(390, 19)
        Me.txtBoxCorrectEquivalent.TabIndex = 62
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(564, 374)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(418, 44)
        Me.PictureBox5.TabIndex = 64
        Me.PictureBox5.TabStop = False
        '
        'lblCorrectEquivalent
        '
        Me.lblCorrectEquivalent.BackColor = System.Drawing.Color.Transparent
        Me.lblCorrectEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectEquivalent.ForeColor = System.Drawing.Color.White
        Me.lblCorrectEquivalent.Location = New System.Drawing.Point(564, 346)
        Me.lblCorrectEquivalent.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCorrectEquivalent.Name = "lblCorrectEquivalent"
        Me.lblCorrectEquivalent.Size = New System.Drawing.Size(418, 13)
        Me.lblCorrectEquivalent.TabIndex = 63
        Me.lblCorrectEquivalent.Text = "Correct Equivalent"
        Me.lblCorrectEquivalent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxIncorrectEquivalent
        '
        Me.txtboxIncorrectEquivalent.BackColor = System.Drawing.Color.White
        Me.txtboxIncorrectEquivalent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxIncorrectEquivalent.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxIncorrectEquivalent.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtboxIncorrectEquivalent.Location = New System.Drawing.Point(577, 474)
        Me.txtboxIncorrectEquivalent.Name = "txtboxIncorrectEquivalent"
        Me.txtboxIncorrectEquivalent.Size = New System.Drawing.Size(390, 19)
        Me.txtboxIncorrectEquivalent.TabIndex = 65
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(564, 467)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(418, 44)
        Me.PictureBox6.TabIndex = 67
        Me.PictureBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(564, 439)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(418, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Incorrect Equivalent"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSaveSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1123, 729)
        Me.Controls.Add(Me.txtboxIncorrectEquivalent)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBoxCorrectEquivalent)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblCorrectEquivalent)
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
    Friend WithEvents txtBoxCorrectEquivalent As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblCorrectEquivalent As Label
    Friend WithEvents txtboxIncorrectEquivalent As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
End Class
