Imports System.Data.SqlClient


Public Class frmdosagelist
    Sub loaddosage()
        Dim i As Integer = 0
        DataView.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tbldosage order by Dosage", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            i += 1
            DataView.Rows.Add(dr.Item("dosageID").ToString, i, dr.Item("Dosage").ToString)
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataView.RowCount & ") "


    End Sub


    Private Sub btnew_Click(sender As Object, e As EventArgs)
        With frmdosage
            .btnsave.Visible = True
            .btnupdate.Visible = False
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnew_Click_1(sender As Object, e As EventArgs) Handles btnew.Click
        With frmdosage
            .btnupdate.Visible = False
            .txtdosage.Focus()
            .ShowDialog()
        End With
    End Sub
    Sub SearchDOS()
        Dim i As Integer = 0
        DataView.Rows.Clear()

        ' Open database connection
        con.Open()

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM tbldosage WHERE Dosage LIKE @searchText"
        cmd = New SqlClient.SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@searchText", Productsearch.Text & "%")

        ' Execute the reader
        dr = cmd.ExecuteReader()
        While dr.Read()
            i += 1
            DataView.Rows.Add(i, dr.Item("dosageID").ToString(), dr.Item("Dosage").ToString())
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub

    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
        SearchDOS()
    End Sub

    Private Sub frmdosagelist_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaddosage()
    End Sub

    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim colname As String = DataView.Columns(e.ColumnIndex).Name

        If colname = "Edit" Then
            With frmdosage
                .lblid.Text = DataView.Rows(e.RowIndex).Cells(0).Value.ToString
                .txtdosage.Text = DataView.Rows(e.RowIndex).Cells(2).Value.ToString
                .btnsave.Visible = False
                .btnupdate.Visible = True
                .ShowDialog()
            End With

        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to Delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tbldosage where dosageID=" & DataView.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been succesfully Deleted", vbInformation)
                loaddosage()
            End If

        End If

    End Sub

    Private Sub DataView_Leave(sender As Object, e As EventArgs) Handles DataView.Leave
        With frmdosage
            .txtdosage.Clear()
            .btnupdate.Visible = False
            .btnsave.Visible = True

        End With
    End Sub
End Class
