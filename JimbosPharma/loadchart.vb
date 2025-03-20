'Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Public Class loadchart

    Private Sub loadchart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadChartData()
    End Sub

    'Sub LoadChartData()
    '    Try
    '        With Chart1
    '            .Series.Clear()
    '            .Series.Add("Series1")
    '        End With

    '        Dim da As New SqlDataAdapter("SELECT Address1, COUNT(Address2) AS AddressCount FROM tblSupplier WHERE Suburb LIKE 'Metro Manila' GROUP BY Address1", con)
    '        Dim ds As New DataSet

    '        da.Fill(ds, "Address1")
    '        If ds.Tables("Address1").Rows.Count > 0 Then
    '            Chart1.DataSource = ds.Tables("Address1")
    '            Dim series1 As Series = Chart1.Series("Series1")
    '            series1.ChartType = SeriesChartType.Pie
    '            series1.Name = "POPULATION"

    '            With Chart1
    '                .Series(series1.Name).XValueMember = "Address1"
    '                .Series(series1.Name).YValueMembers = "AddressCount"
    '                .Series(0).LabelFormat = "(#,##0)"
    '            End With
    '        Else
    '            MessageBox.Show("No data available to display.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error loading chart: " & ex.Message)
    '    End Try
    'End Sub

End Class