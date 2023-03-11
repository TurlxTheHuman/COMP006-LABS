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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        radCastles = New RadioButton()
        radRoses = New RadioButton()
        radWillow = New RadioButton()
        GroupBox2 = New GroupBox()
        cbTeapot = New CheckBox()
        cbCreamer = New CheckBox()
        cbSugarBowl = New CheckBox()
        cbSetOfSoupBowls = New CheckBox()
        cbServingBowl = New CheckBox()
        cbPlatter = New CheckBox()
        lstQuantity = New ListBox()
        Label1 = New Label()
        btnSubmit = New Button()
        btnClear = New Button()
        btnQuit = New Button()
        picWillow = New PictureBox()
        picRoses = New PictureBox()
        picCastles = New PictureBox()
        lblOutput = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(picWillow, ComponentModel.ISupportInitialize).BeginInit()
        CType(picRoses, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCastles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radCastles)
        GroupBox1.Controls.Add(radRoses)
        GroupBox1.Controls.Add(radWillow)
        GroupBox1.Location = New Point(10, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(268, 187)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Select China Pattern"' 
        ' radCastles
        ' 
        radCastles.AutoSize = True
        radCastles.Location = New Point(6, 68)
        radCastles.Name = "radCastles"
        radCastles.Size = New Size(258, 19)
        radCastles.TabIndex = 2
        radCastles.TabStop = True
        radCastles.Text = "Johnson Brothers Old British Castles ($19.99)"
        radCastles.UseVisualStyleBackColor = True
        ' 
        ' radRoses
        ' 
        radRoses.AutoSize = True
        radRoses.Location = New Point(6, 43)
        radRoses.Name = "radRoses"
        radRoses.Size = New Size(234, 19)
        radRoses.TabIndex = 1
        radRoses.TabStop = True
        radRoses.Text = "Royal Albert Old Country Roses ($39.95)"
        radRoses.UseVisualStyleBackColor = True
        ' 
        ' radWillow
        ' 
        radWillow.AutoSize = True
        radWillow.Location = New Point(6, 18)
        radWillow.Name = "radWillow"
        radWillow.Size = New Size(205, 19)
        radWillow.TabIndex = 0
        radWillow.TabStop = True
        radWillow.Text = "Royal Wessex Blue Willow ($15.00)"
        radWillow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbTeapot)
        GroupBox2.Controls.Add(cbCreamer)
        GroupBox2.Controls.Add(cbSugarBowl)
        GroupBox2.Controls.Add(cbSetOfSoupBowls)
        GroupBox2.Controls.Add(cbServingBowl)
        GroupBox2.Controls.Add(cbPlatter)
        GroupBox2.Location = New Point(433, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 187)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Additional Pieces"' 
        ' cbTeapot
        ' 
        cbTeapot.AutoSize = True
        cbTeapot.Location = New Point(12, 144)
        cbTeapot.Name = "cbTeapot"
        cbTeapot.Size = New Size(111, 19)
        cbTeapot.TabIndex = 5
        cbTeapot.Text = "Teapot ($150.00)"
        cbTeapot.UseVisualStyleBackColor = True
        ' 
        ' cbCreamer
        ' 
        cbCreamer.AutoSize = True
        cbCreamer.Location = New Point(12, 119)
        cbCreamer.Name = "cbCreamer"
        cbCreamer.Size = New Size(115, 19)
        cbCreamer.TabIndex = 4
        cbCreamer.Text = "Creamer ($25.00)"
        cbCreamer.UseVisualStyleBackColor = True
        ' 
        ' cbSugarBowl
        ' 
        cbSugarBowl.AutoSize = True
        cbSugarBowl.Location = New Point(12, 94)
        cbSugarBowl.Name = "cbSugarBowl"
        cbSugarBowl.Size = New Size(129, 19)
        cbSugarBowl.TabIndex = 3
        cbSugarBowl.Text = "Sugar Bowl ($35.00)"
        cbSugarBowl.UseVisualStyleBackColor = True
        ' 
        ' cbSetOfSoupBowls
        ' 
        cbSetOfSoupBowls.AutoSize = True
        cbSetOfSoupBowls.Location = New Point(12, 69)
        cbSetOfSoupBowls.Name = "cbSetOfSoupBowls"
        cbSetOfSoupBowls.Size = New Size(173, 19)
        cbSetOfSoupBowls.TabIndex = 2
        cbSetOfSoupBowls.Text = "Set of 8 Soup Bowls ($85.00)"
        cbSetOfSoupBowls.UseVisualStyleBackColor = True
        ' 
        ' cbServingBowl
        ' 
        cbServingBowl.AutoSize = True
        cbServingBowl.Location = New Point(12, 44)
        cbServingBowl.Name = "cbServingBowl"
        cbServingBowl.Size = New Size(138, 19)
        cbServingBowl.TabIndex = 1
        cbServingBowl.Text = "Serving Bowl ($20.00)"
        cbServingBowl.UseVisualStyleBackColor = True
        ' 
        ' cbPlatter
        ' 
        cbPlatter.AutoSize = True
        cbPlatter.Location = New Point(12, 19)
        cbPlatter.Name = "cbPlatter"
        cbPlatter.Size = New Size(124, 19)
        cbPlatter.TabIndex = 0
        cbPlatter.Text = "11"" Platter ($30.00)"
        cbPlatter.UseVisualStyleBackColor = True
        ' 
        ' lstQuantity
        ' 
        lstQuantity.FormattingEnabled = True
        lstQuantity.ItemHeight = 15
        lstQuantity.Location = New Point(284, 33)
        lstQuantity.Name = "lstQuantity"
        lstQuantity.Size = New Size(143, 169)
        lstQuantity.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(284, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 3
        Label1.Text = "Plate Set Quantity"' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(16, 357)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(97, 357)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(178, 357)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 23)
        btnQuit.TabIndex = 6
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' picWillow
        ' 
        picWillow.BackgroundImage = CType(resources.GetObject("picWillow.BackgroundImage"), Image)
        picWillow.BackgroundImageLayout = ImageLayout.Zoom
        picWillow.Location = New Point(284, 208)
        picWillow.Name = "picWillow"
        picWillow.Size = New Size(349, 154)
        picWillow.TabIndex = 7
        picWillow.TabStop = False
        ' 
        ' picRoses
        ' 
        picRoses.BackgroundImage = CType(resources.GetObject("picRoses.BackgroundImage"), Image)
        picRoses.BackgroundImageLayout = ImageLayout.Zoom
        picRoses.Location = New Point(284, 208)
        picRoses.Name = "picRoses"
        picRoses.Size = New Size(349, 154)
        picRoses.TabIndex = 8
        picRoses.TabStop = False
        ' 
        ' picCastles
        ' 
        picCastles.BackgroundImage = CType(resources.GetObject("picCastles.BackgroundImage"), Image)
        picCastles.BackgroundImageLayout = ImageLayout.Zoom
        picCastles.Location = New Point(284, 208)
        picCastles.Name = "picCastles"
        picCastles.Size = New Size(349, 154)
        picCastles.TabIndex = 9
        picCastles.TabStop = False
        ' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.Location = New Point(28, 339)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(45, 15)
        lblOutput.TabIndex = 10
        lblOutput.Text = "Output"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(645, 400)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lstQuantity)
        Controls.Add(Label1)
        Controls.Add(lblOutput)
        Controls.Add(btnQuit)
        Controls.Add(picWillow)
        Controls.Add(picRoses)
        Controls.Add(btnClear)
        Controls.Add(picCastles)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(picWillow, ComponentModel.ISupportInitialize).EndInit()
        CType(picRoses, ComponentModel.ISupportInitialize).EndInit()
        CType(picCastles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCastles As RadioButton
    Friend WithEvents radRoses As RadioButton
    Friend WithEvents radWillow As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbTeapot As CheckBox
    Friend WithEvents cbCreamer As CheckBox
    Friend WithEvents cbSugarBowl As CheckBox
    Friend WithEvents cbSetOfSoupBowls As CheckBox
    Friend WithEvents cbServingBowl As CheckBox
    Friend WithEvents cbPlatter As CheckBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents picWillow As PictureBox
    Friend WithEvents picRoses As PictureBox
    Friend WithEvents picCastles As PictureBox
    Friend WithEvents lblOutput As Label
End Class
