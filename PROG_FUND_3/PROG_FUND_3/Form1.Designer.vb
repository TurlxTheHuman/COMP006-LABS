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
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTriangle
        '
        Me.btnTriangle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTriangle.Location = New System.Drawing.Point(136, 133)
        Me.btnTriangle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(107, 32)
        Me.btnTriangle.TabIndex = 0
        Me.btnTriangle.Text = "Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSquare.Location = New System.Drawing.Point(251, 133)
        Me.btnSquare.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(107, 32)
        Me.btnSquare.TabIndex = 1
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCircle.Location = New System.Drawing.Point(367, 133)
        Me.btnCircle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(107, 32)
        Me.btnCircle.TabIndex = 2
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(165, 183)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 21)
        Me.lblOutput.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(589, 307)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCircle)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnTriangle)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Area Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTriangle As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnCircle As Button
    Friend WithEvents lblOutput As Label
End Class
