﻿Public Class Form1

    Private Sub thisisdoneinBUg2()
        'in bug 2
    End Sub

    Private Sub thisisit()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Did this in Branch 1
        MsgBox("Bug 1")
    End Sub

    Private Sub mastet(ByVal somevar As Integer)
        Dim i As Integer
        Dim tmpString As String
        Dim Branch4 As String
        Dim a As Integer

        i = 10
        tmpString = "Done in Master"

        If i = 10 Then
            tmpString = "hmmm I = 10"
        End If

    End Sub
End Class
