
Imports Microsoft.Data.SqlClient
Imports System.Data.SqlClient

Module ConnectionClass

    Public connectionString As String =
    "Data Source=(localdb)\MSSQLLocalDB;
    Initial Catalog=ClinicDB;
    Integrated Security=True"

    Public conn As New SqlConnection(connectionString)

    Public Sub OpenConnection()

        If conn.State = ConnectionState.Closed Then

            conn.Open()

        End If

    End Sub

    Public Sub CloseConnection()

        If conn.State = ConnectionState.Open Then

            conn.Close()

        End If

    End Sub
    Public Function GetPatients() As DataTable

        Dim dt As New DataTable()

        Try
            OpenConnection()

            Dim query As String = "SELECT PatientName FROM Patients"
            Dim cmd As New SqlCommand(query, conn)

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            CloseConnection()
        End Try

        Return dt

    End Function

End Module