Public Class Editor

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If My.Computer.FileSystem.FileExists(Splash.drv & "\E_INFO\uudis6.rtf") Then My.Computer.FileSystem.DeleteFile(Splash.drv & "\E_INFO\uudis6.rtf")
        My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis5.rtf", "uudis6.rtf")
        My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis4.rtf", "uudis5.rtf")
        My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis3.rtf", "uudis4.rtf")
        My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis2.rtf", "uudis3.rtf")
        My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis1.rtf", "uudis2.rtf")
        RichTextBox1.SaveFile(Splash.drv & "\E_INFO\uudis1.rtf")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Italic)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Underline)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Strikeout)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            Dim s As String
            s = Clipboard.GetText()
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Clipboard.SetImage(Image.FromFile(OpenFileDialog1.FileName))
            End If
            RichTextBox1.Paste()
            Clipboard.SetText(s)
        Catch ex As Exception
            MsgBox("Tegu pole toetatud pildiformaadiga", MsgBoxStyle.Critical, "Pildi lisamine ebaõnnestus")
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Regular)
    End Sub

    Private Sub Editor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.SelectionCharOffset = 15
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Button10.Text = "Keela reavahe" Then
            RichTextBox1.SelectionCharOffset = 1
            Button10.Text = "Luba reavahe"
        ElseIf Button10.Text = "Luba reavahe" Then
            RichTextBox1.SelectionCharOffset = 15
            Button10.Text = "Keela reavahe"
        End If
    End Sub
End Class