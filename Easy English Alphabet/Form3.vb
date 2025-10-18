' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.Media

Public Class Form3
    Private Sub S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.Click
        AudioHelper.PlaySound(My.Resources.S_is_for_sun)
        
    End Sub

    Private Sub T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T.Click
        AudioHelper.PlaySound(My.Resources.T_is_for_teddy)
        
    End Sub

    Private Sub U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles U.Click
        AudioHelper.PlaySound(My.Resources.U_is_for_unicorn)
        
    End Sub

    Private Sub V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V.Click
        AudioHelper.PlaySound(My.Resources.V_is_for_violin)
        
    End Sub

    Private Sub W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W.Click
        AudioHelper.PlaySound(My.Resources.W_is_for_wall)
        
    End Sub

    Private Sub X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.Click
        AudioHelper.PlaySound(My.Resources.X_is_for_xylophone)
        
    End Sub

    Private Sub Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Y.Click
        AudioHelper.PlaySound(My.Resources.Y_is_for_yoga)
        
    End Sub

    Private Sub Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Z.Click
        AudioHelper.PlaySound(My.Resources.Z_is_for_zebra)
        
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Back.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://autastic-media.github.io/home")
    End Sub

    Private Sub Button_Close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        Form0.Show()
    End Sub
End Class
