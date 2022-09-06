<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbx_Screen = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstbx_Port = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstbx_Baud = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtn_Connect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtn_Disconnect = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslbl_ByteStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslbl_DATA0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslbl_xypos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_Color0 = New System.Windows.Forms.Button()
        Me.btn_Color1 = New System.Windows.Forms.Button()
        Me.btn_Color2 = New System.Windows.Forms.Button()
        Me.btn_Color3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.pbx_Screen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbx_Screen
        '
        Me.pbx_Screen.BackColor = System.Drawing.Color.Black
        Me.pbx_Screen.Location = New System.Drawing.Point(12, 57)
        Me.pbx_Screen.Name = "pbx_Screen"
        Me.pbx_Screen.Size = New System.Drawing.Size(320, 280)
        Me.pbx_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Screen.TabIndex = 0
        Me.pbx_Screen.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstbx_Port, Me.ToolStripLabel2, Me.tstbx_Baud, Me.tsbtn_Connect, Me.ToolStripSeparator1, Me.tsbtn_Disconnect})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(343, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel1.Text = "Port:"
        '
        'tstbx_Port
        '
        Me.tstbx_Port.Name = "tstbx_Port"
        Me.tstbx_Port.Size = New System.Drawing.Size(100, 25)
        Me.tstbx_Port.Text = "COM9"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel2.Text = "Speed:"
        '
        'tstbx_Baud
        '
        Me.tstbx_Baud.Name = "tstbx_Baud"
        Me.tstbx_Baud.Size = New System.Drawing.Size(100, 25)
        Me.tstbx_Baud.Text = "115200"
        '
        'tsbtn_Connect
        '
        Me.tsbtn_Connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtn_Connect.Image = CType(resources.GetObject("tsbtn_Connect.Image"), System.Drawing.Image)
        Me.tsbtn_Connect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_Connect.Name = "tsbtn_Connect"
        Me.tsbtn_Connect.Size = New System.Drawing.Size(56, 19)
        Me.tsbtn_Connect.Text = "Connect"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtn_Disconnect
        '
        Me.tsbtn_Disconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtn_Disconnect.Image = CType(resources.GetObject("tsbtn_Disconnect.Image"), System.Drawing.Image)
        Me.tsbtn_Disconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_Disconnect.Name = "tsbtn_Disconnect"
        Me.tsbtn_Disconnect.Size = New System.Drawing.Size(70, 19)
        Me.tsbtn_Disconnect.Text = "Disconnect"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslbl_Status, Me.tsslbl_ByteStat, Me.tsslbl_DATA0, Me.tsslbl_xypos})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 343)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(343, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslbl_Status
        '
        Me.tsslbl_Status.Name = "tsslbl_Status"
        Me.tsslbl_Status.Size = New System.Drawing.Size(43, 17)
        Me.tsslbl_Status.Text = "Offline"
        '
        'tsslbl_ByteStat
        '
        Me.tsslbl_ByteStat.Name = "tsslbl_ByteStat"
        Me.tsslbl_ByteStat.Size = New System.Drawing.Size(22, 17)
        Me.tsslbl_ByteStat.Text = "---"
        '
        'tsslbl_DATA0
        '
        Me.tsslbl_DATA0.Name = "tsslbl_DATA0"
        Me.tsslbl_DATA0.Size = New System.Drawing.Size(12, 17)
        Me.tsslbl_DATA0.Text = "-"
        '
        'tsslbl_xypos
        '
        Me.tsslbl_xypos.Name = "tsslbl_xypos"
        Me.tsslbl_xypos.Size = New System.Drawing.Size(40, 17)
        Me.tsslbl_xypos.Text = "X:- Y:-"
        '
        'btn_Color0
        '
        Me.btn_Color0.BackColor = System.Drawing.Color.Black
        Me.btn_Color0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Color0.Location = New System.Drawing.Point(12, 28)
        Me.btn_Color0.Name = "btn_Color0"
        Me.btn_Color0.Size = New System.Drawing.Size(25, 23)
        Me.btn_Color0.TabIndex = 3
        Me.btn_Color0.UseVisualStyleBackColor = False
        '
        'btn_Color1
        '
        Me.btn_Color1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Color1.Location = New System.Drawing.Point(36, 28)
        Me.btn_Color1.Name = "btn_Color1"
        Me.btn_Color1.Size = New System.Drawing.Size(25, 23)
        Me.btn_Color1.TabIndex = 4
        Me.btn_Color1.UseVisualStyleBackColor = False
        '
        'btn_Color2
        '
        Me.btn_Color2.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Color2.Location = New System.Drawing.Point(60, 28)
        Me.btn_Color2.Name = "btn_Color2"
        Me.btn_Color2.Size = New System.Drawing.Size(25, 23)
        Me.btn_Color2.TabIndex = 5
        Me.btn_Color2.UseVisualStyleBackColor = False
        '
        'btn_Color3
        '
        Me.btn_Color3.BackColor = System.Drawing.Color.White
        Me.btn_Color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Color3.Location = New System.Drawing.Point(84, 28)
        Me.btn_Color3.Name = "btn_Color3"
        Me.btn_Color3.Size = New System.Drawing.Size(25, 23)
        Me.btn_Color3.TabIndex = 6
        Me.btn_Color3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Greyscale", "Game Boy"})
        Me.ComboBox1.Location = New System.Drawing.Point(115, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 23)
        Me.ComboBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 365)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_Color3)
        Me.Controls.Add(Me.btn_Color2)
        Me.Controls.Add(Me.btn_Color1)
        Me.Controls.Add(Me.btn_Color0)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pbx_Screen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "gb-fx2 Capture"
        CType(Me.pbx_Screen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbx_Screen As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tstbx_Port As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tstbx_Baud As ToolStripTextBox
    Friend WithEvents tsbtn_Connect As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtn_Disconnect As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslbl_Status As ToolStripStatusLabel
    Friend WithEvents tsslbl_ByteStat As ToolStripStatusLabel
    Friend WithEvents btn_Color0 As Button
    Friend WithEvents btn_Color1 As Button
    Friend WithEvents btn_Color2 As Button
    Friend WithEvents btn_Color3 As Button
    Friend WithEvents tsslbl_DATA0 As ToolStripStatusLabel
    Friend WithEvents tsslbl_xypos As ToolStripStatusLabel
    Friend WithEvents ComboBox1 As ComboBox
End Class
