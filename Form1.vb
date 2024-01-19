Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim StrSerialIn As String
    Dim lotNum As String
    Dim scannedLabel As String
    Dim lotSize As Integer

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Dim rg As Integer
    Dim next_data As Integer
    Dim total_in_lot As Integer
    Dim OpInitials As String




    'StrSerialIn = SerialPort1.ReadExisting 'read incoming data 
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'LotNumber.Text = TextBox1.Text.Substring(TextBox1.Text.Length - 5)
        lotNum = lotNum + TextBox1.Text

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click

        TextBox1.BackColor = Color.White
        Button1.BackColor = Color.White
        Button1.Text = "Enter"

        LotNumber.Text = ""
        lotSize = 0
        Total.Text = lotSize
        PassResult.BackColor = Color.Gray
        PassResult.Text = ""
        total_in_lot = 0
        Overall_total.Text = total_in_lot


        rg = worksheet.Rows.End(Excel.XlDirection.xlDown).Row 'give the number of the last row that is not empty
        next_data = rg + 1
        'MsgBox(rg)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LotNumber.Text = lotNum.Substring(lotNum.Length - 7)
        worksheet.Range("A" & next_data).Value = LotNumber.Text
        worksheet.Range("C" & next_data).Value = Now
        worksheet.Range("E" & next_data).Value = OpInitials
        lotNum = ""
        TextBox1.Text = " "

        TextBox1.BackColor = Color.LightBlue
        Button1.BackColor = Color.LightBlue
        Button1.Text = ""




        For cells = 1 To rg
            ' MsgBox(TypeName(worksheet.Range("A" & cells).Value)) ' Type: String
            If worksheet.Range("A" & cells).Value = LotNumber.Text Then
                total_in_lot = total_in_lot + worksheet.Range("B" & cells).Value

            End If
        Next cells

        Overall_total.Text = total_in_lot


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length = 39 Then
            scannedLabel = TextBox2.Text.Substring(TextBox2.Text.Length - 7)
            Debug.Print(TextBox2.Text)
            Debug.Print(scannedLabel)
            If scannedLabel = LotNumber.Text Then
                SerialPort1.Write("G")
                PassResult.BackColor = Color.Lime
                PassResult.Font = New Font("Segoe UI", 80, FontStyle.Regular)
                PassResult.Text = "PASS"

                TextBox2.Text = ""
                scannedLabel = ""
                lotSize = lotSize + 1
                total_in_lot = total_in_lot + 1

                'TypeName(worksheet.Range("B" & next_data).Value)
                worksheet.Range("B" & next_data).Value = lotSize
                Total.Text = lotSize

                Overall_total.Text = total_in_lot



            Else
                SerialPort1.Write("R")
                PassResult.BackColor = Color.Red
                PassResult.Font = New Font("Segoe UI", 40, FontStyle.Regular)
                PassResult.Text = "WRONG LOT"

                TextBox2.Text = ""
                scannedLabel = ""
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        workbook = APP.Workbooks.Open("C:\LotsScanned\LotScanning.xlsx")
        worksheet = workbook.Worksheets("Sheet1")
        OpInitials = ""

        'rg = worksheet.Range("A1").Value
        'MsgBox(rg)

        SerialPort1.Open()





    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        workbook.Save()
        workbook.Close()
        APP.Quit()
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        worksheet.Range("D" & next_data).Value = Now
        PassResult.BackColor = Color.Gray
        PassResult.Text = ""
        Total.Text = ""

    End Sub



    Private Sub OpsInitialsEnterButton_Click(sender As Object, e As EventArgs) Handles OpsInitialsEnterButton.Click
        OpInitials = OperatorInitials.Text
        OperatorInitials.BackColor = Color.LightBlue
        OperatorInitials.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        OpsInitialsEnterButton.BackColor = Color.LightBlue
        OpsInitialsEnterButton.Text = ""
    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        SerialPort1.Write("R")
    End Sub

    Private Sub Green_Click(sender As Object, e As EventArgs) Handles Green.Click
        SerialPort1.Write("G")
    End Sub

End Class