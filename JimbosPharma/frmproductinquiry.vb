Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Public Class frmproductinquiry

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Dispose()

    End Sub

    'Sub ProductInventoryCart()  '   READING ATTRIBUTES FROM TABLE PRODUCT WITH USING INNER JOIN
    '    Dim i As Integer = 0
    '    Guna2DataGridView1.Rows.Clear()
    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID inner join tblcategory as c on p.cid =	c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID  inner join tblunit as un on p.uid = un.unitID where qty <> 0 and (brand like '" & txtsearch.Text & "%' or generic like '" & txtsearch.Text & "%' or Category like '" & txtsearch.Text & "%')", con)
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        i += 1
    '        Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("CompanyName").ToString, dr.Item("reorder").ToString, dr.Item("price").ToString, dr.Item("qty").ToString)
    '    End While
    '    dr.Close()
    '    con.Close()


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

    Sub loadinventory()
        Guna2DataGridView1.Rows.Clear()
        Dim i As Integer = 0

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New SqlCommand("select * from tblInventory as iv inner join tblDelivery as del on iv.DeliveryID = del.DeliveryID inner join tblproduct as p on iv.id = p.id LEFT JOIN tblcategory as c on p.cid =	c.catID LEFT JOIN  tblunit as un on p.uid = un.unitID ", con)
            dr = cmd.ExecuteReader

            While dr.Read
                i += 1

                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) Then
                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                    img = ByteArrayToImage(imgData)
                Else
                    ' Optional: Set a placeholder image if ImageSpl is NULL
                    img = Nothing
                End If

                ' Add row with FullName and other fields, including img
                Guna2DataGridView1.Rows.Add(dr("InventoryID").ToString(), i, dr("id").ToString(), img, dr("barcode").ToString(), dr("BatchNumber").ToString(), dr("item_des").ToString(), dr("unit").ToString(), dr("Quantity").ToString(), dr("price").ToString())
            End While



            dr.Close()

            ' Adjust row height in DataGridView
            For Each r As DataGridViewRow In Guna2DataGridView1.Rows
                r.Height = 50
            Next


            '' Set row height
            'For i = 0 To Guna2DataGridView1.Rows.Count - 1
            '    Dim r As DataGridViewRow = Guna2DataGridView1.Rows(i)
            '    r.Height = 75
            'Next

            '' Set image layout for the image column
            'Dim imageColumn = DirectCast(Guna2DataGridView1.Columns("image"), DataGridViewImageColumn)
            'imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub

    'Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Escape
    '            Me.Dispose()

    '    End Select
    'End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        '    Select Case Asc(e.KeyChar)
        '        Case 13
        '            ProductInventoryCart()
        '    End Select
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        loadinventory()
    End Sub


    ' ESC KEY
    Private Sub frmproductinquiry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub frmproductinquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub



    Sub searchproduct(ByVal search As String)
        Try
            If search = String.Empty Then Return
            con.Open()

            cmd = New SqlClient.SqlCommand("select * from tblInventory as iv inner join tblproduct as p on iv.id = p.id WHERE InventoryID LIKE '" & search & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then


                With frmqty
                    .txtdescription.Text = dr.Item("item_des").ToString
                    .lblprice.Text = dr.Item("price").ToString
                    .lblPid.Text = dr.Item("InventoryID").ToString

                    dr.Close()
                    con.Close()
                    .ShowDialog()
                End With

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "Coladd" Then
            searchproduct(Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)

            With cashier  '  real time na mag cacart
                .loadcart()
            End With

        End If
    End Sub



End Class