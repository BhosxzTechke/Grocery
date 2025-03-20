
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class frmsupplierlist

    ' Helper function to convert byte array to Image and resize it







    Sub LoadUserList()
        Dim i As Integer = 0
        dataprod.Rows.Clear()

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Open the connection and execute the query
            con.Open()

            Using cmd As New SqlCommand("Select * from tblSupplier order by CompanyName", con)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        i += 1

                        ' Retrieve and convert the ImageSpl column
                        Dim img As Image = Nothing
                        If Not IsDBNull(dr("ImageSpl")) Then
                            Dim imgData As Byte() = DirectCast(dr("ImageSpl"), Byte())
                            img = ByteArrayToImage(imgData)
                        Else
                            ' Optional: Set a placeholder image if ImageSpl is NULL
                            img = Nothing ' Use your own placeholder image here
                        End If

                        ' Add row to DataGridView
                        dataprod.Rows.Add(
                            dr("SupplierID").ToString(),
                            i,
                            dr("CompanyName").ToString(),
                            dr("Address").ToString(),
                            img,
                            dr("Contact_Person").ToString(),
                            dr("Mobile_no").ToString(),
                            dr("Tel_no").ToString()
                        )
                    End While
                End Using
            End Using

            ' Update record count label
            rc1.Text = " Record Found.(" & dataprod.RowCount & ") "

        Catch ex As Exception
            MsgBox("Error loading supplier list: " & ex.Message, vbCritical)
        Finally
            ' Close the connection in case it's still open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub frmsupplierlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserList()

        dataprod.AlternatingRowsDefaultCellStyle = dataprod.RowsDefaultCellStyle

    End Sub

    ' Create a new supplier
    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        With frmmodifsupplier
            .btnupdate.Visible = False
            .btnsave.Visible = True
            .ShowDialog()
        End With
    End Sub




    Private Sub datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs)


        With frmmodifsupplier
            .txtcompany.Clear()
            .txtaddress.Clear()
            .txtmob.Clear()
            .txttel.Clear()
            .PictureBox1.Image = Nothing ' Or set a default image
            .txtcontact.Clear()
            .btnsave.Visible = True
            .btnupdate.Visible = False
        End With


    End Sub

    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then Return Nothing

        Try
            Using ms As New MemoryStream(byteArray)
                Dim originalImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                Dim resizedImage As New Bitmap(100, 130) ' Adjust dimensions as needed
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(originalImage, 0, 0, 100, 130)
                End Using
                Return resizedImage
            End Using
        Catch ex As ArgumentException
            Return Nothing
        End Try
    End Function

    Sub Searchcompany()
        Try
            Dim i As Integer = 0
            dataprod.Rows.Clear() ' Clear existing rows

            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As String
            If String.IsNullOrWhiteSpace(searchboxing.Text) Then
                query = "SELECT * FROM tblSupplier ORDER BY CompanyName"
            Else
                query = "SELECT * FROM tblSupplier WHERE CompanyName LIKE @CompanyName OR Address LIKE @Address ORDER BY CompanyName"
            End If

            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CompanyName", "%" & searchboxing.Text.Trim() & "%")
            cmd.Parameters.AddWithValue("@Address", "%" & searchboxing.Text.Trim() & "%")

            dr = cmd.ExecuteReader()

            While dr.Read()
                i += 1
                Dim img As Image = Nothing
                If Not IsDBNull(dr("ImageSpl")) Then
                    Dim imgData As Byte() = DirectCast(dr("ImageSpl"), Byte())
                    If imgData.Length > 0 Then img = ByteArrayToImage(imgData)
                End If

                dataprod.Rows.Add(i,
                                  dr("SupplierID").ToString(),
                                  dr("CompanyName").ToString(),
                                  dr("Address").ToString(),
                                  img,
                                  If(Not IsDBNull(dr("Contact_Person")), dr("Contact_Person").ToString(), ""),
                                  If(Not IsDBNull(dr("Mobile_no")), dr("Mobile_no").ToString(), ""),
                                  If(Not IsDBNull(dr("Tel_no")), dr("Tel_no").ToString(), ""))
            End While

            For Each r As DataGridViewRow In dataprod.Rows
                r.Height = 40
            Next
            dataprod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            If dataprod.Rows.Count = 0 Then MsgBox("No records found.", vbInformation, "Search Results")

        Catch ex As Exception
            MsgBox("An error occurred while searching: " & ex.Message, vbCritical, "Search Error")
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub





    Private Sub dataprod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataprod.CellContentClick
        ' Prevent processing if the header row is clicked
        If e.RowIndex < 0 Then Return

        Dim colname As String = dataprod.Columns(e.ColumnIndex).Name

        If colname = "View" Then
            With frmviewsupplie

                .txtcompany.Text = dataprod.Rows(e.RowIndex).Cells(3).Value.ToString()
                .txtcont.Text = dataprod.Rows(e.RowIndex).Cells(5).Value.ToString()
                .txtemail.Text = dataprod.Rows(e.RowIndex).Cells(3).Value.ToString()
                .txtmob.Text = dataprod.Rows(e.RowIndex).Cells(6).Value.ToString()
                .txttel.Text = dataprod.Rows(e.RowIndex).Cells(7).Value.ToString()


                Dim imageData As Byte() = Nothing
                If Not IsDBNull(dataprod.Rows(e.RowIndex).Cells(4).Value) Then
                    Dim bitmap As Bitmap = TryCast(dataprod.Rows(e.RowIndex).Cells(4).Value, Bitmap)
                    If bitmap IsNot Nothing Then
                        Using ms As New MemoryStream()
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                            imageData = ms.ToArray()
                        End Using
                    End If
                End If


                ' Pass the image data to the frmmodifsupplier form
                .SetImageData(imageData)
                .ShowDialog()

            End With

        ElseIf colname = "Edit" Then
            ' Populate the frmmodifsupplier form with retrieved data from the DataGridView

            Dim supplierform As New frmmodifsupplier()

            ' ✅ Set Editing Mode to prevent clearing fields
            supplierform.isEditing = True  ' 🔥 Add this line

            supplierform.lblid.Text = dataprod.Rows(e.RowIndex).Cells(0).Value.ToString()
            supplierform.txtcompany.Text = dataprod.Rows(e.RowIndex).Cells(2).Value.ToString()
            supplierform.txtaddress.Text = dataprod.Rows(e.RowIndex).Cells(3).Value.ToString()
            supplierform.txtcontact.Text = dataprod.Rows(e.RowIndex).Cells(5).Value.ToString()
            supplierform.txtmob.Text = dataprod.Rows(e.RowIndex).Cells(6).Value.ToString()
            supplierform.txttel.Text = dataprod.Rows(e.RowIndex).Cells(7).Value.ToString()
            supplierform.btnupdate.Visible = True
            supplierform.btnsave.Visible = False



            Dim imageData As Byte() = Nothing
            If Not IsDBNull(dataprod.Rows(e.RowIndex).Cells(4).Value) Then
                Dim bitmap As Bitmap = TryCast(dataprod.Rows(e.RowIndex).Cells(4).Value, Bitmap)
                If bitmap IsNot Nothing Then
                    Using ms As New MemoryStream()
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png) ' You can also use other formats like .Jpeg
                        imageData = ms.ToArray()
                    End Using
                End If
            End If

            ' Pass the image data to the frmmodifsupplier form
            supplierform.SetImageData(imageData)

            ' Show the modification form as a dialog
            supplierform.ShowDialog()

        ElseIf colname = "Delete" Then
            ' Confirm before deleting
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Supplier?",
                                                         "Confirm Deletion",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                Return
            End If

            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("DELETE FROM tblSupplier WHERE SupplierID = " &
                                               dataprod.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()

                ' Success message
                MessageBox.Show("Supplier has been deleted successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                LoadUserList()

            Catch ex As Exception
                ' Error message
                MessageBox.Show("Error deleting user: " & ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If

    End Sub




    Private Sub searchboxing_TextChanged(sender As Object, e As EventArgs)
        Searchcompany()

    End Sub
End Class







'Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
'    ' Check if the clicked row is valid (ignores header row clicks)
'    If e.RowIndex < 0 Then Return

'    ' Get the column name where the click occurred
'    Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name

'    ' Check if the clicked column is "Edit" or "Delete"
'    If colname = "Action" Then
'        ' Store the row index in the ContextMenuStrip's Tag for later use
'        Guna2ContextMenuStrip1.Tag = e.RowIndex

'        ' Show the context menu at the mouse position
'        Dim mousePosition As Point = Guna2DataGridView1.PointToClient(Cursor.Position)
'        Guna2ContextMenuStrip1.Show(Guna2DataGridView1, mousePosition)
'    End If
'End Sub

'Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
'    ' Get the row index from the ContextMenuStrip's Tag property
'    If Guna2ContextMenuStrip1.Tag IsNot Nothing Then
'        Dim rowIndex As Integer = CType(Guna2ContextMenuStrip1.Tag, Integer)

'        ' Confirm delete operation
'        If MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
'            con.Open()
'            Dim cmd As New SqlCommand("DELETE FROM tblSupplier WHERE SupplierID = @SupplierID", con)
'            cmd.Parameters.AddWithValue("@SupplierID", Guna2DataGridView1.Rows(rowIndex).Cells(0).Value.ToString())
'            cmd.ExecuteNonQuery()
'            con.Close()

'            ' Notify user
'            MessageBox.Show("Record has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            supplierrecord() ' Refresh grid or view
'        End If
'    End If
'End Sub
