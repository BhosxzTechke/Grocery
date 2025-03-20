Imports System.Data.SqlClient

Public Class frmgenericlist


    Sub genericview()
        Dim i As Integer = 0
        DataView.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblgeneric order by generic", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataView.Rows.Add(dr.Item("genericID").ToString, i, dr.Item("generic").ToString)   ' EDIT DELETE IF EVER NA MAY MAIINSERT NA BAGO SA ROW]
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataView.RowCount & ") "

    End Sub

    Private Sub frmgenericlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genericview()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub



    Sub Searchgeneric()
        Dim i As Integer = 0
        DataView.Rows.Clear()

        ' Open database connection
        con.Open()

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM tblgeneric WHERE generic LIKE @searchText"
        cmd = New SqlClient.SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@searchText", genericsearch.Text & "%")

        ' Execute the reader
        dr = cmd.ExecuteReader()
        While dr.Read()
            i += 1
            DataView.Rows.Add(i, dr.Item("genericID").ToString(), dr.Item("generic").ToString())
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub



    Private Sub genericsearch_TextChanged_1(sender As Object, e As EventArgs) Handles genericsearch.TextChanged
        Searchgeneric()

    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        With frmgeneric
            .btnupdate.Visible = False
            .txtgeneric.Focus()
            .ShowDialog()
        End With
    End Sub



    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs)
        With frmgeneric
            .txtgeneric.Clear()
            .btnupdate.Visible = False
            .btnsave.Visible = True

        End With
    End Sub


    Private Sub DataView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim colname As String = DataView.Columns(e.ColumnIndex).Name

        If colname = "Edit" Then
            With frmgeneric
                .lblID.Text = DataView.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtgeneric.Text = DataView.Rows(e.RowIndex).Cells(2).Value.ToString()
                .btnupdate.Visible = True
                .btnsave.Visible = False
                .ShowDialog()
            End With

        ElseIf colname = "Delete" Then
            If MsgBox("Are you sure you want to delete", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("DELETE FROM tblgeneric WHERE genericID = " & DataView.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                genericview()
            End If
        End If
    End Sub
End Class