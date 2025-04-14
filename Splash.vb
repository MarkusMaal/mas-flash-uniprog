Imports System.IO
Imports System.Management
Public Class Splash
    Public drv As String
    Dim devpass As String

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        MainScreen.Timer2.Enabled = False
        If Not Directory.Exists("C:\mas") Then Timer1.Enabled = False
        If Not Directory.Exists("C:\mas") Then Timer2.Enabled = False
        If Not Directory.Exists("C:\mas") Then MessageBox.Show("Tegu pole Markuse arvutiga. Te saate jätkata, kuid pidage meeles, et Markuse arvutis töötab see programm kõige paremini.", "Võõras arvuti tuvastatud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If Not Directory.Exists("C:\mas") Then MessageBox.Show("Olge kindlad, et rakendus töötab Süsteemiülema režiimis", "Võõras arvuti tuvastatud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If Not Directory.Exists("C:\mas") Then Directory.CreateDirectory("C:\mas")
        If ComboBox1.Text = "true" Then Me.Hide()
        Timer1.Enabled = True
        If Timer2.Enabled = False Then Timer2.Enabled = True
        If ComboBox1.Text = "false" Then Me.BackColor = Color.Black
        If ComboBox1.Text = "false" Then PictureBox1.Visible = False
        If ComboBox1.Text = "false" Then Label1.Visible = False
        If ComboBox1.Text = "false" Then infoLabel.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If File.Exists("C:\Windows\explorer-217.exe") Then Me.Close()
            If Not ProgressBar1.Value = ProgressBar1.Maximum Then
                ProgressBar1.Increment(5)
                If ProgressBar1.Value = 50 Then
                    infoLabel.Text = "Mälupulga otsimine..."
                    Dim int As Integer
begincode:
                    Dim multiple As Boolean
                    If File.Exists("A:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "A:"
                    ElseIf File.Exists("B:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "B:"
                    ElseIf File.Exists("C:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "C:"
                    ElseIf File.Exists("D:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "D:"
                    ElseIf File.Exists("E:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "E:"
                    ElseIf File.Exists("F:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "F:"
                    ElseIf File.Exists("G:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "G:"
                    ElseIf File.Exists("H:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "H:"
                    ElseIf File.Exists("I:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "I:"
                    ElseIf File.Exists("J:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "J:"
                    ElseIf File.Exists("K:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "K:"
                    ElseIf File.Exists("L:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "L:"
                    ElseIf File.Exists("M:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "M:"
                    ElseIf File.Exists("N:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "N:"
                    ElseIf File.Exists("O:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "O:"
                    ElseIf File.Exists("P:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "P:"
                    ElseIf File.Exists("Q:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "Q:"
                    ElseIf File.Exists("R:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "R:"
                    ElseIf File.Exists("S:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "S:"
                    ElseIf File.Exists("T:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "T:"
                    ElseIf File.Exists("U:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "U:"
                    ElseIf File.Exists("V:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "V:"
                    ElseIf File.Exists("W:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "W:"
                    ElseIf File.Exists("X:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "X:"
                    ElseIf File.Exists("Y:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "Y:"
                    ElseIf File.Exists("Z:\E_INFO\edition.cmd") Then
                        If Not drv = "" Then multiple = True
                        drv = "Z:"

                    Else
                        infoLabel.Visible = True
                        Show()
                        Me.WindowState = FormWindowState.Normal
                        infoLabel.Text = "Mälupulga otsimine..."
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        soption.ShowDialog()
                        If soption.val = "close" Then
                            Me.Close()
                        ElseIf soption.val = "new" Then
                            Me.Hide()
                            MainScreen.Timer1.Enabled = False
                            br.ShowDialog()
                            Me.Show()
                            GoTo lolocode
                        ElseIf soption.val = "restart" Then
                            Process.Start("cmd /k", "shutdown /r /t 0")
                            Me.Close()
                        ElseIf soption.val = "ignore" Then
                            GoTo lolocode
                        End If
lolocode:
                        infoLabel.Text = "Mälupulga otsimine..."
                        GoTo begincode
                    End If
bitycode:
                    int = int + 1
                    If Not int = 5 Then GoTo begincode
                    If multiple = True Then
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        If Drivedialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                            drv = Drivedialog.ComboBox1.SelectedItem.ToString
                            Timer1.Enabled = True
                            Timer2.Enabled = True
                        Else
                            Me.Close()
                        End If
                        Me.Show()
                        Timer1.Enabled = True
                        Timer2.Enabled = True
                    End If
                    If devpass = "43218765" Then
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Me.Hide()
                        Me.TopMost = False
                        Developer.ShowDialog()
                        Me.Show()
                        Me.TopMost = True
                        devpass = Nothing
                        Timer1.Enabled = True
                        Timer2.Enabled = True
                        Exit Sub
                    End If
                    Me.WindowState = FormWindowState.Normal
                    If Me.Visible = False Then Me.Show()
                    If ComboBox1.Text = "false" Then GoTo begincode
                    If File.Exists(drv & "\definatelynotakillswitch.txt") Then Timer1.Enabled = False
                    If File.Exists(drv & "\definatelynotakillswitch.txt") Then Timer2.Enabled = False
                    If File.Exists(drv & "\definatelynotakillswitch.txt") Then Me.Close()
                    If Not ComboBox1.Text = "true" Then Me.Show()
                    If ComboBox1.Text = "true" Then ComboBox1.Text = ""
                    GetSize(drv & "\")
                    If Not Directory.Exists(drv & "\markuse asjad") Then
                        If Directory.Exists(drv & "\dajsa esukram") Then
                            Directory.CreateDirectory(drv & "\markuse asjad")
                        End If
                        Me.BackColor = Color.DarkRed
                        infoLabel.Visible = True
                        Label1.Visible = True
                        PictureBox1.Visible = True
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        If MessageBox.Show("Väljaanne Premium tuvastatud. Kas soovite taastada väljaande Ultimate varundusest?", "Markuse asjad kausta ei leitud", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                            br.RadioButton2.Checked = True
                            br.RadioButton1.Checked = False
                            br.RadioButton1.Enabled = False
                            Me.Hide()
                            MainScreen.Timer1.Enabled = False
                            br.ShowDialog()
                            Me.Show()
                            MsgBox("Sisestatud mälupulk ei ühildu selle tarkvaraga. Palun sisestage mälupulk, mille väljaanne on Basic või Ultimate. Et hallata Premium väljaandega mälupulke, buutige mälupulgale ja/või kasutage YUMI installerit." & vbNewLine & vbNewLine & "Programm sulgub nüüd", MsgBoxStyle.Information, "Teade")
                            Me.Close()
                        Else
                            MsgBox("Sisestatud mälupulk ei ühildu selle tarkvaraga. Palun sisestage mälupulk, mille väljaanne on Basic või Ultimate. Et hallata Premium väljaandega mälupulke, buutige mälupulgale ja/või kasutage YUMI installerit." & vbNewLine & vbNewLine & "Programm sulgub nüüd", MsgBoxStyle.Information, "Teade")
                            Me.Close()
                        End If
                    End If
                    infoLabel.Visible = True
                    Label1.Visible = True
                    PictureBox1.Visible = True
                    Me.BackColor = Color.Green
                    If Directory.Exists(drv & "\multiboot") Then Me.BackColor = Color.BlueViolet
                ElseIf ProgressBar1.Value = 75 Then
                    infoLabel.Text = "Sätete laadimine..."
                ElseIf ProgressBar1.Value = 95 Then
                    infoLabel.Text = "Peaaegu valmis!"
                End If
            ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
                ProgressBar1.Value = ProgressBar1.Minimum
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source, "Tõrge", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If Timer1.Enabled = False Then
                Timer2.Enabled = False
                infoLabel.Text = "Seadete laadimine..."
                Dim finfo As New IO.DirectoryInfo(drv & "\markuse asjad\Kiirrakendused")
                For Each fi In finfo.GetDirectories
                    MainScreen.ListBox1.Items.Add(fi.FullName)
                    MainScreen.ListBox3.Items.Add(fi.Name)
                Next
                MainScreen.RichTextBox1.LoadFile(drv & "\E_INFO\uudis1.rtf")
                Dim filename As String
                filename = File.ReadAllText(drv & "\E_INFO\edition.txt")
                MainScreen.Label5.Text = "Väljaanne: " & filename
                filename = File.ReadAllText(drv & "\markuse asjad\markuse asjad\kasutajad.txt")
                MainScreen.TextBox1.Text = filename
                MainScreen.ListBox2.Items.AddRange(MainScreen.TextBox1.Text.Split(";"))
                MainScreen.TextBox1.Text = ""
                filename = File.ReadAllText(drv & "\E_INFO\videod.txt")
                MainScreen.TextBox1.Text = filename
                MainScreen.VideoBox.Items.AddRange(MainScreen.TextBox1.Text.Split(";"))
                MainScreen.TextBox1.Text = ""
                MainScreen.drive.Text = drv
                MainScreen.Label6.Text = "Draiv: " & drv
                If Not File.Exists("C:\mas\settings.sf") Then GoTo skipcast
                Dim nightcast As String
                nightcast = File.ReadAllText("C:\mas\settings.sf")
                If nightcast.StartsWith("NightMode=Yes") Then
                    MainScreen.CheckBox1.Checked = True
                    MainScreen.NightMode.Checked = True
                ElseIf nightcast.StartsWith("NightMode=No") Then
                    GoTo skipcast
                End If
skipcast:

                MainScreen.Show()
                If Not CheckBox1.Checked = True Then Me.Close()
            ElseIf Timer1.Enabled = True Then
                Exit Sub
            End If
        Catch ex As Exception
            Timer1.Enabled = False
            Timer2.Enabled = False
            MainScreen.Timer1.Enabled = False
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source, "Tõrge", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            MainScreen.Show()
            If Not CheckBox1.Checked = True Then Me.Close()
        End Try
    End Sub

    Private Sub GetSize(ByVal drivename As String)
        Dim drive As New DriveInfo(drivename)
        Dim sizeinteger As Integer = drive.TotalSize / 1024 / 1024 / 1024
        MainScreen.Label4.Text = "Maht: " & Math.Round(sizeinteger, 3, MidpointRounding.ToEven) & " GB"
        MainScreen.Label3.Text = "Tüüp: " & drive.DriveFormat
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
            Me.TopMost = False
            Exit Sub
        End If
        If Not CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            Me.TopMost = True
            Exit Sub
        End If
    End Sub

    Private Sub ReadTimer_Tick(sender As Object, e As EventArgs) Handles ReadTimer.Tick

    End Sub

    Private Sub Splash_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(117) Then
            'Code for manual device
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Käsitsi seade")
            Me.TopMost = False
            Drivedialog.manualmode = True
            Drivedialog.ShowDialog()
            Drivedialog.manualmode = False
            Me.TopMost = True
        ElseIf e.KeyChar = Chr(114) Then
            'Code for recovery
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Taaste")
            Me.TopMost = False
            br.ShowDialog()
            Me.TopMost = True
        ElseIf e.KeyChar = Chr(109) Then
            'Code for developer
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Arendaja")
            Me.TopMost = False
            devpass = InputBox("Sisestage arendaja PIN kood", "Arendaja režiim nõuab kinnitust", "?")
            Me.TopMost = True
        ElseIf e.KeyChar = Chr(97) Then
            'Code for old batch file
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Pakkfail")
            Process.Start(drv & "\Batch\markuse_asjad.bat")
            Me.Close()
        ElseIf e.KeyChar = Chr(77) Then
            'Code for developer
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Arendaja")
            Me.TopMost = False
            devpass = InputBox("Sisestage arendaja PIN kood", "Arendaja režiim nõuab kinnitust", "?")
            Me.TopMost = True
        ElseIf e.KeyChar = Chr(27) Then
            'Code for cancel
            Timer1.Enabled = False
            Timer2.Enabled = False
            Me.Close()
        End If
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class
