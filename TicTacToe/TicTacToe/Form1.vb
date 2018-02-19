Public Class Form1
    Dim footlettuce(2, 2) As Byte
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawLine(Pens.Black, 153, 0, 153, 460)
        e.Graphics.DrawLine(Pens.Black, 306, 0, 306, 460)
        e.Graphics.DrawLine(Pens.Black, 0, 153, 460, 153)
        e.Graphics.DrawLine(Pens.Black, 0, 306, 460, 306)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub
End Class

