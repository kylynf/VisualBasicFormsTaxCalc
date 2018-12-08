Imports System.IO

Public Class WelcomePage
    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub setupButton_Click(sender As Object, e As EventArgs) Handles setupButton.Click

        Setup.ShowDialog()

        LoadData() 'in case it changed
        'EnableAndDisable() 'grays out buttons and enables buttons
    End Sub

    Private Sub computeDeductionsButton_Click(sender As Object, e As EventArgs) Handles computeDeductionsButton.Click
        Dim value As Decimal
        value = Val(payTextBox.Text) * Val(hoursWorkedTextBox.Text)

        'TODO: CHECK CALCULATIONS
        'nameTextBox.Text = nameListBox.SelectedItem
        'payTextBox.Text = payListBox.SelectedItem 
        grossPayTextBox.Text = value
        FICATextBox.Text = Val(FICAListBox.SelectedItem) * Val(grossPayTextBox.Text)
        FederalTextBox.Text = Val(federalListBox.SelectedItem) * Val(grossPayTextBox.Text)
        StateTextBox.Text = Val(stateListBox.SelectedItem) * Val(grossPayTextBox.Text)
        TotalTextBox.Text = Val(FICATextBox.Text) + Val(FederalTextBox.Text) + Val(StateTextBox.Text)
        netTextBox.Text = value - Val(TotalTextBox.Text)
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        End
    End Sub

    Private Sub nameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nameListBox.SelectedIndexChanged
        'highlights and selects name
        Dim listBoxesIndex As Integer
        listBoxesIndex = nameListBox.SelectedIndex
        payListBox.SelectedIndex = listBoxesIndex
        FICAListBox.SelectedIndex = listBoxesIndex
        federalListBox.SelectedIndex = listBoxesIndex
        stateListBox.SelectedIndex = listBoxesIndex

        'populates name tb and salary tb
        nameTextBox.Text = nameListBox.SelectedItem
        payTextBox.Text = payListBox.SelectedItem

        ResetTB()
    End Sub

    Private Sub ResetTB()
        'nameTextBox.Text = ""
        'payTextBox.Text = ""
        hoursWorkedTextBox.Text = ""
        grossPayTextBox.Text = ""
        FICATextBox.Text = ""
        FederalTextBox.Text = ""
        StateTextBox.Text = ""
        TotalTextBox.Text = ""
        netTextBox.Text = ""
    End Sub

    Private Sub LoadData()
        'erase old data
        nameListBox.Items.Clear()
        payListBox.Items.Clear()
        FICAListBox.Items.Clear()
        federalListBox.Items.Clear()
        stateListBox.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String
            Dim salary As String
            Dim FICA As Decimal
            Dim federal As Decimal
            Dim state As Decimal

            count = fStreamReader.ReadLine

            For i = 1 To count
                name = fStreamReader.ReadLine
                salary = fStreamReader.ReadLine
                FICA = fStreamReader.ReadLine
                federal = fStreamReader.ReadLine
                state = fStreamReader.ReadLine

                nameListBox.Items.Add(name)
                payListBox.Items.Add(salary)
                FICAListBox.Items.Add(FICA)
                federalListBox.Items.Add(federal)
                stateListBox.Items.Add(state)
            Next
            fStreamReader.Close()
        End If
    End Sub

    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'erase old data
        nameListBox.Items.Clear()
        payListBox.Items.Clear()
        FICAListBox.Items.Clear()
        federalListBox.Items.Clear()
        stateListBox.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String
            Dim salary As String
            Dim FICA As Decimal
            Dim federal As Decimal
            Dim state As Decimal

            count = fStreamReader.ReadLine

            For i = 1 To count
                name = fStreamReader.ReadLine
                salary = fStreamReader.ReadLine
                FICA = fStreamReader.ReadLine
                federal = fStreamReader.ReadLine
                state = fStreamReader.ReadLine

                nameListBox.Items.Add(name)
                payListBox.Items.Add(salary)
                FICAListBox.Items.Add(FICA)
                federalListBox.Items.Add(federal)
                stateListBox.Items.Add(state)
            Next
            fStreamReader.Close()
        End If
    End Sub

    Private Sub FICAListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FICAListBox.SelectedIndexChanged
        'DONT CHANGE ME
    End Sub
End Class