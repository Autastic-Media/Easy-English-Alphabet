' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz4_1

    'This Hides the Next button and disables question 2 and 3 answer buttons.

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_Next.Hide()
        Teddy.Enabled = False
        Teddy.BackColor = Color.Gray
        Icecream.Enabled = False
        Icecream.BackColor = Color.Gray
        Horse.Enabled = False
        Horse.BackColor = Color.Gray
        Cat.Enabled = False
        Cat.BackColor = Color.Gray
        Elephant.Enabled = False
        Elephant.BackColor = Color.Gray
        Pig.Enabled = False
        Pig.BackColor = Color.Gray
    End Sub

    Private Sub Orange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Orange.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub


    'This Enables question 2 buttons and disables question 1 buttons. It also adds 1 point for the correct answer.

    Private Sub Rocket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rocket.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 1 out of 9"
        Teddy.Enabled = True
        Teddy.BackColor = Color.Gray
        Icecream.Enabled = True
        Icecream.BackColor = Color.Gray
        Horse.Enabled = True
        Horse.BackColor = Color.Gray
        Orange.Enabled = False
        Orange.BackColor = Color.Gray
        Rocket.Enabled = False
        Rocket.BackColor = Color.Gray()
        Fish.Enabled = False
        Fish.BackColor = Color.Gray
    End Sub

    Private Sub Fish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fish.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Icecream_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icecream.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Horse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horse.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub


    'This Enables question 3 buttons and disables question 2 buttons. It also adds 1 point for the correct answer.

    Private Sub Teddy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teddy.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 2 out of 9"
        Teddy.Enabled = False
        Teddy.BackColor = Color.Gray
        Icecream.Enabled = False
        Icecream.BackColor = Color.Gray
        Horse.Enabled = False
        Horse.BackColor = Color.Gray
        Cat.Enabled = True
        Cat.BackColor = Color.Gray
        Elephant.Enabled = True
        Elephant.BackColor = Color.Gray
        Pig.Enabled = True
        Pig.BackColor = Color.Gray
    End Sub

    Private Sub Cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cat.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables the Next button and disables question 3 buttons. It also adds 1 point for the correct answer.

    Private Sub Elephant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elephant.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 3 out of 9"
        Button_Next.Show()
        Cat.Enabled = False
        Cat.BackColor = Color.Gray
        Elephant.Enabled = False
        Elephant.BackColor = Color.Gray
        Pig.Enabled = False
        Pig.BackColor = Color.Gray
    End Sub

    Private Sub Pig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pig.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        Form0.Show()
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz4_2.Show()
        Me.Hide()
    End Sub
End Class
