Imports System
Imports System.IO
Imports System.Collections

Public Class Setup


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        NameListBox.Items.Add(NameTextBox.Text)
        PayListBox.Items.Add(PayTextBox.Text)
        FICAListBox.Items.Add(FICATextBox.Text)
        FederalListBox.Items.Add(FederalTextBox.Text)
        StateListBox.Items.Add(StateTextBox.Text)

        NameTextBox.Text = " "
        PayTextBox.Text = " "
        FICATextBox.Text = " "
        FederalTextBox.Text = " "
        StateTextBox.Text = " "
    End Sub

    'RECODE FROM QUIT BUTTON TO SAVE BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'SAVE BUTTON
        SaveData()
        ResetTB()
    End Sub


    Private Sub DeleteEmployeeButton_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeButton.Click
        'Take information from selected name and put back into text fields
        Dim index As Integer
        index = NameListBox.SelectedIndex
        If (index <> -1) Then
            NameListBox.Items.RemoveAt(index)
            PayListBox.Items.RemoveAt(index)
            FICAListBox.Items.RemoveAt(index)
            FederalListBox.Items.RemoveAt(index)
            StateListBox.Items.RemoveAt(index)
            'EnableAndDisable()
            ResetTB()
        End If
    End Sub

    Private Sub CancelReturnButton_Click(sender As Object, e As EventArgs) Handles CancelReturnButton.Click
        Me.Close()
        ResetTB()
    End Sub

    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'erase any old data
        NameListBox.Items.Clear()
        PayListBox.Items.Clear()
        FICAListBox.Items.Clear()
        FederalListBox.Items.Clear()
        StateListBox.Items.Clear()

        'create the file
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

                NameListBox.Items.Add(name)
                PayListBox.Items.Add(salary)
                FICAListBox.Items.Add(FICA)
                FederalListBox.Items.Add(federal)
                StateListBox.Items.Add(state)
            Next

            fStreamReader.Close()
        End If

    End Sub

    Private Sub SaveData()
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count As Integer
        Dim i As Integer

        count = NameListBox.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(NameListBox.Items(i))
            fStreamWriter.WriteLine(PayListBox.Items(i))
            fStreamWriter.WriteLine(FICAListBox.Items(i))
            fStreamWriter.WriteLine(FederalListBox.Items(i))
            fStreamWriter.WriteLine(StateListBox.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

        'EnableAndDisable()
    End Sub

    Private Sub NameListBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        Dim listBoxesIndex As Integer
        listBoxesIndex = NameListBox.SelectedIndex
        PayListBox.SelectedIndex = listBoxesIndex
        FICAListBox.SelectedIndex = listBoxesIndex
        FederalListBox.SelectedIndex = listBoxesIndex
        StateListBox.SelectedIndex = listBoxesIndex

        EditEmployeeButton.Enabled = True
        SaveEmployeeButton.Enabled = False
        DeleteEmployeeButton.Enabled = True
        'AddEmployeeButton.Enabled = False
    End Sub

    Private Sub EnableAndDisable()
        'Edit button
        If NameListBox.SelectedIndex >= 0 And NameTextBox.Text <> "" Then
            EditEmployeeButton.Enabled = True
        Else
            EditEmployeeButton.Enabled = False
        End If

        'Add button
        '<> is not equal to
        If NameTextBox.Text <> "" And Val(PayTextBox.Text) > 0 And Val(FICATextBox.Text) > 0 And Val(FederalTextBox.Text) > 0 And Val(StateTextBox.Text) > 0 Then
            AddEmployeeButton.Enabled = True
        Else
            AddEmployeeButton.Enabled = False
        End If

        'Delete button
        If NameListBox.SelectedIndex >= 0 Then
            DeleteEmployeeButton.Enabled = True
        Else
            DeleteEmployeeButton.Enabled = False
        End If

        'Save edited button
        If EditEmployeeButton.Enabled = True Then
            SaveEmployeeButton.Enabled = False
        Else
            SaveEmployeeButton.Enabled = True
            EditEmployeeButton.Enabled = False
        End If
    End Sub

    Private Sub ResetTB()
        NameTextBox.Text = ""
        PayTextBox.Text = ""
        FICATextBox.Text = ""
        FederalTextBox.Text = ""
        StateTextBox.Text = ""
    End Sub

    Private Sub SaveReturnButton_Click_1(sender As Object, e As EventArgs) Handles SaveReturnButton.Click
        SaveData()
        Me.Close()

        ResetTB()
    End Sub

    Private Sub SaveEmployeeButton_Click(sender As Object, e As EventArgs) Handles SaveEmployeeButton.Click
        'Grayed out when edit employee button is active
        'grabs textfields and overwrites if name is already in textfile
        'clears textfields when finished

        Dim index As Integer
        index = NameListBox.SelectedIndex
        PayListBox.Items(index) = PayTextBox.Text
        FICAListBox.Items(index) = FICATextBox.Text
        FederalListBox.Items(index) = FederalTextBox.Text
        StateListBox.Items(index) = StateTextBox.Text
        NameListBox.Items(index) = NameTextBox.Text
        'EnableAndDisable()

        EditEmployeeButton.Enabled = True
        SaveEmployeeButton.Enabled = False
        AddEmployeeButton.Enabled = True
        DeleteEmployeeButton.Enabled = True
        ResetTB()
    End Sub

    Private Sub EditEmployeeButton_Click(sender As Object, e As EventArgs) Handles EditEmployeeButton.Click
        'TODO: REPLACE EMPLOYEE InsTEAD OF MAKInG NEW ONE
        'populates textboxes with selected item from listbox

        NameTextBox.Text = NameListBox.SelectedItem.ToString()
        PayTextBox.Text = PayListBox.SelectedItem.ToString()
        FICATextBox.Text = FICAListBox.SelectedItem.ToString()
        FederalTextBox.Text = FederalListBox.SelectedItem.ToString()
        StateTextBox.Text = StateListBox.SelectedItem.ToString()
        'EnableAndDisable()

        SaveEmployeeButton.Enabled = True
        EditEmployeeButton.Enabled = False
        AddEmployeeButton.Enabled = False
        DeleteEmployeeButton.Enabled = False
        'ResetTB()
    End Sub
End Class
