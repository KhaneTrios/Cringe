<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCringe = New System.Windows.Forms.Button()
        Me.tmrCringe = New System.Windows.Forms.Timer(Me.components)
        Me.lblCringe = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblOuchText = New System.Windows.Forms.Label()
        Me.lblOuch = New System.Windows.Forms.Label()
        Me.tmrTen = New System.Windows.Forms.Timer(Me.components)
        Me.txtMult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.tmrCool = New System.Windows.Forms.Timer(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCringe
        '
        Me.btnCringe.Location = New System.Drawing.Point(144, 240)
        Me.btnCringe.Name = "btnCringe"
        Me.btnCringe.Size = New System.Drawing.Size(184, 72)
        Me.btnCringe.TabIndex = 0
        Me.btnCringe.Text = "Start The Cringe"
        Me.btnCringe.UseVisualStyleBackColor = True
        '
        'tmrCringe
        '
        Me.tmrCringe.Interval = 1000
        '
        'lblCringe
        '
        Me.lblCringe.AutoSize = True
        Me.lblCringe.BackColor = System.Drawing.Color.Transparent
        Me.lblCringe.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCringe.ForeColor = System.Drawing.Color.Yellow
        Me.lblCringe.Location = New System.Drawing.Point(152, 144)
        Me.lblCringe.Name = "lblCringe"
        Me.lblCringe.Size = New System.Drawing.Size(77, 90)
        Me.lblCringe.TabIndex = 1
        Me.lblCringe.Text = "0"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(192, 328)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(88, 32)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Coast Is Clear"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(8, 392)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(88, 40)
        Me.btnEnd.TabIndex = 3
        Me.btnEnd.Text = "RUN!"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 1
        '
        'lblOuchText
        '
        Me.lblOuchText.AutoSize = True
        Me.lblOuchText.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOuchText.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOuchText.Location = New System.Drawing.Point(0, 192)
        Me.lblOuchText.Name = "lblOuchText"
        Me.lblOuchText.Size = New System.Drawing.Size(82, 30)
        Me.lblOuchText.TabIndex = 4
        Me.lblOuchText.Text = "Cancer"
        '
        'lblOuch
        '
        Me.lblOuch.AutoSize = True
        Me.lblOuch.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOuch.ForeColor = System.Drawing.Color.Yellow
        Me.lblOuch.Location = New System.Drawing.Point(88, 192)
        Me.lblOuch.Name = "lblOuch"
        Me.lblOuch.Size = New System.Drawing.Size(24, 26)
        Me.lblOuch.TabIndex = 5
        Me.lblOuch.Text = "0"
        '
        'tmrTen
        '
        Me.tmrTen.Interval = 10000
        '
        'txtMult
        '
        Me.txtMult.Location = New System.Drawing.Point(344, 168)
        Me.txtMult.Name = "txtMult"
        Me.txtMult.Size = New System.Drawing.Size(80, 20)
        Me.txtMult.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cringe Multiplier"
        '
        'picBack
        '
        Me.picBack.Image = Global.WindowsApplication1.My.Resources.Resources.Back
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(472, 440)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 8
        Me.picBack.TabStop = False
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(144, 400)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(104, 24)
        Me.btnCool.TabIndex = 9
        Me.btnCool.Text = "Cancer Cooldown"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'tmrCool
        '
        Me.tmrCool.Interval = 1000
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(432, 168)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(32, 24)
        Me.btnGo.TabIndex = 10
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 437)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.lblCringe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMult)
        Me.Controls.Add(Me.lblOuch)
        Me.Controls.Add(Me.lblOuchText)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnCringe)
        Me.Controls.Add(Me.picBack)
        Me.Name = "frmMain"
        Me.Text = "Cringe"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCringe As System.Windows.Forms.Button
    Friend WithEvents tmrCringe As System.Windows.Forms.Timer
    Friend WithEvents lblCringe As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents lblOuchText As System.Windows.Forms.Label
    Friend WithEvents lblOuch As System.Windows.Forms.Label
    Friend WithEvents tmrTen As System.Windows.Forms.Timer
    Friend WithEvents txtMult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents btnCool As System.Windows.Forms.Button
    Friend WithEvents tmrCool As System.Windows.Forms.Timer
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
