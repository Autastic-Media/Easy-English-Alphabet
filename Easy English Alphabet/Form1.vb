' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form1

    Private Sub A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Click
        AudioHelper.PlaySound(My.Resources.A_is_for_apple)

    End Sub

    Private Sub B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B.Click
        AudioHelper.PlaySound(My.Resources.B_is_for_ball)

    End Sub

    Private Sub C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click
        AudioHelper.PlaySound(My.Resources.C_is_for_cat)

    End Sub

    Private Sub D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.Click
        AudioHelper.PlaySound(My.Resources.D_is_for_dog)

    End Sub

    Private Sub E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E.Click
        AudioHelper.PlaySound(My.Resources.E_is_for_elephant)

    End Sub

    Private Sub F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F.Click
        AudioHelper.PlaySound(My.Resources.F_is_for_fish)

    End Sub

    Private Sub G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Click
        AudioHelper.PlaySound(My.Resources.G_is_for_guinea_pig)

    End Sub

    Private Sub H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H.Click
        AudioHelper.PlaySound(My.Resources.H_is_for_horse)

    End Sub

    Private Sub I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I.Click
        AudioHelper.PlaySound(My.Resources.I_is_for_icecream)

    End Sub

    Private Sub J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.J_is_for_jam)

    End Sub

    Private Sub K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.K_is_for_kite)

    End Sub

    Private Sub L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.L_is_for_ladybird)

    End Sub

    Private Sub M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.M_is_for_meerkat)

    End Sub

    Private Sub N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.N_is_for_nail)

    End Sub

    Private Sub O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioHelper.PlaySound(My.Resources.O_is_for_orange)

    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Back.Click
        Me.Close()
        Form0.Show()
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
        Form0.Show()
    End Sub
End Class
