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
        btnSubmit = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lstAges = New ListBox()
        txtName = New TextBox()
        txtTicket = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblOutput = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(12, 209)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(129, 209)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(242, 209)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lstAges
        ' 
        lstAges.FormattingEnabled = True
        lstAges.ItemHeight = 15
        lstAges.Location = New Point(222, 12)
        lstAges.Name = "lstAges"
        lstAges.Size = New Size(95, 124)
        lstAges.TabIndex = 3
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(12, 30)
        txtName.Name = "txtName"
        txtName.Size = New Size(204, 23)
        txtName.TabIndex = 4
        ' 
        ' txtTicket
        ' 
        txtTicket.Location = New Point(12, 72)
        txtTicket.Name = "txtTicket"
        txtTicket.Size = New Size(61, 23)
        txtTicket.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 15)
        Label1.TabIndex = 6
        Label1.Text = "Have you had a ticket in the past year?"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 7
        Label2.Text = "(Y or N)"' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.Location = New Point(12, 144)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(0, 15)
        lblOutput.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 9
        Label3.Text = "Full Name:"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(329, 253)
        Controls.Add(Label3)
        Controls.Add(lblOutput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTicket)
        Controls.Add(txtName)
        Controls.Add(lstAges)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstAges As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label3 As Label
End Class
