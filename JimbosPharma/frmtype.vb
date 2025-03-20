Public Class frmtype

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub


    Sub clear()
        txttype.Clear()
        txttype.Focus()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False

                ' Check for duplicate entry
                Using cmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblType WHERE Type = @Type", con)
                    cmd.Parameters.AddWithValue("@Type", txttype.Text)
                    con.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    found = (count > 0)
                End Using


                If Not found Then
                    ' Insert new generic
                    Using cmd As New SqlClient.SqlCommand("INSERT INTO tblType (Type) VALUES (@Type)", con)
                        cmd.Parameters.AddWithValue("@Type", txttype.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Type has been successfully saved.", vbInformation)
                    con.Close()
                    Me.Dispose()
                    With frmtypelist
                        .typeview()
                    End With
                Else
                    MsgBox("Error: Duplicate entry.", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub frmtype_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("update tblType set Type =  @Type where TypeID like @typeID", con)
                cmd.Parameters.AddWithValue("@Type", txttype.Text)
                cmd.Parameters.AddWithValue("@TypeID", lblID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Category has been successfully updated.", vbInformation)
            With frmtypelist
                .typeview()
                clear()

            End With
            Me.Dispose()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txttype_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub txttype_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If txttype.Text <> "" Then
            txttype.Text = ""
        End If
    End Sub

    Private Sub txttype_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        txttype.Clear()

    End Sub
End Class