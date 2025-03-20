Public Class frmdiscountcashier

    Private Sub frmdiscountcashier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub frmdiscountcashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub

    Private Sub cboDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDescrip.KeyPress
        e.Handled = True

    End Sub

    Sub GetDiscount()              ' ILALAGAY NIYA UNG VALUE NA DESCRIPTION SA COMBOBOX
        cboDescrip.Items.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tbldiscount", con)
        dr = cmd.ExecuteReader
        While dr.Read
            cboDescrip.Items.Add(dr.Item(1).ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub cboDescrip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDescrip.SelectedIndexChanged
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tbldiscount where Description_disc like '" & cboDescrip.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then txtdiscount.Text = dr.Item(2).ToString Else txtdiscount.Text = 0
        dr.Close()      ' ILALAGAY UNG VALUE NA PIPILIIN NATIN SA COMBOBOX NA MAGMAMATCH SA DR.ITEM 2 WHICH IS SI DISCOUNT SA DATABASE
        con.Close()


    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If Walanglaman(cboDescrip) = True Then Return ' IF WALANG LAMAN SI DESCRIPTION MAG WAWARNING
        With cashier
            Dim discount As Double
            discount = CDbl(.lbltotal.Text) * CDbl(txtdiscount.Text)
            .lbldics.Text = Format(discount, "#,##0.00")
            .loadcart()
            Me.Dispose()

        End With
    End Sub
    ' THEN DITO IS KAPAG CINLICK NANATIN SI SELECT WHICH IS ITATIMES SA TOTAL NA GALING SA CASHIER SA DISCOUNT NA NAPILI SA TEXTBOX
    'THEN LALAGYAN NIYA NA NG FORMAT SI LABEL DISCOUNT

End Class

