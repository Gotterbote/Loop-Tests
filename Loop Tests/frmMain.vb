Public Class frmMain
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim strPayRate As String = ""
        strPayRate = InputBox("Enter in the hourly rate of pay", "Enter Pay Rate", "12.50")
        MessageBox.Show(strPayRate)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim intX As Integer

        For intX = 1 To 5
            MessageBox.Show(intX)
        Next
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim intX As Integer
        Dim intTotal As Integer
        Dim strMessage As String = ""

        For intX = 1 To 10
            strMessage = strMessage + intX.ToString("n0") + " "
            intTotal = intTotal + intX
        Next

        MessageBox.Show("My Output: " + strMessage + vbCrLf +
                         "Totals: " + intTotal.ToString("n2"))
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strTeam As String = ""

        strTeam = InputBox("Enter your favorite sports team", "Sports Team", "No favoritet team")

        lstContainer.Items.Add(strTeam)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to clear the list box?", "Clear Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If Result = vbYes Then
            lstContainer.Items.Clear()
        End If
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim intX As Integer
        Dim intTotal As Integer

        intX = 1

        Do While intX <= 10
            intTotal += intX
            lstContainer.Items.Add("intX is: " + intX.ToString("n0") + vbCrLf + "  intTotal is: " + intTotal.ToString("n0"))
            intX += 1
        Loop

        MessageBox.Show("intX is: " + intX.ToString("n0") + vbCrLf + "intTotal is: " + intTotal.ToString("n0"))
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        Dim intX As Integer
        Dim intTotal As Integer

        intX = 1

        Do
            intTotal += intX
            lstContainer.Items.Add("intX is: " + intX.ToString("n0") + vbCrLf + "   intTotal is: " + intTotal.ToString("n0"))
            intX += 1
        Loop Until intX >= 10

        MessageBox.Show("intX is: " + intX.ToString("n0") + vbCrLf + "intTotal is: " + intTotal.ToString("n0"))
    End Sub

    Private Sub btnUserInput_Click(sender As Object, e As EventArgs) Handles btnUserInput.Click
        'Input Box Variables
        Dim strInputMessage As String = "Enter in test score or cancel to end"
        Dim strTitle As String = "Enter Test Score"
        Dim strDefault As String = "0"
        Dim strCancelClicked As String = ""

        'Other Variables
        Dim strTestScore As String = ""
        Dim sngTestScore As Single = 0
        Dim intCount As Integer = 0
        Dim sngTotal As Single = 0
        Dim sngAverage As Single = 0

        'Get user input
        strTestScore = InputBox(strInputMessage, strTitle, strDefault)


        Do While strTestScore <> strCancelClicked
            If IsNumeric(strTestScore) Then
                'input is a number
                sngTestScore = Convert.ToSingle(strTestScore)
                'test to see if input is within range
                If (sngTestScore >= 0 And sngTestScore <= 100) Then
                    'test score is within range
                    'add test score to the listbox
                    lstContainer.Items.Add(sngTestScore.ToString("n2"))
                    'add test score to the accumulator
                    sngTotal += sngTestScore
                    intCount += 1
                Else
                    'Test score is not within acceptable range
                    MessageBox.Show("Test score must be within 0 and 100")
                End If
            Else
                'input is not a number
                MessageBox.Show("Please enter a valid number")
            End If
            strTestScore = InputBox(strInputMessage, strTitle, strDefault)
        Loop
        sngAverage = sngTotal / intCount

        MessageBox.Show(intCount.ToString("n0") + " tests were entered" + vbCrLf +
                        "Total Score: " + sngTotal.ToString("n2") + vbCrLf +
                        "Average Score: " + sngAverage.ToString("n2"), "Test Results")
    End Sub
End Class
