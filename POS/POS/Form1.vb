Public Class Form1
    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            loginform.Show()
        Else
            tsLogin.Text = "Login"
            Visible_Admin("False")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible_Admin("False")
    End Sub

    Private Sub tsExit_Click(sender As Object, e As EventArgs) Handles tsExit.Click
        Me.Close()
    End Sub

    Private Sub tsPOS_Click(sender As Object, e As EventArgs) Handles tsPOS.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles companyName1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click

    End Sub

    Private Sub tsManage_Click(sender As Object, e As EventArgs) Handles tsManage.Click
        manageUser.Show()
    End Sub
End Class
