Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static tickCount As Integer = 0 ' Static variable to keep track of tick count

        tickCount += 1 ' Increment tick count
        If tickCount = 30 Then ' Check if tick count reaches 20
            Timer1.Stop() ' Stop the timer
            Dim loginForm As New loginform()
            loginForm.Show() ' Show the login form
            Me.Hide() ' Hide the current form instead of closing it
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 40 ' Set the interval to 30 milliseconds
        Timer1.Start() ' Start the timer
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class