' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz1_3

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 6 out of 9"
        Button_Menu.Hide()
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Guineapig.Enabled = False : Guineapig.BackColor = Color.Gray
        Nail.Enabled = False : Nail.BackColor = Color.Gray
        Orange.Enabled = False : Orange.BackColor = Color.Gray
        Wall.Enabled = False : Wall.BackColor = Color.Gray
        Yoga.Enabled = False : Yoga.BackColor = Color.Gray
        Fish.Enabled = False : Fish.BackColor = Color.Gray
    End Sub

    Private Sub Cat_Click(sender As Object, e As EventArgs) Handles Cat.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Dog_Click(sender As Object, e As EventArgs) Handles Dog.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 7 out of 9"
        Guineapig.Enabled = True : Guineapig.BackColor = Color.White
        Nail.Enabled = True : Nail.BackColor = Color.White
        Orange.Enabled = True : Orange.BackColor = Color.White
        Cat.Enabled = False : Cat.BackColor = Color.Gray
        Dog.Enabled = False : Dog.BackColor = Color.Gray
        Elephant.Enabled = False : Elephant.BackColor = Color.Gray
    End Sub

    Private Sub Elephant_Click(sender As Object, e As EventArgs) Handles Elephant.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Guineapig_Click(sender As Object, e As EventArgs) Handles Guineapig.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 8 out of 9"
        Guineapig.Enabled = False : Guineapig.BackColor = Color.Gray
        Nail.Enabled = False : Nail.BackColor = Color.Gray
        Orange.Enabled = False : Orange.BackColor = Color.Gray
        Wall.Enabled = True : Wall.BackColor = Color.White
        Yoga.Enabled = True : Yoga.BackColor = Color.White
        Fish.Enabled = True : Fish.BackColor = Color.White
    End Sub

    Private Sub Nail_Click(sender As Object, e As EventArgs) Handles Nail.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Wall_Click(sender As Object, e As EventArgs) Handles Wall.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Yoga_Click(sender As Object, e As EventArgs) Handles Yoga.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Fish_Click(sender As Object, e As EventArgs) Handles Fish.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 9 out of 9 - Congratulations!"
        Wall.Enabled = False : Wall.BackColor = Color.Gray
        Yoga.Enabled = False : Yoga.BackColor = Color.Gray
        Fish.Enabled = False : Fish.BackColor = Color.Gray
        Button_Menu.Show()
        Button_Close.Enabled = True
        Button_Close.BackColor = Color.WhiteSmoke
        Button_Close.ForeColor = Color.Black

        ' Ceremonial transition to results sanctuary
        Dim resultForm As New FormQ1_Done()
        resultForm.txtUserName.Text = Globals.UserName
        resultForm.lblDateTime.Text = Globals.QuizDate
        resultForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
        Form_Quiz1_1.Close()
        Form_Quiz1_2.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Me.Close()
        Form0.Close()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        Form_Quiz1_1.Close()
        Form_Quiz1_2.Close()
        Form_TakeQuiz1.txtUserName.Text = ""
        Me.Close()
        Form0.Show()
    End Sub
End Class