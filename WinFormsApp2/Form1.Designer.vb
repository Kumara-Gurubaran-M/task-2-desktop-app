<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        btnsearchform = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(175, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(505, 44)
        Button1.TabIndex = 0
        Button1.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SkyBlue
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(175, 249)
        Button2.Name = "Button2"
        Button2.Size = New Size(505, 44)
        Button2.TabIndex = 1
        Button2.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(152, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(551, 32)
        Label1.TabIndex = 2
        Label1.Text = "KUMARAN, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnsearchform
        ' 
        btnsearchform.BackColor = Color.RosyBrown
        btnsearchform.BackgroundImageLayout = ImageLayout.Center
        btnsearchform.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsearchform.ForeColor = Color.Black
        btnsearchform.Location = New Point(175, 337)
        btnsearchform.Name = "btnsearchform"
        btnsearchform.Size = New Size(505, 44)
        btnsearchform.TabIndex = 3
        btnsearchform.Text = "SEARCH FORM (CTRL + L)"
        btnsearchform.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 483)
        Controls.Add(btnsearchform)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearchform As Button

End Class
