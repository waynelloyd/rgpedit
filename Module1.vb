Module Module1
    Private systray As New NotifyIcon

    Public Sub Main()

        Dim mnu As New ContextMenu
        Dim mnuitem As New MenuItem

        mnuitem.Text = "Exit"

        AddHandler mnuitem.Click, AddressOf EndApp

        mnu.MenuItems.Add(mnuitem)

        systray.ContextMenu = mnu
        systray.Icon = New Icon(Application.StartupPath & "\systray.ico")
        systray.Visible = True

        Application.Run()
    End Sub

    Private Sub EndApp(ByVal sender As Object, ByVal e As EventArgs)
        systray.Visible = False
        Application.Exit()
    End Sub

End Module
