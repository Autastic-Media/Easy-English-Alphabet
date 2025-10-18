' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz4_3

    'This Hides the Next button, continues previous score and disables question 8 and 9 answer buttons.

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 6 out of 9"
        Button_Menu.Hide()
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Guineapig.Enabled = False
        Guineapig.BackColor = Color.Gray
        Violin.Enabled = False
        Violin.BackColor = Color.Gray
        Orange.Enabled = False
        Orange.BackColor = Color.Gray
        Queen.Enabled = False
        Queen.BackColor = Color.Gray
        Yoga.Enabled = False
        Yoga.BackColor = Color.Gray
        Rocket.Enabled = False
        Rocket.BackColor = Color.Gray
    End Sub

    Private Sub Elephant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elephant.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Dog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dog.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables question 8 buttons and disables question 7 buttons. It also adds 1 point for the correct answer.

    Private Sub Zebra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zebra.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 7 out of 9"
        Guineapig.Enabled = True
        Guineapig.BackColor = Color.White
        Violin.Enabled = True
        Violin.BackColor = Color.White
        Orange.Enabled = True
        Orange.BackColor = Color.White
        Zebra.Enabled = False
        Zebra.BackColor = Color.Gray
        Dog.Enabled = False
        Dog.BackColor = Color.Gray
        Elephant.Enabled = False
        Elephant.BackColor = Color.Gray
    End Sub


    Private Sub Guineapig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guineapig.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables question 9 buttons and disables question 8 buttons. It also adds 1 point for the correct answer.

    Private Sub Violin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Violin.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 8 out of 9"
        Guineapig.Enabled = False
        Guineapig.BackColor = Color.Gray
        Violin.Enabled = False
        Violin.BackColor = Color.Gray
        Orange.Enabled = False
        Orange.BackColor = Color.Gray
        Queen.Enabled = True
        Queen.BackColor = Color.White
        Yoga.Enabled = True
        Yoga.BackColor = Color.White
        Rocket.Enabled = True
        Rocket.BackColor = Color.White
    End Sub

    Private Sub Orange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Orange.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Rocket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rocket.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Yoga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yoga.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables the Next button and disables question 8 buttons. It also adds 1 point for the correct answer.

    Private Sub Queen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Queen.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 9 out of 9 - Congratulations!"
        Queen.Enabled = False
        Queen.BackColor = Color.Gray
        Yoga.Enabled = False
        Yoga.BackColor = Color.Gray
        Rocket.Enabled = False
        Rocket.BackColor = Color.Gray
        Button_Menu.Show()

        ' Ceremonial transition to results sanctuary
        Dim resultForm As New FormQ4_Done()
        resultForm.txtUserName.Text = Globals.UserName
        resultForm.lblDateTime.Text = Globals.QuizDate
        resultForm.Show()
        Me.Hide()

        Button_Close.Enabled = True
        Button_Close.BackColor = Color.WhiteSmoke
        Button_Close.ForeColor = Color.Black
    End Sub


    Private Sub Button_Close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_Quiz4_1.Close()
        Form_Quiz4_2.Close()
        Form_TakeQuiz4.txtUserName.Text = ""
        Form0.Close()
    End Sub

    Private Sub Button_Menu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Menu.Click
        Me.Close()
        Form_Quiz4_1.Close()
        Form_Quiz4_2.Close()
        Form_TakeQuiz4.txtUserName.Text = ""
        Form0.Show()
    End Sub
End Class
