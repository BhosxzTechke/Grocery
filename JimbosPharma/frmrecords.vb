Imports System.IO

Public Class frmrecords

    'Sub stockinventory()
    '    Try
    '        Dim i As Integer, total As Double
    '        Guna2DataGridView1.Rows.Clear()
    '        con.Open()
    '        cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID  inner join tblcategory as c on p.cid =	c.id inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = T.TypeID inner join tblSupplier as sp on p.sid = sp.SupplierID where qty > 0 and " & cbofilter.Text & " like '" & txtsearch.Text & "%'", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            i += 1
    '            total += CInt(dr.Item("qty").ToString)
    '            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("CompanyName").ToString, dr.Item("qty").ToString)
    '        End While

    '        dr.Close()
    '        cmd = Nothing
    '        con.Close()
    '        lblstock.Text = "Record count : " & Guna2DataGridView1.Rows.Count & vbTab & " Available Stock(s): " & total

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try


    'End Sub



    Sub SalesInventory()
        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Guna2DataGridView3.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'  order by id", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView3.Rows.Add(i, dr.Item("invoice").ToString, dr.Item("subtotal").ToString, dr.Item("vat").ToString, dr.Item("discount").ToString, dr.Item("amountdue").ToString, Format(CDate(dr.Item("sdate").ToString), "MM-dd-yyyy"), dr.Item("users").ToString)

        End While
        dr.Close()
        con.Close()

        lblsalesinvent.Text = "Record Count: " & Format(Guna2DataGridView3.RowCount _
                    & Space(10) & "Sub total: " & Format(GetTotalData("Select ISNULL(sum(subtotal),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "VATable: " & Format(GetTotalData("Select ISNULL(sum(vat),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "Discount: " & Format(GetTotalData("Select ISNULL(sum(discount),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "Total: " & Format(GetTotalData("Select ISNULL(sum(amountdue),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00"))

        lbltotaldue.Text = "Total : " & Format(GetTotalData("Select ISNULL(sum(amountdue),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00")
    End Sub
    Function GetTotalData(ByVal sql As String) As Double
        con.Open()
        cmd = New SqlClient.SqlCommand(sql, con)
        GetTotalData = CDbl(cmd.ExecuteScalar)
        con.Close()
        Return GetTotalData
    End Function


    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        SalesInventory()
    End Sub






    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub cbofilter_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs)
        'If Walanglaman(txtsearch) = True Then Return
        'If Walanglaman(cbofilter) = True Then Return
        'stockinventory()

    End Sub

    Private Sub cboselect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboselect.KeyPress
        e.Handled = True
    End Sub







    '                                               FOR CRITICAL STOCK UNDER STOCK / OUT OF STOCK
    Private Sub cboselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboselect.SelectedIndexChanged
        CriticalStock()

    End Sub

    Sub CriticalStock()       ' FOR CRITICAL STOCK UNDER STOCK / OUT OF STOCK
        Guna2DataGridView2.Rows.Clear()
        Dim i As Integer = 0
        Dim total As Double = 0

        con.Open()

        If Walanglaman(cboselect) = True Then
            con.Close()
            Return
        End If

        If cboselect.Text = "Under Stock" Then
            cmd = New SqlClient.SqlCommand("select * from tblInventory as iv inner join tblproduct as p on iv.id = p.id inner join tblcategory as c on p.cid = c.catID where (Quantity <= ReorderLevel and Quantity > 0)", con)

        ElseIf cboselect.Text = "Out of Stock" Then
            cmd = New SqlClient.SqlCommand("select * from tblInventory as iv inner join tblproduct as p on iv.id = p.id inner join tblcategory as c on p.cid = c.catID where Quantity = 0", con)
        End If

        dr = cmd.ExecuteReader

        While dr.Read
            i += 1
            total += CInt(dr.Item("Quantity").ToString)
            Guna2DataGridView2.Rows.Add(i, dr.Item("InventoryID").ToString, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("item_des").ToString, dr.Item("Category").ToString, dr.Item("ReorderLevel").ToString, dr.Item("Quantity").ToString)
        End While

        dr.Close()
        cmd = Nothing
        con.Close()
        cs1.Text = "Record count : " & Format(CLng(Guna2DataGridView2.Rows.Count), "#,##0")


    End Sub



    Sub SoldItem()
        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker4.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker3.Value.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT ca.pid, " & _
                              "(ISNULL(p.item_des, '') + ' - ' + ISNULL(c.Category, '') + ' - ' + ISNULL(un.unit, '')) AS item_details, " & _
                              "SUM(ca.qty) as qty " & _
                              "FROM tblcart as ca " & _
                              "INNER JOIN tblInventory as inv ON ca.pid = inv.InventoryID " & _
                              "INNER JOIN tblproduct as p ON inv.id = p.id " & _
                              "INNER JOIN tblcategory as c ON p.cid = c.catID " & _
                              "INNER JOIN tblunit as un ON p.uid = un.unitID " & _
                              "WHERE ca.sdate BETWEEN @date1 AND @date2 AND ca.status = 'Sold' " & _
                              "GROUP BY ca.pid, p.item_des, c.Category, un.unit"

        Guna2DataGridView4.Rows.Clear()

        Try
            con.Open()
            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@date1", date1)
            cmd.Parameters.AddWithValue("@date2", date2)

            dr = cmd.ExecuteReader()
            While dr.Read
                i += 1
                Guna2DataGridView4.Rows.Add(i, dr.Item("pid").ToString, dr.Item("item_details").ToString, dr.Item("qty").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub



    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        SoldItem()
    End Sub




    Sub ExpiredItem()
        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker6.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker5.Value.ToString("yyyy-MM-dd")

        Guna2DataGridView5.Rows.Clear()

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query As String = "SELECT * FROM tblDeliveryLineItem as div INNER JOIN tbldelivery as del on div.DeliveryID = del.DeliveryID JOIN tblSupplier as sp on div.SupplierID = sp.SupplierID INNER JOIN tblproduct as p on div.id = p.id WHERE div.ExpirationDate BETWEEN @StartDate AND @EndDate ORDER BY div.ExpirationDate DESC;"

            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@StartDate", date1)
            cmd.Parameters.AddWithValue("@EndDate", date2)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read
                    ' Handle image conversion
                    Dim img As Image = Nothing
                    If Not IsDBNull(dr("imagepath")) Then
                        Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                        img = ByteArrayToImage(imgData)
                    Else
                        img = Nothing ' Placeholder image
                    End If

                    ' Add row to DataGridView
                    i += 1
                    Guna2DataGridView5.Rows.Add(i, dr("LineItemID").ToString(), dr("DeliveryID").ToString(),
                                                dr("barcode").ToString(), dr("BatchNumber").ToString(),
                                                dr("CompanyName").ToString(), img,
                                                dr("ProductName").ToString(), dr("DeliveryDate").ToString(),
                                                dr("ExpirationDate").ToString())
                End While
            Else
                MessageBox.Show("No records found for the given date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

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

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        ExpiredItem()
    End Sub

    Private Sub Guna2DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView3.CellContentClick

    End Sub

    Private Sub cs1_Click(sender As Object, e As EventArgs) Handles cs1.Click

    End Sub

    Private Sub Guna2DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView2.CellContentClick

    End Sub

    Private Sub Guna2DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView4.CellContentClick

    End Sub

    Private Sub Guna2DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView5.CellContentClick

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub
End Class