Imports System.IO
Imports System.Threading.Tasks

Public Class br
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        If RapidLoad.Enabled = True Then
            If MessageBox.Show("Protsessi käigus ei ole võimalik programmi sulgeda. Kas soovite selle asemel programmi peita?", "Sulgemine", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                Me.Hide()
            Else
                Exit Sub
            End If
        ElseIf RapidLoad.Enabled = False Then
            Me.Close()
        End If
    End Sub

    Private Sub Label13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseLeave
        Label13.BackColor = Color.DarkRed
    End Sub

    Private Sub Label13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseMove
        Label13.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("See protsess võib kaua aega võtta. Palun ärge eemaldage protsessi käigus Markuse mälupulka või lülitage arvutit välja. Vajutage OK, et protsessi alustada.", MsgBoxStyle.Exclamation, "Hoiatus") = MsgBoxResult.Ok Then
            File.WriteAllText(MainScreen.drive.Text & "\br.bat", My.Resources.br)
            If RadioButton1.Checked = True Then
                'Code for backup
                If File.Exists(MainScreen.drive.Text & "\E_INFO\process.txt") Then File.Delete(MainScreen.drive.Text & "\E_INFO\process.txt")
                If File.Exists(MainScreen.drive.Text & "\E_INFO\communicate.cmd") Then File.Delete(MainScreen.drive.Text & "\E_INFO\communicate.cmd")
                If File.Exists(MainScreen.drive.Text & "\E_INFO\pro.txt") Then File.Delete(MainScreen.drive.Text & "\E_INFO\pro.txt")
                If File.Exists(MainScreen.drive.Text & "\E_INFO\endprocess.txt") Then File.Delete(MainScreen.drive.Text & "\E_INFO\endprocess.txt")
                ElapseTimer.Enabled = True
                ElapsedLabel.Visible = True
                Button2.Enabled = False
                mas.Enabled = False
                Batch.Enabled = False
                Windows.Enabled = False
                YUMI.Enabled = False
                TextBox1.Enabled = False
                Button1.Enabled = False
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                RapidTextBox.Text = "set drv=" & MainScreen.drive.Text
                RapidTextBox.Text = "set destination=" & FolderBrowserDialog1.SelectedPath
                RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set br=backup"
                If mas.Checked = True Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat1=yes"
                If mas.Checked = False Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat1=no"
                If Windows.Checked = True Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat2=yes"
                If Windows.Checked = False Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat2=no"
                If Batch.Checked = True Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat3=yes"
                If Batch.Checked = False Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat3=no"
                If YUMI.Checked = True Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat4=yes"
                If YUMI.Checked = False Then RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat4=no"
                RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat5=yes"
                RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set cat6=yes"
                If File.Exists(MainScreen.drive.Text & "\E_INFO\process.txt") Then File.Delete(MainScreen.drive.Text & "\E_INFO\process.txt")
                If File.Exists(MainScreen.drive.Text & "\E_INFO\communicate.cmd") Then File.Delete(MainScreen.drive.Text & "\E_INFO\communicate.cmd")
                File.WriteAllText(MainScreen.drive.Text & "\E_INFO\count.bat", My.Resources.count)
                File.WriteAllText(MainScreen.drive.Text & "\E_INFO\communicate.cmd", RapidTextBox.Text, System.Text.Encoding.ASCII)
                RapidTextBox.Text = ""
                Dim p As New ProcessStartInfo(MainScreen.drive.Text & "\br.bat")
                p.WindowStyle = ProcessWindowStyle.Normal
                p.CreateNoWindow = True
                Process.Start(p)
                Exit Sub
            ElseIf RadioButton2.Checked = True Then
                'Code for restore
                ElapseTimer.Enabled = True
                ElapsedLabel.Visible = True
                Button2.Enabled = False
                mas.Enabled = False
                Batch.Enabled = False
                Windows.Enabled = False
                YUMI.Enabled = False
                TextBox1.Enabled = False
                Button1.Enabled = False
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                RapidTextBox.Text = "set drv=" & MainScreen.drive.Text
                RapidTextBox.Text = "set destination=" & FolderBrowserDialog1.SelectedPath
                RapidTextBox.Text = RapidTextBox.Text & vbNewLine & "set br=restore"
                File.WriteAllText(MainScreen.drive.Text & "\E_INFO\communicate.cmd", RapidTextBox.Text, System.Text.Encoding.ASCII)
                RapidTextBox.Text = ""
                Dim p As New ProcessStartInfo(MainScreen.drive.Text & "\br.bat")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
            End If
        Else
            MsgBox("Protsess katkestati", MsgBoxStyle.Information, "Loobu toimingust")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        FolderBrowserDialog1.SelectedPath = TextBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        FolderBrowserDialog1.SelectedPath = TextBox1.Text
    End Sub


    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        Button2.Text = "Alusta taastega"
        Label3.Text = "Kaust, kus asub varundus:"
        notelabel.Visible = True
        Label4.Visible = False
        mas.Visible = False
        Windows.Visible = False
        Batch.Visible = False
        YUMI.Visible = False
        Check.Visible = False
        Other.Visible = False
    End Sub


    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        Button2.Text = "Alusta varundamisega"
        Label3.Text = "Kaust, kuhu varundada:"
        notelabel.Visible = False
        Label4.Visible = True
        mas.Visible = True
        Windows.Visible = True
        Batch.Visible = True
        YUMI.Visible = True
        Check.Visible = True
        Other.Visible = True
    End Sub

    Private Sub RapidLoad_Tick(sender As System.Object, e As System.EventArgs) Handles RapidLoad.Tick
        If File.Exists(MainScreen.drive.Text & "\E_INFO\pro.txt") Then
                Dim ac As String
                ac = File.ReadAllText(MainScreen.drive.Text & "\E_INFO\pro.txt")
                ListBox1.Items.Clear()
                ListBox1.Items.AddRange(ac.Split(";"))
            ListBox1.SelectedIndex = 0
            Try
                ProgressBar1.Value = Convert.ToInt32(ListBox1.SelectedItem.ToString())
            Catch
            End Try
            Dim prc = ListBox1.SelectedItem.ToString()
            ListBox1.SelectedIndex = 1
            Label6.Text = "Praegune toiming: " & ListBox1.SelectedItem.ToString()
            Label7.Text = prc & "% valmis"
        End If
        If File.Exists(MainScreen.drive.Text & "\E_INFO\process.txt") Then
            Try
                Dim rc As String
                rc = File.ReadAllText(MainScreen.drive.Text & "\E_INFO\process.txt", System.Text.Encoding.ASCII)
                RapidTextBox.Text = rc
            Catch
            End Try
            If File.Exists(MainScreen.drive.Text & "\E_INFO\endprocess.txt") Then
                File.Delete(MainScreen.drive.Text & "\E_INFO\endprocess.txt")
                File.Delete(MainScreen.drive.Text & "\E_INFO\process.txt")
                File.Delete(MainScreen.drive.Text & "\br.bat")
                Button2.Enabled = True
                mas.Enabled = True
                Batch.Enabled = True
                Windows.Enabled = True
                YUMI.Enabled = True
                TextBox1.Enabled = True
                Button1.Enabled = True
                RadioButton1.Enabled = True
                RadioButton2.Enabled = True
                ElapseTimer.Enabled = False
                secondlabel.Text = 0
                minutelabel.Text = 0
                hourlabel.Text = 0
                daylabel.Text = 0
                RapidLoad.Enabled = False
                If Button2.Text = "Alusta varundamisega" Then
                    MainScreen.NotifyLabel.Text = "Varundamine viidi lõpule"
                    MainScreen.NotifyText.Text = "Kui soovite näha, kuidas varundamine õnnestus, vajutage allolevale nupule."
                    MainScreen.NotifyLabel.Visible = True
                    MainScreen.NotifyText.Visible = True
                    MainScreen.IgnoreButton.Visible = True
                    MainScreen.GotoButton.Visible = True
                ElseIf Button2.Text = "Alusta taastega" Then
                    MainScreen.NotifyLabel.Text = "Taaste viidi lõpule"
                    MainScreen.NotifyText.Text = "Kui soovite näha, kuidas taaste õnnestus, vajutage allolevale nupule."
                    MainScreen.NotifyLabel.Visible = True
                    MainScreen.NotifyText.Visible = True
                    MainScreen.IgnoreButton.Visible = True
                    MainScreen.GotoButton.Visible = True
                End If
            End If
        End If
            If Not DisplayTextBox.Text = RapidTextBox.Text Then
                DisplayTextBox.Text = RapidTextBox.Text.Replace("\9", "ü")
                DisplayTextBox.Text = DisplayTextBox.Text.Replace("\6", "õ")
                DisplayTextBox.Text = DisplayTextBox.Text.Replace("\2", "ä")
                DisplayTextBox.SelectionStart = DisplayTextBox.TextLength
                DisplayTextBox.ScrollToCaret()
                DisplayTextBox.Refresh()
            Else
                Exit Sub
            End If
            Exit Sub
    End Sub

    Private Sub br_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainScreen.CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.LightGray
            TextBox1.BackColor = Color.Black
            TextBox1.ForeColor = Color.LightGray
            Button2.BackColor = Color.Black
            Button2.ForeColor = Color.LightGray
        ElseIf MainScreen.CheckBox1.Checked = False Then
            Me.BackColor = Color.WhiteSmoke
            Me.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
            Button2.BackColor = Color.WhiteSmoke
            Button2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ElapseTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElapseTimer.Tick
        If secondlabel.Text = 59 Then
            secondlabel.Text = 0
            minutelabel.Text = minutelabel.Text + 1
            If minutelabel.Text = 60 Then
                minutelabel.Text = 0
                hourlabel.Text = hourlabel.Text + 1
                If hourlabel.Text = 24 Then
                    hourlabel.Text = 0
                    daylabel.Text = daylabel.Text + 1
                End If
            End If
        Else
            secondlabel.Text = secondlabel.Text + 1
        End If
        Dim sec As String = secondlabel.Text
        Dim min As String = minutelabel.Text
        Dim hrs As String = hourlabel.Text
        Dim day As String = daylabel.Text
        If sec < 10 Then sec = "0" & sec
        If min < 10 Then min = "0" & min
        If hrs < 10 Then hrs = "0" & hrs
        If day < 10 Then day = "0" & day
        ElapsedLabel.Text = "Kulunud aeg: " & day & ":" & hrs & ":" & min & ":" & sec
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs)
        If Not File.Exists(TextBox1.Text & "\E_INFO\edition.cmd") Then MsgBox("Tegu pole Markuse mälupulga varunduskaustaga", MsgBoxStyle.Critical, "Varunduse kustutamine")
        If Not File.Exists(TextBox1.Text & "\E_INFO\edition.cmd") Then Exit Sub
        If MessageBox.Show("See toiming kustutab varunduse lõplikult teie varundusmeediumilt. Kas olete kindel, et soovite jätkata?", "Varunduse kustutamine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
            delb.Show()
        Else
            MsgBox("Muudatusi ei tehtud", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Varunduse kustutamine")
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
            If Button2.Text = "Alusta varundamisega" Then
                RadioButton2.Checked = False
                RadioButton1.Checked = True
            ElseIf Button2.Text = "Alusta taastega" Then
                RadioButton2.Checked = True
                RadioButton1.Checked = False
            End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub hideInfo_Click(sender As System.Object, e As System.EventArgs) Handles hideInfo.Click
        hideInfo.Visible = False
        DisplayTextBox.Visible = False
        Button3.Visible = True
        Me.Size = New Size(637, 328)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        hideInfo.Visible = True
        DisplayTextBox.Visible = True
        Button3.Visible = False
        Me.Size = New Size(637, 558)
    End Sub

    Private Sub max_Click(sender As System.Object, e As System.EventArgs) Handles max.Click
        max.Text = MainScreen.drive.Text
    End Sub
End Class