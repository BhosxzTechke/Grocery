Public Class frmdiscountmodif


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If Walanglaman(txtdesc) = True Then Return
            If Walanglaman(txtdiscount) = True Then Return

            If ValidateDuplicateEntry("select * from tbldiscount where Description_disc like '" & txtdesc.Text & "'") = True Then Return

            con.Open()
            cmd = New SqlClient.SqlCommand("INSERT INTO  tbldiscount (Description_disc, Discount ) VALUES (@Description_disc, @Discount)", con)
            With cmd
                .Parameters.AddWithValue("@Description_disc", txtdesc.Text)
                .Parameters.AddWithValue("@Discount", txtdiscount.Text)
                .ExecuteNonQuery()


            End With
            con.Close()
            MsgBox("Discount has been succesfully saved.", vbInformation)
            With frmdiscount
                .loaddiscount()
                cleardiscount()
            End With



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Sub cleardiscount()
        txtdesc.Clear()
        txtdiscount.Clear()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If Walanglaman(txtdesc) = True Then Return
            If Walanglaman(txtdiscount) = True Then Return

            con.Open()
            cmd = New SqlClient.SqlCommand("UPDATE tbldiscount set Description_disc = @Description_disc, Discount=@Discount where ID like @ID", con)
            With cmd
                .Parameters.AddWithValue("@Description_disc", txtdesc.Text)
                .Parameters.AddWithValue("@Discount", CDbl(txtdiscount.Text))
                .Parameters.AddWithValue("@ID", lblid.Text)   '  NEED THIS IF IN THE SAME FORM
                .ExecuteNonQuery()


            End With
            con.Close()
            MsgBox("Discount has been succesfully saved.", vbInformation)
            With frmdiscount
                .loaddiscount()
                cleardiscount()
            End With

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub txtdiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' 0 - 9
            Case 46
            Case 8
            Case Else
                e.Handled = True


        End Select
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()

    End Sub
End Class