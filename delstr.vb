Imports System.IO
Public Class delstr
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Directory.Delete(Label1.Text, True)
                Timer1.Enabled = False
                MsgBox("Programm taaskäivitub nüüd", MsgBoxStyle.Information, "Operatsioon viidi lõpule")
                Splash.ComboBox1.Text = "true"
                Splash.Show()
                Me.Close()
            Else
                ProgressBar1.Increment(1)
            End If
        Catch ex As Exception
            Timer1.Enabled = False
            Splash.ComboBox1.Text = "true"
            MsgBox(ex.Message & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical, "Tõrge")
            Splash.Show()
            Splash.Hide()
            Me.Close()
        End Try
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub


    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub delstr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class