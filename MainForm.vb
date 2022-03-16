'CPT-206-A01S-Test-2
'Charlotte Childers
'3-16-22



Option Strict On
Option Explicit On
Option Infer Off

Public Class MainForm



    Dim Message As DialogResult

    Private Sub readFileBtn_Click(sender As Object, e As EventArgs) Handles readFileBtn.Click
        lstStudentFiles.Items.Clear()
        Dim LoadFile As IO.StreamReader 'Stream reader to open coded file
        Dim FailFile As OpenFileDialog = New OpenFileDialog
        Dim strStudentLst As String
        If IO.File.Exists("StudentFile.txt") Then
            LoadFile = IO.File.OpenText("StudentFile.txt")
            Do Until LoadFile.Peek = -1
                strStudentLst = LoadFile.ReadLine
                lstStudentFiles.Items.Add(strStudentLst.ToString)
            Loop
            LoadFile.Close()
            For Each item As String In lstStudentFiles.Items
                numRecLbl.Text = lstStudentFiles.Items.Count.ToString()
            Next



        Else
            'Message box varAssigned
            Message = MessageBox.Show("Unable to open the intended file. It was either missing or unreadable. Please select a file from the directory, or cancel to exit.",
                            "Error",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error)
            'If/else - If the user chooses to exit the program upon reaching an error, they will be able to do so.
            If Message = System.Windows.Forms.DialogResult.Cancel Then
                Me.Close()
            Else



                If Message = System.Windows.Forms.DialogResult.OK Then
                    'If/else - If the user chooses to continue, let them proceed
                    If FailFile.ShowDialog() = DialogResult.OK Then
                        LoadFile = IO.File.OpenText(FailFile.FileName)
                        Do Until LoadFile.Peek = -1
                            strStudentLst = LoadFile.ReadLine
                            lstStudentFiles.Items.Add(strStudentLst.ToString)
                        Loop
                        LoadFile.Close()

                        For Each item As String In lstStudentFiles.Items
                            numRecLbl.Text = lstStudentFiles.Items.Count.ToString()
                        Next
                    End If
                End If

            End If
        End If
    End Sub



    Private Sub lstStudentFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentFiles.SelectedIndexChanged
        Dim strGrade As String
        Dim intScore1 As Integer
        strGrade = String.Empty
        gradeLbl.Text = String.Empty


        'Select Case intScore1
        '    Case Is < 60
        '        strGrade = "F"
        '    Case Is <= 69
        '        strGrade = "D"
        '    Case Is >= 79
        '        strGrade = "C"
        '    Case Is <= 89
        '        strGrade = "B"
        '    Case Else
        '        strGrade = "A"
        'End Select


        If intScore1 < 60 Then
            strGrade = "F"
        ElseIf intScore1 <= 69 Then
            strGrade = "D"
        ElseIf intScore1 >= 79 Then
            strGrade = "C"
        ElseIf intScore1 <= 89 Then
            strGrade = "B"
        Else
            strGrade = "A"
        End If

        Integer.TryParse(lstStudentFiles.SelectedItem.ToString, intScore1)

        gradeLbl.Text = strGrade


    End Sub






    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?", "Woah!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' they decided to exit so let them
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LblTime.Text = DateTime.Now.ToString("F") '<-- Clock to label
    End Sub


End Class
