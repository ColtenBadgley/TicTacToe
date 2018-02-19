Public Class Form1
    Dim footlettuce(2, 2) As Byte
    Dim currentTurn As Boolean = False
    'false is Player 1 or x
    'true is Player 2 or o
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawLine(Pens.Black, 153, 0, 153, 460)
        e.Graphics.DrawLine(Pens.Black, 306, 0, 306, 460)
        e.Graphics.DrawLine(Pens.Black, 0, 153, 460, 153)
        e.Graphics.DrawLine(Pens.Black, 0, 306, 460, 306)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        footlettuce(0, 0) = 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        footlettuce(0, 1) = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        footlettuce(0, 2) = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        footlettuce(1, 0) = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        footlettuce(1, 1) = 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        footlettuce(1, 2) = 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        footlettuce(2, 0) = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        footlettuce(2, 1) = 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        footlettuce(2, 2) = 1
    End Sub
    Sub chooselettuce(ByVal boi As Object)
        If currentTurn = False Then
            boi.text = "X"
            playerdisplay.Text = "O's Turn"
            Cursor = Cursors.WaitCursor
        Else
            boi.text = "O"
            playerdisplay.Text = "X's Turn"
            Cursor = Cursors.Cross
        End If
    End Sub
End Class


