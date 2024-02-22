Imports System.DirectoryServices
Public Class Form1
    Private carTypes As New List(Of String) From {"Sedan", "SUV", "Truck", "Convertible", "Sports Car"}

    Private Sub Form1(sender As Object, e As EventArgs)
        ' Populate the ComboBox with car types
        ComboBoxCarTypes.DataSource = carTypes

        ' Set up the DirectorySearcher control
        InitializeDirectorySearcher()
    End Sub

    Private Sub InitializeDirectorySearcher()
        ' Create a DirectorySearcher object
        Dim searcher As New DirectorySearcher()

        ' Set the search base (e.g., the root of the directory you want to search)
        searcher.SearchRoot = New DirectoryEntry("LDAP://CN=Users,DC=example,DC=com")

        ' Set the filter (e.g., to search for all users)
        searcher.Filter = "(&(objectClass=user)(objectCategory=person))"

        ' Set other properties as needed (e.g., PageSize, SearchScope, etc.)

        ' Perform the initial search
        Dim searchResultCollection As SearchResultCollection = searcher.FindAll()

        ' Display the initial results or process them as needed
        ' For simplicity, we'll just print the count of results to the console
        Console.WriteLine("Initial search found: " & searchResultCollection.Count & " results")
    End Sub

    Private Sub ComboBoxCarTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarTypes.SelectedIndexChanged
        ' Handle the SelectedIndexChanged event of the ComboBox
        Dim selectedCarType As String = ComboBoxCarTypes.SelectedItem.ToString()

        ' Perform actions based on the selected car type
        MessageBox.Show("You selected: " & selectedCarType)
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
End Class
