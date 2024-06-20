<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        searchbar = New TextBox()
        btnsearch = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchbar
        ' 
        searchbar.Location = New Point(284, 99)
        searchbar.Name = "searchbar"
        searchbar.Size = New Size(432, 27)
        searchbar.TabIndex = 0
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.DarkGray
        btnsearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsearch.ForeColor = Color.Black
        btnsearch.Location = New Point(772, 92)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(160, 36)
        btnsearch.TabIndex = 1
        btnsearch.Text = "SEARCH"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.LavenderBlush
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 179)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(903, 293)
        DataGridView1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(381, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 32)
        Label1.TabIndex = 3
        Label1.Text = "Search Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 23)
        Label2.TabIndex = 4
        Label2.Text = "Enter Full Email ID :"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 498)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(btnsearch)
        Controls.Add(searchbar)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchbar As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
