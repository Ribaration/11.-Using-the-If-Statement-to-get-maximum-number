Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaring Variables
        Dim firstNumber As Double
        Dim SecondNumber As Double

        firstNumber = Val(TextBox1.Text)
        SecondNumber = Val(TextBox2.Text)

        If firstNumber > SecondNumber Then
            TextBox3.Text = firstNumber
        Else
            TextBox3.Text = SecondNumber

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
