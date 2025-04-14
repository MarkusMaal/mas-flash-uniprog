Imports System.IO
Imports System.Drawing.Drawing2D
Public Class MainScreen
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim delr As Boolean
    Const WM_NCLBUTTONDOWN As Integer = &HA1S
    Const HTBORDER As Integer = 18
    Const HTBOTTOM As Integer = 15
    Const HTBOTTOMLEFT As Integer = 16
    Const HTBOTTOMRIGHT As Integer = 17
    Const HTCAPTION As Integer = 2
    Const HTCLOSE As Integer = 20
    Const HTGROWBOX As Integer = 4
    Const HTLEFT As Integer = 10
    Const HTMAXBUTTON As Integer = 9
    Const HTMINBUTTON As Integer = 8
    Const HTRIGHT As Integer = 11
    Const HTSYSMENU As Integer = 3
    Const HTTOP As Integer = 12
    Const HTTOPLEFT As Integer = 13
    Const HTTOPRIGHT As Integer = 14
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FileNumber.Text = 1 Then
            FileNumber.Text = 5
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis5.rtf")
        ElseIf FileNumber.Text = 2 Then
            FileNumber.Text = FileNumber.Text - 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis1.rtf")
        ElseIf FileNumber.Text = 3 Then
            FileNumber.Text = FileNumber.Text - 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis2.rtf")
        ElseIf FileNumber.Text = 4 Then
            FileNumber.Text = FileNumber.Text - 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis3.rtf")
        ElseIf FileNumber.Text = 5 Then
            FileNumber.Text = FileNumber.Text - 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis4.rtf")
        End If

        If CheckBox1.Checked = False Then
            RichTextBox1.ForeColor = SystemColors.MenuText
        ElseIf CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            CheckBox1.Checked = True
            RichTextBox1.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If FileNumber.Text = 1 Then
            FileNumber.Text = FileNumber.Text + 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis2.rtf")
        ElseIf FileNumber.Text = 2 Then
            FileNumber.Text = FileNumber.Text + 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis3.rtf")
        ElseIf FileNumber.Text = 3 Then
            FileNumber.Text = FileNumber.Text + 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis4.rtf")
        ElseIf FileNumber.Text = 4 Then
            FileNumber.Text = FileNumber.Text + 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis5.rtf")
        ElseIf FileNumber.Text = 5 Then
            FileNumber.Text = 1
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis1.rtf")
        End If

        If CheckBox1.Checked = False Then
            RichTextBox1.ForeColor = SystemColors.MenuText
        ElseIf CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            CheckBox1.Checked = True
            RichTextBox1.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If FileNumber.Text = 1 Then
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis1.rtf")
        ElseIf FileNumber.Text = 2 Then
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis2.rtf")
        ElseIf FileNumber.Text = 3 Then
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis3.rtf")
        ElseIf FileNumber.Text = 4 Then
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis4.rtf")
        ElseIf FileNumber.Text = 5 Then
            RichTextBox1.LoadFile(drive.Text & "\E_INFO\uudis5.rtf")
        End If

        If CheckBox1.Checked = False Then
            RichTextBox1.ForeColor = SystemColors.MenuText
        ElseIf CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            CheckBox1.Checked = True
            RichTextBox1.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub ListBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox3.MouseMove
        ListBox1.SelectedIndex = ListBox3.SelectedIndex
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        If delr = False Then
            ListBox1.SelectedIndex = ListBox3.SelectedIndex
            InfoPicture.Image = Nothing
            InfoPicture.BackgroundImage = My.Resources.Resources.f22170384
            QuickInfo.Text = ""
            Button1.Enabled = True
            Button7.Enabled = True
            QuickLabel.Text = ListBox3.SelectedItem
            If Not File.Exists(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Info.txt") Then GoTo checkimg
            Dim textloader As String
            textloader = File.ReadAllText(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Info.txt", System.Text.Encoding.Unicode)
            QuickInfo.Text = textloader
checkimg:
            If Not File.Exists(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "ScreenShot.bmp") Then GoTo finishinfo
            InfoPicture.Load(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "ScreenShot.bmp")
finishinfo:
            If File.Exists(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Launcher.exe") Then Button6.Visible = True
            If Not File.Exists(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Launcher.exe") Then Button6.Visible = False
            If QuickInfo.Text = "" Then QuickInfo.Text = "Info pole saadaval"
        ElseIf delr = True Then
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Portable.exe")
        Catch ex As Exception
            Dim col As String = ex.Message
            Dim err As String = ex.StackTrace
            Dim ker As String = ex.Data.ToString
            MsgBox(col & vbNewLine & err & vbNewLine & ker, MsgBoxStyle.Critical, "Rakenduse avamine ebaõnnestus")
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Abi.Enabled = True
        Pildid.Enabled = True
        Muusika.Enabled = True
        Videod.Enabled = True
        PowerPoint.Enabled = True
        Word.Enabled = True
        PaigaldatavadFailid.Enabled = True
        Tekstid.Enabled = True
        Muu.Enabled = True
    End Sub

    Private Sub Pildid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pildid.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem & "\Pildid")
    End Sub

    Private Sub Muusika_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Muusika.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem & "\Muusika")
    End Sub

    Private Sub Videod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Videod.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem & "\Minu videod")
    End Sub

    Private Sub Abi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abi.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem & "\Abi")
    End Sub

    Private Sub PowerPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerPoint.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem.ToString & "\PowerPoint")
    End Sub

    Private Sub Word_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Word.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem.ToString & "\Word")
    End Sub

    Private Sub PaigaldatavadFailid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaigaldatavadFailid.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem.ToString & "\Paigaldatavad failid")
    End Sub

    Private Sub Tekstid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tekstid.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem.ToString & "\Tekst")
    End Sub

    Private Sub Muu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Muu.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\" & ListBox2.SelectedItem.ToString & "\Muud asjad")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start(drive.Text & "\")
    End Sub

    Private Sub maj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maj.Click
        Process.Start(drive.Text & "\markuse asjad")
    End Sub

    Private Sub Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Download.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad\Allalaadimised")
    End Sub

    Private Sub mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        Process.Start(drive.Text & "\markuse asjad\markuse asjad")
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As System.EventArgs) Handles Label1.DoubleClick

    End Sub

    Private Sub Label1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            RectangleShape1.Visible = False
            Label18.Visible = False
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            RectangleShape1.Visible = True
            Label18.Visible = True
        End If
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub


    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        Me.Cursor = Cursors.Arrow
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        If File.Exists("C:\mas\running.log") Then File.Delete("C:\mas\running.log")
        Me.Close()
    End Sub

    Private Sub Label13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseLeave
        Label13.BackColor = Color.DarkRed
    End Sub

    Private Sub Label13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseMove
        Label13.BackColor = Color.Red
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        If Label1.Visible = True Then
            Label1.Visible = False
            Label13.Visible = False
            Label14.Text = "↓"
            Label14.BackColor = Color.Transparent
            Label17.Visible = False
            If CheckBox1.Checked = False Then Label14.ForeColor = Color.Black
            If CheckBox1.Checked = True Then Label14.ForeColor = SystemColors.WindowText
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
            Label13.Visible = True
            Label14.Text = "↑"
            Label14.BackColor = SystemColors.ActiveCaption
            Label14.ForeColor = SystemColors.ActiveCaptionText
            Label17.Visible = True
        End If
    End Sub

    Private Sub RichTextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.DoubleClick
        If RichTextBox1.Dock = DockStyle.None Then
            RichTextBox1.Dock = DockStyle.Fill
        ElseIf RichTextBox1.Dock = DockStyle.Fill Then
            RichTextBox1.Dock = DockStyle.None
            RichTextBox1.Anchor = AnchorStyles.Top & AnchorStyles.Right
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub


    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click

    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If Label7.Visible = True Then QuickAppsVisible()
        If Label8.Visible = True Then NewVisible()
        If Label9.Visible = False Then ShortVisible()
        If Label16.Visible = True Then OptionVisible()
        If Label19.Visible = True Then StatVisible()
        Label18.SendToBack()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Label7.Visible = True Then QuickAppsVisible()
        If Label8.Visible = False Then NewVisible()
        If Label9.Visible = True Then ShortVisible()
        If Label16.Visible = True Then OptionVisible()
        If Label19.Visible = True Then StatVisible()
        Label18.SendToBack()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        If Label7.Visible = False Then QuickAppsVisible()
        If Label8.Visible = True Then NewVisible()
        If Label9.Visible = True Then ShortVisible()
        If Label16.Visible = True Then OptionVisible()
        If Label19.Visible = True Then StatVisible()
        Label18.SendToBack()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If Label7.Visible = True Then QuickAppsVisible()
        If Label8.Visible = True Then NewVisible()
        If Label9.Visible = True Then ShortVisible()
        If Label16.Visible = False Then OptionVisible()
        If Label19.Visible = True Then StatVisible()
        Label18.SendToBack()
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NightMode.Click
        If NightMode.Checked = True Then
            If File.Exists("C:\mas\settings.sf") Then File.Delete("C:\mas\settings.asf")
            File.WriteAllText("C:\mas\settings.sf", "NightMode=Yes;")
        ElseIf NightMode.Checked = False Then
            If File.Exists("C:\mas\settings.sf") Then File.Delete("C:\mas\settings.asf")
            File.WriteAllText("C:\mas\settings.sf", "NightMode=No;")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Me.BackColor = SystemColors.Window
            Me.ForeColor = SystemColors.WindowText
            RichTextBox1.BackColor = SystemColors.Menu
            RichTextBox1.ForeColor = SystemColors.MenuText
            ListBox3.BackColor = SystemColors.Window
            ListBox3.ForeColor = SystemColors.WindowText
            ListBox2.BackColor = SystemColors.Window
            ListBox2.ForeColor = SystemColors.WindowText
            VideoBox.BackColor = SystemColors.Window
            VideoBox.ForeColor = SystemColors.Window
            RectangleShape1.BorderColor = SystemColors.WindowFrame
            FolderBox.BackColor = SystemColors.Window
            FolderBox.ForeColor = SystemColors.WindowText
            Exit Sub
        ElseIf CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.LightGray
            RichTextBox1.BackColor = Color.Black
            RichTextBox1.ForeColor = Color.LightGray
            ListBox3.BackColor = Color.Black
            ListBox3.ForeColor = Color.LightGray
            ListBox2.BackColor = Color.Black
            ListBox2.ForeColor = Color.LightGray
            VideoBox.BackColor = Color.Black
            VideoBox.ForeColor = Color.LightGray
            RectangleShape1.BorderColor = Color.LightGray
            FolderBox.BackColor = Color.Black
            FolderBox.ForeColor = Color.LightGray
            Exit Sub
        End If
    End Sub

    Private Sub Kustuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kustuta.Click
        Try
            Dim checkpin As String
            checkpin = InputBox("Sisestage mälupulga PIN kood", "Markuse asjade kustutamine")
            If checkpin = "" Then Exit Sub
            Dim nompin As String = File.ReadAllText(drive.Text & "\NTFS\config.sys")
            If checkpin & vbNewLine = nompin Then
                If MessageBox.Show("Selle protsessi käigus kustutatakse KÕIK failid Markuse asjade kaustast. Palun kasutage taastamise tööriista, et Markuse asjad taastada! Jätkake ainult siis, kui te teate, mida te teete. Kas olete kindel, et soovite jätkata?", "Tähelepanu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                    'Code for delete
                    File.WriteAllText(drive.Text & "\delete.bat", My.Resources.del)
                    Dim p As New ProcessStartInfo(drive.Text & "\delete.bat")
                    p.WindowStyle = ProcessWindowStyle.Hidden
                    p.CreateNoWindow = True
                    Process.Start(p)
                    del.ShowDialog()
                Else
                    MessageBox.Show("Muudatusi ei tehtud", "Operatsioonist loobuti", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Vale PIN kood", "Markuse asjade kustutamine", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source, "Tõrge", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub VarundaTaasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VarundaTaasta.Click
        br.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If File.Exists("C:\mas\running.log") Then File.Delete("C:\mas\running.log")
        Me.Hide()
        Drivedialog.WindowState = FormWindowState.Normal
        Drivedialog.ComboBox1.Items.Clear()
        Drivedialog.ComboBox1.Text = "Valige draiv, millega soovite töötada.."
        Splash.ComboBox1.Text = "true"
        InfoPicture.BackgroundImage = My.Resources.f22170384
        InfoPicture.Image = Nothing
        InfoPicture.Update()
        ListBox3.Items.Clear()
        ListBox1.Items.Clear()
        QuickLabel.Text = "Kiirrakendused"
        QuickInfo.Text = "Kiirrakendused on nagu tavalised töölauarakendused, mida leiate enda arvutist, aga neil on eriline funktsioon: need töötavad kohe igas arvutis otse mälupulgalt."
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        CheckBox1.Checked = False
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        VideoBox.Items.Clear()
        RichTextBox1.Visible = True
        Label8.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        FileNumber.Visible = True
        Label12.Visible = True
        LabelNewVids.Visible = True
        PlayButton.Visible = True
        VideoBox.Visible = True
        InfoPicture.Visible = False
        QuickLabel.Visible = False
        QuickInfo.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Label9.Visible = False
        Label11.Visible = False
        Button14.Visible = False
        maj.Visible = False
        Download.Visible = False
        mas.Visible = False
        Label10.Visible = False
        ListBox2.Visible = False
        Pildid.Visible = False
        Videod.Visible = False
        Muusika.Visible = False
        Abi.Visible = False
        PowerPoint.Visible = False
        Word.Visible = False
        PaigaldatavadFailid.Visible = False
        Tekstid.Visible = False
        Muu.Visible = False

        Label7.Visible = False
        ListBox3.Visible = False
        Button1.Visible = False

        Label16.Visible = False
        Label16.Visible = False
        Kustuta.Visible = False
        VarundaTaasta.Visible = False
        pinkood.Visible = False
        Nimi.Visible = False
        NightMode.Visible = False
        Splash.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not Directory.Exists(drive.Text) Then
            Label26.Text = "Väljutatud"
            Timer1.Enabled = False
            NotifyLabel.Text = "Mälupulk eemaldati arvutist"
            NotifyText.Text = "Programm vajab mälupulga olemasolekut, et korralikult töötada. Te saate programmi kasutada, kuid võib esineda kriitilisi tõrkeid."
            NotifyLabel.Visible = True
            NotifyText.Visible = True
            IgnoreButton.Visible = False
            GotoButton.Visible = False
            Timer1.Enabled = True
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            FolderBox.Visible = False
            Label21.Visible = False
            Kustuta.Enabled = False
            pinkood.Enabled = False
            Nimi.Enabled = False
            Button5.Enabled = False
            VarundaTaasta.Enabled = False
            If RadioButton4.Checked = False Then StatRadioButton.PerformClick()
            Timer1.Interval = 100
        ElseIf Not Directory.Exists(drive.Text & "\markuse asjad") Then
            Label26.Text = "Väljutatud"
            Timer1.Enabled = False
            NotifyLabel.Text = "Mälupulk ei ühildu selle programmiga"
            NotifyText.Text = "Sisestatud mälupulk ei toimi kõigi selle programm funktsioonidega. See võib olla põhjustatud järgnevast:" & vbNewLine & " - Mälupulga väljaanne on Premium, funktsioonide kasutamiseks taaskäivitage mälupulgale" & vbNewLine & " - Markuse asjade kaust on kustutatud ja/või programm ei pääse sellele juurde" & vbNewLine & " - Tegu ei ole õige Markuse mälupulgaga"
            NotifyLabel.Visible = True
            NotifyText.Visible = True
            IgnoreButton.Visible = False
            GotoButton.Visible = False
            Timer1.Enabled = True
            Button5.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            FolderBox.Visible = False
            Label21.Visible = False
            Kustuta.Enabled = False
            pinkood.Enabled = False
            Nimi.Enabled = False
            VarundaTaasta.Enabled = False
            If RadioButton4.Checked = False Then StatRadioButton.PerformClick()
            Timer1.Interval = 100
        Else
            If NotifyLabel.Text = "Mälupulk eemaldati arvutist" Then
                NotifyLabel.Visible = False
                NotifyText.Visible = False
                IgnoreButton.Visible = False
                GotoButton.Visible = False
                RadioButton1.Enabled = True
                RadioButton2.Enabled = True
                RadioButton3.Enabled = True
                Kustuta.Enabled = True
                pinkood.Enabled = True
                Nimi.Enabled = True
                Button5.Enabled = True
                VarundaTaasta.Enabled = True
                Timer1.Interval = 2000
            ElseIf NotifyLabel.Text = "Mälupulk ei ühildu selle programmiga" Then
                NotifyLabel.Visible = False
                NotifyText.Visible = False
                IgnoreButton.Visible = False
                GotoButton.Visible = False
                RadioButton1.Enabled = True
                RadioButton2.Enabled = True
                RadioButton3.Enabled = True
                Kustuta.Enabled = True
                pinkood.Enabled = True
                Nimi.Enabled = True
                Button5.Enabled = True
                VarundaTaasta.Enabled = True
                Timer1.Interval = 2000
            End If
            Label26.Text = "Ühendatud"
        End If
    End Sub

    Private Sub VideoBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoBox.SelectedIndexChanged
        PlayButton.Enabled = True
    End Sub

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        Dim index As String = VideoBox.SelectedIndex + 1
        Process.Start(drive.Text & "\Markuse_videod\" & index & ". " & VideoBox.SelectedItem.ToString)
    End Sub

    Private Sub Nimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nimi.Click
        Try
            Dim dname As String
            dname = InputBox("Sisestage mälupulga tavaline draivi nimi", "Muuda mälupulga nime", "MULTIBOOT")
            Dim aname As String
            aname = InputBox("Sisestage mälupulga autorun nimi", "Muuda mälupulga nime", "markuse mälupulk")
            File.Delete(drive.Text & "\autorun.inf")
            File.WriteAllText(drive.Text & "\autorun.inf", "[Autorun]" & vbNewLine & "icon=mas_flash.ico" & vbNewLine & "label=" & aname & vbNewLine, System.Text.Encoding.ASCII)
            Dim p As New ProcessStartInfo("cmd", "/k label " & drive.Text & " " & dname)
            p.WindowStyle = ProcessWindowStyle.Hidden
            p.CreateNoWindow = True
            Process.Start(p)
            Dim b As New ProcessStartInfo("cmd", "/k attrib " & drive.Text & "\autorun.inf +h")
            b.WindowStyle = ProcessWindowStyle.Hidden
            b.CreateNoWindow = True
            Process.Start(b)
            MessageBox.Show("Mälupulga nime muudeti edukalt", "Operatsioon õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source, "Tõrge", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub pinkood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinkood.Click
        Try
            Dim inputpin As String
            inputpin = InputBox("Sisestage praegune PIN kood", "PIN koodi muutmine")
            If inputpin = "" Then Exit Sub
            Dim outputpin As String = File.ReadAllText(drive.Text & "\NTFS\config.sys", System.Text.Encoding.Default)
            If inputpin & vbNewLine = outputpin Then
                Dim chgpin As String
                chgpin = InputBox("Sisestage uus pin kood", "PIN koodi muutmine")
                If chgpin = "" Then MsgBox("PIN koodi ei muudetud", MsgBoxStyle.Information, "PIN koodi muutmine")
                If chgpin = "" Then Exit Sub
                File.Delete(drive.Text & "\NTFS\config.sys")
                File.WriteAllText(drive.Text & "\NTFS\config.sys", chgpin & vbNewLine, System.Text.Encoding.ASCII)
                MessageBox.Show("PIN kood on nüüd muudetud", "Operatsioon õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Vale pin kood", MsgBoxStyle.Critical, "PIN koodi muutmine")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source, "Tõrge", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label17_MouseLeave(sender As Object, e As System.EventArgs) Handles Label17.MouseLeave
        Label17.BackColor = Color.DarkBlue
    End Sub

    Private Sub Label17_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label17.MouseMove
        Label17.BackColor = Color.Blue
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Sub QuickAppsVisible()
        If Label7.Visible = False Then
            Label7.Visible = True
            ListBox3.Visible = True
            Button1.Visible = True
            QuickInfo.Visible = True
            QuickLabel.Visible = True
            InfoPicture.Visible = True
            Button7.Visible = True
            Exit Sub
        ElseIf Label7.Visible = True Then
            Label7.Visible = False
            ListBox3.Visible = False
            Button1.Visible = False
            QuickInfo.Visible = False
            QuickLabel.Visible = False
            InfoPicture.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Exit Sub
        End If
    End Sub

    Sub NewVisible()
        If Label8.Visible = False Then
            RichTextBox1.Visible = True
            Label8.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            FileNumber.Visible = True
            Label12.Visible = True
            LabelNewVids.Visible = True
            PlayButton.Visible = True
            VideoBox.Visible = True
            Exit Sub
        ElseIf Label8.Visible = True Then
            RichTextBox1.Visible = False
            Label8.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            FileNumber.Visible = False
            Label12.Visible = False
            LabelNewVids.Visible = False
            PlayButton.Visible = False
            VideoBox.Visible = False
            Exit Sub
        End If
    End Sub
    Sub ShortVisible()
        If Label9.Visible = False Then
            Label9.Visible = True
            Label11.Visible = True
            Button14.Visible = True
            maj.Visible = True
            Download.Visible = True
            mas.Visible = True
            Label10.Visible = True
            ListBox2.Visible = True
            Pildid.Visible = True
            Videod.Visible = True
            Muusika.Visible = True
            Abi.Visible = True
            PowerPoint.Visible = True
            Word.Visible = True
            PaigaldatavadFailid.Visible = True
            Tekstid.Visible = True
            Muu.Visible = True
            Exit Sub
        ElseIf Label9.Visible = True Then
            Label9.Visible = False
            Label11.Visible = False
            Button14.Visible = False
            maj.Visible = False
            Download.Visible = False
            mas.Visible = False
            Label10.Visible = False
            ListBox2.Visible = False
            Pildid.Visible = False
            Videod.Visible = False
            Muusika.Visible = False
            Abi.Visible = False
            PowerPoint.Visible = False
            Word.Visible = False
            PaigaldatavadFailid.Visible = False
            Tekstid.Visible = False
            Muu.Visible = False
            Exit Sub
        End If
    End Sub
    Sub StatVisible()
        If Label19.Visible = False Then
            Label19.Visible = True
            'Label20.Visible = True
            If RadioButton1.Enabled = True Then Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label25.Visible = True
            Label26.Visible = True
            SizeLabel.Visible = True
            If RadioButton1.Enabled = True Then FolderBox.Visible = True
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
            Exit Sub
        ElseIf Label19.Visible = True Then
            Label19.Visible = False
            'Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            SizeLabel.Visible = False
            FolderBox.Visible = False
            ProgressBar1.Visible = False
            Exit Sub
        End If
    End Sub
    Sub OptionVisible()
        If Label16.Visible = False Then
            Label16.Visible = True
            Kustuta.Visible = True
            VarundaTaasta.Visible = True
            pinkood.Visible = True
            Nimi.Visible = True
            NightMode.Visible = True
            Exit Sub
        ElseIf Label16.Visible = True Then
            Label16.Visible = False
            Kustuta.Visible = False
            VarundaTaasta.Visible = False
            pinkood.Visible = False
            Nimi.Visible = False
            NightMode.Visible = False
            Exit Sub
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start(ListBox1.SelectedItem.ToString & "\" & ListBox3.SelectedItem.ToString & "Launcher.exe")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MessageBox.Show("Selle toiminguga kustutatakse see kiirrakendus koos seadete ja kaustaga. Kas olete kindel, et soovite jätkata?", "Kiirrakenduse eemaldamine", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Dim path As String = ListBox1.SelectedItem.ToString
            Dim app As String = ListBox3.SelectedItem
            delr = True
            InfoPicture.BackgroundImage = My.Resources.f22170384
            InfoPicture.Image = Nothing
            InfoPicture.Update()
            ListBox3.Items.Clear()
            ListBox1.Items.Clear()
            QuickLabel.Text = "Kiirrakendused"
            QuickInfo.Text = "Kiirrakendused on nagu tavalised töölauarakendused, mida leiate enda arvutist, aga neil on eriline funktsioon: need töötavad kohe igas arvutis otse mälupulgalt."
            delstr.Label1.Text = path
            delstr.Label4.Text = "Kustutatav rakendus: " & app
            delstr.Show()
            Me.Close()
        Else
            MessageBox.Show("Kasutaja katkestas toimingu. Kiirrakendus jäi alles", "Kiirrakenduse eemaldamine", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub MainScreen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub MainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("C:\mas\running.log") Then
            File.Delete("C:\mas\running.log")
            Me.Close()
        End If
        File.WriteAllText("C:\mas\running.log", "app is running")
        Timer1.Enabled = True
        delr = False
        PictureBox1.Visible = True
        PictureBox1.BackgroundImage = My.Resources.mas_flash
        Label18.SendToBack()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = True Then
            If Not RichTextBox1.ForeColor = Color.LightGray Then
                CheckBox1.Checked = False
                CheckBox1.Checked = True
            End If
        ElseIf CheckBox1.Checked = False Then
            RichTextBox1.BackColor = Color.White
            RichTextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub StatusStrip1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If Me.WindowState = FormWindowState.Maximized Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Capture = False
            Dim theCursor As Cursor = Cursors.Arrow
            Dim Direction As New IntPtr(Bottom)

            If e.X = 0 Or e.X = 1 Or e.X = 2 Or e.X = 3 _
            Or e.X = Me.Width - 1 Or e.X = Me.Width - 2 Or e.X = Me.Width - 3 Or e.X = Me.Width - 4 _
            Or e.Y = 0 Or e.Y = 1 Or e.Y = 2 Or e.Y = 3 _
            Or e.Y = Me.Height - 1 Or e.Y = Me.Height - 2 Or e.Y = Me.Height - 3 Or e.Y = Me.Height - 4 Then

                Select Case e.X
                    Case 0 To 3 ' On the left line
                        Select Case e.Y
                            Case 0 To 3
                                ' top left corner
                                Direction = CType(HTTOPLEFT, IntPtr)
                                theCursor = Cursors.SizeNWSE

                            Case Me.Height - 4 To Me.Height - 1
                                ' bottom left corner
                                Direction = CType(HTBOTTOMLEFT, IntPtr)
                                theCursor = Cursors.SizeNESW
                            Case Else
                                ' left side
                                Direction = CType(HTLEFT, IntPtr)
                                theCursor = Cursors.SizeWE
                        End Select
                    Case Me.Width - 4 To Me.Width - 1   ' On the right line
                        Select Case e.Y
                            Case 0 To 3
                                ' top right corner
                                Direction = CType(HTTOPRIGHT, IntPtr)
                                theCursor = Cursors.SizeNESW
                            Case Me.Height - 4 To Me.Height - 1
                                ' bottom right corner
                                Direction = CType(HTBOTTOMRIGHT, IntPtr)
                                theCursor = Cursors.SizeNWSE
                            Case Else
                                ' right side
                                Direction = CType(HTRIGHT, IntPtr)
                                theCursor = Cursors.SizeWE
                        End Select
                    Case Else
                        Select Case e.Y
                            Case 0 To 3
                                ' top line
                                Direction = CType(HTTOP, IntPtr)
                                theCursor = Cursors.SizeNS
                            Case Me.Height - 4 To Me.Height - 1
                                ' bottom line
                                Direction = CType(HTBOTTOM, IntPtr)
                                theCursor = Cursors.SizeNS
                        End Select
                End Select

                Me.Cursor = theCursor

                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        Direction, IntPtr.Zero)
                Me.DefWndProc(msg)
            Else
                'If Not hovered Then
                Me.Cursor = Cursors.SizeAll
                Application.DoEvents()
                Dim msg As Message = _
           Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
               New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
                'End If
            End If

        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Form1_ResizeEnd(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Me.WindowState = FormWindowState.Maximized Then Me.Cursor = Cursors.Arrow
        If Me.WindowState = FormWindowState.Maximized Then Exit Sub
        If e.X = 0 Or e.X = 1 Or e.X = 2 Or e.X = 3 _
        Or e.X = Me.Width - 1 Or e.X = Me.Width - 2 Or e.X = Me.Width - 3 Or e.X = Me.Width - 4 _
        Or e.Y = 0 Or e.Y = 1 Or e.Y = 2 Or e.Y = 3 _
        Or e.Y = Me.Height - 1 Or e.Y = Me.Height - 2 Or e.Y = Me.Height - 3 Or e.Y = Me.Height - 4 Then

            Dim theCursor As Cursor = Cursors.Arrow

            Select Case e.X
                Case 0 To 3 ' On the left line
                    Select Case e.Y
                        Case 0 To 3
                            ' top left corner
                            theCursor = Cursors.SizeNWSE
                        Case Me.Height - 4 To Me.Height - 1
                            ' bottom left corner
                            theCursor = Cursors.SizeNESW
                        Case Else
                            ' left side
                            theCursor = Cursors.SizeWE
                    End Select
                Case Me.Width - 4 To Me.Width - 1   ' On the right line
                    Select Case e.Y
                        Case 0 To 3
                            ' top right corner
                            theCursor = Cursors.SizeNESW
                        Case Me.Height - 4 To Me.Height - 1
                            ' bottom right corner
                            theCursor = Cursors.SizeNWSE
                        Case Else
                            ' right side
                            theCursor = Cursors.SizeWE
                    End Select
                Case Else
                    Select Case e.Y
                        Case 0 To 3
                            ' top line
                            theCursor = Cursors.SizeNS
                        Case Me.Height - 4 To Me.Height - 1
                            ' bottom line
                            theCursor = Cursors.SizeNS
                    End Select
            End Select

            Me.Cursor = theCursor

        Else
            If Me.Cursor IsNot Cursors.SizeAll Then
                Me.Cursor = Cursors.Arrow
            End If

        End If

    End Sub

    Private Sub RectangleShape1_Click(sender As System.Object, e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape1.MouseMove
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub InfoPicture_Click(sender As System.Object, e As System.EventArgs) Handles InfoPicture.Click

    End Sub

    Private Sub InfoPicture_DoubleClick(sender As Object, e As System.EventArgs) Handles InfoPicture.DoubleClick
        Splash.ComboBox1.Text = "false"
        Splash.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs)
        RadioButton4.PerformClick()
    End Sub

    Private Sub StatRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles StatRadioButton.CheckedChanged
        If Label7.Visible = True Then QuickAppsVisible()
        If Label8.Visible = True Then NewVisible()
        If Label9.Visible = True Then ShortVisible()
        If Label16.Visible = True Then OptionVisible()
        If Label19.Visible = False Then StatVisible()
        Label18.SendToBack()
    End Sub

    Private Overloads Function DirectorySize(ByVal sPath As String, ByVal bRecursive As Boolean) As Long

        Dim Size As Long = 0

        Dim diDir As New DirectoryInfo(sPath)

        Try

            Dim fil As FileInfo

            For Each fil In diDir.GetFiles()

                Size += fil.Length

            Next fil

            If bRecursive = True Then

                Dim diSubDir As DirectoryInfo

                For Each diSubDir In diDir.GetDirectories()

                    Size += DirectorySize(diSubDir.FullName, True)
                    Dim lngNumberOfDirectories As Long
                    lngNumberOfDirectories += 1

                Next diSubDir

            End If

            Return Size

        Catch ex As System.IO.FileNotFoundException

            ' File not found. Take no action
            Return ex.Message
        Catch exx As Exception

            ' Another error occurred

            Return 0
        End Try

    End Function

    Private Sub FolderBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FolderBox.SelectedIndexChanged
        If FolderBox.SelectedItem = "Markuse asjad (juurkaust)" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\markuse asjad", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Markuse asjad (sisu)" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\markuse asjad\markuse asjad", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Kiirrakendused" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\markuse asjad\Kiirrakendused", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "YUMI ja opsüsteemid" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\multiboot", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\sources", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\HBCD", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\support", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\upgrade", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\boot", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\efi", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Otseteede kasutajad" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\markuse asjad\markuse asjad", True) / 1024 / 1024 / 1024
            Dim g As Integer = DirectorySize(drive.Text & "\markuse asjad\markuse asjad\Allalaadimised", True) / 1024 / 1024 / 1024
            s = s - g
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Allalaadimised" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\markuse asjad\markuse asjad\Allalaadimised", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Kettainfo" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\System Volume Information", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\.disk", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\LOST.DIR", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Kogu ketas" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        ElseIf FolderBox.SelectedItem = "Muud asjad ja autorun" Then
            Label20.Visible = True
            Dim s As Integer
            s = DirectorySize(drive.Text & "\Markuse_videod", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\Batch", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\PortableInstall", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\E_INFO", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\NTFS", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\GT4", True) / 1024 / 1024 / 1024
            s = s + DirectorySize(drive.Text & "\launcher", True) / 1024 / 1024 / 1024
            SizeLabel.Text = Math.Round(s, 1, MidpointRounding.ToEven) & " GB"
            Dim drs As New DriveInfo(drive.Text)
            Dim sizeinteger As Integer = drs.TotalSize / 1024 / 1024 / 1024
            Dim percent As New Integer
            percent = s * 100 / sizeinteger
            ProgressBar1.Value = percent
            Label24.Text = percent & "%"
            Label20.Visible = False
        End If
    End Sub

    Private Sub MainScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not File.Exists("C:\mas\edition.txt") Then
            If File.Exists("C:\mas\settings.sf") Then File.Delete("C:\mas\settings.sf")
            Directory.Delete("C:\mas")
        End If
    End Sub

    Private Sub GotoButton_Click(sender As Object, e As EventArgs) Handles GotoButton.Click
        NotifyLabel.Visible = False
        NotifyText.Visible = False
        IgnoreButton.Visible = False
        GotoButton.Visible = False
        br.Show()
    End Sub

    Private Sub IgnoreButton_Click(sender As Object, e As EventArgs) Handles IgnoreButton.Click
        NotifyLabel.Visible = False
        NotifyText.Visible = False
        IgnoreButton.Visible = False
        GotoButton.Visible = False
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not File.Exists("C:\mas\running.log") Then
            Me.Close()
        End If
    End Sub
End Class