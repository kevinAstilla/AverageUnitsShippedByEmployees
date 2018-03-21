'/****************************** Module Header ******************************\
'Module Name : AverageUnitsShippedByEmployee.vb
'Project: Lab 3 Average Units Shipped by Employees
'Copyright (c) Kevin Astilla
'Date Modified: March , 2018

'the program is created to store a weeks worth of history in a multidimensional 
'array then is later used to calculate the average units in the week
'it consists of buttons that will calculate, reset and exit the program

'THIS CODE And INFORMATION Is PROVIDED "AS IS" WITHOUT WARRANTY Of ANY KIND,
'EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED To THE IMPLIED
'WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE.
'\*****************************************************************

Option Strict On
Public Class frmAverageUnitsShippedByEmployee
    'class level constants
    Private Const numberOfEmpoyees As Integer = 2
    Private Const daysInAWeek As Integer = 6

    'we create a 2D array that will represent the number of employees and 
    'number of days in the week, the recorded number in the index will be the units
    'we did minus one because array index starts from 0
    Private employeeUnitsShipped(numberOfEmpoyees, daysInAWeek) As Integer
    Private employeeNumber As Integer = 0
    Private dayOfTheWeek As Integer = 0

    ''' <summary>
    ''' this private function is created to get the average of an array by going 
    ''' through a nested for loop
    ''' </summary>
    ''' <param name="unitRecord"></param>
    ''' <returns></returns>
    Private Function GetAverage(ByRef unitRecord(,) As Integer) As Double


        Dim totalInArray As Double 'this value will hold the total value in the array
        Dim divisor As Integer 'this value will increment as the loop repeats

        'we then first create the first index loop
        For firstIndex As Integer = 0 To numberOfEmpoyees
            'then followed by the seond index loop
            For secondIndex As Integer = 0 To daysInAWeek
                'it is inside the second index loop where the addition and incement occurs
                totalInArray += unitRecord(firstIndex, secondIndex)
                divisor += 1
            Next
        Next
        'once the total units have been collected, we then use our counter to divide
        'the accumulated total, giving us the averag
        Return totalInArray / divisor

    End Function

    ''' <summary>
    ''' this function calculates the average of a specific first index of
    ''' the array. it was created that it can work for jagged arrays as well
    ''' </summary>
    ''' <param name="employeeRecord"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Private Function AverageOfIndex(ByRef employeeRecord(,) As Integer, index As Integer) As Double
        Dim employeeTotal As Double
        Dim recordedUnit As Integer = daysInAWeek + 1

        For day As Integer = 0 To daysInAWeek
            employeeTotal += employeeRecord(index, day)
        Next
        Return employeeTotal / recordedUnit
    End Function

    ''' <summary>
    ''' the reset form resets the entire form textbox and labels
    ''' it also resets the values stores in the memory for the form
    ''' </summary>
    Private Sub ResetForm()
        For Each controlBox As Object In Me.Controls
            If (TypeOf (controlBox) Is TextBox) Then 'empties all textbox
                CType(controlBox, TextBox).Text = String.Empty

            ElseIf (TypeOf (controlBox) Is Label) Then 'empties all label that has fixed3d border
                If (CType(controlBox, Label).BorderStyle = BorderStyle.Fixed3D) Then
                    CType(controlBox, Label).Text = String.Empty
                End If
            End If
        Next
        'restarts the values in stored in memory
        employeeNumber = 0
        dayOfTheWeek = 0
        'restarts the focus of the labels
        lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Bold)
        lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
        lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Regular)

        tbInput.ReadOnly = False
        tbInput.Focus()
        btnEnter.Enabled = True
    End Sub

    ''' <summary>
    ''' the method will end/close the windows form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()                     'closes the program
    End Sub

    ''' <summary>
    ''' this button is the backbone of the software
    ''' it validates input and assignes it to a specific array location
    ''' it als handles the logic structure in updating the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim unitEntered As Integer 'this variable acts a temporary holder of the input while validating

        'we first validate of there are any inputs, if nonm give a warning and refocus
        If (tbInput.Text Is Nothing) Then
            MessageBox.Show("Please enter number of units.")
            tbInput.Focus()
            'we then validate to check if the input was a whole number
            'if not, we then give a warning - focus on the input textbox - then select the input
        ElseIf (Not Integer.TryParse(tbInput.Text, unitEntered)) Then
            MessageBox.Show("Units Cannot be stored as fraction.")
            tbInput.Focus()
            tbInput.SelectAll()
            'lastly we validate if the input is within the range of the defined scope
            'if no, we then give a warning  - focus on the input box - then select the input
        ElseIf (unitEntered < 0 Or unitEntered > 1000) Then
            MessageBox.Show("Units stored can only be between 0 to 1000.")
            tbInput.Focus()
            tbInput.SelectAll()
            'once the input is validated, we then proceed to assigning the variable
        Else
            'we assign the validated inut to the array in the class
            employeeUnitsShipped(employeeNumber, dayOfTheWeek) = unitEntered
            'we then choose where in the multiline textbox to display the input
            'the label on top of the multiline textbox changes font to indicate where it is being stored

            'for employee 1 displays
            If (employeeNumber = 0) Then
                lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Bold)
                lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
                lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Regular)
                tbEmployeeOneRecord.Text += employeeUnitsShipped(employeeNumber, dayOfTheWeek).ToString & vbCrLf

                'once the day of the week is completed for this employee, we then calculated the employee average
                If (dayOfTheWeek = 6) Then
                    lblEmployeeOneAverage.Text = "Average: " + AverageOfIndex(employeeUnitsShipped, employeeNumber).ToString("N2")
                End If
                'for employee 2 displays
            ElseIf (employeeNumber = 1) Then
                lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Regular)
                lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Bold)
                lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Regular)
                tbEmployeeTwoRecord.Text += employeeUnitsShipped(employeeNumber, dayOfTheWeek).ToString & vbCrLf

                'once the day of the week is completed for this employee, we then calculated the employee average
                If (dayOfTheWeek = 6) Then
                    lblEmployeeTwoAverage.Text = "Average: " + AverageOfIndex(employeeUnitsShipped, employeeNumber).ToString("N2")
                End If
                'for employee 3 displays 
            ElseIf (employeeNumber = 2) Then
                lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Regular)
                lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
                lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Bold)
                tbEmployeeThreeRecord.Text += employeeUnitsShipped(employeeNumber, dayOfTheWeek).ToString & vbCrLf

                'once the day of the week is completed for this employee, we then calculated the employee average
                If (dayOfTheWeek = 6) Then
                    lblEmployeeThreeAverage.Text = "Average: " + AverageOfIndex(employeeUnitsShipped, employeeNumber).ToString("N2")
                End If
            End If

            'the textbox is then cleared for the next input and is focused
            tbInput.ResetText()
            tbInput.Focus()
            'we increment the counter by 1 to go to the next array location
            dayOfTheWeek += 1


            'when the day of the week reach 7, this if statement will increment the employee 
            'number and turn day of the week back to 0
            If (dayOfTheWeek = 7 And employeeNumber < 3) Then
                employeeNumber += 1
                dayOfTheWeek = 0
            End If

        End If
        'updating the DayDisplay does not have to happen withing the nested of for assignment
        lblDayDisplay.Text = "Day: " + (dayOfTheWeek + 1).ToString

        'this is only envoked when all the employee inputs have been obtained
        'this if updates the Dayy Display to Done
        'it disables the input texbox as well as the button to enter
        If (employeeNumber = 3) Then
            lblDayDisplay.Text = "Done"
            btnEnter.Enabled = False
            tbInput.ReadOnly = True
            'the overall average is also calsulated and displayed
            lblAveragePerDay.Text = "Average per day: " + GetAverage(employeeUnitsShipped).ToString("N2")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm() 'this button calls in the function for clearing the form
    End Sub
End Class
