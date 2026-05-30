Public Class HealthAssessment

    Public Function CalculateBMI(
            weight As Double,
            height As Double) As Double

        Return Math.Round(
                weight / (height * height), 2)

    End Function

    Public Function GetStatus(
            bmi As Double) As String

        If bmi < 18.5 Then

            Return "Underweight"

        ElseIf bmi < 25 Then

            Return "Normal"

        ElseIf bmi < 30 Then

            Return "Overweight"

        Else

            Return "Obese"

        End If

    End Function

End Class