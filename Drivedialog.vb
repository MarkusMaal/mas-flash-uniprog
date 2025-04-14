Imports System.Windows.Forms
Imports System.IO

Public Class Drivedialog
    Public manualmode As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.WindowState = FormWindowState.Minimized
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.WindowState = FormWindowState.Minimized
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Drivedialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        If File.Exists("A:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("A:")
        If File.Exists("B:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("B:")
        If File.Exists("C:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("C:")
        If File.Exists("D:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("D:")
        If File.Exists("E:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("E:")
        If File.Exists("F:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("F:")
        If File.Exists("G:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("G:")
        If File.Exists("H:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("H:")
        If File.Exists("I:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("I:")
        If File.Exists("J:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("J:")
        If File.Exists("K:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("K:")
        If File.Exists("L:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("L:")
        If File.Exists("M:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("M:")
        If File.Exists("N:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("N:")
        If File.Exists("O:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("O:")
        If File.Exists("P:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("P:")
        If File.Exists("Q:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("Q:")
        If File.Exists("R:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("R:")
        If File.Exists("S:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("S:")
        If File.Exists("T:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("T:")
        If File.Exists("U:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("U:")
        If File.Exists("V:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("V:")
        If File.Exists("W:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("W:")
        If File.Exists("X:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("X:")
        If File.Exists("Y:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("Y:")
        If File.Exists("Z:\E_INFO\edition.cmd") Then ComboBox1.Items.Add("Z:")
        If manualmode = True Then Me.Show()
        If manualmode = True Then Exit Sub
        If ComboBox1.Items.Count = 1 Then
            ComboBox1.SelectedIndex = 0
            Me.WindowState = FormWindowState.Minimized
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        If Not ComboBox1.Items.Count = 1 Then Me.WindowState = FormWindowState.Normal
    End Sub
End Class
