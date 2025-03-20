Public Class frmvat

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            con.Open()
            cmd = New SqlClient.SqlCommand("Select count(*) from tblVat", con)
            Dim icount As Integer = CInt(cmd.ExecuteScalar)
            con.Close()

            If icount > 0 Then
                con.Open()
                cmd = New SqlClient.SqlCommand("UPDATE tblVat set vat ='" & CDbl(txtvat.Text) & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                cmd = New SqlClient.SqlCommand("Insert into tblVat (vat) values( '" & CDbl(txtvat.Text) & "')", con)
                cmd.ExecuteNonQuery()

            End If

            MsgBox("VAT has been succesfully saved.", vbInformation)



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub txtvat_TextChanged(sender As Object, e As EventArgs) Handles txtvat.TextChanged

    End Sub

    Private Sub frmvat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()

    End Sub
End Class