Public Class frmformulationlist


    Sub formulationview()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblformulations order by Formulations", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("formID").ToString, i, dr.Item("Formulations").ToString)

        End While
        dr.Close()
        con.Close()
        rc1.Text = "Record Found.(" & DataGridView1.Rows.Count & ")"


    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        With frmformulation
            .btnupdates.Visible = False
            .txtformulation.Focus()
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave
        With frmformulation
            .txtformulation.Clear()
            .btnupdates.Visible = False
            .btnsave.Visible = True

        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Edit" Then
            With frmformulation
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtformulation.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                .btnsave.Visible = False
                .btnupdates.Visible = True
                .ShowDialog()

            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tblformulations WHERE  formID = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                formulationview()

            End If


        End If
    End Sub



    Sub Searchformu()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()

        ' Open database connection
        con.Open()

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM tblformulations WHERE Formulations LIKE @searchText"
        cmd = New SqlClient.SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@searchText", Productsearch.Text & "%")

        ' Execute the reader
        dr = cmd.ExecuteReader()
        While dr.Read()
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("formID").ToString(), dr.Item("Formulations").ToString())
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub

    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
        Searchformu()
    End Sub
End Class