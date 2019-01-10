<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmMain))
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.LinkLabel()
        Me.lblSettings = New System.Windows.Forms.LinkLabel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1027, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(37, 56)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1064, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblLogout
        '
        Me.lblLogout.ActiveLinkColor = System.Drawing.Color.DarkOrange
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.Chocolate
        Me.lblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblLogout.LinkColor = System.Drawing.Color.DarkOrange
        Me.lblLogout.Location = New System.Drawing.Point(953, 0)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(74, 56)
        Me.lblLogout.TabIndex = 4
        Me.lblLogout.TabStop = True
        Me.lblLogout.Text = "Logout"
        Me.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSettings
        '
        Me.lblSettings.ActiveLinkColor = System.Drawing.Color.DarkOrange
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.Chocolate
        Me.lblSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblSettings.LinkColor = System.Drawing.Color.DarkOrange
        Me.lblSettings.Location = New System.Drawing.Point(875, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(78, 56)
        Me.lblSettings.TabIndex = 5
        Me.lblSettings.TabStop = True
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Black
        Me.lblFormTitle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblFormTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFormTitle.Size = New System.Drawing.Size(1101, 56)
        Me.lblFormTitle.TabIndex = 6
        Me.lblFormTitle.Text = "Garbage Segregation System"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkOrange
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Chocolate
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkOrange
        Me.LinkLabel1.Location = New System.Drawing.Point(800, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 56)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1103, 584)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMinimize As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLogout As LinkLabel
    Friend WithEvents lblSettings As LinkLabel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
