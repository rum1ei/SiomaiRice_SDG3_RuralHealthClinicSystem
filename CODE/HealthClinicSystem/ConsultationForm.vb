Imports Microsoft.Data.SqlClient

Public Class ConsultationForm

    '========================
    ' LOAD FORM
    '========================
    Private Sub ConsultationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPatients()

        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")

    End Sub

    '========================
    ' LOAD PATIENTS
    '========================
    Private Sub LoadPatients()

        Try
            OpenConnection()

            Dim cmd As New SqlCommand("SELECT PatientID, FullName FROM Patients", conn)
            Dim dt As New DataTable()

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

            cmbPatient.DisplayMember = "FullName"
            cmbPatient.ValueMember = "PatientID"
            cmbPatient.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error loading patients: " & ex.Message)

        Finally
            CloseConnection()
        End Try

    End Sub

    '========================
    ' BMI CALCULATOR
    '========================
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim weight As Double = CDbl(txtWeight.Text)
            Dim height As Double = CDbl(txtHeight.Text)
            Dim age As Integer = CInt(txtAge.Text)
            Dim gender As String = cmbGender.Text

            Dim bmi As Double = weight / (height * height)

            txtBMI.Text = Math.Round(bmi, 2).ToString()

            Dim status As String

            If bmi < 18.5 Then
                status = "Underweight"
            ElseIf bmi < 25 Then
                status = "Normal"
            ElseIf bmi < 30 Then
                status = "Overweight"
            Else
                status = "Obese"
            End If

            If age >= 60 Then
                status &= " (Senior Citizen)"
            End If

            status &= " - " & gender

            txtStatus.Text = status

        Catch ex As Exception
            MessageBox.Show("Invalid input. Please check values.")
        End Try

    End Sub

    '========================
    ' SAVE RECORD
    '========================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            OpenConnection()

            Dim query As String = "
        INSERT INTO Consultations
        (PatientID, Weight, Height, Symptoms, Diagnosis, BMI)
        VALUES
        (@PatientID, @Weight, @Height, @Symptoms, @Diagnosis, @BMI)"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@PatientID", cmbPatient.SelectedValue)
            cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeight.Text))
            cmd.Parameters.AddWithValue("@Height", Convert.ToDecimal(txtHeight.Text))
            cmd.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text)
            cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text)
            cmd.Parameters.AddWithValue("@BMI", Convert.ToDecimal(txtBMI.Text))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Saved Successfully!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            CloseConnection()
        End Try

    End Sub

End Class