﻿' Charlotte Childers
' CPT-206-Lab-9
' 3/16/2022


Option Strict On
Option Explicit On
Option Infer Off

Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prog.Increment(1)
        If prog.Value = 100 Then
            Me.Hide()
            MainForm.Show()
        End If
        date_time.Text = DateTime.Now.ToString("F")
        ' Shows a splash screen depicting
        ' Along with Date / Time
        ' Name at time
    End Sub
End Class