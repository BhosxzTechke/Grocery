Imports System.Data.SqlClient

Public Class frmdosage

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False

                ' Check for duplicate entry
                Using cmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM tbldosage WHERE Dosage = @Dosage", con)
                    cmd.Parameters.AddWithValue("@Dosage", txtdosage.Text)
                    con.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    found = (count > 0)
                End Using


                If Not found Then
                    ' Insert new generic
                    Using cmd As New SqlClient.SqlCommand("INSERT INTO tbldosage (Dosage) VALUES (@Dosage)", con)
                        cmd.Parameters.AddWithValue("@Dosage", txtdosage.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Generic has been successfully saved.", vbInformation)
                    con.Close()
                    With frmdosagelist
                        .loaddosage()
                    End With
                    Me.Close()

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
    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Dosage", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tbldosage WHERE Dosage = @Dosage", txtdosage.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            If MsgBox("Are you sure you want to Update?", vbYesNo + vbQuestion) + vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Update tbldosage set Dosage = @dosage where dosageID like @dosageID", con)
                cmd.Parameters.AddWithValue("@dosageID", lblid.Text)
                cmd.Parameters.AddWithValue("@dosage", txtdosage.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Dosage has been successfully updated.", vbInformation)
            With frmdosagelist
                .loaddosage()
                'clear()

            End With
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_KeyDown(sender As Object, e As KeyEventArgs) Handles btnupdate.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True ' Prevent the 'ding' sound
        '    btnsave.PerformClick() ' Simulate a click on the save button
        'End If
    End Sub

    Private Sub frmdosage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True ' Prevent the 'ding' sound
        '    btnsave.PerformClick() ' Simulate a click on the save button
        'End If

    End Sub

    Private Sub txtdosage_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub lblid_Click(sender As Object, e As EventArgs) Handles lblid.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class