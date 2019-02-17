<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainStudents))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotalPlastic = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalMetal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotalPaper = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblCorrectPlastic = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCorrectMetal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCorrectPaper = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblIncorrectPlastic = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblIncorrectMetal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblIncorrectPaper = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalIncorrect = New System.Windows.Forms.Label()
        Me.lblTotalCorrect = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dgvBrowseSortedWaste = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentYearSection = New System.Windows.Forms.Label()
        Me.ArduinoSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerThrowGB = New System.Windows.Forms.Timer(Me.components)
        Me.lblResultPrompt = New System.Windows.Forms.Label()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBrowseSortedWaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalPlastic
        '
        Me.lblTotalPlastic.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotalPlastic.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPlastic.ForeColor = System.Drawing.Color.MistyRose
        Me.lblTotalPlastic.Location = New System.Drawing.Point(863, 529)
        Me.lblTotalPlastic.Name = "lblTotalPlastic"
        Me.lblTotalPlastic.Size = New System.Drawing.Size(79, 21)
        Me.lblTotalPlastic.TabIndex = 65
        Me.lblTotalPlastic.Text = "0"
        Me.lblTotalPlastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(863, 546)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Plastic"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalMetal
        '
        Me.lblTotalMetal.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotalMetal.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMetal.ForeColor = System.Drawing.Color.MistyRose
        Me.lblTotalMetal.Location = New System.Drawing.Point(775, 529)
        Me.lblTotalMetal.Name = "lblTotalMetal"
        Me.lblTotalMetal.Size = New System.Drawing.Size(79, 21)
        Me.lblTotalMetal.TabIndex = 63
        Me.lblTotalMetal.Text = "0"
        Me.lblTotalMetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DarkOrange
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(775, 546)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 21)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Metal"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPaper
        '
        Me.lblTotalPaper.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotalPaper.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaper.ForeColor = System.Drawing.Color.MistyRose
        Me.lblTotalPaper.Location = New System.Drawing.Point(687, 529)
        Me.lblTotalPaper.Name = "lblTotalPaper"
        Me.lblTotalPaper.Size = New System.Drawing.Size(79, 21)
        Me.lblTotalPaper.TabIndex = 61
        Me.lblTotalPaper.Text = "0"
        Me.lblTotalPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkOrange
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(687, 546)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 21)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Paper"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectPlastic
        '
        Me.lblCorrectPlastic.BackColor = System.Drawing.Color.DarkOrange
        Me.lblCorrectPlastic.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectPlastic.ForeColor = System.Drawing.Color.MistyRose
        Me.lblCorrectPlastic.Location = New System.Drawing.Point(561, 533)
        Me.lblCorrectPlastic.Name = "lblCorrectPlastic"
        Me.lblCorrectPlastic.Size = New System.Drawing.Size(79, 21)
        Me.lblCorrectPlastic.TabIndex = 59
        Me.lblCorrectPlastic.Text = "0"
        Me.lblCorrectPlastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkOrange
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(561, 550)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Plastic"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectMetal
        '
        Me.lblCorrectMetal.BackColor = System.Drawing.Color.DarkOrange
        Me.lblCorrectMetal.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectMetal.ForeColor = System.Drawing.Color.MistyRose
        Me.lblCorrectMetal.Location = New System.Drawing.Point(475, 533)
        Me.lblCorrectMetal.Name = "lblCorrectMetal"
        Me.lblCorrectMetal.Size = New System.Drawing.Size(79, 21)
        Me.lblCorrectMetal.TabIndex = 57
        Me.lblCorrectMetal.Text = "0"
        Me.lblCorrectMetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkOrange
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(475, 550)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 21)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Metal"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectPaper
        '
        Me.lblCorrectPaper.BackColor = System.Drawing.Color.DarkOrange
        Me.lblCorrectPaper.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectPaper.ForeColor = System.Drawing.Color.MistyRose
        Me.lblCorrectPaper.Location = New System.Drawing.Point(383, 533)
        Me.lblCorrectPaper.Name = "lblCorrectPaper"
        Me.lblCorrectPaper.Size = New System.Drawing.Size(79, 21)
        Me.lblCorrectPaper.TabIndex = 55
        Me.lblCorrectPaper.Text = "0"
        Me.lblCorrectPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkOrange
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(383, 550)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 21)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Paper"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrectPlastic
        '
        Me.lblIncorrectPlastic.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIncorrectPlastic.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectPlastic.ForeColor = System.Drawing.Color.MistyRose
        Me.lblIncorrectPlastic.Location = New System.Drawing.Point(257, 531)
        Me.lblIncorrectPlastic.Name = "lblIncorrectPlastic"
        Me.lblIncorrectPlastic.Size = New System.Drawing.Size(79, 21)
        Me.lblIncorrectPlastic.TabIndex = 53
        Me.lblIncorrectPlastic.Text = "0"
        Me.lblIncorrectPlastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkOrange
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 548)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 21)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Plastic"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrectMetal
        '
        Me.lblIncorrectMetal.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIncorrectMetal.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectMetal.ForeColor = System.Drawing.Color.MistyRose
        Me.lblIncorrectMetal.Location = New System.Drawing.Point(176, 531)
        Me.lblIncorrectMetal.Name = "lblIncorrectMetal"
        Me.lblIncorrectMetal.Size = New System.Drawing.Size(79, 21)
        Me.lblIncorrectMetal.TabIndex = 51
        Me.lblIncorrectMetal.Text = "0"
        Me.lblIncorrectMetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(176, 548)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Metal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrectPaper
        '
        Me.lblIncorrectPaper.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIncorrectPaper.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectPaper.ForeColor = System.Drawing.Color.MistyRose
        Me.lblIncorrectPaper.Location = New System.Drawing.Point(81, 531)
        Me.lblIncorrectPaper.Name = "lblIncorrectPaper"
        Me.lblIncorrectPaper.Size = New System.Drawing.Size(79, 21)
        Me.lblIncorrectPaper.TabIndex = 49
        Me.lblIncorrectPaper.Text = "0"
        Me.lblIncorrectPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkOrange
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Paper"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(817, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(520, 509)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Correct"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(220, 510)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Incorrect"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalIncorrect
        '
        Me.lblTotalIncorrect.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotalIncorrect.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncorrect.Location = New System.Drawing.Point(220, 460)
        Me.lblTotalIncorrect.Name = "lblTotalIncorrect"
        Me.lblTotalIncorrect.Size = New System.Drawing.Size(80, 60)
        Me.lblTotalIncorrect.TabIndex = 46
        Me.lblTotalIncorrect.Text = "0"
        Me.lblTotalIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCorrect
        '
        Me.lblTotalCorrect.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotalCorrect.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCorrect.Location = New System.Drawing.Point(522, 460)
        Me.lblTotalCorrect.Name = "lblTotalCorrect"
        Me.lblTotalCorrect.Size = New System.Drawing.Size(78, 60)
        Me.lblTotalCorrect.TabIndex = 47
        Me.lblTotalCorrect.Text = "0"
        Me.lblTotalCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(818, 457)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(81, 59)
        Me.lblTotal.TabIndex = 48
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(131, 460)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(87, 70)
        Me.PictureBox8.TabIndex = 37
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(434, 460)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(85, 70)
        Me.PictureBox9.TabIndex = 38
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox10.Location = New System.Drawing.Point(369, 448)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(284, 126)
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(731, 456)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(85, 70)
        Me.PictureBox12.TabIndex = 41
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox13.Location = New System.Drawing.Point(671, 449)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(285, 123)
        Me.PictureBox13.TabIndex = 42
        Me.PictureBox13.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox11.Location = New System.Drawing.Point(66, 448)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(283, 126)
        Me.PictureBox11.TabIndex = 40
        Me.PictureBox11.TabStop = False
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Franklin Gothic Book", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(54, 110)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(904, 36)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Sorted waste"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvBrowseSortedWaste
        '
        Me.dgvBrowseSortedWaste.AllowUserToAddRows = False
        Me.dgvBrowseSortedWaste.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBrowseSortedWaste.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBrowseSortedWaste.ColumnHeadersHeight = 30
        Me.dgvBrowseSortedWaste.Location = New System.Drawing.Point(66, 160)
        Me.dgvBrowseSortedWaste.Name = "dgvBrowseSortedWaste"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBrowseSortedWaste.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBrowseSortedWaste.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvBrowseSortedWaste.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrange
        Me.dgvBrowseSortedWaste.Size = New System.Drawing.Size(891, 270)
        Me.dgvBrowseSortedWaste.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PeachPuff
        Me.Label1.Location = New System.Drawing.Point(86, 699)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 21)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Arduino-based waste material detector bin with fingerprint identification"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(87, 679)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(416, 22)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Garbage Segregation System"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(904, 28)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 58)
        Me.btnClose.TabIndex = 74
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(829, 27)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(60, 59)
        Me.btnMinimize.TabIndex = 73
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(58, 688)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 30)
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(57, 439)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 145)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.Location = New System.Drawing.Point(360, 439)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(303, 145)
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox4.Location = New System.Drawing.Point(662, 439)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(303, 145)
        Me.PictureBox4.TabIndex = 78
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox5.Location = New System.Drawing.Point(57, 149)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(908, 290)
        Me.PictureBox5.TabIndex = 79
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(88, 699)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 2)
        Me.Label6.TabIndex = 81
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(671, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(294, 59)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Sign out"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(48, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox6.TabIndex = 83
        Me.PictureBox6.TabStop = False
        '
        'lblStudentName
        '
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.Font = New System.Drawing.Font("Franklin Gothic Book", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Bisque
        Me.lblStudentName.Location = New System.Drawing.Point(94, 21)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(650, 37)
        Me.lblStudentName.TabIndex = 84
        Me.lblStudentName.Text = "Albert Pangidian Dizon Jr."
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStudentYearSection
        '
        Me.lblStudentYearSection.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentYearSection.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentYearSection.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblStudentYearSection.Location = New System.Drawing.Point(93, 54)
        Me.lblStudentYearSection.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStudentYearSection.Name = "lblStudentYearSection"
        Me.lblStudentYearSection.Size = New System.Drawing.Size(650, 24)
        Me.lblStudentYearSection.TabIndex = 85
        Me.lblStudentYearSection.Text = "BSIT, 2-A"
        '
        'TimerThrowGB
        '
        Me.TimerThrowGB.Interval = 500
        '
        'lblResultPrompt
        '
        Me.lblResultPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblResultPrompt.Font = New System.Drawing.Font("Franklin Gothic Book", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultPrompt.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblResultPrompt.Location = New System.Drawing.Point(103, 600)
        Me.lblResultPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResultPrompt.Name = "lblResultPrompt"
        Me.lblResultPrompt.Size = New System.Drawing.Size(510, 59)
        Me.lblResultPrompt.TabIndex = 86
        Me.lblResultPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1030, 727)
        Me.Controls.Add(Me.lblResultPrompt)
        Me.Controls.Add(Me.lblStudentYearSection)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.dgvBrowseSortedWaste)
        Me.Controls.Add(Me.lblTotalPlastic)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalMetal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTotalPaper)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblCorrectPlastic)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCorrectMetal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCorrectPaper)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblIncorrectPlastic)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblIncorrectMetal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblIncorrectPaper)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalIncorrect)
        Me.Controls.Add(Me.lblTotalCorrect)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMainStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainStudents"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBrowseSortedWaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTotalPlastic As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalMetal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTotalPaper As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblCorrectPlastic As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCorrectMetal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCorrectPaper As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblIncorrectPlastic As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblIncorrectMetal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblIncorrectPaper As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalIncorrect As Label
    Friend WithEvents lblTotalCorrect As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents dgvBrowseSortedWaste As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentYearSection As Label
    Friend WithEvents ArduinoSerialPort As IO.Ports.SerialPort
    Friend WithEvents TimerThrowGB As Timer
    Friend WithEvents lblResultPrompt As Label
End Class
