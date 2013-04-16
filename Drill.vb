Public Class Drill
    Public Rows As List(Of Row)
    Public Steps As Integer

    Public Sub New()

        MyBase.New()

        Steps = 0
        Rows = New List(Of Row)

    End Sub

    Public Sub AddRow(ByVal Top As Integer)
        Steps += 1

        Dim newRow As New Row(Steps, LastOrDefaultTime(), Main.LeftMargin, Top)
        Rows.Add(newRow)
        Main.Controls.Add(newRow.RowPanel)

    End Sub

    Public Sub RemoveRow()

        If Steps > 0 Then
            Steps -= 1

            Main.Controls.Remove(NewestRow())
            Rows.Remove(Rows.Last())
        End If

    End Sub

    Public Function NewestRow() As Panel
        Return Rows.Last().RowPanel

    End Function

    Public Function LastOrDefaultTime() As Integer
        If Steps > 1 Then
            Return CInt(Rows.Last().RowSpinner.Value)
        Else
            Return 3
        End If
    End Function

End Class