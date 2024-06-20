<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        editsubmit = New Button()
        editname = New TextBox()
        editemail = New TextBox()
        editnumber = New TextBox()
        editlink = New TextBox()
        edittimer = New TextBox()
        Timer1 = New Timer(components)
        btntimer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' editsubmit
        ' 
        editsubmit.BackColor = Color.SkyBlue
        editsubmit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editsubmit.Location = New Point(420, 403)
        editsubmit.Name = "editsubmit"
        editsubmit.Size = New Size(189, 36)
        editsubmit.TabIndex = 0
        editsubmit.Text = "SUBMIT "
        editsubmit.UseVisualStyleBackColor = False
        ' 
        ' editname
        ' 
        editname.Location = New Point(251, 90)
        editname.Name = "editname"
        editname.Size = New Size(285, 27)
        editname.TabIndex = 1
        ' 
        ' editemail
        ' 
        editemail.Location = New Point(251, 149)
        editemail.Name = "editemail"
        editemail.Size = New Size(285, 27)
        editemail.TabIndex = 2
        ' 
        ' editnumber
        ' 
        editnumber.Location = New Point(251, 209)
        editnumber.Name = "editnumber"
        editnumber.Size = New Size(285, 27)
        editnumber.TabIndex = 3
        ' 
        ' editlink
        ' 
        editlink.Location = New Point(252, 274)
        editlink.Name = "editlink"
        editlink.Size = New Size(285, 27)
        editlink.TabIndex = 4
        ' 
        ' edittimer
        ' 
        edittimer.Location = New Point(253, 336)
        edittimer.Name = "edittimer"
        edittimer.ReadOnly = True
        edittimer.Size = New Size(285, 27)
        edittimer.TabIndex = 5
        ' 
        ' Timer1
        ' 
        ' 
        ' btntimer
        ' 
        btntimer.BackColor = Color.Khaki
        btntimer.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntimer.Location = New Point(101, 403)
        btntimer.Name = "btntimer"
        btntimer.Size = New Size(245, 36)
        btntimer.TabIndex = 6
        btntimer.Text = "TOGGLE STOPWATCH"
        btntimer.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 32)
        Label1.TabIndex = 7
        Label1.Text = "Edit Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(154, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 23)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label3.Location = New Point(154, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 23)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label4.Location = New Point(137, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 23)
        Label4.TabIndex = 10
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(128, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 11
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label6.Location = New Point(134, 294)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 23)
        Label6.TabIndex = 12
        Label6.Text = "for Task 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label7.Location = New Point(111, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 23)
        Label7.TabIndex = 13
        Label7.Text = "Stopwatch Time"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 498)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btntimer)
        Controls.Add(edittimer)
        Controls.Add(editlink)
        Controls.Add(editnumber)
        Controls.Add(editemail)
        Controls.Add(editname)
        Controls.Add(editsubmit)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents editsubmit As Button
    Friend WithEvents editname As TextBox
    Friend WithEvents editemail As TextBox
    Friend WithEvents editnumber As TextBox
    Friend WithEvents editlink As TextBox
    Friend WithEvents edittimer As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btntimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
