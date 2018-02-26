Public Class Form1
    Dim footlettuce(2, 2) As Byte
    Dim currentTurn As Boolean = False
    Dim turnTimer As Byte
    Dim myIcon As New Icon("H:\Pictures\tictactoegame\xcursor.ico")
    Dim myCursor As Cursor
    Dim myIcon2 As New Icon("H:\Pictures\tictactoegame\ocursor.ico")
    Dim myCursor2 As Cursor
    'false is Player 1 or x
    'true is Player 2 or o
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawLine(Pens.Black, 153, 0, 153, 460)
        e.Graphics.DrawLine(Pens.Black, 306, 0, 306, 460)
        e.Graphics.DrawLine(Pens.Black, 0, 153, 460, 153)
        e.Graphics.DrawLine(Pens.Black, 0, 306, 460, 306)
    End Sub

#Region "Bottons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call playerpress(Button1, 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call playerpress(Button2, 0, 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call playerpress(Button3, 0, 2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call playerpress(Button4, 1, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call playerpress(Button5, 1, 1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call playerpress(Button6, 1, 2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call playerpress(Button7, 2, 0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call playerpress(Button8, 2, 1)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call playerpress(Button9, 2, 2)
    End Sub
#End Region
    Sub playerpress(ByVal botton As Object, ByVal arrayval1 As Byte, ByVal arrayval2 As Byte)
        If currentTurn = False Then
            footlettuce(arrayval1, arrayval2) = 1
            botton.text = "X"
            playerdisplay.Text = "O's Turn"

        Else
            footlettuce(arrayval1, arrayval2) = 2
            botton.text = "O"
            playerdisplay.Text = "X's Turn"

        End If
        currentTurn = Not currentTurn
        turnTimer += 1
        botton.Enabled = False

        Select Case turnTimer
            Case 5 To 8
                Select Case winner()
                    Case 1
                        winnerdisplay.Text = "X Wins!"
                        Call disablebutton(False)
                    Case 2
                        winnerdisplay.Text = "O Wins!"
                        Call disablebutton(False)
                End Select
            Case 9
                Select Case winner()
                    Case 1
                        winnerdisplay.Text = "X Wins!"
                        Call disablebutton(False)
                    Case 2
                        winnerdisplay.Text = "O Wins!"
                        Call disablebutton(False)
                    Case Else
                        tiedisplay.Visible = True
                        Call disablebutton(False)
                End Select
        End Select
        Call cursorselect()
    End Sub
    Sub ResetButton(ByVal boi As Object)
        boi.Text = ""
        boi.Enabled = True
    End Sub
    Sub resetbs()
        Call ResetButton(Button1)
        Call ResetButton(Button2)
        Call ResetButton(Button3)
        Call ResetButton(Button4)
        Call ResetButton(Button5)
        Call ResetButton(Button6)
        Call ResetButton(Button7)
        Call ResetButton(Button8)
        Call ResetButton(Button9)
        ReDim footlettuce(2, 2)
        turnTimer = 0
    End Sub

    Private Sub restartbutton_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
        Call resetbs()
        If currentTurn = False Then
            playerdisplay.Text = "X's Turn"
        Else
            playerdisplay.Text = "O's Turn"
        End If
        winnerdisplay.Text = ""
        Call disablebutton(True)
        If tiedisplay.Visible = True Then
            tiedisplay.Visible = False
        Else
            tiedisplay.Visible = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerdisplay.Text = "X's Turn"
        myCursor = New Cursor(myIcon.Handle)
        Cursor = myCursor
    End Sub

    Function winner() As Byte
        If footlettuce(0, 0) = 1 And footlettuce(1, 0) = 1 And footlettuce(2, 0) = 1 _
                Or footlettuce(0, 1) = 1 And footlettuce(1, 1) = 1 And footlettuce(2, 1) = 1 _
                Or footlettuce(0, 2) = 1 And footlettuce(1, 2) = 1 And footlettuce(2, 2) = 1 _
                Or footlettuce(0, 0) = 1 And footlettuce(0, 1) = 1 And footlettuce(0, 2) = 1 _
                Or footlettuce(1, 0) = 1 And footlettuce(1, 1) = 1 And footlettuce(1, 2) = 1 _
                Or footlettuce(2, 0) = 1 And footlettuce(2, 1) = 1 And footlettuce(2, 2) = 1 _
                Or footlettuce(0, 0) = 1 And footlettuce(1, 1) = 1 And footlettuce(2, 2) = 1 _
                Or footlettuce(0, 2) = 1 And footlettuce(1, 1) = 1 And footlettuce(2, 0) = 1 Then
            Return 1
        End If
        'winning for O's
        If footlettuce(0, 0) = 2 And footlettuce(1, 0) = 2 And footlettuce(2, 0) = 2 _
             Or footlettuce(0, 1) = 2 And footlettuce(1, 1) = 2 And footlettuce(2, 1) = 2 _
             Or footlettuce(0, 2) = 2 And footlettuce(1, 2) = 2 And footlettuce(2, 2) = 2 _
             Or footlettuce(0, 0) = 2 And footlettuce(0, 1) = 2 And footlettuce(0, 2) = 2 _
             Or footlettuce(1, 0) = 2 And footlettuce(1, 1) = 2 And footlettuce(1, 2) = 2 _
             Or footlettuce(2, 0) = 2 And footlettuce(2, 1) = 2 And footlettuce(2, 2) = 2 _
             Or footlettuce(0, 0) = 2 And footlettuce(1, 1) = 2 And footlettuce(2, 2) = 2 _
             Or footlettuce(0, 2) = 2 And footlettuce(1, 1) = 2 And footlettuce(2, 0) = 2 Then
            Return 2
        End If
    End Function
    Sub disablebutton(ByVal what As Boolean)
        Button1.Enabled = what
        Button2.Enabled = what
        Button3.Enabled = what
        Button4.Enabled = what
        Button5.Enabled = what
        Button6.Enabled = what
        Button7.Enabled = what
        Button8.Enabled = what
        Button9.Enabled = what
    End Sub


    Sub cursorselect()
        If currentTurn = False Then
            myCursor = New Cursor(myIcon.Handle)
            Cursor = myCursor
        Else
            myCursor = New Cursor(myIcon2.Handle)
            Cursor = myCursor
        End If
    End Sub

End Class




