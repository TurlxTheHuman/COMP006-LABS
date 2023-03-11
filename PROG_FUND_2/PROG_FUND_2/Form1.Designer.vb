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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDonuts = New System.Windows.Forms.TextBox()
        Me.txtMuffins = New System.Windows.Forms.TextBox()
        Me.lblTotalSales = New System.Windows.Forms.TextBox()
        Me.lblTotalItems = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(224, 72)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 23)
        Me.txtDate.TabIndex = 0
        '
        'txtDonuts
        '
        Me.txtDonuts.Location = New System.Drawing.Point(137, 122)
        Me.txtDonuts.Name = "txtDonuts"
        Me.txtDonuts.Size = New System.Drawing.Size(100, 23)
        Me.txtDonuts.TabIndex = 1
        '
        'txtMuffins
        '
        Me.txtMuffins.Location = New System.Drawing.Point(137, 151)
        Me.txtMuffins.Name = "txtMuffins"
        Me.txtMuffins.Size = New System.Drawing.Size(100, 23)
        Me.txtMuffins.TabIndex = 2
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Location = New System.Drawing.Point(137, 209)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.ReadOnly = True
        Me.lblTotalSales.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalSales.TabIndex = 3
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Location = New System.Drawing.Point(137, 180)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.ReadOnly = True
        Me.lblTotalItems.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalItems.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Doughnuts:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Muffins:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total items:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(184, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 30)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sales Receipt"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(282, 122)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(103, 23)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(282, 151)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 23)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print Reciept"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(282, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 338)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.txtMuffins)
        Me.Controls.Add(Me.txtDonuts)
        Me.Controls.Add(Me.txtDate)
        Me.Name = "Form1"
        Me.Text = "Meyer's Purple Bakery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtDonuts As TextBox
    Friend WithEvents txtMuffins As TextBox
    Friend WithEvents lblTotalSales As TextBox
    Friend WithEvents lblTotalItems As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
