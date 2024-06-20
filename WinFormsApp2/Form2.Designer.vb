<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Timer1 = New Timer(components)
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(101, 28)
        Label1.MaximumSize = New Size(0, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(570, 30)
        Label1.TabIndex = 0
        Label1.Text = "KUMARAN, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(123, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 23)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label3.Location = New Point(126, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 23)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label4.Location = New Point(101, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 23)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(95, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Github Link"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(101, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(269, 42)
        Button1.TabIndex = 5
        Button1.Text = "TOOGLE STOPWATCH (CTRL + T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSkyBlue
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(275, 443)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 41)
        Button2.TabIndex = 6
        Button2.Text = "SUBMIT (CTRL + S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(298, 112)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 20)
        LinkLabel1.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(204, 103)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(371, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(204, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(371, 27)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(204, 221)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(371, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(204, 290)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(371, 27)
        TextBox4.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label6.Location = New Point(101, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 23)
        Label6.TabIndex = 12
        Label6.Text = "For Task 2"
        ' 
        ' Timer1
        ' 
        ' 
        ' TextBox5
        ' 
        TextBox5.AcceptsReturn = True
        TextBox5.Location = New Point(398, 384)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(177, 27)
        TextBox5.TabIndex = 13
        TextBox5.Text = "00:00:00"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(768, 520)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox5 As TextBox
End Class
