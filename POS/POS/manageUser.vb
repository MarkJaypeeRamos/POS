Public Class manageUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If pass.Text = "" Then
            MsgBox("Password must be filled up.", MsgBoxStyle.Exclamation)
            Return
        End If
        If cpass.Text = "" Then
            MsgBox("Password must be filled up.", MsgBoxStyle.Exclamation)
            Return
        End If

        If btnSave.Text = "Save" Then
            If pass.Text = cpass.Text Then
                manage = insertdb("INSERT INTO `tbl_employee`(`EMP_ID`, `EMP_NAME`, `EMP_ADDRESS`, `EMP_CONTACT`, `EMP_POSITION`, `EMP_USERNAME`, `EMP_PASSWORD`)
                            VALUES ('" & empId.Text & "', '" & empName.Text & "', '" & empAdd.Text & "', '" & empContact.Text & "', '" & empPosition.Text & "', '" & username.Text & "', '" & pass.Text & "')")

                If manage = True Then
                    MsgBox("Employee record has been saved!")
                Else
                    MsgBox("No record has been saved!")
                End If
            Else
                MsgBox("Password not match!")
            End If
        Else
            If pass.Text = cpass.Text Then
                manage = insertdb("UPDATE `tblemployee` SET `EMP_NAME`='" & empName.Text & "', `EMP_ADDRESS`='" & empAdd.Text & "', `EMP_CONTACT`='" & empContact.Text & "', `EMP_POSITION`='" & empPosition.Text & "', `EMP_USERNAME`='" & username.Text & "', `EMP_PASSWORD`= '" & pass.Text & "' where EMP_ID=" & Val(empId.Text) & "")
                If manage = True Then
                    MsgBox("Employee record has been Updated!")
                Else
                    MsgBox("No record has been Updated!")
                End If
            Else
                MsgBox("Password not match!")
            End If
        End If
        Call btnNew_Click(sender, e)
    End Sub

    Private Sub manageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logindb("SELECT `EMP_ID`, `EMP_NAME`, `EMP_ADDRESS`, `EMP_CONTACT`, `EMP_POSITION`, `EMP_USERNAME` FROM tbl_employee")
        readData(empDataview, "employee")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        logindb("SELECT `EMP_ID`, `EMP_NAME`, `EMP_ADDRESS`, `EMP_CONTACT`, `EMP_POSITION`, `EMP_USERNAME` FROM tbl_employee")
        readData(empDataview, "employee")
        ClearAll(GroupBox1, "employee")
        empPosition.Text = "Select"
        btnSave.Text = "Save"
    End Sub

    Private Sub empDataview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles empDataview.CellClick
        empId.Text = empDataview.CurrentRow.Cells(0).Value
        empName.Text = empDataview.CurrentRow.Cells(1).Value
        empAdd.Text = empDataview.CurrentRow.Cells(2).Value
        empContact.Text = empDataview.CurrentRow.Cells(3).Value
        empPosition.Text = empDataview.CurrentRow.Cells(4).Value
        username.Text = empDataview.CurrentRow.Cells(5).Value
        btnSave.Text = "Update"
    End Sub
End Class