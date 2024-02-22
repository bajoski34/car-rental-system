Imports System.DirectoryServices


Public Class Form1
    Private carTypes As New List(Of String) From {"Sedan", "SUV", "Truck", "Convertible", "Sports Car"}

    Dim cars As New List(Of Car) From {
            New Car With {.Category = "SUV", .Model = "Toyota RAV4", .Price = 35000},
            New Car With {.Category = "Sedan", .Model = "Honda Civic", .Price = 25000},
            New Car With {.Category = "Truck", .Model = "Ford F-150", .Price = 50000},
            New Car With {.Category = "Covertible", .Model = "Ford F-100", .Price = 4000},
            New Car With {.Category = "Sports Car", .Model = "Ford B-150", .Price = 42000}
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
        DateTimePicker1.MinDate = DateTime.Now
        DateTimePicker1.MinDate = DateTime.Now

        ' Populate the ComboBox with car types
        ComboBoxCarTypes.DataSource = carTypes

        carListView.AutoSize = True
        carListView.DataSource = cars
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

    Private Sub carListView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles carListView.CellContentClick

    End Sub
End Class
