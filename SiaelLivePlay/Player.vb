Public Class Player
    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As Screen In Screen.AllScreens
            If s.Primary = False Then
                Me.Bounds = s.WorkingArea
                Me.WindowState = FormWindowState.Maximized
                'vlcPl.video.toggleFullscreen()
                vlcPl.Visible = False
                picBack.BringToFront()
                Return
            End If
        Next
    End Sub
End Class