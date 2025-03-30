Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports JimbosPharma.loginform
Imports Guna.UI2.WinForms




Public Class frmproductlists

    Private Sub frmproductlists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prodrecord()
        dataprod.AlternatingRowsDefaultCellStyle = dataprod.RowsDefaultCellStyle


    End Sub

    'dropdownunit(frmproduct) ' ✅ Load the dropdown first


    Private Sub dataprod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataprod.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim colname As String = dataprod.Columns(e.ColumnIndex).Name

        ' ✅ Edit Product
        If colname = "Edit" Then
            ' ✅ Close existing instance if open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is frmproduct Then
                    frm.Close()
                    Exit For
                End If
            Next

            ' ✅ Open new instance of frmproduct
            Dim productForm As New frmproduct()
            productForm.isEditing = True  ' 🔥 Editing mode

            ' ✅ Assign values safely
            Dim catIdValue As Object = dataprod.Rows(e.RowIndex).Cells("catID").Value
            productForm.categorycbx.SelectedValue = If(catIdValue IsNot Nothing, catIdValue, -1)

            Dim unitIDValue As Object = dataprod.Rows(e.RowIndex).Cells("UnitID").Value
            productForm.unitcbx.SelectedValue = If(unitIDValue IsNot Nothing, unitIDValue, -1)

            ' ✅ Other fields
            productForm.lblid.Text = dataprod.Rows(e.RowIndex).Cells("Column2").Value.ToString()
            productForm.txtbarcode.Text = dataprod.Rows(e.RowIndex).Cells("Barcode").Value.ToString()
            productForm.itemdes.Text = dataprod.Rows(e.RowIndex).Cells("Description").Value.ToString()
            productForm.txtcost.Text = dataprod.Rows(e.RowIndex).Cells("CostPrice").Value.ToString()
            productForm.txtsales.Text = dataprod.Rows(e.RowIndex).Cells("SalesPrice").Value.ToString()

            ' ✅ Load Image safely
            Try
                If Not IsDBNull(dataprod.Rows(e.RowIndex).Cells("ProductImage").Value) Then
                    productForm.PictureBox1.Image = CType(dataprod.Rows(e.RowIndex).Cells("ProductImage").Value, Image)
                Else
                    productForm.PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
                productForm.PictureBox1.Image = Nothing
            End Try

            ' ✅ Show update button, hide save button
            productForm.btnupdate.Visible = True
            productForm.btnsave.Visible = False

            ' ✅ Open as Modal Dialog
            productForm.ShowDialog()

        ElseIf colname = "Delete" Then
            ' ✅ Configure Guna2MessageDialog for delete confirmation
            Guna2MessageDialog1.Parent = Me ' 🔥 Ensures centering
            Guna2MessageDialog1.Buttons = MessageDialogButtons.YesNo
            Guna2MessageDialog1.Icon = MessageDialogIcon.Question
            Guna2MessageDialog1.Style = MessageDialogStyle.Dark
            Guna2MessageDialog1.Caption = "Confirm Deletion"
            Guna2MessageDialog1.Text = "Are you sure you want to delete this record?"

            ' ✅ Show the confirmation dialog
            If Guna2MessageDialog1.Show() = DialogResult.Yes Then
                Dim productID As String = dataprod.Rows(e.RowIndex).Cells("Column2").Value.ToString()

                ' ✅ Fetch the old product details before deletion
                Dim oldValue As String = ""
                Try
                    con.Open()
                    Dim fetchQuery As String = "SELECT barcode, item_des, price, costprice FROM tblproduct WHERE id = @id"
                    Dim fetchCmd As New SqlCommand(fetchQuery, con)
                    fetchCmd.Parameters.AddWithValue("@id", productID) ' 🔥 Fixed parameter name
                    Dim reader As SqlDataReader = fetchCmd.ExecuteReader()

                    If reader.Read() Then
                        oldValue = "ID: " & productID & _
                                   ", Barcode: " & reader("barcode").ToString() & _
                                   ", Description: " & reader("item_des").ToString() & _
                                   ", Price: " & reader("price").ToString() & _
                                   ", Cost Price: " & reader("costprice").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error fetching old data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

                ' ✅ Insert audit log for delete action
                Try
                    con.Open()
                    Dim auditQuery As String = "INSERT INTO AuditLog (UserID, Action, TableName, RecordID, OldValue, NewValue, Timestamp) " & _
                                               "VALUES (@UserID, @Action, @TableName, @RecordID, @OldValue, @NewValue, GETDATE())"
                    Dim auditCmd As New SqlCommand(auditQuery, con)
                    auditCmd.Parameters.AddWithValue("@UserID", GlobalUser.UserId)
                    auditCmd.Parameters.AddWithValue("@Action", "DELETE")
                    auditCmd.Parameters.AddWithValue("@TableName", "tblproduct")
                    auditCmd.Parameters.AddWithValue("@RecordID", productID)
                    auditCmd.Parameters.AddWithValue("@OldValue", oldValue)
                    auditCmd.Parameters.AddWithValue("@NewValue", "Record Deleted")
                    auditCmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error logging audit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

                ' ✅ Delete the product
                Try
                    con.Open()
                    Dim deleteCmd As New SqlCommand("DELETE FROM tblproduct WHERE id = @id", con)
                    deleteCmd.Parameters.AddWithValue("@id", productID)
                    deleteCmd.ExecuteNonQuery()
                    con.Close()

                    ' ✅ Configure Guna2MessageDialog for success message
                    Guna2MessageDialog1.Parent = Me ' 🔥 Ensures centering
                    Guna2MessageDialog1.Buttons = MessageDialogButtons.OK
                    Guna2MessageDialog1.Icon = MessageDialogIcon.Information
                    Guna2MessageDialog1.Style = MessageDialogStyle.Dark
                    Guna2MessageDialog1.Caption = "Deleted Successfully"
                    Guna2MessageDialog1.Text = "The product has been successfully deleted."

                    ' ✅ Show success dialog
                    Guna2MessageDialog1.Show()

                    ' ✅ Refresh DataGridView
                    prodrecord()
                Catch ex As Exception
                    MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub



    Sub prodrecord()
        Dim i As Integer = 0
        dataprod.Rows.Clear()

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim query As String = "SELECT p.id, p.barcode, p.item_des, p.price, p.costprice, p.imagepath, " & _
                                  "c.catID, c.Category AS Category, " & _
                                  "u.unitID, u.unit " & _
                                  "FROM tblproduct AS p " & _
                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " & _
                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID"

            cmd = New SqlClient.SqlCommand(query, con)
            dr = cmd.ExecuteReader()

            While dr.Read()
                i += 1

                ' ✅ Load Image Safely
                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) AndAlso dr("imagepath") IsNot Nothing Then
                    Try
                        Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                        If imgData.Length > 0 Then img = ByteArrayToImage(imgData)
                    Catch ex As Exception
                        img = Nothing ' Default image
                    End Try
                End If

                ' ✅ Handle DBNull values correctly
                Dim barcode As String = If(IsDBNull(dr("barcode")), String.Empty, dr("barcode").ToString())
                Dim itemDes As String = If(IsDBNull(dr("item_des")), String.Empty, dr("item_des").ToString())

                ' ✅ Add Category ID and Name
                Dim categoryID As String = If(IsDBNull(dr("catID")), String.Empty, dr("catID").ToString()) ' Category ID
                Dim categoryName As String = If(IsDBNull(dr("Category")), String.Empty, dr("Category").ToString()) ' Category Name

                ' ✅ Add Unit ID and Name
                Dim unitID As String = If(IsDBNull(dr("unitID")), String.Empty, dr("unitID").ToString()) ' Unit ID
                Dim unitName As String = If(IsDBNull(dr("unit")), String.Empty, dr("unit").ToString()) ' Unit Name

                Dim costprice As String = If(IsDBNull(dr("costprice")), "0.00", Convert.ToDecimal(dr("costprice")).ToString("#,##0.00"))
                Dim price As String = If(IsDBNull(dr("price")), "0.00", Convert.ToDecimal(dr("price")).ToString("#,##0.00"))

                ' ✅ Ensure the column count matches DataGridView
                dataprod.Rows.Add(i, dr("id").ToString(), img, barcode, itemDes, categoryID, categoryName, unitID, unitName, costprice, price)
            End While

            ' ✅ Set Row Height
            For Each r As DataGridViewRow In dataprod.Rows
                r.Height = 40
            Next

            ' ✅ Display Record Count
            rc1.Text = "Record Found: (" & dataprod.RowCount & ")"

        Catch ex As Exception
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace, vbCritical)
        Finally
            ' ✅ Ensure resources are properly closed
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub




    '' 📌 Clear Controls Before Fetching Data
    'Private Sub ClearsControls()
    '    With frmproduct
    '        .txtbarcode.Clear()
    '        .itemdes.Clear()
    '        .txtcost.Clear()
    '        .txtsales.Clear()
    '        .lblclass.Text = ""
    '        .unitid.Text = ""
    '        .categorycbx.SelectedIndex = -1
    '        .unitcbx.SelectedIndex = -1
    '        .PictureBox1.Image = Nothing
    '    End With
    'End Sub


    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        ' Check if byteArray is valid and has data
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then
            Return Nothing
        End If

        Try
            Using ms As New MemoryStream(byteArray)
                Dim originalImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

                ' Resize the image to specific dimensions, e.g., 100x130 pixels
                Dim resizedImage As New Bitmap(100, 130) ' Adjust the width and height as needed
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(originalImage, 0, 0, 100, 130) ' Draw the image at specified size
                End Using

                Return resizedImage
            End Using
        Catch ex As ArgumentException
            ' Handle invalid image format
            Return Nothing
        End Try
    End Function


    Private Sub frmproductlists_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        With frmproduct
            .txtbarcode.Clear()
            .txtsales.Clear()
            .itemdes.Clear()

            .PictureBox1.Image = Nothing

            .btnsave.Visible = True
            .btnupdate.Visible = False
            .categorycbx.SelectedIndex = -1
            .unitcbx.SelectedIndex = -1


            'categorycbx.SelectedIndex = -1
            'unitcbx.SelectedIndex = -1
        End With
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        Dim frm As New frmproduct()
        frm.ActiveControl = frm.txtbarcode ' Set focus to txtbarcode
        frm.btnsave.Visible = True
        frm.ShowDialog()
    End Sub


    Sub SearchBarcode()
        Try
            Dim i As Integer = 0
            dataprod.Rows.Clear() ' Clear existing rows in DataGridView

            ' Open database connection
            If con.State = ConnectionState.Closed Then con.Open()

            ' Define query
            Dim query As String = "SELECT p.id, p.imagepath, p.barcode, p.item_des, " &
                                  "c.Category, u.unit, p.costprice, p.price " &
                                  "FROM tblproduct AS p " &
                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID " &
                                  "WHERE p.barcode LIKE @barcode or p.item_des LIKE @item_des"


            ' Create SQL command and parameters
            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = "%" & Productsearch.Text.Trim() & "%"
            cmd.Parameters.Add("@item_des", SqlDbType.VarChar).Value = "%" & Productsearch.Text.Trim() & "%"

            ' Execute reader
            dr = cmd.ExecuteReader()

            ' Process data
            While dr.Read()
                i += 1


                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) AndAlso dr("imagepath") IsNot Nothing Then
                    Try
                        Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                        If imgData.Length > 0 Then img = ByteArrayToImage(imgData)
                    Catch ex As Exception
                        img = Nothing ' Default image
                    End Try
                End If

                ' Handle costPrice and price
                Dim costPrice As Decimal = If(IsDBNull(dr("costprice")), 0, Convert.ToDecimal(dr("costprice")))
                Dim price As Decimal = If(IsDBNull(dr("price")), 0, Convert.ToDecimal(dr("price")))

                ' Add row to DataGridView
                dataprod.Rows.Add(i,
                                      dr("id").ToString(),
                                      img,
                                      dr("barcode").ToString(),
                                      dr("item_des").ToString(),
                                      dr("Category").ToString(),
                                      dr("unit").ToString(),
                                      costPrice.ToString("C2"),
                                      price.ToString("C2"))


            End While


            ' Adjust row height and auto-size columns
            For Each r As DataGridViewRow In dataprod.Rows
                r.Height = 40
            Next
            dataprod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dr.Close()

        Catch ex As Exception
            ' Display error message
            MsgBox("Error: {ex.Message}", vbCritical, "Search Error")
        Finally
            ' Ensure connection is closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    'Private Sub Productsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Productsearch.KeyDown
    '    SearchBarcode()

    'End Sub

    'Private Sub ClearControls()
    '    ' Clear TextBox controls
    '    frmproduct.txtbarcode.Clear()
    '    frmproduct.itemdes.Clear()
    '    frmproduct.txtcost.Clear()
    '    frmproduct.txtsales.Clear()

    '    ' Clear ComboBox controls
    '    frmproduct.categorycbx.SelectedIndex = -1
    '    frmproduct.unitcbx.SelectedIndex = -1

    '    ' Clear PictureBox controls
    '    frmproduct.PictureBox1.Image = Nothing
    '    frmproduct.picbarcode.Text = String.Empty

    '    ' Clear any other controls if needed
    '    ' frmproduct.txtgeneric.Clear()
    '    ' frmproduct.brandcbx.SelectedIndex = -1
    'End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
        SearchBarcode()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub dataprod_Leave(sender As Object, e As EventArgs) Handles dataprod.Leave
        frmproduct.categorycbx.SelectedIndex = -1

    End Sub
End Class