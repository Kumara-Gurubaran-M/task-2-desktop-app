Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class Form5
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
        SetupDataGridView()
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim request As HttpWebRequest = WebRequest.CreateHttp("http://localhost:5000/read")
            request.Method = "GET"
            request.ContentType = "application/json"

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim jsonResponse As String = reader.ReadToEnd()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
            submissions = New List(Of Submission)()
        End Try
    End Sub

    Private Sub SetupDataGridView()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Name", .DataPropertyName = "name"})
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Email", .DataPropertyName = "email"})
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Phone", .DataPropertyName = "phone"})
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "GitHub Link", .DataPropertyName = "githubLink"})
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Elapsed Time", .DataPropertyName = "elapsedTime"})

        DataGridView1.DataSource = submissions
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim searchEmail As String = searchbar.Text.Trim()

        If Not String.IsNullOrEmpty(searchEmail) Then
            Dim filteredSubmissions = submissions.Where(Function(submission) submission.email.Equals(searchEmail, StringComparison.OrdinalIgnoreCase)).ToList()

            If filteredSubmissions.Any() Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = filteredSubmissions
            Else
                MessageBox.Show("No submissions found for the given email.")
                DataGridView1.DataSource = Nothing
            End If
        Else
            MessageBox.Show("Please enter an email to search.")
        End If
    End Sub

    Private Sub searchbar_TextChanged(sender As Object, e As EventArgs) Handles searchbar.TextChanged
        DataGridView1.DataSource = Nothing
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property githubLink As String
    Public Property elapsedTime As String
    Public Property timestamp As String
End Class
