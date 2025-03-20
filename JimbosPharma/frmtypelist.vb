Public Class frmtypelist


    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column4" Then
            With frmtype
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txttype.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()
            End With

        ElseIf colname = "Column5" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tblType where TypeID  = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                typeview()
            End If


        End If
    End Sub
    Sub typeview()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblType order by Type", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("TypeID").ToString, i, dr.Item("Type").ToString)   ' EDIT DELETE IF EVER NA MAY MAIINSERT NA BAGO SA ROW]
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataGridView1.RowCount & ") "

    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs)

        With frmtype
            .btnupdate.Enabled = False
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class