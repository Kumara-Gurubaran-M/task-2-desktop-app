<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        displayname = New TextBox()
        displayemail = New TextBox()
        displaynumber = New TextBox()
        displaylink = New TextBox()
        displaytimer = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        btndeiete = New Button()
        editbtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(81, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(569, 32)
        Label1.TabIndex = 0
        Label1.Text = "KUMARAN , Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(113, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 23)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(115, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 23)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(99, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 23)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(93, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label6.Location = New Point(99, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 23)
        Label6.TabIndex = 5
        Label6.Text = "For Task 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label7.Location = New Point(101, 317)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 23)
        Label7.TabIndex = 6
        Label7.Text = "Stopwatch"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label8.Location = New Point(118, 339)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 23)
        Label8.TabIndex = 7
        Label8.Text = "Time"
        ' 
        ' displayname
        ' 
        displayname.Location = New Point(201, 103)
        displayname.Name = "displayname"
        displayname.ReadOnly = True
        displayname.Size = New Size(352, 27)
        displayname.TabIndex = 8
        ' 
        ' displayemail
        ' 
        displayemail.Location = New Point(201, 150)
        displayemail.Name = "displayemail"
        displayemail.ReadOnly = True
        displayemail.Size = New Size(352, 27)
        displayemail.TabIndex = 9
        ' 
        ' displaynumber
        ' 
        displaynumber.Location = New Point(201, 195)
        displaynumber.Name = "displaynumber"
        displaynumber.ReadOnly = True
        displaynumber.Size = New Size(352, 27)
        displaynumber.TabIndex = 10
        ' 
        ' displaylink
        ' 
        displaylink.Location = New Point(201, 259)
        displaylink.Name = "displaylink"
        displaylink.ReadOnly = True
        displaylink.Size = New Size(352, 27)
        displaylink.TabIndex = 11
        ' 
        ' displaytimer
        ' 
        displaytimer.Location = New Point(201, 324)
        displaytimer.Name = "displaytimer"
        displaytimer.ReadOnly = True
        displaytimer.Size = New Size(352, 27)
        displaytimer.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSkyBlue
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(401, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(216, 37)
        Button1.TabIndex = 13
        Button1.Text = "NEXT (CTRL + N)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Khaki
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 0
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(105, 381)
        Button2.Name = "Button2"
        Button2.Size = New Size(224, 37)
        Button2.TabIndex = 14
        Button2.Text = "PREVIOUS (CTRL + P)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btndeiete
        ' 
        btndeiete.BackColor = Color.IndianRed
        btndeiete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndeiete.Location = New Point(105, 454)
        btndeiete.Name = "btndeiete"
        btndeiete.Size = New Size(224, 36)
        btndeiete.TabIndex = 15
        btndeiete.Text = "DELETE (CTRL + D)"
        btndeiete.UseVisualStyleBackColor = False
        ' 
        ' editbtn
        ' 
        editbtn.BackColor = Color.BlanchedAlmond
        editbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editbtn.Location = New Point(401, 454)
        editbtn.Name = "editbtn"
        editbtn.Size = New Size(216, 36)
        editbtn.TabIndex = 16
        editbtn.Text = "EDIT FORM (CTRL + E)"
        editbtn.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(718, 509)
        Controls.Add(editbtn)
        Controls.Add(btndeiete)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(displaytimer)
        Controls.Add(displaylink)
        Controls.Add(displaynumber)
        Controls.Add(displayemail)
        Controls.Add(displayname)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents displayname As TextBox
    Friend WithEvents displayemail As TextBox
    Friend WithEvents displaynumber As TextBox
    Friend WithEvents displaylink As TextBox
    Friend WithEvents displaytimer As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btndeiete As Button
    Friend WithEvents editbtn As Button
End Class
