<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameListBox = New System.Windows.Forms.ListBox()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PayListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FICAListBox = New System.Windows.Forms.ListBox()
        Me.FederalListBox = New System.Windows.Forms.ListBox()
        Me.StateListBox = New System.Windows.Forms.ListBox()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.FICATextBox = New System.Windows.Forms.TextBox()
        Me.FederalTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.EditEmployeeButton = New System.Windows.Forms.Button()
        Me.DeleteEmployeeButton = New System.Windows.Forms.Button()
        Me.SaveReturnButton = New System.Windows.Forms.Button()
        Me.CancelReturnButton = New System.Windows.Forms.Button()
        Me.SaveEmployeeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(12, 295)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'NameListBox
        '
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.Location = New System.Drawing.Point(12, 50)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.Size = New System.Drawing.Size(120, 225)
        Me.NameListBox.TabIndex = 1
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Location = New System.Drawing.Point(88, 349)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(108, 23)
        Me.AddEmployeeButton.TabIndex = 2
        Me.AddEmployeeButton.Text = "Add Employee"
        Me.AddEmployeeButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(88, 400)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(108, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pay Per Hour"
        '
        'PayListBox
        '
        Me.PayListBox.Enabled = False
        Me.PayListBox.FormattingEnabled = True
        Me.PayListBox.Location = New System.Drawing.Point(161, 50)
        Me.PayListBox.Name = "PayListBox"
        Me.PayListBox.Size = New System.Drawing.Size(120, 225)
        Me.PayListBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FICA Withholdings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Federal Withholdings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "State Withholdings"
        '
        'FICAListBox
        '
        Me.FICAListBox.Enabled = False
        Me.FICAListBox.FormattingEnabled = True
        Me.FICAListBox.Location = New System.Drawing.Point(316, 50)
        Me.FICAListBox.Name = "FICAListBox"
        Me.FICAListBox.Size = New System.Drawing.Size(120, 225)
        Me.FICAListBox.TabIndex = 10
        '
        'FederalListBox
        '
        Me.FederalListBox.Enabled = False
        Me.FederalListBox.FormattingEnabled = True
        Me.FederalListBox.Location = New System.Drawing.Point(472, 50)
        Me.FederalListBox.Name = "FederalListBox"
        Me.FederalListBox.Size = New System.Drawing.Size(120, 225)
        Me.FederalListBox.TabIndex = 11
        '
        'StateListBox
        '
        Me.StateListBox.Enabled = False
        Me.StateListBox.FormattingEnabled = True
        Me.StateListBox.Location = New System.Drawing.Point(625, 50)
        Me.StateListBox.Name = "StateListBox"
        Me.StateListBox.Size = New System.Drawing.Size(120, 225)
        Me.StateListBox.TabIndex = 12
        '
        'PayTextBox
        '
        Me.PayTextBox.Location = New System.Drawing.Point(161, 295)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.Size = New System.Drawing.Size(120, 20)
        Me.PayTextBox.TabIndex = 13
        '
        'FICATextBox
        '
        Me.FICATextBox.Location = New System.Drawing.Point(316, 295)
        Me.FICATextBox.Name = "FICATextBox"
        Me.FICATextBox.Size = New System.Drawing.Size(120, 20)
        Me.FICATextBox.TabIndex = 14
        '
        'FederalTextBox
        '
        Me.FederalTextBox.Location = New System.Drawing.Point(472, 295)
        Me.FederalTextBox.Name = "FederalTextBox"
        Me.FederalTextBox.Size = New System.Drawing.Size(120, 20)
        Me.FederalTextBox.TabIndex = 15
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(625, 294)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(120, 20)
        Me.StateTextBox.TabIndex = 16
        '
        'EditEmployeeButton
        '
        Me.EditEmployeeButton.Enabled = False
        Me.EditEmployeeButton.Location = New System.Drawing.Point(267, 349)
        Me.EditEmployeeButton.Name = "EditEmployeeButton"
        Me.EditEmployeeButton.Size = New System.Drawing.Size(104, 23)
        Me.EditEmployeeButton.TabIndex = 17
        Me.EditEmployeeButton.Text = "Edit Employee"
        Me.EditEmployeeButton.UseVisualStyleBackColor = True
        '
        'DeleteEmployeeButton
        '
        Me.DeleteEmployeeButton.Enabled = False
        Me.DeleteEmployeeButton.Location = New System.Drawing.Point(549, 349)
        Me.DeleteEmployeeButton.Name = "DeleteEmployeeButton"
        Me.DeleteEmployeeButton.Size = New System.Drawing.Size(120, 23)
        Me.DeleteEmployeeButton.TabIndex = 18
        Me.DeleteEmployeeButton.Text = "Delete Employee"
        Me.DeleteEmployeeButton.UseVisualStyleBackColor = True
        '
        'SaveReturnButton
        '
        Me.SaveReturnButton.Location = New System.Drawing.Point(316, 400)
        Me.SaveReturnButton.Name = "SaveReturnButton"
        Me.SaveReturnButton.Size = New System.Drawing.Size(120, 23)
        Me.SaveReturnButton.TabIndex = 19
        Me.SaveReturnButton.Text = "Save and Return"
        Me.SaveReturnButton.UseVisualStyleBackColor = True
        '
        'CancelReturnButton
        '
        Me.CancelReturnButton.Location = New System.Drawing.Point(549, 400)
        Me.CancelReturnButton.Name = "CancelReturnButton"
        Me.CancelReturnButton.Size = New System.Drawing.Size(120, 23)
        Me.CancelReturnButton.TabIndex = 20
        Me.CancelReturnButton.Text = "Cancel and Return"
        Me.CancelReturnButton.UseVisualStyleBackColor = True
        '
        'SaveEmployeeButton
        '
        Me.SaveEmployeeButton.Enabled = False
        Me.SaveEmployeeButton.Location = New System.Drawing.Point(377, 349)
        Me.SaveEmployeeButton.Name = "SaveEmployeeButton"
        Me.SaveEmployeeButton.Size = New System.Drawing.Size(128, 23)
        Me.SaveEmployeeButton.TabIndex = 21
        Me.SaveEmployeeButton.Text = "Save Edited Employee"
        Me.SaveEmployeeButton.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SaveEmployeeButton)
        Me.Controls.Add(Me.CancelReturnButton)
        Me.Controls.Add(Me.SaveReturnButton)
        Me.Controls.Add(Me.DeleteEmployeeButton)
        Me.Controls.Add(Me.EditEmployeeButton)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.FederalTextBox)
        Me.Controls.Add(Me.FICATextBox)
        Me.Controls.Add(Me.PayTextBox)
        Me.Controls.Add(Me.StateListBox)
        Me.Controls.Add(Me.FederalListBox)
        Me.Controls.Add(Me.FICAListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PayListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Controls.Add(Me.NameListBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Setup"
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameListBox As ListBox
    Friend WithEvents AddEmployeeButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PayListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FICAListBox As ListBox
    Friend WithEvents FederalListBox As ListBox
    Friend WithEvents StateListBox As ListBox
    Friend WithEvents PayTextBox As TextBox
    Friend WithEvents FICATextBox As TextBox
    Friend WithEvents FederalTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents EditEmployeeButton As Button
    Friend WithEvents DeleteEmployeeButton As Button
    Friend WithEvents SaveReturnButton As Button
    Friend WithEvents CancelReturnButton As Button
    Friend WithEvents SaveEmployeeButton As Button
End Class
