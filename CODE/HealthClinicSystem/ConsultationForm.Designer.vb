<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultationForm))
        cmbPatient = New ComboBox()
        txtSymptoms = New TextBox()
        txtDiagnosis = New TextBox()
        txtBMI = New TextBox()
        btnCalculate = New Button()
        btnSave = New Button()
        Label1 = New Label()
        txtStatus = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dtpDate = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        txtWeight = New TextBox()
        txtHeight = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtAge = New TextBox()
        cmbGender = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbPatient
        ' 
        cmbPatient.AccessibleName = "cmbPatient"
        cmbPatient.ForeColor = SystemColors.ActiveCaptionText
        cmbPatient.FormattingEnabled = True
        cmbPatient.Location = New Point(111, 84)
        cmbPatient.Name = "cmbPatient"
        cmbPatient.Size = New Size(240, 25)
        cmbPatient.TabIndex = 0
        cmbPatient.Text = "Select patient"
        ' 
        ' txtSymptoms
        ' 
        txtSymptoms.AccessibleName = ""
        txtSymptoms.Location = New Point(431, 145)
        txtSymptoms.Multiline = True
        txtSymptoms.Name = "txtSymptoms"
        txtSymptoms.Size = New Size(275, 107)
        txtSymptoms.TabIndex = 3
        txtSymptoms.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' txtDiagnosis
        ' 
        txtDiagnosis.AccessibleName = "txtDiagnosis"
        txtDiagnosis.Location = New Point(431, 286)
        txtDiagnosis.Multiline = True
        txtDiagnosis.Name = "txtDiagnosis"
        txtDiagnosis.Size = New Size(275, 118)
        txtDiagnosis.TabIndex = 4
        ' 
        ' txtBMI
        ' 
        txtBMI.AccessibleName = ""
        txtBMI.Location = New Point(111, 289)
        txtBMI.Multiline = True
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(137, 25)
        txtBMI.TabIndex = 5
        txtBMI.Text = "0.00"
        txtBMI.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCalculate
        ' 
        btnCalculate.AccessibleName = "btnCalculate"
        btnCalculate.Location = New Point(111, 248)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(201, 35)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "CALCULATE BMI"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.AccessibleName = ""
        btnSave.BackColor = SystemColors.HotTrack
        btnSave.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.Control
        btnSave.Location = New Point(111, 382)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(169, 43)
        btnSave.TabIndex = 7
        btnSave.Text = "SAVE RECORD"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(35, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 8
        Label1.Text = "Patient"
        ' 
        ' txtStatus
        ' 
        txtStatus.AccessibleName = ""
        txtStatus.ForeColor = SystemColors.HotTrack
        txtStatus.Location = New Point(111, 329)
        txtStatus.Multiline = True
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(186, 27)
        txtStatus.TabIndex = 11
        txtStatus.Text = "--"
        txtStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(63, 292)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 17)
        Label4.TabIndex = 12
        Label4.Text = "BMI"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(62, 332)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 17)
        Label5.TabIndex = 13
        Label5.Text = "Status"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(432, 125)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 17)
        Label6.TabIndex = 14
        Label6.Text = "Symptoms"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(431, 266)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 17)
        Label7.TabIndex = 15
        Label7.Text = "Diagnosis"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarForeColor = SystemColors.HotTrack
        dtpDate.CalendarTitleForeColor = SystemColors.Highlight
        dtpDate.CalendarTrailingForeColor = SystemColors.HotTrack
        dtpDate.Location = New Point(432, 81)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 25)
        dtpDate.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AccessibleName = "lblTitle"
        Label8.BackColor = SystemColors.HotTrack
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(-2, 0)
        Label8.MaximumSize = New Size(1000, 1000)
        Label8.Name = "Label8"
        Label8.Size = New Size(745, 58)
        Label8.TabIndex = 17
        Label8.Text = "             CONSULTATION RECORD"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtWeight
        ' 
        txtWeight.AccessibleName = ""
        txtWeight.ForeColor = SystemColors.ActiveCaptionText
        txtWeight.Location = New Point(111, 115)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(104, 25)
        txtWeight.TabIndex = 1
        ' 
        ' txtHeight
        ' 
        txtHeight.AccessibleName = ""
        txtHeight.ForeColor = SystemColors.ActiveCaptionText
        txtHeight.Location = New Point(111, 146)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(104, 25)
        txtHeight.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(35, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 17)
        Label2.TabIndex = 9
        Label2.Text = "Weight (kg)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(35, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 10
        Label3.Text = "Height (cm)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = SystemColors.HotTrack
        Label9.Location = New Point(35, 211)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 17)
        Label9.TabIndex = 22
        Label9.Text = "Gender"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = SystemColors.HotTrack
        Label10.Location = New Point(35, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(31, 17)
        Label10.TabIndex = 21
        Label10.Text = "Age"
        ' 
        ' txtAge
        ' 
        txtAge.AccessibleName = ""
        txtAge.ForeColor = SystemColors.ActiveCaptionText
        txtAge.Location = New Point(111, 177)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(104, 25)
        txtAge.TabIndex = 19
        ' 
        ' cmbGender
        ' 
        cmbGender.ForeColor = SystemColors.ActiveCaptionText
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(111, 208)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(104, 25)
        cmbGender.TabIndex = 23
        ' 
        ' ConsultationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        BackgroundImage = My.Resources.Resources._3db579dc_b980_4694_ad5f_1730beaa1387
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(743, 441)
        Controls.Add(cmbGender)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(txtAge)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(dtpDate)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtStatus)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(btnCalculate)
        Controls.Add(txtBMI)
        Controls.Add(txtDiagnosis)
        Controls.Add(txtSymptoms)
        Controls.Add(txtHeight)
        Controls.Add(txtWeight)
        Controls.Add(cmbPatient)
        Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.HotTrack
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ConsultationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consultation Record"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPatient As ComboBox
    Friend WithEvents txtSymptoms As TextBox
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cmbGender As ComboBox
End Class
