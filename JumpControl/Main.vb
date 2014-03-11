Imports System.Runtime.InteropServices

Public Class MainForm
#Region "API Delarations"
    Public Delegate Function CallBack(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
    <DllImport("wtsapi32.dll", SetLastError:=True)> _
    Private Shared Function WTSDisconnectSession(ByVal hServer As IntPtr, ByVal sessionId As Integer, ByVal bWait As Boolean) As Boolean
    End Function
#End Region
    Private ConfigXML As New XmlDocument
    Private Jumplist As JumpList
    Private ShutDownLink As New JumpListLink("shutdown.exe", "Shutdown")
    Private RestartLink As New JumpListLink("shutdown.exe", "Restart")
    Private SleepLink As New JumpListLink("rundll32.exe", "Sleep")
    Private SwitchUserLink As New JumpListLink(Application.ExecutablePath, "Switch User")
    Private LockLink As New JumpListLink("rundll32.exe", "Lock")
    Private LogOffLink As New JumpListLink("shutdown.exe", "Log Off")
    Private RestartExplorerLink As New JumpListLink("wmic.exe", "Restart Explorer")

    Public Shared Sub Main(ByVal args() As String)
        If args.Length = 1 Then
            For Each arg In args
                Select Case arg
                    Case "-d"
                        WTSDisconnectSession(0, -1, 0)
                End Select
            Next
        Else
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            If TaskbarManager.IsPlatformSupported Then
                Application.Run(New MainForm)
            Else
                MessageBox.Show("JumpControl requires Windows 7 to run.", "JumpControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the config file
        ConfigXML.Load("config.xml")
        'Parse the config file
        'Get item strings
        ChooseItemsLabel.Text = ConfigXML.SelectSingleNode("/settings/chooseItems/string").InnerText & ":"
        ShutDownCheckBox.Text = ConfigXML.SelectSingleNode("/settings/shutdown/string").InnerText
        RestartCheckBox.Text = ConfigXML.SelectSingleNode("/settings/restart/string").InnerText
        SleepCheckBox.Text = ConfigXML.SelectSingleNode("/settings/sleep/string").InnerText
        SwitchUserCheckBox.Text = ConfigXML.SelectSingleNode("/settings/switchUser/string").InnerText
        LockCheckBox.Text = ConfigXML.SelectSingleNode("/settings/lock/string").InnerText
        LogOffCheckBox.Text = ConfigXML.SelectSingleNode("/settings/logOff/string").InnerText
        RestartExplorerCheckBox.Text = ConfigXML.SelectSingleNode("/settings/restartExplorer/string").InnerText

        'Check enable items
        ShutDownCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/shutdown/enabled").InnerText
        RestartCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/restart/enabled").InnerText
        SleepCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/sleep/enabled").InnerText
        SwitchUserCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/switchUser/enabled").InnerText
        LockCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/lock/enabled").InnerText
        LogOffCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/logOff/enabled").InnerText
        RestartExplorerCheckBox.Checked = ConfigXML.SelectSingleNode("/settings/restartExplorer/enabled").InnerText
    End Sub

    Private Sub Form_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'Create the JumpList.
        Jumplist = Jumplist.CreateJumpList()

        'Get Jumplist task strings
        ShutDownLink.Title = ConfigXML.SelectSingleNode("/settings/shutdown/string").InnerText
        RestartLink.Title = ConfigXML.SelectSingleNode("/settings/restart/string").InnerText
        SleepLink.Title = ConfigXML.SelectSingleNode("/settings/sleep/string").InnerText
        SwitchUserLink.Title = ConfigXML.SelectSingleNode("/settings/switchUser/string").InnerText
        LockLink.Title = ConfigXML.SelectSingleNode("/settings/lock/string").InnerText
        LogOffLink.Title = ConfigXML.SelectSingleNode("/settings/logOff/string").InnerText
        RestartExplorerLink.Title = ConfigXML.SelectSingleNode("/settings/restartExplorer/string").InnerText

        'Set up the JumpList task arguments
        ShutDownLink.Arguments = "-s -t 0"
        RestartLink.Arguments = "-r -t 0"
        SleepLink.Arguments = "powrprof.dll,SetSuspendState Sleep"
        SwitchUserLink.Arguments = "-d"
        LockLink.Arguments = "user32.dll,LockWorkStation"
        LogOffLink.Arguments = "-l"""
        RestartExplorerLink.Arguments = "process where name=""explorer.exe"" call terminate"

        'Add the JumpList tasks
        AddJumpListUserTasks()

        'Add events to update the JumpList when the value of each checkbox is modified
        AddHandler ShutDownCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler RestartCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler SleepCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler SwitchUserCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler LockCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler LogOffCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
        AddHandler RestartExplorerCheckBox.CheckedChanged, AddressOf AddJumpListUserTasks
    End Sub

    Private Sub Form_Closed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ConfigXML.SelectSingleNode("/settings/shutdown/enabled").InnerText = ShutDownCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/restart/enabled").InnerText = RestartCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/sleep/enabled").InnerText = SleepCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/switchUser/enabled").InnerText = SwitchUserCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/lock/enabled").InnerText = LockCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/logOff/enabled").InnerText = LogOffCheckBox.Checked
        ConfigXML.SelectSingleNode("/settings/restartExplorer/enabled").InnerText = RestartExplorerCheckBox.Checked
        ConfigXML.Save("config.xml")
    End Sub

    Private Sub GoToAuthorPage(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AuthorLinkLabel.LinkClicked
        Process.Start("http://protosphere.deviantart.com/")
    End Sub

    Private Sub AddJumpListUserTasks()
        Jumplist.ClearAllUserTasks()

        If ShutDownCheckBox.Checked Then Jumplist.AddUserTasks(ShutDownLink)
        If RestartCheckBox.Checked Then Jumplist.AddUserTasks(RestartLink)
        If SleepCheckBox.Checked Then Jumplist.AddUserTasks(SleepLink)
        If SwitchUserCheckBox.Checked Or LockCheckBox.Checked Or LogOffCheckBox.Checked Then Jumplist.AddUserTasks(New JumpListSeparator)
        If SwitchUserCheckBox.Checked Then Jumplist.AddUserTasks(SwitchUserLink)
        If LockCheckBox.Checked Then Jumplist.AddUserTasks(LockLink)
        If LogOffCheckBox.Checked Then Jumplist.AddUserTasks(LogOffLink)
        If RestartExplorerCheckBox.Checked Then Jumplist.AddUserTasks(New JumpListSeparator)
        If RestartExplorerCheckBox.Checked Then Jumplist.AddUserTasks(RestartExplorerLink)

        Jumplist.Refresh()
    End Sub
End Class
