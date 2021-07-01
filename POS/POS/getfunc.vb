Module getfunc

    Public Sub writeThisError(ByVal errMsg As String)
        Try
            Dim FILE_NAME As String = Application.StartupPath & "\errorlogfile.txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            objWriter.WriteLine(errMsg)
            objWriter.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    Public Function GetRows() As Integer
        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            Return table.Rows.Count

        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module
