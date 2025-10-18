' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form2

    Private Sub J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J.Click
        AudioHelper.PlaySound(My.Resources.J_is_for_jam)
        
    End Sub

    Private Sub K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K.Click
        AudioHelper.PlaySound(My.Resources.K_is_for_kite)
        
    End Sub

    Private Sub L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.Click
        AudioHelper.PlaySound(My.Resources.L_is_for_ladybird)
        
    End Sub

    Private Sub M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M.Click
        AudioHelper.PlaySound(My.Resources.M_is_for_meerkat)
        
    End Sub

    Private Sub N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N.Click
        AudioHelper.PlaySound(My.Resources.N_is_for_nail)
        
    End Sub

    Private Sub O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O.Click
        AudioHelper.PlaySound(My.Resources.O_is_for_orange)
        
    End Sub

    Private Sub P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.Click
        AudioHelper.PlaySound(My.Resources.P_is_for_pig)
        
    End Sub

    Private Sub Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q.Click
        AudioHelper.PlaySound(My.Resources.Q_is_for_queen)
        
    End Sub

    Private Sub R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.Click
        AudioHelper.PlaySound(My.Resources.R_is_for_rocket)
        
    End Sub

    Private Sub Button_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Back.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Close()
        Form0.Show()
    End Sub

End Class
