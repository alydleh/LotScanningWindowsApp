<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PassResult = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Red = New System.Windows.Forms.Button()
        Me.Green = New System.Windows.Forms.Button()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.OpsInitialsEnterButton = New System.Windows.Forms.Button()
        Me.OperatorInitials = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LotNumber = New System.Windows.Forms.Label()
        Me.TotalScanned = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Overall_total = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'PassResult
        '
        Me.PassResult.AutoSize = True
        Me.PassResult.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassResult.Location = New System.Drawing.Point(23, 137)
        Me.PassResult.Name = "PassResult"
        Me.PassResult.Size = New System.Drawing.Size(306, 212)
        Me.PassResult.TabIndex = 0
        Me.PassResult.Text = "rslt"
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(608, 28)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 30)
        Me.Reset.TabIndex = 1
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Red
        '
        Me.Red.BackColor = System.Drawing.Color.Tomato
        Me.Red.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red.Location = New System.Drawing.Point(608, 124)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(75, 36)
        Me.Red.TabIndex = 3
        Me.Red.Text = "Red"
        Me.Red.UseVisualStyleBackColor = False
        '
        'Green
        '
        Me.Green.BackColor = System.Drawing.Color.PaleGreen
        Me.Green.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green.Location = New System.Drawing.Point(608, 166)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(75, 28)
        Me.Green.TabIndex = 4
        Me.Green.Text = "Green"
        Me.Green.UseVisualStyleBackColor = False
        '
        'DoneButton
        '
        Me.DoneButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneButton.Location = New System.Drawing.Point(559, 386)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(144, 38)
        Me.DoneButton.TabIndex = 5
        Me.DoneButton.Text = "End Lot Batch"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'OpsInitialsEnterButton
        '
        Me.OpsInitialsEnterButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpsInitialsEnterButton.Location = New System.Drawing.Point(242, 35)
        Me.OpsInitialsEnterButton.Name = "OpsInitialsEnterButton"
        Me.OpsInitialsEnterButton.Size = New System.Drawing.Size(75, 31)
        Me.OpsInitialsEnterButton.TabIndex = 6
        Me.OpsInitialsEnterButton.Text = "Enter"
        Me.OpsInitialsEnterButton.UseVisualStyleBackColor = True
        '
        'OperatorInitials
        '
        Me.OperatorInitials.Location = New System.Drawing.Point(123, 35)
        Me.OperatorInitials.Name = "OperatorInitials"
        Me.OperatorInitials.Size = New System.Drawing.Size(100, 26)
        Me.OperatorInitials.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Operator:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Current Lot:"
        '
        'LotNumber
        '
        Me.LotNumber.AutoSize = True
        Me.LotNumber.Location = New System.Drawing.Point(501, 36)
        Me.LotNumber.Name = "LotNumber"
        Me.LotNumber.Size = New System.Drawing.Size(83, 20)
        Me.LotNumber.TabIndex = 10
        Me.LotNumber.Text = "22BRXXX"
        '
        'TotalScanned
        '
        Me.TotalScanned.AutoSize = True
        Me.TotalScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalScanned.Location = New System.Drawing.Point(417, 305)
        Me.TotalScanned.Name = "TotalScanned"
        Me.TotalScanned.Size = New System.Drawing.Size(232, 20)
        Me.TotalScanned.TabIndex = 11
        Me.TotalScanned.Text = "Total Scanned in Lot Batch:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(642, 305)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(36, 20)
        Me.Total.TabIndex = 12
        Me.Total.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Scanned in Lot:"
        '
        'Overall_total
        '
        Me.Overall_total.AutoSize = True
        Me.Overall_total.Location = New System.Drawing.Point(646, 341)
        Me.Overall_total.Name = "Overall_total"
        Me.Overall_total.Size = New System.Drawing.Size(36, 20)
        Me.Overall_total.TabIndex = 14
        Me.Overall_total.Text = "200"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(491, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(549, 235)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 16
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Overall_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.TotalScanned)
        Me.Controls.Add(Me.LotNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OperatorInitials)
        Me.Controls.Add(Me.OpsInitialsEnterButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.Green)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.PassResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PassResult As Label
    Friend WithEvents Reset As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Red As Button
    Friend WithEvents Green As Button
    Friend WithEvents DoneButton As Button
    Friend WithEvents OpsInitialsEnterButton As Button
    Friend WithEvents OperatorInitials As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LotNumber As Label
    Friend WithEvents TotalScanned As Label
    Friend WithEvents Total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Overall_total As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
