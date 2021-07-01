Module modfunc

    Public Sub Visible_Admin(ByVal result As Boolean)
        With Form1
            .tsPOS.Visible = result
            .tsItems.Visible = result
            .tsManage.Visible = result
            .tsReport.Visible = result
            .tsStocks.Visible = result
            .tsHelp.Visible = result

        End With

    End Sub

    Public Sub Visible_Cashier(ByVal result As Boolean)
        With Form1
            .tsPOS.Visible = result
            .tsItems.Visible = result
            .tsReport.Visible = result
            .tsStocks.Visible = result
            .tsHelp.Visible = result
        End With
    End Sub
End Module
