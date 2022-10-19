Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim age As Integer
        Dim Tname As String
        Dim Email As String
        Dim Month As String
        Dim Day As String
        Dim Gender As String
        Dim Destination As String
        Dim Cost As Single
        Dim Duration As String
        Dim Meal As String
        Dim Spare_Time As String
        Dim Enjoy_your_stay_with_us As String


        'Validation for age
        If txtage.Text = Nothing Then
            MessageBox.Show("Enter Travellers Age")
        ElseIf Not IsNumeric(txtage.Text) Then
            MessageBox.Show("Enter Numbers only for age")
        ElseIf txtage.Text <= 18 Then
            MessageBox.Show("You are too young; go to mummy!")
            txtage.Text = Nothing
        ElseIf txtage.Text >= 70 Then
            MessageBox.Show("You are too old; go to Sleep!")
            txtage.Text = Nothing
        Else
            age = txtage.Text
        End If

        'validation for name
        If txtName.Text = Nothing Then
            MessageBox.Show("Enter Traveller's Name")
        ElseIf txtName.Text.Length < 3 Then
            MessageBox.Show("Enter minimum length of 3 char for Name")
        ElseIf txtName.Text.Length > 30 Then
            MessageBox.Show("Enter max length of 3 char for Name")
        Else
            Tname = txtName.Text
        End If

        'validation for Email
        If txtEmail.Text = Nothing Then
            MessageBox.Show("Enter Traveller's email address")
        ElseIf txtEmail.Text.Length < 10 Then
            MessageBox.Show("Enter minimum length of 10 character for email")
        ElseIf txtEmail.Text.Length > 50 Then
            MessageBox.Show("enter maximum length of 50 characters of email")
        Else
            Email = txtEmail.Text
        End If
        'Selection of month

        If cboMonth.Text = "January" Then
            Month = "Month : January"
        ElseIf cboMonth.Text = "February" Then
            Month = "Month :February"
        ElseIf cboMonth.Text = "March" Then
            Month = "Month : March"
        ElseIf cboMonth.Text = "April" Then
            Month = "Month : April"
        ElseIf cboMonth.Text = "May" Then
            Month = "Month : May"
        ElseIf cboMonth.Text = "June" Then
            Month = "Month : June"
        ElseIf cboMonth.Text = "July" Then
            Month = "Month : July"
        ElseIf cboMonth.Text = "August" Then
            Month = "Month : August"
        ElseIf cboMonth.Text = "September" Then
            Month = "Month : September"
        ElseIf cboMonth.Text = "October" Then
            Month = "Month : October"
        ElseIf cboMonth.Text = "November" Then
            Month = "Month : November"
        ElseIf cboMonth.Text = "December" Then
            Month = "Month : December"

        End If
        'Selection of Days
        If cboDay.Text = "1" Then
            Day = "Day : 1 "
        ElseIf cboDay.Text = "2" Then
            Day = "Day : 2"
        ElseIf cboDay.Text = "3" Then
            Day = "Day : 3"
        ElseIf cboDay.Text = "4" Then
            Day = "day : 4"
        ElseIf cboDay.Text = "5" Then
            Day = "Day : 5"
        ElseIf cboDay.Text = "6" Then
            Day = "Day :6"
        ElseIf cboDay.Text = "7" Then
            Day = "Day :7"
        ElseIf cboDay.Text = "8" Then
            Day = "Day :8"
        ElseIf cboDay.Text = "9" Then
            Day = "Day :9"
        ElseIf cboDay.Text = "10" Then
            Day = "Day :10"
        ElseIf cboDay.Text = "11" Then
            Day = "Day :11"
        ElseIf cboDay.Text = "12" Then
            Day = "Day :12"
        ElseIf cboDay.Text = "13" Then
            Day = "Day :13"
        ElseIf cboDay.Text = "14" Then
            Day = "Day :14"
        ElseIf cboDay.Text = "15" Then
            Day = "Day :15"
        ElseIf cboDay.Text = "16" Then
            Day = "Day :16"
        ElseIf cboDay.Text = "17" Then
            Day = "Day :17"
        ElseIf cboDay.Text = "18" Then
            Day = "Day :18"
        ElseIf cboDay.Text = "19" Then
            Day = "Day :18"
        ElseIf cboDay.Text = "19" Then
            Day = "Day :19"
        ElseIf cboDay.Text = "20" Then
            Day = "Day :20"
        ElseIf cboDay.Text = "21" Then
            Day = "Day :21"
        ElseIf cboDay.Text = "22" Then
            Day = "Day :22"
        ElseIf cboDay.Text = "23" Then
            Day = "Day :23"
        ElseIf cboDay.Text = "24" Then
            Day = "Day :24"
        ElseIf cboDay.Text = "25" Then
            Day = "Day :25"
        ElseIf cboDay.Text = "26" Then
            Day = "Day :26"
        ElseIf cboDay.Text = "27" Then
            Day = "Day :27"
        ElseIf cboDay.Text = "28" Then
            Day = "Day :28"
        ElseIf cboDay.Text = "29" Then
            Day = "Day :29"
        ElseIf cboDay.Text = "30" Then
            Day = "Day :30"
        ElseIf cboDay.Text = "31" Then
            Day = "Day :31"
        End If
        ' Selection of Gender
        If cboGender.Text = "Male" Then
            Gender = "Gender : Male"
        ElseIf cboGender.Text = "Female" Then
            Gender = "Gender : Female"
        End If
        'Selection of Destination
        If rbtnLondon.Checked = True Then
            Cost = 125
            Destination = "Destination city : Lodon"
        ElseIf rbtnBelfast.Checked = True Then
            Cost = 101
            Destination = "Destination city : Belfast"
        ElseIf rbtnEdinburgh.Checked = True Then
            Cost = 150
            Destination = "Destination city : Edinburgh"
        ElseIf rbtnCardiff.Checked = True Then
            Cost = 200
            Destination = "Destination city :  Cardiff"
        ElseIf rbtnManchester.Checked = True Then
            Cost = 225
            Destination = "Destination city :  Manchester"
        ElseIf rbtnNewcastle.Checked = True Then
            Cost = 300
            Destination = "Destination city : Newcastle"
        End If
        'Selection of Duration
        If rbtn2Nights.Checked = True Then
            Cost = Cost * 3
            Duration = "Duration : 2 Nights"
        ElseIf rbtn3Nights.Checked = True Then
            Cost = Cost * 3
            Duration = "Duration : 3 Nights"
        ElseIf rbtn7Nights.Checked = True Then
            Cost = Cost * 3
            Duration = "Duration : 7 Nights"
        End If
        'Selection of Meal
        If chkBreakfast.Checked = True Then
            Meal = "Breakfast"
            Cost = Cost + 24
        ElseIf chkDinner.checked = True Then
            Meal = "dinner"
            Cost = Cost + 24
        ElseIf chkLunch.Checked = True Then
            Meal = "Lunch"
            Cost = Cost + 24
        End If
        'Selection of  Spare_Time
        If chkFitness_Suite.Checked = True Then
            Spare_Time = "Fitness_Suite"
            Cost = Cost + 50
            Enjoy_your_stay_with_us = "Enjoy_your_stay_with_us"
        ElseIf chkGuide_City_Tour.Checked = True Then
            Spare_Time = "Guide_City_Tour"
            Cost = Cost + 50
            Enjoy_your_stay_with_us = "Enjoy_your_stay_with_us"
        ElseIf chkSpa_and_Pool.Checked = True Then
            Spare_Time = "Spa_and_Pool "
            Cost = Cost + 50



















































        End If
        lblReciept.Text = "Name: " & Tname & vbCrLf & "Age: " & age & vbCrLf & "Email: " & Email & vbCrLf & Month & vbCrLf & Day & vbCrLf & Gender & vbCrLf & Destination & vbCrLf & Duration & vbCrLf & " Meal : " & Meal & vbCrLf & " Spare_Time :" & Spare_Time & vbCrLf & "Cost: " & Cost & vbCrLf & Enjoy_your_stay_with_us






    End Sub

    Private Sub lblReciept_Click(sender As Object, e As EventArgs) Handles lblReciept.Click

    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged

    End Sub

    Private Sub rbtnManchester_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnManchester.CheckedChanged

    End Sub

    Private Sub rbtnEdinburgh_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEdinburgh.CheckedChanged

    End Sub

    Private Sub rbtnBelfast_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBelfast.CheckedChanged

    End Sub
End Class
