Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        A = TextBox1.Text
        B = TextBox2.Text

        C = Val((A ^ 2 + B ^ 2) ^ 0.5)

        TextBox3.Text = C.ToString("N2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        A = TextBox1.Text
        C = TextBox3.Text

        B = Val((C ^ 2 - A ^ 2) ^ 0.5)

        TextBox2.Text = B.ToString("N2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double

        C = TextBox3.Text
        B = TextBox2.Text

        C = Val((C ^ 2 - B ^ 2) ^ 0.5)

        TextBox1.Text = A.ToString("N2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.BlueViolet


    End Sub
End Class
