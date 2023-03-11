Public Class Form1
    'I moved these 3 variables to be fields for the class so that if a user wants to input more speeds after getting an average they are able to
    Dim intEntries As Integer = 1
    Dim decAvg As Decimal = 0D
    Dim decSum As Decimal = 0

    'Form load does the same thing as the button clear click
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
    End Sub

    'Resets the form, putting the fields back to 0 and making the average invisible and clearing the listbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeeds.Items.Clear()
        intEntries = 1
        decAvg = 0D
        decSum = 0
        lblAvg.Text = ""
        lblAvg.Text = ""
        btnEnterSpeed.Enabled = True
        btnClear.Enabled = False
    End Sub

    Private Sub btnEnterSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal

        'Default messages for the info popup box
        Dim strInfoBoxMsg As String = "Enter the number of Mbps of your Internet speed user#"
        Dim strInfoBoxTitle As String = "Internet Speed"
        Dim strNonnumericMsg As String = "Error! - Enter speed of your Internet speed as a positive number in Mbps"
        Dim strNonPositiveMsg As String = "Error! - Speed entered is invalid!  Enter a positive speed in Mbps"

        'Only allow 10 entries
        Dim intMaxEntries As Integer = 10

        strSpeed = InputBox(strInfoBoxMsg & intEntries, strInfoBoxTitle)

        'Main loop to continue to get speeds till the user hits 10 entries or hits cancel
        Do Until intEntries > intMaxEntries Or strSpeed = ""
            'Check if the entry is numeric
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                'Check if the entry is over 0 and if so, adds it to list and adds it to the sum
                If decSpeed > 0 Then
                    lstSpeeds.Items.Add(decSpeed)
                    decSum += decSpeed
                    intEntries += 1
                    strInfoBoxMsg = strInfoBoxMsg
                Else
                    'Set info box message if the number isn't positive
                    strInfoBoxMsg = strNonPositiveMsg
                End If
            Else
                'Set info box message if the number isn't a number
                strInfoBoxMsg = strNonnumericMsg
            End If

            'Continues to get entries if the max hasn't been reached
            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strInfoBoxMsg & intEntries, strInfoBoxTitle)
                'If we are at the max, the enter speeds button is disabled
                If intEntries = intMaxEntries Then
                    btnEnterSpeed.Enabled = False
                End If
            End If
        Loop

        lblAvg.Visible = True

        'Compute the average if there is at least 1 entry
        If intEntries > 1 Then
            decAvg = decSum / (intEntries - 1)
            lblAvg.Text = "Average Internet Speed:  " & decAvg.ToString("F2") & " Mbps"
            btnClear.Enabled = True
        Else
            lblAvg.Text = "No Speed Values Entered"
        End If
    End Sub
End Class
