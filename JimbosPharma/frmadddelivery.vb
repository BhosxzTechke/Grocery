Public Class frmadddelivery

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

    End Sub

    Private Sub frmadddelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True    'When KeyPreview is set to True, the form's KeyPress, KeyDown, and KeyUp events will be raised before the same events occur for the active control on the form.

    End Sub

    Private Sub frmadddelivery_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                With dashboard

                End With
                Me.Dispose()
        End Select


  

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BranCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranCBx.SelectedIndexChanged
































    End Sub

    Private Sub txtref_TextChanged(sender As Object, e As EventArgs) Handles txtref.TextChanged

    End Sub
End Class