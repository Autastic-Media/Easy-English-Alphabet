' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form_Quiz1_2

    'This Hides the Next button, continues previous score and disables question 5 and 6 answer buttons.

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: 3 out of 9"
        Button_Close.Enabled = False
        Button_Close.BackColor = Color.Gray
        Button_Next.Hide()
        Violin.Enabled = False
        Violin.BackColor = Color.Gray
        Zebra.Enabled = False
        Zebra.BackColor = Color.Gray
        Sun.Enabled = False
        Sun.BackColor = Color.Gray
        Icecream.Enabled = False
        Icecream.BackColor = Color.Gray()
        Ladybird.Enabled = False
        Ladybird.BackColor = Color.Gray()
        Xylophone.Enabled = False
        Xylophone.BackColor = Color.Gray()
    End Sub

    Private Sub Rocket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rocket.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub


    Private Sub Unicorn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unicorn.Click
        YN1.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables question 5 buttons and disables question 4 buttons. It also adds 1 point for the correct answer.

    Private Sub Teddy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teddy.Click
        YN1.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 4 out of 9"
        Violin.Enabled = True
        Violin.BackColor = Color.White
        Zebra.Enabled = True
        Zebra.BackColor = Color.White
        Sun.Enabled = True
        Sun.BackColor = Color.White
        Rocket.Enabled = False
        Rocket.BackColor = Color.Gray()
        Unicorn.Enabled = False
        Unicorn.BackColor = Color.Gray()
        Teddy.Enabled = False
        Teddy.BackColor = Color.Gray()
    End Sub

    Private Sub Violin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Violin.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables question 6 buttons and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Zebra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zebra.Click
        YN2.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 5 out of 9"
        Violin.Enabled = False
        Violin.BackColor = Color.Gray
        Zebra.Enabled = False
        Zebra.BackColor = Color.Gray
        Sun.Enabled = False
        Sun.BackColor = Color.Gray
        Icecream.Enabled = True
        Icecream.BackColor = Color.White
        Ladybird.Enabled = True
        Ladybird.BackColor = Color.White
        Xylophone.Enabled = True
        Xylophone.BackColor = Color.White
    End Sub

    Private Sub Sun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sun.Click
        YN2.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    'This Enables the Next button and disables question 5 buttons. It also adds 1 point for the correct answer.

    Private Sub Icecream_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icecream.Click
        YN3.Image = My.Resources.tick2
        AudioHelper.PlaySound(My.Resources.YesSound)
        
        lblScore.Text = "Score: 6 out of 9"
        Icecream.Enabled = False
        Icecream.BackColor = Color.Gray
        Ladybird.Enabled = False
        Ladybird.BackColor = Color.Gray
        Xylophone.Enabled = False
        Xylophone.BackColor = Color.Gray
        Button_Next.Show()
    End Sub

    Private Sub Ladybird_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ladybird.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Xylophone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xylophone.Click
        YN3.Image = My.Resources.cross2
        AudioHelper.PlaySound(My.Resources.NoSound)
        
    End Sub

    Private Sub Button_Next_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Form_Quiz1_3.Show()
        Me.Hide()
    End Sub

End Class
