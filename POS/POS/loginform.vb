Public Class loginform
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        sql = "SELECT * FROM `tbl_employee` WHERE `EMP_USERNAME` ='" & UsernameTextBox.Text & "' and `EMP_PASSWORD` = '" & PasswordTextBox.Text & "'"
        logindb(sql)

        If GetRows() = 1 Then
            LoadSingleResult("login")
            Form1.tsLogin.Text = "Logout"

            If UserType = "Administrator" Then
                Visible_Admin(True)

            End If

            If UserType = "Cashier" Then
                Visible_Cashier(True)
            End If
        Else
            MsgBox("Username or Password not registered!")
        End If

        Form1.user.Text = UserType
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class