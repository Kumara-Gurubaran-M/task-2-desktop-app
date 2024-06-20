Imports System.Text.RegularExpressions
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form2
    Private elapsedTime As TimeSpan
    Private isRunning As Boolean = False
    Private startTime As DateTime

    Public Sub New()
        InitializeComponent()

        Me.KeyPreview = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        startTime = DateTime.Now
        isRunning = True
    End Sub

    Private Sub btntogglestopwatch(sender As Object, e As EventArgs) Handles Button1.Click
        If isRunning Then
            Timer1.Stop()
        Else
            Timer1.Start()
            startTime = DateTime.Now - elapsedTime
        End If
        isRunning = Not isRunning
    End Sub

    Private Sub btnsubmit(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ValidateInputs() Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim submissionData As New Dictionary(Of String, String)()
        submissionData.Add("name", TextBox1.Text)
        submissionData.Add("email", TextBox2.Text)
        submissionData.Add("phone", TextBox3.Text)
        submissionData.Add("githubLink", TextBox4.Text)
        submissionData.Add("elapsedTime", TextBox5.Text)


        Dim json As String = JsonConvert.SerializeObject(submissionData)

        Dim backendUrl As String = "http://localhost:5000/submit"

        Using client As New HttpClient()
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = client.PostAsync(backendUrl, content).Result
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to submit data to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        Me.Close()
    End Sub



    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim urlPattern As String = "^https?://([\w-]+(\.[\w-]+)+(:\d+)?(/[\w- ./?%&=]*)?)?$"


        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse Not TextBox1.Text.Replace(" ", "").All(Function(c) Char.IsLetter(c)) Then
            TextBox1.BackColor = Color.LightCoral
            isValid = False
        Else
            TextBox1.BackColor = Color.White
        End If


        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse Not Regex.IsMatch(TextBox2.Text, emailPattern) Then
            TextBox2.BackColor = Color.LightCoral
            isValid = False
        Else
            TextBox2.BackColor = Color.White
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) OrElse TextBox3.Text.Length <> 10 OrElse Not TextBox3.Text.All(Function(c) Char.IsDigit(c)) Then
            TextBox3.BackColor = Color.LightCoral
            isValid = False
        Else
            TextBox3.BackColor = Color.White
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) OrElse Not Regex.IsMatch(TextBox4.Text, urlPattern) Then
            TextBox4.BackColor = Color.LightCoral
            isValid = False
        Else
            TextBox4.BackColor = Color.White
        End If

        Return isValid
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = DateTime.Now - startTime
        TextBox5.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btntogglestopwatch(Me, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnsubmit(Me, EventArgs.Empty)
        End If
    End Sub

End Class
