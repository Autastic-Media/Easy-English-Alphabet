<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form0))
        Me.Button_1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button_3 = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Quiz = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_About = New System.Windows.Forms.Button()
        Me.Button_2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar_Volume = New System.Windows.Forms.TrackBar()
        Me.Volume = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AudioState = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_1
        '
        Me.Button_1.BackColor = System.Drawing.Color.White
        Me.Button_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_1.Image = CType(resources.GetObject("Button_1.Image"), System.Drawing.Image)
        Me.Button_1.Location = New System.Drawing.Point(12, 109)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(110, 110)
        Me.Button_1.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.Button_1, "A-I Letters")
        Me.Button_1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Easy_English_Alphabet.My.Resources.Resources.TITLE_HEADER_MEDIUM
        Me.PictureBox2.Location = New System.Drawing.Point(26, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(315, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Button_3
        '
        Me.Button_3.BackColor = System.Drawing.Color.White
        Me.Button_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_3.Image = CType(resources.GetObject("Button_3.Image"), System.Drawing.Image)
        Me.Button_3.Location = New System.Drawing.Point(244, 109)
        Me.Button_3.Name = "Button_3"
        Me.Button_3.Size = New System.Drawing.Size(110, 110)
        Me.Button_3.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.Button_3, "S-Z Letters")
        Me.Button_3.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Close.Location = New System.Drawing.Point(244, 300)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(110, 30)
        Me.Button_Close.TabIndex = 46
        Me.Button_Close.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.Button_Close, "Close application")
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Quiz
        '
        Me.Button_Quiz.BackColor = System.Drawing.Color.White
        Me.Button_Quiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Quiz.Image = CType(resources.GetObject("Button_Quiz.Image"), System.Drawing.Image)
        Me.Button_Quiz.Location = New System.Drawing.Point(128, 225)
        Me.Button_Quiz.Name = "Button_Quiz"
        Me.Button_Quiz.Size = New System.Drawing.Size(110, 110)
        Me.Button_Quiz.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Button_Quiz, "Selects Random Quizes to take")
        Me.Button_Quiz.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 341)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 21)
        Me.TextBox1.TabIndex = 56
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Press the Image of your choice. Look, Press, Listen and Learn!"
        '
        'Button_About
        '
        Me.Button_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_About.Location = New System.Drawing.Point(244, 229)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(110, 30)
        Me.Button_About.TabIndex = 57
        Me.Button_About.Text = "About"
        Me.ToolTip1.SetToolTip(Me.Button_About, "About application")
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'Button_2
        '
        Me.Button_2.BackColor = System.Drawing.Color.White
        Me.Button_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_2.Image = CType(resources.GetObject("Button_2.Image"), System.Drawing.Image)
        Me.Button_2.Location = New System.Drawing.Point(128, 109)
        Me.Button_2.Name = "Button_2"
        Me.Button_2.Size = New System.Drawing.Size(110, 110)
        Me.Button_2.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.Button_2, "J-R Letters")
        Me.Button_2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 429)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.White
        Me.Button_Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Start.Image = CType(resources.GetObject("Button_Start.Image"), System.Drawing.Image)
        Me.Button_Start.Location = New System.Drawing.Point(12, 225)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(110, 110)
        Me.Button_Start.TabIndex = 64
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_Next
        '
        Me.Button_Next.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Next.ForeColor = System.Drawing.Color.Black
        Me.Button_Next.Location = New System.Drawing.Point(244, 264)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(110, 30)
        Me.Button_Next.TabIndex = 66
        Me.Button_Next.Text = "Next"
        Me.ToolTip1.SetToolTip(Me.Button_Next, "Move to first page")
        Me.Button_Next.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(319, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(262, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "75"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(202, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(140, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(80, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "0"
        '
        'TrackBar_Volume
        '
        Me.TrackBar_Volume.LargeChange = 25
        Me.TrackBar_Volume.Location = New System.Drawing.Point(71, 368)
        Me.TrackBar_Volume.Maximum = 100
        Me.TrackBar_Volume.Name = "TrackBar_Volume"
        Me.TrackBar_Volume.Size = New System.Drawing.Size(273, 45)
        Me.TrackBar_Volume.SmallChange = 5
        Me.TrackBar_Volume.TabIndex = 67
        Me.TrackBar_Volume.TickFrequency = 25
        Me.ToolTip1.SetToolTip(Me.TrackBar_Volume, "Sets Global Audio Volume")
        Me.TrackBar_Volume.Value = 100
        '
        'Volume
        '
        Me.Volume.AutoSize = True
        Me.Volume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volume.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Volume.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Volume.Location = New System.Drawing.Point(30, 388)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(31, 24)
        Me.Volume.TabIndex = 74
        Me.Volume.Text = "🔊"
        Me.ToolTip1.SetToolTip(Me.Volume, "Toggles Volume On/Off")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(25, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Volume: "
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "ToolStrip1"
        '
        'AudioState
        '
        Me.AudioState.AutoSize = True
        Me.AudioState.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AudioState.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AudioState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AudioState.Location = New System.Drawing.Point(53, 393)
        Me.AudioState.Name = "AudioState"
        Me.AudioState.Size = New System.Drawing.Size(25, 16)
        Me.AudioState.TabIndex = 77
        Me.AudioState.Text = "On"
        Me.ToolTip1.SetToolTip(Me.AudioState, "Toggles Volume On/Off")
        '
        'Form0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(369, 429)
        Me.Controls.Add(Me.AudioState)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar_Volume)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_2)
        Me.Controls.Add(Me.Button_About)
        Me.Controls.Add(Me.Button_Quiz)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_3)
        Me.Controls.Add(Me.Button_1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy English Alphabet"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_3 As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Quiz As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button_About As System.Windows.Forms.Button
    Friend WithEvents Button_2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar_Volume As TrackBar
    Friend WithEvents Volume As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AudioState As Label
End Class
