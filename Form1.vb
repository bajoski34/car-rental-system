Imports System.DirectoryServices


Public Class Form1
    Private carTypes As New List(Of String) From {
    "Sedan", "SUV", "Truck", "Convertible", "Sports Car",
    "Economy", "Compact", "Midsize", "Standard", "Full-Size",
    "Premium", "Luxury", "Mini-van", "Van", "Pickup", "Other"}

    Dim cars As New List(Of Car) From {
            New Car With {.Category = "SUV", .Model = "Toyota RAV4", .Price = 35},
            New Car With {.Category = "Sedan", .Model = "Honda Civic", .Price = 45},
            New Car With {.Category = "Truck", .Model = "Ford F-150", .Price = 50},
            New Car With {.Category = "Convertible", .Model = "Ford F-100", .Price = 40},
            New Car With {.Category = "Economy", .Model = "Ford B-150", .Price = 42},
            New Car With {.Category = "Sports Car", .Model = "Ford B-150", .Price = 52},
            New Car With {.Category = "Sports Car", .Model = "Ford B-150", .Price = 72},
            New Car With {.Category = "Luxury", .Model = "Ford B-150", .Price = 82},
            New Car With {.Category = "Sports Car", .Model = "Ford B-150", .Price = 55},
            New Car With {.Category = "Mini-van", .Model = "Ford B-150", .Price = 90},
            New Car With {.Category = "Sports Car", .Model = "Ford B-150", .Price = 40},
            New Car With {.Category = "Van", .Model = "Ford B-150", .Price = 60},
            New Car With {.Category = "Pickup", .Model = "Ford B-150", .Price = 44},
            New Car With {.Category = "Pickup", .Model = "Nissan", .Price = 48},
            New Car With {.Category = "Other", .Model = "Ford B-150", .Price = 41}
    }


    Private Sub Form1(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_pickup.Click
        lbl_pickup.Text = "Queensborough Community College"
        txtAddress.AutoCompleteMode = AutoCompleteMode.Suggest
        txtAddress.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim addressCollecttion As New AutoCompleteStringCollection()
        txtAddress.AutoCompleteCustomSource = addressCollecttion
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = DateTime.Today
        DateTimePicker2.MinDate = DateTime.Now.AddDays(29)

        carListView.Columns.Add("CategoryColumn", "Category")
        carListView.Columns.Add("ModelColumn", "Model")
        carListView.Columns.Add("PriceColumn", "Price")

        'carListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'carListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Populate the ComboBox with car types
        ComboBoxCarTypes.DataSource = carTypes

        carListView.AutoSize = True
        Dim defaultCars = cars.Where(Function(car) car.Category.Equals("Sedan", StringComparison.OrdinalIgnoreCase)).ToList()
        DisplayCars(defaultCars)
    End Sub

    Private Sub lbl_dropoff_Click(sender As Object, e As EventArgs) Handles lbl_dropoff.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            lbl_dropoff.Visible = False
            TextBox5.Visible = False
        End If

        If Not CheckBox1.Checked Then
            lbl_dropoff.Visible = True
            TextBox5.Visible = True
        End If
    End Sub

    Private Sub carListView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles carListView.RowHeaderMouseClick
        If e.RowIndex >= 0 And Not licenseTextBox.Text.Equals("") Then  ' Check if the clicked row is valid
            Dim clickedRow As DataGridViewRow = carListView.Rows(e.RowIndex)
            ' Do something with the clicked row data
            Dim rowData As String = ""

            ' Get the selected dates from the DateTimePicker controls
            Dim startDate As DateTime = DateTimePicker1.Value
            Dim endDate As DateTime = DateTimePicker2.Value

            ' Calculate the duration between the two dates
            Dim duration As TimeSpan = endDate - startDate

            ' Display the duration in days
            Dim daysDuration As Integer = duration.Days

            For Each cell As DataGridViewCell In clickedRow.Cells
                rowData &= cell.Value.ToString() & ","
            Next
            ' MessageBox.Show("You clicked on row data: " & rowData)
            ' Display row data in a dialog box
            Dim rowDataDialog As New RowDataDialog()
            rowDataDialog.SetRowData(rowData)
            rowDataDialog.SetLicenseData(licenseTextBox.Text)
            rowDataDialog.SetDurationData(daysDuration)
            rowDataDialog.ShowDialog()
        Else
            licenseErrorMsg.Text = "license not supplied"
        End If
    End Sub

    Private Sub carCategorySearch_Click(sender As Object, e As EventArgs) Handles carCategorySearch.Click
        Dim selectedCarType As String = ComboBoxCarTypes.SelectedValue.ToString()

        ' Clear existing rows
        carListView.Rows.Clear()


        ' Filter the list of cars by category
        Dim filteredCars = cars.Where(Function(car) car.Category.Equals(selectedCarType, StringComparison.OrdinalIgnoreCase)).ToList()
        DisplayCars(filteredCars)
    End Sub

    Private Sub ComboBoxCarTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarTypes.SelectedIndexChanged

    End Sub

    Private Sub DisplayCars(cars As List(Of Car))
        ' Clear existing rows
        carListView.Rows.Clear()

        ' Add cars to DataGridView
        For Each car In cars
            carListView.Rows.Add(car.Category, car.Model, car.Price.ToString("C"))
        Next

    End Sub

    Private Sub licenseTextBox_TextChanged(sender As Object, e As EventArgs) Handles licenseTextBox.TextChanged
        If licenseTextBox.Text.Length > 10 Then
            ' Display error message if text length exceeds 10 characters
            ErrorProvider1.SetError(licenseTextBox, "invalid license. identifier cannot exceeded (10 characters)")
            licenseErrorMsg.Text = "invalid license number. identifier cannot exceed (10 characters)"

            ' Truncate the text to the maximum allowed length
            licenseTextBox.Text = licenseTextBox.Text.Substring(0, 11)
            ' Set the cursor position to the end of the text
            licenseTextBox.SelectionStart = licenseTextBox.TextLength
        Else
            ' Clear any previous error message
            ErrorProvider1.SetError(licenseTextBox, "")
            licenseErrorMsg.Text = ""
        End If

    End Sub
End Class
