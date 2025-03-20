Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow
Imports System.Drawing.Printing

Public Class cashier

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        loginform.Show()
        Me.Close()

    End Sub

    Private Sub cashier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btnnewing_Click(sender, e)
            Case Keys.F2
                btbprodinqu_Click(sender, e)
            Case Keys.F3
                btndiscountan_Click(sender, e)
            Case Keys.F4
                btnset_Click(sender, e)
            Case Keys.F5
                btndaily_Click(sender, e)
            Case Keys.F6
                btnchangepass_Click(sender, e)
            Case Keys.F10
                btnlogouts_Click(sender, e)
        End Select
    End Sub

    Private Sub cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'Me.WindowState = FormWindowState.Maximized
        Panel1.Dock = DockStyle.Fill
        Timer2.Start()
        NotifyCriticalStock()


    End Sub


    Sub loadcart()
        Guna2DataGridView1.Rows.Clear()
        Dim _total As Double = 0, i As Integer = 0
        Try

            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New SqlCommand("select * from tblcart as ct inner join tblInventory as iv on ct.pid = iv.InventoryID inner join tblproduct as p on iv.id = p.id inner join tblcategory as c on p.cid =	c.catID inner join tblunit as un on p.uid = un.unitID where invoice like'" & lblinvoice.Text & "'", con)
            dr = cmd.ExecuteReader

            While dr.Read
                i += 1

                ' Add row with FullName and other fields, including img
                Guna2DataGridView1.Rows.Add(dr("id").ToString(), i, dr("InventoryID").ToString(), dr("id").ToString(), dr("invoice").ToString(), dr("item_des").ToString(), dr("qty").ToString(), dr("price").ToString(), dr.Item("total").ToString)
                _total += CDbl(dr.Item("total").ToString)


            End While

            con.Close()
            dr.Close()


            computesalesdetail(CDbl(_total))
            If Guna2DataGridView1.RowCount > 0 Then btnset.Enabled = True Else btnset.Enabled = False
            If Guna2DataGridView1.RowCount > 0 Then btndiscountan.Enabled = True Else btndiscountan.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub


    Sub computesalesdetail(ByVal _total As Double)
        lbltotal.Text = Format(_total, "#,##0.00")

        ' Calculate the subtotal
        lblsubtotal.Text = Format(CDbl(lbltotal.Text) - CDbl(lbldics.Text), "#,##0.00")
        frmsettle.SalesData.Subtotal = CDbl(lblsubtotal.Text) ' Store the subtotal value




        ' Calculate the VAT
        lblvat.Text = Format(CDbl(lblsubtotal.Text) * getvat(), "#,##0.00")
        frmsettle.SalesData.vat = CDbl(lblvat.Text) ' store the vat value


        ' Calculate the due amount to vat
        lbldue.Text = Format(CDbl(lblsubtotal.Text) + CDbl(lblvat.Text), "#,##0.00")

        ' Store the discount amount
        frmsettle.SalesData.Discount = CDbl(lbldics.Text) ' Store the discount amount

        lbldisplaytot.Text = lblsubtotal.Text
    End Sub



    Function getinvoiceNo() As String          ' A FUNCTION TO RETURN A STRING
        Dim invoiceNo As String = String.Empty ' Use a different name for the local variable

        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")     ' Gets the current date in "yyyyMMdd" format
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Open the connection and execute the query
            con.Open()
            cmd = New SqlClient.SqlCommand("SELECT TOP 1 invoice FROM tblcart WHERE invoice LIKE '%" & sdate & "%' ORDER BY id DESC", con) ' SQL to find the latest invoice
            dr = cmd.ExecuteReader
            dr.Read()

            ' Check if a row exists
            If dr.HasRows Then
                invoiceNo = dr.Item("invoice").ToString()
            Else
                invoiceNo = String.Empty
            End If
            dr.Close()
            con.Close()

            ' Generate a new invoice number if no rows exist
            If invoiceNo = String.Empty Then
                invoiceNo = sdate & "0001"
            Else
                invoiceNo = Trim((CLng(invoiceNo) + 1).ToString())
            End If

        Catch ex As Exception
            MsgBox("Error on getting invoice: " & ex.Message, vbCritical)
        Finally
            ' Close the connection in case it's still open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Return the invoice number
        Return invoiceNo
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick  '       LIVE DATE AND TIME
        lbldate.Text = Now.ToLongDateString
        lbltime.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Sub searchproduct(ByVal search As String)
        Try
            ' Exit if the search input is empty
            If String.IsNullOrWhiteSpace(search) Then
                MsgBox("Search input is empty.")
                Return
            End If

            ' Debugging - Confirm search input
            MsgBox("Searching for: " & search)

            ' Use the connection in a Using block
            Using con As New SqlConnection(Dbsql.connString)
                con.Open()

                ' SQL query with parameterized input
                Dim query As String = "select * from tblInventory as iv " &
                                      "inner join tblproduct as p on iv.id = p.id " &
                                      "WHERE barcode = @search"

                Using cmd As New SqlClient.SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                        ' Check if any rows are returned
                        If dr.Read() Then
                            MsgBox("Product found!")

                            ' Pass the retrieved values to frmqty
                            With frmqty
                                .lblprice.Text = dr("price").ToString()
                                .lblPid.Text = dr("InventoryID").ToString()
                                .ShowDialog()
                            End With
                        Else
                            MsgBox("No product found for the given barcode.", vbExclamation)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column13" Then
            If MsgBox("Remove this Item? Please confirm", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tblcart where id=" & Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                loadcart()
            End If
        End If
    End Sub


    Private Sub btnproduct_Click(sender As Object, e As EventArgs)
        'With frmproductinquiry
        '    .ProductInventoryCart()
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs)  ' CLICK TO SHOW DISCOUNT FORM
        'With frmdiscountcashier
        '    .GetDiscount()
        '    .ShowDialog()

        'End With
    End Sub




    Private Sub btndailysales_Click(sender As Object, e As EventArgs)
        With frmdailysales
            .loadsales()
            .ShowDialog()

        End With
    End Sub


    Sub ClearAfterPaid()
        lbldisplaytot.Text = "0.00"
        lbldics.Text = "0.00"
        lblvat.Text = "0.00"
        lblsubtotal.Text = "0.00"
        lbldue.Text = "0.00"

    End Sub



    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    tiktok.Text = Date.Now.ToString("hh:mm:ss")
    '    ampm.Text = Date.Now.ToString("tt")

    '    Guna2CircleProgressBar1.Value = Date.Now.ToString("ss")

    '    day.Text = Date.Now.ToString("dddd")
    '    calendar.Text = Date.Now.Date
    'End Sub


    'shortcut key SA BABA


    ' NEW TRANSACTION
    Private Sub btnnewing_Click(sender As Object, e As EventArgs) Handles btnnewing.Click

        If Guna2DataGridView1.RowCount > 0 Then Return ' IF may laman na sa datagrid di na mageexecute yung whole code if wala pang laman pedeng mag new uli
        lblinvoice.Text = getinvoiceNo() ' THIS LINE IS RETURNING A STRING TO UPDATE THE lblinvoice.text 
        btbprodinqu.Enabled = True
        txtsearch.Enabled = True
        txtsearch.Focus()
    End Sub

    ' PRODUCT INQUIRY
    Private Sub btbprodinqu_Click(sender As Object, e As EventArgs) Handles btbprodinqu.Click
        With frmproductinquiry
            .loadinventory()
            .ShowDialog()
        End With
    End Sub

    ' ADD DISCOUNT
    Private Sub btndiscountan_Click(sender As Object, e As EventArgs) Handles btndiscountan.Click
        With frmdiscountcashier
            .GetDiscount()
            .ShowDialog()

        End With
    End Sub

    ' SETTLE
    Private Sub btnset_Click(sender As Object, e As EventArgs) Handles btnset.Click
        With frmsettle
            .lbltotalitem.Text = lblsubtotal.Text     ' Para ilagay niya sa form yung total due 
            .ShowDialog()
        End With
    End Sub

    ' DAILY SALES
    Private Sub btndaily_Click(sender As Object, e As EventArgs) Handles btndaily.Click
        With frmdailysales
            .loadsales()
            .ShowDialog()

        End With


    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs)
        With frmchangepass
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub




    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        ' Check if the Enter key is pressed

        If e.KeyCode = Keys.Enter Then
            ' Call the search function with the full barcode
            searchproduct(txtsearch.Text)

            ' Prevent the beep sound when pressing Enter
            e.SuppressKeyPress = True
        End If
    End Sub




    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs)
        If Not frmstaffboard.Visible Then
            frmstaffboard.Show() ' Show the frmstaffboard form
        End If
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        With frmchangepass
            .ShowDialog()
        End With
    End Sub


    Private Sub btnreturningg_Click(sender As Object, e As EventArgs)
        frmstaffboard.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub lblvat_Click(sender As Object, e As EventArgs) Handles lblvat.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnlogouts_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnlogouts_Click_1(sender As Object, e As EventArgs) Handles btnlogouts.Click
        loginform.Show()

        Me.Dispose()

    End Sub

    Private Sub lblinvoice_Click(sender As Object, e As EventArgs) Handles lblinvoice.Click, lblcashier.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnreturns_Click(sender As Object, e As EventArgs)
        If Not frmstaffboard.Visible Then
            frmstaffboard.Show() ' Show the frmstaffboard form
        End If
        Me.Hide() ' Hide the current form
    End Sub

    Sub NotifyCriticalStock()
        Dim underStockCount As Integer = 0
        Dim outOfStockCount As Integer = 0

        Try

            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            ' Query to get details of under stock items
            cmd = New SqlClient.SqlCommand("SELECT p.item_des, iv.Quantity FROM tblInventory AS iv INNER JOIN tblproduct AS p ON iv.id = p.id WHERE (Quantity <= ReorderLevel AND Quantity > 0)", con)
            Dim underStockDr As SqlClient.SqlDataReader = cmd.ExecuteReader()

            ' Notify for under stock items
            While underStockDr.Read()
                Dim productName As String = underStockDr("item_des").ToString()
                Dim quantity As Integer = CInt(underStockDr("Quantity"))

                Dim popupNotifier As New Tulpep.NotificationWindow.PopupNotifier
                popupNotifier.TitleText = "Critical Stock Alert"
                popupNotifier.ContentText = String.Format("Critical Stock Alert: {0} - only {1} left in stock.", productName, quantity)
                popupNotifier.Delay = 5000 ' Show for 5 seconds
                popupNotifier.ShowCloseButton = True
                popupNotifier.Popup()
            End While
            underStockDr.Close()

            ' Query to get details of out-of-stock items
            cmd = New SqlClient.SqlCommand("SELECT p.item_des, iv.Quantity FROM tblInventory AS iv INNER JOIN tblproduct AS p ON iv.id = p.id WHERE Quantity = 0", con)
            Dim outOfStockDr As SqlClient.SqlDataReader = cmd.ExecuteReader()

            ' Notify for out of stock items
            While outOfStockDr.Read()
                Dim productName As String = outOfStockDr("item_des").ToString()

                Dim popupNotifier As New Tulpep.NotificationWindow.PopupNotifier
                popupNotifier.TitleText = "Out of Stock Alert"
                popupNotifier.ContentText = String.Format("Out of Stock Alert: {0} is currently unavailable.", productName)
                popupNotifier.Delay = 5000 ' Show for 5 seconds
                popupNotifier.ShowCloseButton = True
                popupNotifier.Popup()
            End While
            outOfStockDr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox("Error Notify Critical: " & ex.Message, vbCritical)
        Finally
            ' Close the connection in case it's still open
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        End Try
    End Sub
End Class