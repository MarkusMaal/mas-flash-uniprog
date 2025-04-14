Public Class soption
    Public Shared val As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        val = "close"
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        val = "new"
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        val = "reboot"
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        val = "ignore"
        Me.Close()
    End Sub
End Class