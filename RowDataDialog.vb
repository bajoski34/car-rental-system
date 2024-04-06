Public Class RowDataDialog
    Private Sub RowDataDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetRowData(rowData As String)
        Dim delimiter As String = ","
        ' Split the input string into an array of substrings
        Dim substrings() As String = rowData.Split(New String() {delimiter}, StringSplitOptions.RemoveEmptyEntries)

        ' Populate controls with the row data
        TextBox1.Text = substrings(1)
        TextBox3.Text = substrings(2)
    End Sub

    Public Sub SetLicenseData(licenseData As String)
        TextBox4.Text = licenseData
    End Sub

    Public Sub SetDurationData(durationData As String)
        TextBox2.Text = durationData
    End Sub
End Class