<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class br
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(br))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mas = New System.Windows.Forms.CheckBox()
        Me.Windows = New System.Windows.Forms.CheckBox()
        Me.YUMI = New System.Windows.Forms.CheckBox()
        Me.Batch = New System.Windows.Forms.CheckBox()
        Me.Other = New System.Windows.Forms.CheckBox()
        Me.Check = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.max = New System.Windows.Forms.Label()
        Me.val = New System.Windows.Forms.Label()
        Me.RapidTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.RapidLoad = New System.Windows.Forms.Timer(Me.components)
        Me.notelabel = New System.Windows.Forms.Label()
        Me.ElapsedLabel = New System.Windows.Forms.Label()
        Me.hourlabel = New System.Windows.Forms.Label()
        Me.daylabel = New System.Windows.Forms.Label()
        Me.minutelabel = New System.Windows.Forms.Label()
        Me.secondlabel = New System.Windows.Forms.Label()
        Me.ElapseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.hideInfo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TipTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(619, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "X"
        Me.TipTip.SetToolTip(Me.Label13, "Sulge/Peida aken")
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Varundamine/Taaste"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Mida te soovite teha?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton1.Location = New System.Drawing.Point(5, 55)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Varundamine"
        Me.TipTip.SetToolTip(Me.RadioButton1, "Varundab mälupulgal olevad failid, juhuks kui midagi peaks nendega juhtuma")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton2.Location = New System.Drawing.Point(98, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.Text = "Taaste"
        Me.TipTip.SetToolTip(Me.RadioButton2, "Võimaldab varem varundatud failid taastada")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(5, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(537, 20)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "C:\usb_backup"
        Me.TipTip.SetToolTip(Me.TextBox1, "Kaust teisel andmekandjal")
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(548, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Sirvi.."
        Me.TipTip.SetToolTip(Me.Button1, "Vali kaust, kasutades Windows'i ""Vali kaust"" dialoogi.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Kaust, kuhu varundada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Mida soovite varundada?"
        '
        'mas
        '
        Me.mas.AutoSize = True
        Me.mas.Checked = True
        Me.mas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mas.Location = New System.Drawing.Point(5, 156)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(93, 17)
        Me.mas.TabIndex = 49
        Me.mas.Text = "Markuse asjad"
        Me.TipTip.SetToolTip(Me.mas, "Failid kaustas <draiv>\markuse asjad ")
        Me.mas.UseVisualStyleBackColor = True
        '
        'Windows
        '
        Me.Windows.AutoSize = True
        Me.Windows.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Windows.Location = New System.Drawing.Point(5, 175)
        Me.Windows.Name = "Windows"
        Me.Windows.Size = New System.Drawing.Size(128, 17)
        Me.Windows.TabIndex = 50
        Me.Windows.Text = "Windows 7 paigaldaja"
        Me.TipTip.SetToolTip(Me.Windows, "Windows 7 paigaldusfailid (\sources, \boot, \EFI, \support jms)")
        Me.Windows.UseVisualStyleBackColor = True
        '
        'YUMI
        '
        Me.YUMI.AutoSize = True
        Me.YUMI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.YUMI.Location = New System.Drawing.Point(145, 175)
        Me.YUMI.Name = "YUMI"
        Me.YUMI.Size = New System.Drawing.Size(124, 17)
        Me.YUMI.TabIndex = 52
        Me.YUMI.Text = "YUMI ja opsüsteemid"
        Me.TipTip.SetToolTip(Me.YUMI, "Failid kaustas <draiv>\multiboot")
        Me.YUMI.UseVisualStyleBackColor = True
        '
        'Batch
        '
        Me.Batch.AutoSize = True
        Me.Batch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Batch.Location = New System.Drawing.Point(145, 156)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(70, 17)
        Me.Batch.TabIndex = 51
        Me.Batch.Text = "Pakkfailid"
        Me.TipTip.SetToolTip(Me.Batch, "Failid kaustas <draiv>\Batch")
        Me.Batch.UseVisualStyleBackColor = True
        '
        'Other
        '
        Me.Other.AutoSize = True
        Me.Other.Checked = True
        Me.Other.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Other.Enabled = False
        Me.Other.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Other.Location = New System.Drawing.Point(273, 175)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(178, 17)
        Me.Other.TabIndex = 54
        Me.Other.Text = "Muud failid ja autorun.inf (vajalik)"
        Me.TipTip.SetToolTip(Me.Other, "Erinevad failid, mis on vajalikud, et mälupulk töötaks normaalselt.")
        Me.Other.UseVisualStyleBackColor = True
        '
        'Check
        '
        Me.Check.AutoSize = True
        Me.Check.Checked = True
        Me.Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check.Enabled = False
        Me.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Check.Location = New System.Drawing.Point(273, 156)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(159, 17)
        Me.Check.TabIndex = 53
        Me.Check.Text = "Kontrollimise seaded (vajalik)"
        Me.TipTip.SetToolTip(Me.Check, "Vajalikud failid, millega saab tuvastada, et sisestatud on Markuse mälupulk")
        Me.Check.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Vali kaust, kuhu te soovite varundada"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog1.SelectedPath = "C:\usb_backup"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(631, 29)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Alusta varundamisega"
        Me.TipTip.SetToolTip(Me.Button2, "Käivitab varundamise/taastamise protsessi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TÄHELEPANU: Ärge eemaldage mälupulka e" & _
        "ga sulgege arvutit protsessi käigus!")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Protsess"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'max
        '
        Me.max.AutoSize = True
        Me.max.Location = New System.Drawing.Point(545, 20)
        Me.max.Name = "max"
        Me.max.Size = New System.Drawing.Size(25, 13)
        Me.max.TabIndex = 59
        Me.max.Text = "true"
        '
        'val
        '
        Me.val.AutoSize = True
        Me.val.Location = New System.Drawing.Point(545, 33)
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(33, 13)
        Me.val.TabIndex = 60
        Me.val.Text = "value"
        Me.val.Visible = False
        '
        'RapidTextBox
        '
        Me.RapidTextBox.BackColor = System.Drawing.Color.Black
        Me.RapidTextBox.ForeColor = System.Drawing.Color.Green
        Me.RapidTextBox.Location = New System.Drawing.Point(471, 398)
        Me.RapidTextBox.Multiline = True
        Me.RapidTextBox.Name = "RapidTextBox"
        Me.RapidTextBox.Size = New System.Drawing.Size(148, 108)
        Me.RapidTextBox.TabIndex = 61
        Me.RapidTextBox.Visible = False
        Me.RapidTextBox.WordWrap = False
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTextBox.BackColor = System.Drawing.Color.Black
        Me.DisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayTextBox.ForeColor = System.Drawing.Color.Green
        Me.DisplayTextBox.Location = New System.Drawing.Point(8, 328)
        Me.DisplayTextBox.Multiline = True
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.ReadOnly = True
        Me.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DisplayTextBox.Size = New System.Drawing.Size(617, 0)
        Me.DisplayTextBox.TabIndex = 62
        Me.DisplayTextBox.Text = "Valmis"
        Me.DisplayTextBox.Visible = False
        '
        'RapidLoad
        '
        Me.RapidLoad.Enabled = True
        '
        'notelabel
        '
        Me.notelabel.AutoSize = True
        Me.notelabel.Location = New System.Drawing.Point(2, 143)
        Me.notelabel.Name = "notelabel"
        Me.notelabel.Size = New System.Drawing.Size(554, 52)
        Me.notelabel.TabIndex = 63
        Me.notelabel.Text = resources.GetString("notelabel.Text")
        Me.notelabel.Visible = False
        '
        'ElapsedLabel
        '
        Me.ElapsedLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElapsedLabel.Location = New System.Drawing.Point(11, 122)
        Me.ElapsedLabel.Name = "ElapsedLabel"
        Me.ElapsedLabel.Size = New System.Drawing.Size(619, 18)
        Me.ElapsedLabel.TabIndex = 64
        Me.ElapsedLabel.Text = "Kulunud aeg: 00:00:00:00"
        Me.ElapsedLabel.Visible = False
        '
        'hourlabel
        '
        Me.hourlabel.AutoSize = True
        Me.hourlabel.Location = New System.Drawing.Point(412, 89)
        Me.hourlabel.Name = "hourlabel"
        Me.hourlabel.Size = New System.Drawing.Size(13, 13)
        Me.hourlabel.TabIndex = 65
        Me.hourlabel.Text = "0"
        Me.hourlabel.Visible = False
        '
        'daylabel
        '
        Me.daylabel.AutoSize = True
        Me.daylabel.Location = New System.Drawing.Point(393, 89)
        Me.daylabel.Name = "daylabel"
        Me.daylabel.Size = New System.Drawing.Size(13, 13)
        Me.daylabel.TabIndex = 66
        Me.daylabel.Text = "0"
        Me.daylabel.Visible = False
        '
        'minutelabel
        '
        Me.minutelabel.AutoSize = True
        Me.minutelabel.Location = New System.Drawing.Point(431, 89)
        Me.minutelabel.Name = "minutelabel"
        Me.minutelabel.Size = New System.Drawing.Size(13, 13)
        Me.minutelabel.TabIndex = 67
        Me.minutelabel.Text = "0"
        Me.minutelabel.Visible = False
        '
        'secondlabel
        '
        Me.secondlabel.AutoSize = True
        Me.secondlabel.Location = New System.Drawing.Point(450, 89)
        Me.secondlabel.Name = "secondlabel"
        Me.secondlabel.Size = New System.Drawing.Size(13, 13)
        Me.secondlabel.TabIndex = 68
        Me.secondlabel.Text = "0"
        Me.secondlabel.Visible = False
        '
        'ElapseTimer
        '
        Me.ElapseTimer.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 257)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(623, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(294, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Praegune toiming: Valmis"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(273, 360)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 73
        Me.ListBox1.Visible = False
        '
        'hideInfo
        '
        Me.hideInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hideInfo.Location = New System.Drawing.Point(2, 302)
        Me.hideInfo.Name = "hideInfo"
        Me.hideInfo.Size = New System.Drawing.Size(89, 24)
        Me.hideInfo.TabIndex = 75
        Me.hideInfo.Text = "Peida lisainfo"
        Me.hideInfo.UseVisualStyleBackColor = True
        Me.hideInfo.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(2, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 24)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "Näita lisainfot"
        Me.TipTip.SetToolTip(Me.Button3, "Kuvab lisainfot protsessi kohta")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(302, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "0% valmis"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'br
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(637, 328)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.hideInfo)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.secondlabel)
        Me.Controls.Add(Me.minutelabel)
        Me.Controls.Add(Me.daylabel)
        Me.Controls.Add(Me.hourlabel)
        Me.Controls.Add(Me.ElapsedLabel)
        Me.Controls.Add(Me.notelabel)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.RapidTextBox)
        Me.Controls.Add(Me.val)
        Me.Controls.Add(Me.max)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Other)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.YUMI)
        Me.Controls.Add(Me.Batch)
        Me.Controls.Add(Me.Windows)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "br"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "br"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mas As System.Windows.Forms.CheckBox
    Friend WithEvents Windows As System.Windows.Forms.CheckBox
    Friend WithEvents YUMI As System.Windows.Forms.CheckBox
    Friend WithEvents Batch As System.Windows.Forms.CheckBox
    Friend WithEvents Other As System.Windows.Forms.CheckBox
    Friend WithEvents Check As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents max As System.Windows.Forms.Label
    Friend WithEvents val As System.Windows.Forms.Label
    Friend WithEvents RapidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RapidLoad As System.Windows.Forms.Timer
    Friend WithEvents notelabel As System.Windows.Forms.Label
    Friend WithEvents ElapsedLabel As System.Windows.Forms.Label
    Friend WithEvents hourlabel As System.Windows.Forms.Label
    Friend WithEvents daylabel As System.Windows.Forms.Label
    Friend WithEvents minutelabel As System.Windows.Forms.Label
    Friend WithEvents secondlabel As System.Windows.Forms.Label
    Friend WithEvents ElapseTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents hideInfo As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TipTip As System.Windows.Forms.ToolTip
End Class
