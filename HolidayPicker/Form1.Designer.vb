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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnManchester = New System.Windows.Forms.RadioButton()
        Me.rbtnBelfast = New System.Windows.Forms.RadioButton()
        Me.rbtnCardiff = New System.Windows.Forms.RadioButton()
        Me.rbtnNewcastle = New System.Windows.Forms.RadioButton()
        Me.rbtnEdinburgh = New System.Windows.Forms.RadioButton()
        Me.rbtnLondon = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtn7Nights = New System.Windows.Forms.RadioButton()
        Me.rbtn3Nights = New System.Windows.Forms.RadioButton()
        Me.rbtn2Nights = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkGuide_City_Tour = New System.Windows.Forms.CheckBox()
        Me.chkFitness_Suite = New System.Windows.Forms.CheckBox()
        Me.chkSpa_and_Pool = New System.Windows.Forms.CheckBox()
        Me.chkDinner = New System.Windows.Forms.CheckBox()
        Me.chkLunch = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblReciept = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Holiday Planner"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " Email:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 99)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 4
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(275, 61)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboMonth.TabIndex = 5
        Me.cboMonth.Text = "Month"
        '
        'cboDay
        '
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(422, 61)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(121, 21)
        Me.cboDay.TabIndex = 6
        Me.cboDay.Text = "Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = " Destination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = " Duration"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnManchester)
        Me.GroupBox1.Controls.Add(Me.rbtnBelfast)
        Me.GroupBox1.Controls.Add(Me.rbtnCardiff)
        Me.GroupBox1.Controls.Add(Me.rbtnNewcastle)
        Me.GroupBox1.Controls.Add(Me.rbtnEdinburgh)
        Me.GroupBox1.Controls.Add(Me.rbtnLondon)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 81)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'rbtnManchester
        '
        Me.rbtnManchester.AutoSize = True
        Me.rbtnManchester.Location = New System.Drawing.Point(104, 55)
        Me.rbtnManchester.Name = "rbtnManchester"
        Me.rbtnManchester.Size = New System.Drawing.Size(84, 17)
        Me.rbtnManchester.TabIndex = 5
        Me.rbtnManchester.Text = " Manchester"
        Me.rbtnManchester.UseVisualStyleBackColor = True
        '
        'rbtnBelfast
        '
        Me.rbtnBelfast.AutoSize = True
        Me.rbtnBelfast.Location = New System.Drawing.Point(0, 55)
        Me.rbtnBelfast.Name = "rbtnBelfast"
        Me.rbtnBelfast.Size = New System.Drawing.Size(60, 17)
        Me.rbtnBelfast.TabIndex = 4
        Me.rbtnBelfast.Text = " Belfast"
        Me.rbtnBelfast.UseVisualStyleBackColor = True
        '
        'rbtnCardiff
        '
        Me.rbtnCardiff.AutoSize = True
        Me.rbtnCardiff.Location = New System.Drawing.Point(104, 9)
        Me.rbtnCardiff.Name = "rbtnCardiff"
        Me.rbtnCardiff.Size = New System.Drawing.Size(58, 17)
        Me.rbtnCardiff.TabIndex = 3
        Me.rbtnCardiff.Text = " Cardiff"
        Me.rbtnCardiff.UseVisualStyleBackColor = True
        '
        'rbtnNewcastle
        '
        Me.rbtnNewcastle.AutoSize = True
        Me.rbtnNewcastle.Location = New System.Drawing.Point(104, 32)
        Me.rbtnNewcastle.Name = "rbtnNewcastle"
        Me.rbtnNewcastle.Size = New System.Drawing.Size(78, 17)
        Me.rbtnNewcastle.TabIndex = 2
        Me.rbtnNewcastle.Text = " Newcastle"
        Me.rbtnNewcastle.UseVisualStyleBackColor = True
        '
        'rbtnEdinburgh
        '
        Me.rbtnEdinburgh.AutoSize = True
        Me.rbtnEdinburgh.Location = New System.Drawing.Point(0, 32)
        Me.rbtnEdinburgh.Name = "rbtnEdinburgh"
        Me.rbtnEdinburgh.Size = New System.Drawing.Size(76, 17)
        Me.rbtnEdinburgh.TabIndex = 1
        Me.rbtnEdinburgh.Text = " Edinburgh"
        Me.rbtnEdinburgh.UseVisualStyleBackColor = True
        '
        'rbtnLondon
        '
        Me.rbtnLondon.AutoSize = True
        Me.rbtnLondon.Checked = True
        Me.rbtnLondon.Location = New System.Drawing.Point(0, 9)
        Me.rbtnLondon.Name = "rbtnLondon"
        Me.rbtnLondon.Size = New System.Drawing.Size(64, 17)
        Me.rbtnLondon.TabIndex = 0
        Me.rbtnLondon.TabStop = True
        Me.rbtnLondon.Text = " London"
        Me.rbtnLondon.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtn7Nights)
        Me.GroupBox2.Controls.Add(Me.rbtn3Nights)
        Me.GroupBox2.Controls.Add(Me.rbtn2Nights)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 81)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'rbtn7Nights
        '
        Me.rbtn7Nights.AutoSize = True
        Me.rbtn7Nights.Location = New System.Drawing.Point(0, 55)
        Me.rbtn7Nights.Name = "rbtn7Nights"
        Me.rbtn7Nights.Size = New System.Drawing.Size(65, 17)
        Me.rbtn7Nights.TabIndex = 2
        Me.rbtn7Nights.Text = " 7 nights"
        Me.rbtn7Nights.UseVisualStyleBackColor = True
        '
        'rbtn3Nights
        '
        Me.rbtn3Nights.AutoSize = True
        Me.rbtn3Nights.Location = New System.Drawing.Point(0, 32)
        Me.rbtn3Nights.Name = "rbtn3Nights"
        Me.rbtn3Nights.Size = New System.Drawing.Size(65, 17)
        Me.rbtn3Nights.TabIndex = 1
        Me.rbtn3Nights.Text = " 3 nights"
        Me.rbtn3Nights.UseVisualStyleBackColor = True
        '
        'rbtn2Nights
        '
        Me.rbtn2Nights.AutoSize = True
        Me.rbtn2Nights.Checked = True
        Me.rbtn2Nights.Location = New System.Drawing.Point(0, 9)
        Me.rbtn2Nights.Name = "rbtn2Nights"
        Me.rbtn2Nights.Size = New System.Drawing.Size(62, 17)
        Me.rbtn2Nights.TabIndex = 0
        Me.rbtn2Nights.TabStop = True
        Me.rbtn2Nights.Text = "2 nights"
        Me.rbtn2Nights.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = " Options"
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(3, 9)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(74, 17)
        Me.chkBreakfast.TabIndex = 12
        Me.chkBreakfast.Text = " Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkGuide_City_Tour)
        Me.GroupBox3.Controls.Add(Me.chkFitness_Suite)
        Me.GroupBox3.Controls.Add(Me.chkSpa_and_Pool)
        Me.GroupBox3.Controls.Add(Me.chkDinner)
        Me.GroupBox3.Controls.Add(Me.chkLunch)
        Me.GroupBox3.Controls.Add(Me.chkBreakfast)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 100)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
        '
        'chkGuide_City_Tour
        '
        Me.chkGuide_City_Tour.AutoSize = True
        Me.chkGuide_City_Tour.Location = New System.Drawing.Point(250, 55)
        Me.chkGuide_City_Tour.Name = "chkGuide_City_Tour"
        Me.chkGuide_City_Tour.Size = New System.Drawing.Size(108, 17)
        Me.chkGuide_City_Tour.TabIndex = 17
        Me.chkGuide_City_Tour.Text = " Guided City Tour"
        Me.chkGuide_City_Tour.UseVisualStyleBackColor = True
        '
        'chkFitness_Suite
        '
        Me.chkFitness_Suite.AutoSize = True
        Me.chkFitness_Suite.Location = New System.Drawing.Point(250, 32)
        Me.chkFitness_Suite.Name = "chkFitness_Suite"
        Me.chkFitness_Suite.Size = New System.Drawing.Size(89, 17)
        Me.chkFitness_Suite.TabIndex = 16
        Me.chkFitness_Suite.Text = " Fitness Suite"
        Me.chkFitness_Suite.UseVisualStyleBackColor = True
        '
        'chkSpa_and_Pool
        '
        Me.chkSpa_and_Pool.AutoSize = True
        Me.chkSpa_and_Pool.Location = New System.Drawing.Point(250, 9)
        Me.chkSpa_and_Pool.Name = "chkSpa_and_Pool"
        Me.chkSpa_and_Pool.Size = New System.Drawing.Size(93, 17)
        Me.chkSpa_and_Pool.TabIndex = 15
        Me.chkSpa_and_Pool.Text = " Spa and Pool"
        Me.chkSpa_and_Pool.UseVisualStyleBackColor = True
        '
        'chkDinner
        '
        Me.chkDinner.AutoSize = True
        Me.chkDinner.Location = New System.Drawing.Point(3, 55)
        Me.chkDinner.Name = "chkDinner"
        Me.chkDinner.Size = New System.Drawing.Size(63, 17)
        Me.chkDinner.TabIndex = 14
        Me.chkDinner.Text = "  Dinner"
        Me.chkDinner.UseVisualStyleBackColor = True
        '
        'chkLunch
        '
        Me.chkLunch.AutoSize = True
        Me.chkLunch.Location = New System.Drawing.Point(3, 32)
        Me.chkLunch.Name = "chkLunch"
        Me.chkLunch.Size = New System.Drawing.Size(59, 17)
        Me.chkLunch.TabIndex = 13
        Me.chkLunch.Text = " Lunch"
        Me.chkLunch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(215, 409)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 36)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = " Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblReciept
        '
        Me.lblReciept.AutoSize = True
        Me.lblReciept.Location = New System.Drawing.Point(509, 143)
        Me.lblReciept.Name = "lblReciept"
        Me.lblReciept.Size = New System.Drawing.Size(265, 26)
        Me.lblReciept.TabIndex = 15
        Me.lblReciept.Text = "RECIEPT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "___________________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblReciept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(422, 99)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 16
        Me.cboGender.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Age:"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(275, 100)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(121, 20)
        Me.txtage.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(768, 467)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.lblReciept)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = " Holiday Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnManchester As RadioButton
    Friend WithEvents rbtnBelfast As RadioButton
    Friend WithEvents rbtnCardiff As RadioButton
    Friend WithEvents rbtnNewcastle As RadioButton
    Friend WithEvents rbtnEdinburgh As RadioButton
    Friend WithEvents rbtnLondon As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtn7Nights As RadioButton
    Friend WithEvents rbtn3Nights As RadioButton
    Friend WithEvents rbtn2Nights As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents chkBreakfast As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkGuide_City_Tour As CheckBox
    Friend WithEvents chkFitness_Suite As CheckBox
    Friend WithEvents chkSpa_and_Pool As CheckBox
    Friend WithEvents chkDinner As CheckBox
    Friend WithEvents chkLunch As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblReciept As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtage As TextBox
End Class
