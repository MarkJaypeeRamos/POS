Imports MySql.Data.MySqlClient
Module db
    Public MyConn As MySqlConnection = myconnection()
    Public result As Integer
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dReader As MySqlDataReader
    Public sql As String = ""
    Public fullname As String = ""
    Public UserId As String = ""
    Public UserType As String = ""
    Public manage As Boolean

    Public Function myconnection() As MySqlConnection

        Return New MySqlConnection(My.Settings.mysetting)

    End Function

    Public Sub logindb(ByVal sql As String)
        Try
            MyConn.Open()
            With cmd
                .Connection = MyConn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            MyConn.Close()
        End Try


    End Sub

    Public Function insertdb(ByVal sql As String) As Boolean

        Try
            MyConn.Open()
            With cmd
                .Connection = MyConn
                .CommandText = sql

                result = cmd.ExecuteNonQuery()
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            MyConn.Close()

        End Try

    End Function
End Module

