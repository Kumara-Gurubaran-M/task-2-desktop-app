Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class Form3
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        Dim request As HttpWebRequest = WebRequest.CreateHttp("http://localhost:5000/read")
        request.Method = "GET"
        request.ContentType = "application/json"
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim jsonResponse As String = reader.ReadToEnd()
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(index)
            displayname.Text = submission.name
            displayemail.Text = submission.email
            displaynumber.Text = submission.phone
            displaylink.Text = submission.githubLink
            displaytimer.Text = submission.elapsedTime
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button1_Click(Me, EventArgs.Empty)
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            Button2_Click(Me, EventArgs.Empty)
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            editbtn_Click(Me, EventArgs.Empty)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btndelete_Click(Me, EventArgs.Empty)
        End If
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndeiete.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            Dim request As HttpWebRequest = WebRequest.CreateHttp($"http://localhost:5000/delete/{submission.timestamp}")
            request.Method = "DELETE"
            request.ContentType = "application/json"
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                MessageBox.Show("Submission deleted successfully!")
                submissions.RemoveAt(currentIndex)
                If currentIndex >= submissions.Count Then
                    currentIndex = submissions.Count - 1
                End If
                DisplaySubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete the submission.")
            End If
        End If
    End Sub



    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            Dim editForm As New Form4(submission)
            editForm.ShowDialog()
            LoadSubmissions()
            DisplaySubmission(currentIndex)
        End If
    End Sub


End Class
