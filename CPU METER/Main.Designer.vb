<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblOSInfo = New System.Windows.Forms.Label()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pgrsProcessor = New System.Windows.Forms.ProgressBar()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.pgrMemory = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalMemory = New System.Windows.Forms.Label()
        Me.lblUsed = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New ns1.BunifuCards()
        Me.BunifuGauge1 = New ns1.BunifuGauge()
        Me.BunifuDatepicker1 = New ns1.BunifuDatepicker()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOSInfo
        '
        Me.lblOSInfo.AutoSize = True
        Me.lblOSInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOSInfo.Location = New System.Drawing.Point(28, 10)
        Me.lblOSInfo.Name = "lblOSInfo"
        Me.lblOSInfo.Size = New System.Drawing.Size(10, 13)
        Me.lblOSInfo.TabIndex = 0
        Me.lblOSInfo.Text = "."
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_total"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pgrsProcessor
        '
        Me.pgrsProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgrsProcessor.Location = New System.Drawing.Point(2, 82)
        Me.pgrsProcessor.Name = "pgrsProcessor"
        Me.pgrsProcessor.Size = New System.Drawing.Size(165, 19)
        Me.pgrsProcessor.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgrsProcessor.TabIndex = 1
        '
        'lblProcessor
        '
        Me.lblProcessor.AutoSize = True
        Me.lblProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProcessor.Location = New System.Drawing.Point(175, 85)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(13, 13)
        Me.lblProcessor.TabIndex = 2
        Me.lblProcessor.Text = "0"
        '
        'pgrMemory
        '
        Me.pgrMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgrMemory.Location = New System.Drawing.Point(2, 123)
        Me.pgrMemory.Name = "pgrMemory"
        Me.pgrMemory.Size = New System.Drawing.Size(165, 19)
        Me.pgrMemory.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROCESSOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MEMORY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(92, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Memory:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(131, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Used:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(113, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Available:"
        '
        'lblTotalMemory
        '
        Me.lblTotalMemory.AutoSize = True
        Me.lblTotalMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalMemory.Location = New System.Drawing.Point(175, 155)
        Me.lblTotalMemory.Name = "lblTotalMemory"
        Me.lblTotalMemory.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalMemory.TabIndex = 9
        Me.lblTotalMemory.Text = "0"
        '
        'lblUsed
        '
        Me.lblUsed.AutoSize = True
        Me.lblUsed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUsed.Location = New System.Drawing.Point(175, 178)
        Me.lblUsed.Name = "lblUsed"
        Me.lblUsed.Size = New System.Drawing.Size(13, 13)
        Me.lblUsed.TabIndex = 10
        Me.lblUsed.Text = "0"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvailable.Location = New System.Drawing.Point(175, 200)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(13, 13)
        Me.lblAvailable.TabIndex = 11
        Me.lblAvailable.Text = "0"
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMemory.Location = New System.Drawing.Point(175, 128)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(13, 13)
        Me.lblMemory.TabIndex = 12
        Me.lblMemory.Text = "0"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.BunifuGauge1)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(237, 284)
        Me.BunifuCards1.TabIndex = 13
        '
        'BunifuGauge1
        '
        Me.BunifuGauge1.BackgroundImage = CType(resources.GetObject("BunifuGauge1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGauge1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuGauge1.Location = New System.Drawing.Point(4, 180)
        Me.BunifuGauge1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuGauge1.Name = "BunifuGauge1"
        Me.BunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray
        Me.BunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.BunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato
        Me.BunifuGauge1.Size = New System.Drawing.Size(118, 98)
        Me.BunifuGauge1.TabIndex = 14
        Me.BunifuGauge1.Thickness = 30
        Me.BunifuGauge1.Value = 0
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(211, 63)
        Me.BunifuDatepicker1.TabIndex = 14
        Me.BunifuDatepicker1.Value = New Date(2019, 11, 10, 2, 43, 13, 263)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(237, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lblUsed)
        Me.Controls.Add(Me.lblTotalMemory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgrMemory)
        Me.Controls.Add(Me.lblProcessor)
        Me.Controls.Add(Me.pgrsProcessor)
        Me.Controls.Add(Me.lblOSInfo)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(850, 2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CPU METER"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOSInfo As System.Windows.Forms.Label
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pgrsProcessor As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProcessor As System.Windows.Forms.Label
    Friend WithEvents pgrMemory As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalMemory As System.Windows.Forms.Label
    Friend WithEvents lblUsed As System.Windows.Forms.Label
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents BunifuCards1 As ns1.BunifuCards
    Friend WithEvents BunifuGauge1 As ns1.BunifuGauge
    Friend WithEvents BunifuDatepicker1 As ns1.BunifuDatepicker
End Class
