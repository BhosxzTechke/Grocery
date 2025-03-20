Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frminventorylist

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Sub inventorylist()
        Guna2DataGridView2.Rows.Clear()
        Dim i As Integer = 0

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New SqlCommand("select * from tblInventory as iv inner join tblproduct as p on iv.id = p.id ", con)
            dr = cmd.ExecuteReader

            While dr.Read
                i += 1

                '' Combine FirstName, MiddleName, and LastName to form FullName
                'Dim fullName As String = String.Format("{0} {1} {2}", dr("FirstName").ToString(), dr("MiddleName").ToString(), dr("LastName").ToString()).Trim()

                ' Retrieve and convert the ImageSpl column
                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) Then
                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                    img = ByteArrayToImage(imgData)
                Else
                    ' Optional: Set a placeholder image if ImageSpl is NULL
                    img = Nothing ' Ensure this resource exists, or replace it
                End If

                ' Add row with FullName and other fields, including img
                Guna2DataGridView2.Rows.Add(dr("InventoryID").ToString(), i, dr("id").ToString(), img, dr("barcode").ToString(), dr("item_des").ToString(), dr("Quantity").ToString(), dr("ExpirationDate").ToString(), dr("price").ToString())
            End While

            dr.Close()

            ' Set row height
            For i = 0 To Guna2DataGridView2.Rows.Count - 1
                Dim r As DataGridViewRow = Guna2DataGridView2.Rows(i)
                r.Height = 75
            Next

            ' Set image layout for the image column
            Dim imageColumn = DirectCast(Guna2DataGridView2.Columns("image"), DataGridViewImageColumn)
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MessageBox.Show("Error loading user list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
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


    Private Sub Guna2DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView2.CellContentClick

    End Sub

    Private Sub frminventorylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventorylist()
        Me.KeyPreview = True

    End Sub

    Private Sub frminventorylist_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()

    End Sub
End Class