Public Class Form3
    Private size_cells As Integer = 5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If size_cells < 30 Then
            size_cells += 1
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                For j As Integer = 0 To DataGridView1.RowCount - 1
                    DataGridView1.Columns(i).Width = size_cells
                    DataGridView1.Rows(j).Height = size_cells
                Next
            Next
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If size_cells > 3 Then
            size_cells -= 1
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                For j As Integer = 0 To DataGridView1.RowCount - 1
                    DataGridView1.Columns(i).Width = size_cells
                    DataGridView1.Rows(j).Height = size_cells
                Next
            Next
        End If
    End Sub
End Class