<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        btnPatients = New Button()
        btnConsultation = New Button()
        btnReports = New Button()
        btnLogout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPatients
        ' 
        btnPatients.AccessibleName = "btnPatients"
        btnPatients.BackgroundImage = CType(resources.GetObject("btnPatients.BackgroundImage"), Image)
        btnPatients.BackgroundImageLayout = ImageLayout.Zoom
        btnPatients.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnPatients.ForeColor = Color.Lavender
        btnPatients.Location = New Point(115, 205)
        btnPatients.Name = "btnPatients"
        btnPatients.Size = New Size(223, 124)
        btnPatients.TabIndex = 0
        btnPatients.Text = vbCrLf & vbCrLf
        btnPatients.UseVisualStyleBackColor = True
        ' 
        ' btnConsultation
        ' 
        btnConsultation.AccessibleName = "btnConsultation"
        btnConsultation.BackgroundImage = My.Resources.Resources.Dashboard_logo_2
        btnConsultation.BackgroundImageLayout = ImageLayout.Zoom
        btnConsultation.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnConsultation.ForeColor = Color.Lavender
        btnConsultation.Location = New Point(376, 205)
        btnConsultation.Name = "btnConsultation"
        btnConsultation.Size = New Size(223, 124)
        btnConsultation.TabIndex = 1
        btnConsultation.Text = vbCrLf & vbCrLf
        btnConsultation.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.AccessibleName = "btnReports"
        btnReports.BackgroundImage = My.Resources.Resources.Dashboard_logo_3
        btnReports.BackgroundImageLayout = ImageLayout.Zoom
        btnReports.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnReports.ForeColor = Color.Lavender
        btnReports.Location = New Point(115, 358)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(223, 124)
        btnReports.TabIndex = 2
        btnReports.Text = vbCrLf & vbCrLf
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.AccessibleName = "btnLogout"
        btnLogout.BackgroundImage = My.Resources.Resources.Dashboard_logo_4
        btnLogout.BackgroundImageLayout = ImageLayout.Zoom
        btnLogout.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btnLogout.ForeColor = Color.Lavender
        btnLogout.Location = New Point(376, 358)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(223, 124)
        btnLogout.TabIndex = 3
        btnLogout.Text = vbCrLf & vbCrLf
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "lblTitle"
        Label1.BackColor = Color.White
        Label1.Dock = DockStyle.Top
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(711, 175)
        Label1.TabIndex = 4
        Label1.Text = vbCrLf & vbCrLf & "Welcome, User!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AccessibleName = "lblTitle"
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.WindowText
        Label2.Location = New Point(247, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 23)
        Label2.TabIndex = 9
        Label2.Text = "What would you like to do?"
        ' 
        ' Label3
        ' 
        Label3.AccessibleName = "lblTitle"
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.HotTrack
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(187, 332)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 23)
        Label3.TabIndex = 10
        Label3.Text = "PATIENTS"
        ' 
        ' Label4
        ' 
        Label4.AccessibleName = "lblTitle"
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.HotTrack
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(412, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 23)
        Label4.TabIndex = 11
        Label4.Text = "CONSULTATION"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AccessibleName = "lblTitle"
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.HotTrack
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Window
        Label5.Location = New Point(448, 485)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 23)
        Label5.TabIndex = 12
        Label5.Text = "LOGOUT"
        ' 
        ' Label6
        ' 
        Label6.AccessibleName = "lblTitle"
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.HotTrack
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(190, 485)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 23)
        Label6.TabIndex = 13
        Label6.Text = "REPORTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(293, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(711, 573)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnReports)
        Controls.Add(btnConsultation)
        Controls.Add(Me.btnPatients)
        ForeColor = Color.Lavender
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Private btnPatients As Button
    Friend WithEvents btnConsultation As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
