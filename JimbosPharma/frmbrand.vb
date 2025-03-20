Public Class frmbrand

    Sub clear()
        txtbrand.Clear()
        txtbrand.Focus()


    End Sub


    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@brand", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function


    Private Sub txtbrand_MouseClick(sender As Object, e As MouseEventArgs)
        If txtbrand.Text <> "" Then
            txtbrand.Text = ""
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

 
    Private Sub frmbrand_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim btnctrl As New DataGridViewButtonColumn
        btnctrl.FlatStyle = FlatStyle.Flat
        btnctrl.CellTemplate.Style.BackColor = System.Drawing.Color.Green

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub txtbrand_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' Validate input
            If String.IsNullOrWhiteSpace(txtbrand.Text) Then
                MsgBox("Brand cannot be empty.", vbExclamation)
                Return
            End If

            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblbrand WHERE brand = @brand", txtbrand.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            ' Confirm save
            If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbNo Then
                Return
            End If

            ' Insert new brand
            Using cmd As New SqlClient.SqlCommand("INSERT INTO tblbrand (brand) VALUES (@brand)", con)
                cmd.Parameters.AddWithValue("@brand", txtbrand.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MsgBox("Brand has been successfully saved.", vbInformation)
            clear()
            Me.Close()
            With frmbrandlist
                .brandview()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub

    Private Sub btnupdate_Click_1(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try


            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblbrand WHERE brand = @brand", txtbrand.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()

                cmd = New SqlClient.SqlCommand("update tblbrand set brand =  @brand where brandID like @brandID", con)
                cmd.Parameters.AddWithValue("@brand", txtbrand.Text)
                cmd.Parameters.AddWithValue("@brandID", lblID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Brand has been successfully updated.", vbInformation)
            With frmbrandlist
                .brandview()
                'clear()

            End With
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txtbrand_TextChanged(sender As Object, e As EventArgs) Handles txtbrand.TextChanged

    End Sub
End Class