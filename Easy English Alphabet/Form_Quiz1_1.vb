' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz1_1

    'This Hides the Next button and disables question 2 and 3 answer buttons.

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_Next.Hide()
        Jam.Enabled = False
        Jam.BackColor = Color.Gray
        Kite.Enabled = False
        Kite.BackColor = Color.Gray
        Horse.Enabled = False
        Horse.BackColor = Color.Gray
        Meerkat.Enabled = False
        Meerkat.BackColor = Color.Gray
        Queen.Enabled = False
        Queen.BackColor = Color.Gray
        Pig.Enabled = False
        Pig.BackColor = Color.Gray
    End Sub

    'This Enables question 2 buttons and disables question 1 buttons. It also adds 1 point for the correct answer.

    Private Sub Apple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apple.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 1 out of 9"
        Jam.Enabled = True
        Jam.BackColor = Color.Gray
        Kite.Enabled = True
        Kite.BackColor = Color.Gray
        Horse.Enabled = True
        Horse.BackColor = Color.Gray
        Apple.Enabled = False
        Apple.BackColor = Color.Gray
        Ball.Enabled = False
        Ball.BackColor = Color.Gray()
        Fish.Enabled = False
        Fish.BackColor = Color.Gray
    End Sub

    Private Sub Ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ball.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Fish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fish.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Jam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jam.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Kite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kite.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables question 3 buttons and disables question 2 buttons. It also adds 1 point for the correct answer.

    Private Sub Horse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horse.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 2 out of 9"
        Jam.Enabled = False
        Jam.BackColor = Color.Gray
        Kite.Enabled = False
        Kite.BackColor = Color.Gray
        Horse.Enabled = False
        Horse.BackColor = Color.Gray
        Meerkat.Enabled = True
        Meerkat.BackColor = Color.Gray
        Queen.Enabled = True
        Queen.BackColor = Color.Gray
        Pig.Enabled = True
        Pig.BackColor = Color.Gray
    End Sub

    Private Sub Meerkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Meerkat.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables the Next button and disables question 3 buttons. It also adds 1 point for the correct answer.

    Private Sub Queen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Queen.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 3 out of 9"
        Button_Next.Show()
        Meerkat.Enabled = False
        Meerkat.BackColor = Color.Gray
        Queen.Enabled = False
        Queen.BackColor = Color.Gray
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
        Form_Quiz1_2.Show()
        Me.Hide()
    End Sub
End Class
