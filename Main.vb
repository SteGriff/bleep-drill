Imports Microsoft.VisualBasic.Devices

Public Class Main

    Dim theDrill As Drill
    Dim audio As Devices.Audio

    'Set to the title Left at Load
    Public LeftMargin As Integer = 0
    Dim VerticalPadding As Integer = 5

    Public Function InsertPoint() As Integer
        If theDrill.Steps > 0 Then
            Return BottomOf(theDrill.NewestRow)
        Else
            Return BottomOf(Me.BeginLabel)
        End If

    End Function

    Public Function BottomOf(ByVal control As Control) As Integer
        Return control.Top + control.Height + VerticalPadding
    End Function

    Public Sub Reposition(ByVal aControl As Control, ByVal theDrill As Drill)
        aControl.Left = LeftMargin
        aControl.Top = InsertPoint()

    End Sub

    Public Sub FixEndLabel()
        If RepeatForever.Checked Then
            EndLabel.Text = "...forever."
        Else
            EndLabel.Text = "..." + RepeatSpinner.Value.ToString() + " times, then play the Finish tone."
        End If

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LeftMargin = BeginLabel.Left
        GoLabel.Visible = False

        theDrill = New Drill
        audio = New Devices.Audio()

        Reposition(ToolsPanel, theDrill)
        FixEndLabel()

    End Sub

    Private Sub AddAnother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAnother.Click
        theDrill.AddRow(InsertPoint())
        Reposition(ToolsPanel, theDrill)

    End Sub

    Private Sub RemoveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveRow.Click
        theDrill.RemoveRow()
        Reposition(ToolsPanel, theDrill)

    End Sub

    Enum SoundType
        Begin
        Bleep
        Finish
    End Enum

    Public Sub PlaySound(ByVal soundType As SoundType)
        Dim audioHost As New Audio
        Dim audioFileName As String = "Bleep.wav"
        Dim async As AudioPlayMode = AudioPlayMode.Background

        Select Case soundType
            Case Main.SoundType.Begin
                audioFileName = "Begin.wav"
            Case Main.SoundType.Bleep
                audioFileName = "Bleep.wav"
            Case Main.SoundType.Finish
                audioFileName = "Finish.wav"
        End Select

        Try
            audioHost.Play(audioFileName, async)
        Catch
            audioHost.PlaySystemSound(Media.SystemSounds.Asterisk)
        End Try

    End Sub

    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        Go()

    End Sub

    Sub Go()

        Dim ticker As New Stopwatch()

        PlaySound(SoundType.Begin)
        GoLabel.Visible = True
        Me.Refresh()

        If RepeatForever.Checked = True Then
            Do
                OneCycle(ticker)
            Loop
        Else
            For i As Integer = 1 To CInt(RepeatSpinner.Value)
                OneCycle(ticker)
            Next
        End If

        System.Threading.Thread.Sleep(1000)
        PlaySound(SoundType.Finish)
        GoLabel.Visible = False

    End Sub

    Sub OneCycle(ByVal ticker As Stopwatch)

        For Each thisRow As Row In theDrill.Rows
            Dim Milliseconds As Integer = CInt(thisRow.RowSpinner.Value) * 1000
            System.Threading.Thread.Sleep(Milliseconds)
            PlaySound(SoundType.Bleep)
        Next

    End Sub

    Private Sub RepeatForever_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeatForever.CheckedChanged
        FixEndLabel()

    End Sub

    Private Sub RepeatSpinner_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeatSpinner.ValueChanged
        FixEndLabel()

    End Sub
End Class
