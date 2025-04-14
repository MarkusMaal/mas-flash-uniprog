Imports System.IO
Public Class Developer

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim s As String
        s = InputBox("Sisestage video nimi koos formaadiga", "Lisa uus video", "näidis.mp4")
        ListBox1.SelectedIndex = 0
        Dim oldvid1 As String = ListBox1.SelectedItem
        ListBox1.SelectedIndex = 1
        Dim oldvid2 As String = ListBox1.SelectedItem
        ListBox1.Items.Clear()
        ListBox1.Items.Add(s)
        ListBox1.Items.Add(oldvid1)
        ListBox1.Items.Add(oldvid2)
        If MsgBox("Kas soovite muudatused salvestada?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Video lisamine õnnestus") = MsgBoxResult.Yes Then
            Dim saveit As String = String.Join(";", ListBox1.Items)
            File.WriteAllText(Splash.drv & "\E_INFO\videod.txt", saveit)
        Else
            MsgBox("Muudatusi ei tehtud")
            Exit Sub
        End If
    End Sub

    Private Sub Developer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim a As String
        a = File.ReadAllText(Splash.drv & "\E_INFO\videod.txt")
        ListBox1.Items.AddRange(a.Split(";"))
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If File.Exists(Splash.drv & "\E_INFO\uudis6.rtf") Then File.Delete(Splash.drv & "\E_INFO\uudis6.rtf")
            My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis5.rtf", "uudis6.rtf")
            My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis4.rtf", "uudis5.rtf")
            My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis3.rtf", "uudis4.rtf")
            My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis2.rtf", "uudis3.rtf")
            My.Computer.FileSystem.RenameFile(Splash.drv & "\E_INFO\uudis1.rtf", "uudis2.rtf")
            File.Copy(OpenFileDialog1.FileName, Splash.drv & "\E_INFO\uudis1.rtf", False)
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'code for make
        If Editor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MsgBox("Uudis salvestati edukalt")
            Exit Sub
        Else
            MsgBox("Muudatusi ei tehtud")
        End If
    End Sub
End Class