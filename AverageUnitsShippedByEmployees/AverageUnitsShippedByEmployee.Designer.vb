<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.tbEmployeeOneRecord = New System.Windows.Forms.TextBox()
        Me.tbEmployeeTwoRecord = New System.Windows.Forms.TextBox()
        Me.tbEmployeeThreeRecord = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tltpAverageUnitsShippedByEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.Location = New System.Drawing.Point(15, 32)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(57, 23)
        Me.lblDayDisplay.TabIndex = 0
        Me.lblDayDisplay.Text = "Day: 1"
        Me.lblDayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(15, 67)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(57, 32)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOne.Location = New System.Drawing.Point(18, 99)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(133, 23)
        Me.lblEmployeeOne.TabIndex = 3
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(162, 99)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(133, 23)
        Me.lblEmployeeTwo.TabIndex = 5
        Me.lblEmployeeTwo.Text = "Employee 2"
        Me.lblEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.Location = New System.Drawing.Point(306, 99)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(133, 23)
        Me.lblEmployeeThree.TabIndex = 7
        Me.lblEmployeeThree.Text = "Employee 3"
        Me.lblEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(18, 279)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(133, 28)
        Me.lblEmployeeOneAverage.TabIndex = 9
        Me.lblEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.lblEmployeeOneAverage, "Week Average for Employee 1")
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(162, 279)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(133, 28)
        Me.lblEmployeeTwoAverage.TabIndex = 10
        Me.lblEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.lblEmployeeTwoAverage, "Week Average for Employee 2")
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(306, 279)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(133, 28)
        Me.lblEmployeeThreeAverage.TabIndex = 11
        Me.lblEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.lblEmployeeThreeAverage, "Week Average for Employee 3")
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(18, 315)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(421, 28)
        Me.lblAveragePerDay.TabIndex = 12
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.lblAveragePerDay, "Overal Daily Average of Three Employees")
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(78, 74)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(73, 22)
        Me.tbInput.TabIndex = 2
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.tbInput, "Units Employee Shipped. Minimum is 0 and Maximum is 1000")
        '
        'tbEmployeeOneRecord
        '
        Me.tbEmployeeOneRecord.Location = New System.Drawing.Point(18, 130)
        Me.tbEmployeeOneRecord.Multiline = True
        Me.tbEmployeeOneRecord.Name = "tbEmployeeOneRecord"
        Me.tbEmployeeOneRecord.ReadOnly = True
        Me.tbEmployeeOneRecord.Size = New System.Drawing.Size(133, 141)
        Me.tbEmployeeOneRecord.TabIndex = 4
        Me.tbEmployeeOneRecord.TabStop = False
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeOneRecord, "Displays Units shipped for Employee 1")
        '
        'tbEmployeeTwoRecord
        '
        Me.tbEmployeeTwoRecord.Location = New System.Drawing.Point(162, 130)
        Me.tbEmployeeTwoRecord.Multiline = True
        Me.tbEmployeeTwoRecord.Name = "tbEmployeeTwoRecord"
        Me.tbEmployeeTwoRecord.ReadOnly = True
        Me.tbEmployeeTwoRecord.Size = New System.Drawing.Size(133, 141)
        Me.tbEmployeeTwoRecord.TabIndex = 6
        Me.tbEmployeeTwoRecord.TabStop = False
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeTwoRecord, "Displays Units shipped for Employee 2")
        '
        'tbEmployeeThreeRecord
        '
        Me.tbEmployeeThreeRecord.Location = New System.Drawing.Point(306, 130)
        Me.tbEmployeeThreeRecord.Multiline = True
        Me.tbEmployeeThreeRecord.Name = "tbEmployeeThreeRecord"
        Me.tbEmployeeThreeRecord.ReadOnly = True
        Me.tbEmployeeThreeRecord.Size = New System.Drawing.Size(133, 141)
        Me.tbEmployeeThreeRecord.TabIndex = 8
        Me.tbEmployeeThreeRecord.TabStop = False
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.tbEmployeeThreeRecord, "Displays Units shipped for Employee 3")
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Location = New System.Drawing.Point(18, 351)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(133, 29)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.btnEnter, "Stores the number in the units textbox")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(162, 351)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(133, 29)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.btnReset, "Resets the form and erases the numbers")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(306, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 29)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.tltpAverageUnitsShippedByEmployee.SetToolTip(Me.btnExit, "Closes the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(460, 415)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbEmployeeThreeRecord)
        Me.Controls.Add(Me.tbEmployeeTwoRecord)
        Me.Controls.Add(Me.tbEmployeeOneRecord)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents tbEmployeeOneRecord As TextBox
    Friend WithEvents tbEmployeeTwoRecord As TextBox
    Friend WithEvents tbEmployeeThreeRecord As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tltpAverageUnitsShippedByEmployee As ToolTip
End Class
