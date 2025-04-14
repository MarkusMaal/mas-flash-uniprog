Imports System.IO

Public Class del

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Exit Sub
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub


    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub RapidLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RapidLoad.Tick
        Try
            If File.Exists(MainScreen.drive.Text & "\E_INFO\process.txt") Then
                Dim rc As String
                rc = File.ReadAllText(MainScreen.drive.Text & "\E_INFO\process.txt", System.Text.Encoding.ASCII)
                RapidTextBox.Text = rc
                If ProgressBar1.Value = ProgressBar1.Maximum Then ProgressBar1.Value = ProgressBar1.Minimum
                ProgressBar1.Value = ProgressBar1.Value + 1
                If File.Exists(MainScreen.drive.Text & "\E_INFO\endprocess.txt") Then
                    File.Delete(MainScreen.drive.Text & "\E_INFO\endprocess.txt")
                    File.Delete(MainScreen.drive.Text & "\E_INFO\process.txt")
                    MessageBox.Show("Protsess viidi lõpule. Programm sulgub nüüd.", "Markuse asjade kustutamine", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If MainScreen.Visible = True Then MainScreen.Close()
                    If Splash.Visible = True Then Splash.Close()
                    If br.Visible = True Then br.Close()
                    File.Delete(MainScreen.drive.Text & "\delete.bat")
                    RapidLoad.Enabled = False
                    Me.Close()
                End If
                If Not DisplayTextBox.Text = RapidTextBox.Text Then
                    DisplayTextBox.Text = RapidTextBox.Text
                    DisplayTextBox.SelectionStart = DisplayTextBox.TextLength
                    DisplayTextBox.ScrollToCaret()
                    DisplayTextBox.Refresh()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub del_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If RapidLoad.Enabled = True Then
            e.Cancel = True
        ElseIf RapidLoad.Enabled = False Then
            e.Cancel = False
            Me.Close()
        End If
    End Sub

    Private Sub del_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainScreen.CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.LightGray
            ProgressBar1.BackColor = Color.Black
            MainScreen.Timer1.Enabled = False
        ElseIf MainScreen.CheckBox1.Checked = False Then
            Me.BackColor = Color.WhiteSmoke
            Me.ForeColor = Color.Black
            ProgressBar1.BackColor = Color.WhiteSmoke
            MainScreen.Timer1.Enabled = False
        End If
    End Sub
End Class