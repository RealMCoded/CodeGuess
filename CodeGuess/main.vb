Public Class main

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODE.Text = "WOWYOUCRACKEDIT" Then
            msg.Show()
            msg.Text = "Correct Code!"
            Timer1.Start()
        Else
            msg.Show()
            CODE.Text = ""
        End If
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        msg.Hide()
        Wait.Hide()
        init.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Wait.Increment(5)
        If Wait.Value = 100 Then
            Me.Close()
        End If
    End Sub
End Class
