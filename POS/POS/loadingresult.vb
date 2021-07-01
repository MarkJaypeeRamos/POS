Module loadingresult
    Public Sub LoadSingleResult(ByVal param As String)

        Try

            MyConn.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "login"
                    Do While dReader.Read = True
                        userID = dReader("EMP_ID")
                        usertype = dReader("EMP_POSITION")
                        fullname = dReader("EMP_NAME")
                    Loop



            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            MyConn.Close()
        End Try
    End Sub

    Public Sub readData(ByVal obj As Object, ByVal param As String)
        Try

            MyConn.Open()
            dReader = cmd.ExecuteReader()
            '  obj.Rows.Clear()
            Select Case param
                Case "employee"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            MyConn.Close()
        End Try
    End Sub

    Public Sub ClearAll(ByVal group As Object, ByVal what As String)

        Select Case what
            Case "employee"
                For Each ctrl As Control In group.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        ctrl.Text = Nothing
                    End If
                Next

        End Select
    End Sub
End Module
