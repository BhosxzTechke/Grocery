Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmreporter
    Dim sdate1 As String
    Dim sdate2 As String


    Sub loaduser()
        Try
            con.Open()
            cmd = New SqlClient.SqlCommand("SELECT DISTINCT users FROM tblpayment", con)
            dr = cmd.ExecuteReader()
            cbouser.Items.Clear() ' Clear combo box before adding items
            While dr.Read()
                cbouser.Items.Add(dr.Item("users").ToString())
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message, vbCritical)
        Finally
            If con.State = ConnectionState.Open Then con.Close() ' Ensure connection is closed
        End Try
    End Sub


    Sub loadReport(ByVal ds As DataSet1)
        Try
            With ReportViewer1.LocalReport
                .ReportPath = "C:\Project\JimbosPharma\JimbosPharma\bin\Debug\Reports\Report1.rdlc"
                .DataSources.Clear()

                ' Set the date parameter for the report
                Dim pdate As New ReportParameter("pDate", "Date covered: (" & sdate1 & " - " & sdate2 & ")")
                .SetParameters(pdate)

                ' Bind the dataset to the report
                Dim rpts As New ReportDataSource("DataSet1", ds.Tables("dtpayment"))
                .DataSources.Add(rpts)
            End With

            ' Set display settings for the report viewer
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            ReportViewer1.RefreshReport()

        Catch ex As Exception
            con.Close()
            MsgBox("Error loading report: " & ex.Message, vbCritical)
        End Try
    End Sub







    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub frmreporter_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaduser() ' Load users when the form loads

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sdate1 = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        sdate2 = Guna2DateTimePicker2.Value.ToString("yyyy-MM-dd")

        ' Prepare the SQL command with parameters to prevent SQL injection
        Dim sql As String = "SELECT * FROM tblpayment WHERE sdate BETWEEN @sdate1 AND @sdate2 AND users LIKE @user"
        Dim cmd As New SqlCommand(sql, con)

        ' Add parameters to avoid SQL injection
        cmd.Parameters.AddWithValue("@sdate1", sdate1)
        cmd.Parameters.AddWithValue("@sdate2", sdate2)
        cmd.Parameters.AddWithValue("@user", "%" & cbouser.Text & "%")

        ' Create a DataAdapter to fill the DataSet
        Dim ds As New DataSet1
        Dim da As New SqlDataAdapter(cmd)

        Try
            con.Open()
            da.Fill(ds.Tables("dtpayment"))
            con.Close()

            ' Check if the dataset is empty
            If ds.Tables("dtpayment").Rows.Count = 0 Then
                MsgBox("No data available for the selected date range.", vbInformation)
                Return
            End If

            ' Call loadReport with the filled DataSet
            loadReport(ds)

        Catch ex As Exception
            ' Ensure the connection is closed and log the error message
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class