<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Me.Title = New System.Windows.Forms.Label()
        Me.nameListBox = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.payPerHourLabel = New System.Windows.Forms.Label()
        Me.hoursWorkedLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.payTextBox = New System.Windows.Forms.TextBox()
        Me.hoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.computeDeductionsButton = New System.Windows.Forms.Button()
        Me.setupButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.grossPayLabel = New System.Windows.Forms.Label()
        Me.FICALabel = New System.Windows.Forms.Label()
        Me.grossPayTextBox = New System.Windows.Forms.TextBox()
        Me.federalLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.FICATextBox = New System.Windows.Forms.TextBox()
        Me.FederalTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.netTextBox = New System.Windows.Forms.TextBox()
        Me.netLabel = New System.Windows.Forms.Label()
        Me.payListBox = New System.Windows.Forms.ListBox()
        Me.FICAListBox = New System.Windows.Forms.ListBox()
        Me.federalListBox = New System.Windows.Forms.ListBox()
        Me.stateListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Title.Location = New System.Drawing.Point(245, 32)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(353, 39)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Kylyn's Tax Calculator"
        '
        'nameListBox
        '
        Me.nameListBox.FormattingEnabled = True
        Me.nameListBox.Location = New System.Drawing.Point(24, 106)
        Me.nameListBox.Name = "nameListBox"
        Me.nameListBox.Size = New System.Drawing.Size(168, 303)
        Me.nameListBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(221, 120)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name:"
        '
        'payPerHourLabel
        '
        Me.payPerHourLabel.AutoSize = True
        Me.payPerHourLabel.Location = New System.Drawing.Point(221, 176)
        Me.payPerHourLabel.Name = "payPerHourLabel"
        Me.payPerHourLabel.Size = New System.Drawing.Size(73, 13)
        Me.payPerHourLabel.TabIndex = 3
        Me.payPerHourLabel.Text = "Pay Per Hour:"
        '
        'hoursWorkedLabel
        '
        Me.hoursWorkedLabel.AutoSize = True
        Me.hoursWorkedLabel.Location = New System.Drawing.Point(219, 231)
        Me.hoursWorkedLabel.Name = "hoursWorkedLabel"
        Me.hoursWorkedLabel.Size = New System.Drawing.Size(79, 13)
        Me.hoursWorkedLabel.TabIndex = 4
        Me.hoursWorkedLabel.Text = "Hours Worked:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Enabled = False
        Me.nameTextBox.Location = New System.Drawing.Point(304, 117)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.nameTextBox.TabIndex = 5
        '
        'payTextBox
        '
        Me.payTextBox.Enabled = False
        Me.payTextBox.Location = New System.Drawing.Point(304, 173)
        Me.payTextBox.Name = "payTextBox"
        Me.payTextBox.Size = New System.Drawing.Size(131, 20)
        Me.payTextBox.TabIndex = 6
        '
        'hoursWorkedTextBox
        '
        Me.hoursWorkedTextBox.Location = New System.Drawing.Point(304, 228)
        Me.hoursWorkedTextBox.Name = "hoursWorkedTextBox"
        Me.hoursWorkedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.hoursWorkedTextBox.TabIndex = 7
        '
        'computeDeductionsButton
        '
        Me.computeDeductionsButton.Location = New System.Drawing.Point(304, 277)
        Me.computeDeductionsButton.Name = "computeDeductionsButton"
        Me.computeDeductionsButton.Size = New System.Drawing.Size(131, 23)
        Me.computeDeductionsButton.TabIndex = 8
        Me.computeDeductionsButton.Text = "Compute Deductions"
        Me.computeDeductionsButton.UseVisualStyleBackColor = True
        '
        'setupButton
        '
        Me.setupButton.Location = New System.Drawing.Point(224, 326)
        Me.setupButton.Name = "setupButton"
        Me.setupButton.Size = New System.Drawing.Size(75, 23)
        Me.setupButton.TabIndex = 9
        Me.setupButton.Text = "Setup"
        Me.setupButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(222, 386)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 10
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'grossPayLabel
        '
        Me.grossPayLabel.AutoSize = True
        Me.grossPayLabel.Location = New System.Drawing.Point(469, 117)
        Me.grossPayLabel.Name = "grossPayLabel"
        Me.grossPayLabel.Size = New System.Drawing.Size(58, 13)
        Me.grossPayLabel.TabIndex = 11
        Me.grossPayLabel.Text = "Gross Pay:"
        '
        'FICALabel
        '
        Me.FICALabel.AutoSize = True
        Me.FICALabel.Location = New System.Drawing.Point(472, 172)
        Me.FICALabel.Name = "FICALabel"
        Me.FICALabel.Size = New System.Drawing.Size(97, 13)
        Me.FICALabel.TabIndex = 12
        Me.FICALabel.Text = "FICA Withholdings:"
        '
        'grossPayTextBox
        '
        Me.grossPayTextBox.Enabled = False
        Me.grossPayTextBox.Location = New System.Drawing.Point(591, 117)
        Me.grossPayTextBox.Name = "grossPayTextBox"
        Me.grossPayTextBox.Size = New System.Drawing.Size(146, 20)
        Me.grossPayTextBox.TabIndex = 13
        '
        'federalLabel
        '
        Me.federalLabel.AutoSize = True
        Me.federalLabel.Location = New System.Drawing.Point(470, 228)
        Me.federalLabel.Name = "federalLabel"
        Me.federalLabel.Size = New System.Drawing.Size(109, 13)
        Me.federalLabel.TabIndex = 14
        Me.federalLabel.Text = "Federal Withholdings:"
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.Location = New System.Drawing.Point(470, 277)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(99, 13)
        Me.stateLabel.TabIndex = 15
        Me.stateLabel.Text = "State Withholdings:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(470, 332)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(98, 13)
        Me.totalLabel.TabIndex = 16
        Me.totalLabel.Text = "Total Withholdings:"
        '
        'FICATextBox
        '
        Me.FICATextBox.Enabled = False
        Me.FICATextBox.Location = New System.Drawing.Point(591, 169)
        Me.FICATextBox.Name = "FICATextBox"
        Me.FICATextBox.Size = New System.Drawing.Size(146, 20)
        Me.FICATextBox.TabIndex = 17
        '
        'FederalTextBox
        '
        Me.FederalTextBox.Enabled = False
        Me.FederalTextBox.Location = New System.Drawing.Point(591, 225)
        Me.FederalTextBox.Name = "FederalTextBox"
        Me.FederalTextBox.Size = New System.Drawing.Size(146, 20)
        Me.FederalTextBox.TabIndex = 18
        '
        'StateTextBox
        '
        Me.StateTextBox.Enabled = False
        Me.StateTextBox.Location = New System.Drawing.Point(591, 274)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(146, 20)
        Me.StateTextBox.TabIndex = 19
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(591, 329)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(146, 20)
        Me.TotalTextBox.TabIndex = 20
        '
        'netTextBox
        '
        Me.netTextBox.Enabled = False
        Me.netTextBox.Location = New System.Drawing.Point(591, 388)
        Me.netTextBox.Name = "netTextBox"
        Me.netTextBox.Size = New System.Drawing.Size(146, 20)
        Me.netTextBox.TabIndex = 21
        '
        'netLabel
        '
        Me.netLabel.AutoSize = True
        Me.netLabel.Location = New System.Drawing.Point(472, 391)
        Me.netLabel.Name = "netLabel"
        Me.netLabel.Size = New System.Drawing.Size(48, 13)
        Me.netLabel.TabIndex = 22
        Me.netLabel.Text = "Net Pay:"
        '
        'payListBox
        '
        Me.payListBox.FormattingEnabled = True
        Me.payListBox.Location = New System.Drawing.Point(222, 415)
        Me.payListBox.Name = "payListBox"
        Me.payListBox.Size = New System.Drawing.Size(120, 95)
        Me.payListBox.TabIndex = 23
        Me.payListBox.Visible = False
        '
        'FICAListBox
        '
        Me.FICAListBox.FormattingEnabled = True
        Me.FICAListBox.Location = New System.Drawing.Point(348, 415)
        Me.FICAListBox.Name = "FICAListBox"
        Me.FICAListBox.Size = New System.Drawing.Size(120, 95)
        Me.FICAListBox.TabIndex = 24
        Me.FICAListBox.Visible = False
        '
        'federalListBox
        '
        Me.federalListBox.FormattingEnabled = True
        Me.federalListBox.Location = New System.Drawing.Point(475, 415)
        Me.federalListBox.Name = "federalListBox"
        Me.federalListBox.Size = New System.Drawing.Size(120, 95)
        Me.federalListBox.TabIndex = 25
        Me.federalListBox.Visible = False
        '
        'stateListBox
        '
        Me.stateListBox.FormattingEnabled = True
        Me.stateListBox.Location = New System.Drawing.Point(602, 415)
        Me.stateListBox.Name = "stateListBox"
        Me.stateListBox.Size = New System.Drawing.Size(120, 95)
        Me.stateListBox.TabIndex = 26
        Me.stateListBox.Visible = False
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.stateListBox)
        Me.Controls.Add(Me.federalListBox)
        Me.Controls.Add(Me.FICAListBox)
        Me.Controls.Add(Me.payListBox)
        Me.Controls.Add(Me.netLabel)
        Me.Controls.Add(Me.netTextBox)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.FederalTextBox)
        Me.Controls.Add(Me.FICATextBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Me.federalLabel)
        Me.Controls.Add(Me.grossPayTextBox)
        Me.Controls.Add(Me.FICALabel)
        Me.Controls.Add(Me.grossPayLabel)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.setupButton)
        Me.Controls.Add(Me.computeDeductionsButton)
        Me.Controls.Add(Me.hoursWorkedTextBox)
        Me.Controls.Add(Me.payTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.hoursWorkedLabel)
        Me.Controls.Add(Me.payPerHourLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.nameListBox)
        Me.Controls.Add(Me.Title)
        Me.Name = "WelcomePage"
        Me.Text = "WelcomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents nameListBox As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents payPerHourLabel As Label
    Friend WithEvents hoursWorkedLabel As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents payTextBox As TextBox
    Friend WithEvents hoursWorkedTextBox As TextBox
    Friend WithEvents computeDeductionsButton As Button
    Friend WithEvents setupButton As Button
    Friend WithEvents quitButton As Button
    Friend WithEvents grossPayLabel As Label
    Friend WithEvents FICALabel As Label
    Friend WithEvents grossPayTextBox As TextBox
    Friend WithEvents federalLabel As Label
    Friend WithEvents stateLabel As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents FICATextBox As TextBox
    Friend WithEvents FederalTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents netTextBox As TextBox
    Friend WithEvents netLabel As Label
    Friend WithEvents payListBox As ListBox
    Friend WithEvents FICAListBox As ListBox
    Friend WithEvents federalListBox As ListBox
    Friend WithEvents stateListBox As ListBox
End Class
