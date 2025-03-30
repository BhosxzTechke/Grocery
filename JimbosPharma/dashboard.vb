Imports System.Data.SqlClient
Imports Tulpep.NotificationWindow
Imports System.IO

Public Class dashboard


    ' Flag to toggle colors
    Private isColorCyan As Boolean = True


    Private Sub LoadImage(pictureBox As PictureBox, userId As String)
        Dim imageData As Byte() = GetUserImageData(userId)
        Try
            If imageData IsNot Nothing Then
                Using ms As New MemoryStream(imageData)
                    pictureBox.Image = Image.FromStream(ms)
                End Using
            Else
                pictureBox.Image = Nothing ' Clear the image if no data is available
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub


    Private Sub btncategory_Click(sender As Object, e As EventArgs) Handles btncategory.Click
        'Dim x As Integer = btncategory.Width ' Set the X position to the button's width (right edge)
        'Dim y As Integer = 0 ' Set the Y position to align at the top of the button
        'Guna2ContextMenuStrip2.Show(btncategory, x, y)


        With frmvat
            .txtvat.Text = getvat()
            .ShowDialog()

        End With


    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        With frmuser
            .LoadUserList()
            .ShowDialog()

        End With
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotifyCriticalStock()
        'Timer1.Start()

        With frmdashboard
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdashboard)
            .BringToFront()
            .Show()
        End With

        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable

        Timer5.Start()

    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click


        ' FORM NI PRODUCT
        With frmproductlists
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmproductlists)
            .BringToFront()
            .Show()

        End With


    End Sub
    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        ' FORM NI supplier
        With frmsupplierlist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmsupplierlist)
            .BringToFront()
            .Show()
            '.supplierrecord()
        End With
    End Sub




    Private Sub dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub





    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    tiktok.Text = Date.Now.ToString("hh:mm:ss")
    '    ampm.Text = Date.Now.ToString("tt")

    '    Guna2CircleProgressBar1.Value = Date.Now.ToString("ss")

    '    day.Text = Date.Now.ToString("dddd")
    '    calendar.Text = Date.Now.Date

    'End Sub


    Private Sub Guna2ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Guna2ContextMenuStrip1.Opening
        ' Check the current color mode and update the menu item text
        Command1ToolStripMenuItem.Text = "System Lock"
        Command2ToolStripMenuItem.Text = "Change Password"
        AToolStripMenuItem.Text = "Logout"
    End Sub

    'Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
    '    Guna2ContextMenuStrip1.Show(btnew, 0, btnew.Height)

    'End Sub


    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

        loginform.Show()

        Me.Dispose()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        With frmdashboard
            .ProductCount()
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub





    Private Sub Command1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Command1ToolStripMenuItem.Click
        With frmlock
            .ShowDialog()        ' LOCK THE SYSTEM
        End With
    End Sub


    Private Sub Command2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Command2ToolStripMenuItem.Click
        With frmchangepass
            .ShowDialog()        '      CHANGE PASSWORD
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        With loadchart
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        With frmreporter
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmreporter)
            .BringToFront()
            .Show()
        End With
    End Sub



    Private Sub Guna2CircleProgressBar2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label1.Text = Now.ToLongDateString
        Label2.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub OtherMaintananceToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub




    ' ---------- DELIVERY AND INVENTORY AND RECORDS BUTTON HIDING ----------

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ' FORM NI Delivery
        With frmdeliverylist
            .ShowDialog()
        End With

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        With frminventorylist
            .ShowDialog()

        End With
    End Sub

    Private Sub btnrecords_Click(sender As Object, e As EventArgs)

        With frmrecords
            '.stockinventory()
            .ShowDialog()

        End With

    End Sub


    ' ---------- END OF THIS ' ----------

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim popup = New PopupNotifier
        'popup.Image = My.Resources
        popup.TitleText = "pogi ko"
        popup.ContentText = "ediwaw"
        popup.Popup()

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


    Private Sub userpic_Click(sender As Object, e As EventArgs) Handles userpic.Click

    End Sub

    Private Sub Guna2ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Function GetUserImageData(userId As String) As Byte()
        Throw New NotImplementedException
    End Function

    Private Sub VatToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        With frmvat
            .txtvat.Text = getvat()
            .ShowDialog()

        End With
    End Sub


    Private Sub DiscountToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        With frmdiscount
            .loaddiscount()
            .ShowDialog()

        End With
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click


        With frmcategorylist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmcategorylist)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        With frmdiscount
            .loaddiscount()
            .ShowDialog()

        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        With frmunitlist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmunitlist)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click, Button4.Click
        ' Calculate the position to show the context menu on the right side
        Dim x As Integer = btnsettings.Width
        Dim y As Integer = btnsettings.Height / 2
        Guna2ContextMenuStrip1.Show(btnsettings, New Point(x, y))
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        With frmdeliverylist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdeliverylist)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        With frmdeliverylist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdeliverylist)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        With frminventorylist
            .ShowDialog()

        End With
    End Sub
End Class
