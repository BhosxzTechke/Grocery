Public Class frmgeneric

    Sub clear()
        txtgeneric.Clear()
        txtgeneric.Focus()

    End Sub

    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@generic", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try



            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False

                ' Check for duplicate entry
                Using cmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblgeneric WHERE generic = @generic", con)
                    cmd.Parameters.AddWithValue("@generic", txtgeneric.Text)
                    con.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    found = (count > 0)
                End Using

                If Not found Then
                    ' Insert new generic
                    Using cmd As New SqlClient.SqlCommand("INSERT INTO tblgeneric (generic) VALUES (@generic)", con)
                        cmd.Parameters.AddWithValue("@generic", txtgeneric.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Generic has been successfully saved.", vbInformation)
                    clear()
                    con.Close()
                    Me.Close()
                    With frmgenerikalist
                        .genericview()
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





    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try

            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblgeneric WHERE generic = @generic", txtgeneric.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then



                con.Open()
                cmd = New SqlClient.SqlCommand("update tblgeneric set generic =  @generic where genericID like @genericID", con)
                cmd.Parameters.AddWithValue("@generic", txtgeneric.Text)
                cmd.Parameters.AddWithValue("@genericID", lblID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Generic has been successfully updated.", vbInformation)
            With frmgenerikalist
                .genericview()
            End With
            Me.Close()
        Catch ex As Exception
            con.Close()


        End Try
    End Sub

    Private Sub txtgeneric_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub txtgeneric_MouseClick(sender As Object, e As MouseEventArgs)
        If txtgeneric.Text <> "" Then
            txtgeneric.Text = ""

        End If
    End Sub

    Sub txtgeneric_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub txtgeneric_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class