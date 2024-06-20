Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub btncreatenewsubmission(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As New Form2
        f2.Show()
    End Sub

    Private Sub btnviewsubmission(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New Form3
        f3.Show()
    End Sub

    Private Sub btnsearchform_Click(sender As Object, e As EventArgs) Handles btnsearchform.Click
        Dim f5 As New Form5
        f5.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnviewsubmission(Me, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            btncreatenewsubmission(Me, EventArgs.Empty)
        End If

        If e.Control AndAlso e.KeyCode = Keys.L Then
            btnsearchform_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class
