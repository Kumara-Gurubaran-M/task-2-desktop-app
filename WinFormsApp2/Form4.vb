Imports Newtonsoft.Json
Imports System.IO
Imports System.Net
Imports WinFormsApp2.Form3

Public Class Form4
    Private submission As Submission
    Private timerRunning As Boolean = True
    Private startTime As DateTime

    Public Sub New(submission As Submission)
        InitializeComponent()
        Me.submission = submission
        LoadSubmissionData()
        startTime = DateTime.Now
        Timer1.Start()
    End Sub

    Private Sub LoadSubmissionData()
        editname.Text = submission.name
        editemail.Text = submission.email
        editnumber.Text = submission.phone
        editlink.Text = submission.githubLink
        edittimer.Text = FormatTime(submission.elapsedTime)
    End Sub

    Private Function FormatTime(timeString As String) As String
        Dim timeSpan As TimeSpan
        If TimeSpan.TryParse(timeString, timeSpan) Then
            Return String.Format("{0:D2}:{1:D2}:{2:D2}", CInt(Math.Truncate(timeSpan.TotalHours)), timeSpan.Minutes, timeSpan.Seconds)
        End If
        Return "00:00:00"
    End Function

    Private Sub editsubmit_Click(sender As Object, e As EventArgs) Handles editsubmit.Click
        Try
            submission.name = editname.Text
            submission.email = editemail.Text
            submission.phone = editnumber.Text
            submission.githubLink = editlink.Text
            submission.elapsedTime = CalculateTotalTime()

            submission.elapsedTime = RemoveMilliseconds(submission.elapsedTime)

            Dim jsonBody As String = JsonConvert.SerializeObject(submission)
            Dim request As HttpWebRequest = WebRequest.CreateHttp($"http://localhost:5000/update/{submission.timestamp}")
            request.Method = "PUT"
            request.ContentType = "application/json"
            Using writer As New StreamWriter(request.GetRequestStream())
                writer.Write(jsonBody)
            End Using

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Me.Close()
            Else
                MessageBox.Show("Failed to update the submission.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub


    Private Function CalculateTotalTime() As String
        Dim previousTime As TimeSpan
        If TimeSpan.TryParse(submission.elapsedTime, previousTime) Then
            Dim currentTime As TimeSpan = DateTime.Now - startTime
            Return previousTime.Add(currentTime).ToString()
        End If
        Return "00:00:00"
    End Function

    Private Function RemoveMilliseconds(timeString As String) As String
        Dim timeSpan As TimeSpan
        If TimeSpan.TryParse(timeString, timeSpan) Then
            Return String.Format("{0:D2}:{1:D2}:{2:D2}", CInt(Math.Truncate(timeSpan.TotalHours)), timeSpan.Minutes, timeSpan.Seconds)
        End If
        Return "00:00:00"
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timerRunning Then
            Dim currentTime As TimeSpan = DateTime.Now - startTime
            edittimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", CInt(Math.Truncate(currentTime.TotalHours)), currentTime.Minutes, currentTime.Seconds)
        End If
    End Sub

    Private Sub btntimer_Click(sender As Object, e As EventArgs) Handles btntimer.Click
        timerRunning = Not timerRunning
        If timerRunning Then

            startTime = DateTime.Now - TimeSpan.Parse(edittimer.Text)
            Timer1.Start()
        Else

            Timer1.Stop()
        End If
    End Sub

End Class