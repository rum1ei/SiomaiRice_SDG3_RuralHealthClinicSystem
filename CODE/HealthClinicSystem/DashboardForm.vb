Public Class Dashboard
    Public Sub New()
        InitializeComponent()
        AddHandler btnPatients.Click, AddressOf btnPatients_Click
    End Sub
    Private Sub Dashboard_Load(
    sender As Object,
    e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btnPatients_Click(
    sender As Object,
    e As EventArgs)

        PatientForm.Show()

    End Sub


    Private Sub btnConsultation_Click(
    sender As Object,
    e As EventArgs) Handles btnConsultation.Click

        ConsultationForm.Show()

    End Sub


    Private Sub btnReports_Click(
    sender As Object,
    e As EventArgs) Handles btnReports.Click

        ReportForm.Show()

    End Sub


    Private Sub btnLogout_Click(
    sender As Object,
    e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult

        result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            LoginForm.Show()

            Me.Close()

        End If

    End Sub

End Class