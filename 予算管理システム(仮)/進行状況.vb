Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports System.Data.SqlClient
Public Class 進行状況
    Private Sub 進行状況_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Private Sub Message2_Click(sender As Object, e As EventArgs) Handles WaitProcessText.Click

    'End Sub
    'Dim Bar As ProgressBar
    'Dim button As Button
    'Dim label As Label

    'Sub New()
    '    Bar = New ProgressBar()
    '    Bar.Location = New Point(10, 10)
    '    Bar.Step = 1


    '    label = New Label()
    '    label.Location = New Point(10, 40)
    '    label.AutoSize = True


    '    button = New Button()
    '    button.Location = New Point(10, 70)
    '    button.Text = "Start"


    '    AddHandler Me.Load, AddressOf エラー_Load
    '    AddHandler Me.button.Click, AddressOf Button_Click


    '    Me.Controls.Add(Bar)
    '    Me.Controls.Add(button)
    '    Me.Controls.Add(label)
    'End Sub
    'Private Sub エラー_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Bar.Minimum = 0
    '    Bar.Maximum = 10
    '    Bar.Value = 0


    '    label.Update()


    '    Dim i As Integer
    '    For i = 1 To 10
    '        ' 1秒待合せ
    '        Threading.Thread.Sleep(1000)

    '        Bar.PerformStep()


    '        label.Text = i.ToString()


    '        label.Update()
    '    Next


    '    label.Text = "完了しました。"
    'End Sub
End Class