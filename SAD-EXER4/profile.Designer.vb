<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSexFemale = New System.Windows.Forms.RadioButton()
        Me.optSexMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkActInLineShaking = New System.Windows.Forms.CheckBox()
        Me.chkActSkiing = New System.Windows.Forms.CheckBox()
        Me.chkActSwimming = New System.Windows.Forms.CheckBox()
        Me.chkActBiking = New System.Windows.Forms.CheckBox()
        Me.chkActWalking = New System.Windows.Forms.CheckBox()
        Me.chkActRunning = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optLevelBeginner = New System.Windows.Forms.RadioButton()
        Me.optLevelIntermediate = New System.Windows.Forms.RadioButton()
        Me.optLevelAdvance = New System.Windows.Forms.RadioButton()
        Me.optLevelExtreme = New System.Windows.Forms.RadioButton()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSexFemale)
        Me.GroupBox1.Controls.Add(Me.optSexMale)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'optSexFemale
        '
        Me.optSexFemale.AutoSize = True
        Me.optSexFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSexFemale.Location = New System.Drawing.Point(6, 58)
        Me.optSexFemale.Name = "optSexFemale"
        Me.optSexFemale.Size = New System.Drawing.Size(72, 21)
        Me.optSexFemale.TabIndex = 1
        Me.optSexFemale.Text = "Female"
        Me.optSexFemale.UseVisualStyleBackColor = True
        '
        'optSexMale
        '
        Me.optSexMale.AutoSize = True
        Me.optSexMale.Checked = True
        Me.optSexMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSexMale.Location = New System.Drawing.Point(6, 31)
        Me.optSexMale.Name = "optSexMale"
        Me.optSexMale.Size = New System.Drawing.Size(56, 21)
        Me.optSexMale.TabIndex = 0
        Me.optSexMale.TabStop = True
        Me.optSexMale.Text = "Male"
        Me.optSexMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkActInLineShaking)
        Me.GroupBox2.Controls.Add(Me.chkActSkiing)
        Me.GroupBox2.Controls.Add(Me.chkActSwimming)
        Me.GroupBox2.Controls.Add(Me.chkActBiking)
        Me.GroupBox2.Controls.Add(Me.chkActWalking)
        Me.GroupBox2.Controls.Add(Me.chkActRunning)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 189)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activites"
        '
        'chkActInLineShaking
        '
        Me.chkActInLineShaking.AutoSize = True
        Me.chkActInLineShaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActInLineShaking.Location = New System.Drawing.Point(6, 166)
        Me.chkActInLineShaking.Name = "chkActInLineShaking"
        Me.chkActInLineShaking.Size = New System.Drawing.Size(124, 21)
        Me.chkActInLineShaking.TabIndex = 15
        Me.chkActInLineShaking.Text = "In-Like Shaking"
        Me.chkActInLineShaking.UseVisualStyleBackColor = True
        '
        'chkActSkiing
        '
        Me.chkActSkiing.AutoSize = True
        Me.chkActSkiing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActSkiing.Location = New System.Drawing.Point(6, 139)
        Me.chkActSkiing.Name = "chkActSkiing"
        Me.chkActSkiing.Size = New System.Drawing.Size(65, 21)
        Me.chkActSkiing.TabIndex = 14
        Me.chkActSkiing.Text = "Skiing"
        Me.chkActSkiing.UseVisualStyleBackColor = True
        '
        'chkActSwimming
        '
        Me.chkActSwimming.AutoSize = True
        Me.chkActSwimming.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActSwimming.Location = New System.Drawing.Point(6, 112)
        Me.chkActSwimming.Name = "chkActSwimming"
        Me.chkActSwimming.Size = New System.Drawing.Size(89, 21)
        Me.chkActSwimming.TabIndex = 13
        Me.chkActSwimming.Text = "Swimming"
        Me.chkActSwimming.UseVisualStyleBackColor = True
        '
        'chkActBiking
        '
        Me.chkActBiking.AutoSize = True
        Me.chkActBiking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActBiking.Location = New System.Drawing.Point(6, 85)
        Me.chkActBiking.Name = "chkActBiking"
        Me.chkActBiking.Size = New System.Drawing.Size(65, 21)
        Me.chkActBiking.TabIndex = 12
        Me.chkActBiking.Text = "Biking"
        Me.chkActBiking.UseVisualStyleBackColor = True
        '
        'chkActWalking
        '
        Me.chkActWalking.AutoSize = True
        Me.chkActWalking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActWalking.Location = New System.Drawing.Point(6, 58)
        Me.chkActWalking.Name = "chkActWalking"
        Me.chkActWalking.Size = New System.Drawing.Size(77, 21)
        Me.chkActWalking.TabIndex = 11
        Me.chkActWalking.Text = "Walking"
        Me.chkActWalking.UseVisualStyleBackColor = True
        '
        'chkActRunning
        '
        Me.chkActRunning.AutoSize = True
        Me.chkActRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActRunning.Location = New System.Drawing.Point(6, 31)
        Me.chkActRunning.Name = "chkActRunning"
        Me.chkActRunning.Size = New System.Drawing.Size(80, 21)
        Me.chkActRunning.TabIndex = 10
        Me.chkActRunning.Text = "Running"
        Me.chkActRunning.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCity)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(147, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 86)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "City of Residence"
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Caloocan City", "Makati City", "Manila City", "Quezon City"})
        Me.cboCity.Location = New System.Drawing.Point(6, 33)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(188, 33)
        Me.cboCity.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optLevelBeginner)
        Me.GroupBox4.Controls.Add(Me.optLevelIntermediate)
        Me.GroupBox4.Controls.Add(Me.optLevelAdvance)
        Me.GroupBox4.Controls.Add(Me.optLevelExtreme)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(163, 158)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 140)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Athletic Level"
        '
        'optLevelBeginner
        '
        Me.optLevelBeginner.AutoSize = True
        Me.optLevelBeginner.Checked = True
        Me.optLevelBeginner.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLevelBeginner.Location = New System.Drawing.Point(6, 111)
        Me.optLevelBeginner.Name = "optLevelBeginner"
        Me.optLevelBeginner.Size = New System.Drawing.Size(83, 21)
        Me.optLevelBeginner.TabIndex = 5
        Me.optLevelBeginner.TabStop = True
        Me.optLevelBeginner.Text = "Beginner"
        Me.optLevelBeginner.UseVisualStyleBackColor = True
        '
        'optLevelIntermediate
        '
        Me.optLevelIntermediate.AutoSize = True
        Me.optLevelIntermediate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLevelIntermediate.Location = New System.Drawing.Point(6, 84)
        Me.optLevelIntermediate.Name = "optLevelIntermediate"
        Me.optLevelIntermediate.Size = New System.Drawing.Size(104, 21)
        Me.optLevelIntermediate.TabIndex = 4
        Me.optLevelIntermediate.Text = "Intermediate"
        Me.optLevelIntermediate.UseVisualStyleBackColor = True
        '
        'optLevelAdvance
        '
        Me.optLevelAdvance.AutoSize = True
        Me.optLevelAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLevelAdvance.Location = New System.Drawing.Point(6, 58)
        Me.optLevelAdvance.Name = "optLevelAdvance"
        Me.optLevelAdvance.Size = New System.Drawing.Size(81, 21)
        Me.optLevelAdvance.TabIndex = 3
        Me.optLevelAdvance.Text = "Advance"
        Me.optLevelAdvance.UseVisualStyleBackColor = True
        '
        'optLevelExtreme
        '
        Me.optLevelExtreme.AutoSize = True
        Me.optLevelExtreme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLevelExtreme.Location = New System.Drawing.Point(6, 31)
        Me.optLevelExtreme.Name = "optLevelExtreme"
        Me.optLevelExtreme.Size = New System.Drawing.Size(77, 21)
        Me.optLevelExtreme.TabIndex = 2
        Me.optLevelExtreme.Text = "Extreme"
        Me.optLevelExtreme.UseVisualStyleBackColor = True
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(367, 108)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(118, 69)
        Me.cmdShow.TabIndex = 5
        Me.cmdShow.Text = "&Show Profile"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(367, 183)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(118, 69)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.Text = "&New Profile"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(367, 258)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(118, 69)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(95, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(252, 32)
        Me.txtName.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(419, 15)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(51, 32)
        Me.txtAge.TabIndex = 9
        '
        'profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 351)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "profile"
        Me.Text = "Customer Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents optSexFemale As System.Windows.Forms.RadioButton
    Friend WithEvents optSexMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents chkActInLineShaking As System.Windows.Forms.CheckBox
    Friend WithEvents chkActSkiing As System.Windows.Forms.CheckBox
    Friend WithEvents chkActSwimming As System.Windows.Forms.CheckBox
    Friend WithEvents chkActBiking As System.Windows.Forms.CheckBox
    Friend WithEvents chkActWalking As System.Windows.Forms.CheckBox
    Friend WithEvents chkActRunning As System.Windows.Forms.CheckBox
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents optLevelBeginner As System.Windows.Forms.RadioButton
    Friend WithEvents optLevelIntermediate As System.Windows.Forms.RadioButton
    Friend WithEvents optLevelAdvance As System.Windows.Forms.RadioButton
    Friend WithEvents optLevelExtreme As System.Windows.Forms.RadioButton

End Class
