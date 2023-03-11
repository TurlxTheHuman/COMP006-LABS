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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBurgerSecret = New System.Windows.Forms.RadioButton()
        Me.radBurgerCheese = New System.Windows.Forms.RadioButton()
        Me.radBurgerRegular = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radFriesLarge = New System.Windows.Forms.RadioButton()
        Me.radFriesSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radDrinkShake = New System.Windows.Forms.RadioButton()
        Me.radDrinkSoda = New System.Windows.Forms.RadioButton()
        Me.checkToGo = New System.Windows.Forms.CheckBox()
        Me.checkDonate = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Big Burger"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBurgerSecret)
        Me.GroupBox1.Controls.Add(Me.radBurgerCheese)
        Me.GroupBox1.Controls.Add(Me.radBurgerRegular)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Burger"
        '
        'radBurgerSecret
        '
        Me.radBurgerSecret.AutoSize = True
        Me.radBurgerSecret.Location = New System.Drawing.Point(21, 70)
        Me.radBurgerSecret.Name = "radBurgerSecret"
        Me.radBurgerSecret.Size = New System.Drawing.Size(133, 19)
        Me.radBurgerSecret.TabIndex = 2
        Me.radBurgerSecret.Text = "Secret Burger ($8.00)"
        Me.radBurgerSecret.UseVisualStyleBackColor = True
        '
        'radBurgerCheese
        '
        Me.radBurgerCheese.AutoSize = True
        Me.radBurgerCheese.Location = New System.Drawing.Point(21, 45)
        Me.radBurgerCheese.Name = "radBurgerCheese"
        Me.radBurgerCheese.Size = New System.Drawing.Size(139, 19)
        Me.radBurgerCheese.TabIndex = 1
        Me.radBurgerCheese.Text = "Cheese Burger ($4.00)"
        Me.radBurgerCheese.UseVisualStyleBackColor = True
        '
        'radBurgerRegular
        '
        Me.radBurgerRegular.AutoSize = True
        Me.radBurgerRegular.Checked = True
        Me.radBurgerRegular.Location = New System.Drawing.Point(21, 20)
        Me.radBurgerRegular.Name = "radBurgerRegular"
        Me.radBurgerRegular.Size = New System.Drawing.Size(103, 19)
        Me.radBurgerRegular.TabIndex = 0
        Me.radBurgerRegular.TabStop = True
        Me.radBurgerRegular.Text = "Regular ($3.50)"
        Me.radBurgerRegular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFriesLarge)
        Me.GroupBox2.Controls.Add(Me.radFriesSmall)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fries"
        '
        'radFriesLarge
        '
        Me.radFriesLarge.AutoSize = True
        Me.radFriesLarge.Location = New System.Drawing.Point(6, 45)
        Me.radFriesLarge.Name = "radFriesLarge"
        Me.radFriesLarge.Size = New System.Drawing.Size(92, 19)
        Me.radFriesLarge.TabIndex = 4
        Me.radFriesLarge.Text = "Large ($2.50)"
        Me.radFriesLarge.UseVisualStyleBackColor = True
        '
        'radFriesSmall
        '
        Me.radFriesSmall.AutoSize = True
        Me.radFriesSmall.Checked = True
        Me.radFriesSmall.Location = New System.Drawing.Point(6, 20)
        Me.radFriesSmall.Name = "radFriesSmall"
        Me.radFriesSmall.Size = New System.Drawing.Size(92, 19)
        Me.radFriesSmall.TabIndex = 3
        Me.radFriesSmall.TabStop = True
        Me.radFriesSmall.Text = "Small ($1.50)"
        Me.radFriesSmall.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radDrinkShake)
        Me.GroupBox3.Controls.Add(Me.radDrinkSoda)
        Me.GroupBox3.Location = New System.Drawing.Point(424, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Drink"
        '
        'radDrinkShake
        '
        Me.radDrinkShake.AutoSize = True
        Me.radDrinkShake.Location = New System.Drawing.Point(6, 45)
        Me.radDrinkShake.Name = "radDrinkShake"
        Me.radDrinkShake.Size = New System.Drawing.Size(94, 19)
        Me.radDrinkShake.TabIndex = 6
        Me.radDrinkShake.Text = "Shake ($2.00)"
        Me.radDrinkShake.UseVisualStyleBackColor = True
        '
        'radDrinkSoda
        '
        Me.radDrinkSoda.AutoSize = True
        Me.radDrinkSoda.Checked = True
        Me.radDrinkSoda.Location = New System.Drawing.Point(6, 20)
        Me.radDrinkSoda.Name = "radDrinkSoda"
        Me.radDrinkSoda.Size = New System.Drawing.Size(89, 19)
        Me.radDrinkSoda.TabIndex = 5
        Me.radDrinkSoda.TabStop = True
        Me.radDrinkSoda.Text = "Soda ($1.00)"
        Me.radDrinkSoda.UseVisualStyleBackColor = True
        '
        'checkToGo
        '
        Me.checkToGo.AutoSize = True
        Me.checkToGo.Location = New System.Drawing.Point(23, 173)
        Me.checkToGo.Name = "checkToGo"
        Me.checkToGo.Size = New System.Drawing.Size(77, 19)
        Me.checkToGo.TabIndex = 4
        Me.checkToGo.Text = "Take Out?"
        Me.checkToGo.UseVisualStyleBackColor = True
        '
        'checkDonate
        '
        Me.checkDonate.AutoSize = True
        Me.checkDonate.Location = New System.Drawing.Point(23, 198)
        Me.checkDonate.Name = "checkDonate"
        Me.checkDonate.Size = New System.Drawing.Size(275, 19)
        Me.checkDonate.TabIndex = 5
        Me.checkDonate.Text = "Make a $1.00 donation to the starving children?"
        Me.checkDonate.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(342, 173)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(22, 240)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 15)
        Me.lblOutput.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 371)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.checkDonate)
        Me.Controls.Add(Me.checkToGo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBurgerSecret As RadioButton
    Friend WithEvents radBurgerCheese As RadioButton
    Friend WithEvents radBurgerRegular As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radFriesLarge As RadioButton
    Friend WithEvents radFriesSmall As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radDrinkShake As RadioButton
    Friend WithEvents radDrinkSoda As RadioButton
    Friend WithEvents checkToGo As CheckBox
    Friend WithEvents checkDonate As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblOutput As Label
End Class
