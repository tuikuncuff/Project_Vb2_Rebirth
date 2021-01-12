Imports System.Runtime.CompilerServices

Public Class Login
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Username.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
