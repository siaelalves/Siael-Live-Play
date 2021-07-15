Public Class main

    Dim posiçãoTexto As String = "Bottom"
    Dim Playlist As DataTable = New DataTable("Playlist")
    Dim Capítulos As DataTable = New DataTable("Capítulos")
    Public Const WideScreen As String = "16:9"
    Public Const VGA As String = "4:3"
    Dim tempo As New TimeSpan(0, 0, 59)

    Sub AdicionarVideo(ByVal video As String)
        VLCPl.playlist.add(video)
        Player.vlcPl.playlist.add(video)
    End Sub

    Overloads Sub AdicionarTexto(ByVal texto As String, ByVal tamanho As Integer, ByVal posição As String)
        posiçãoTexto = posição
        Player.vlcPl.video.marquee.enable()
        Player.vlcPl.video.marquee.text = texto
        Player.vlcPl.video.marquee.size = tamanho
        Player.vlcPl.video.marquee.position = posição

        'VLCPl.video.marquee.text = Player.vlcPl.video.marquee.text
        'VLCPl.video.marquee.size = Player.vlcPl.video.marquee.size
        'VLCPl.video.marquee.position = Player.vlcPl.video.marquee.position
    End Sub

    Overloads Sub AdicionarTexto(ByVal texto As String)
        Player.lblCron.Visible = True
        Player.lblCron.BringToFront()
        Player.lblCron.Text = texto
    End Sub

    Sub RemoverTexto()
        Player.vlcPl.video.marquee.disable()
        VLCPl.video.marquee.disable()
    End Sub

    Sub AlternarVídeoTexto()

    End Sub

    Function EstáTocando() As Boolean
        Return VLCPl.playlist.isPlaying
    End Function

    Overloads Sub Play()
        VLCPl.playlist.play()
        VLCPl.Visible = True
        VLCPl.BringToFront()

        Player.vlcPl.playlist.play()
        Player.vlcPl.Visible = True
        Player.vlcPl.BringToFront()
    End Sub

    Overloads Sub Tocar()
        VLCPl.playlist.play()
        VLCPl.Visible = True
        VLCPl.BringToFront()

        Player.vlcPl.playlist.play()
        Player.vlcPl.Visible = True
        Player.vlcPl.BringToFront()
    End Sub

    Overloads Sub Play(ByVal i As Integer)
        VLCPl.playlist.playItem(i)
        VLCPl.Visible = True
        VLCPl.BringToFront()

        Player.vlcPl.playlist.playItem(i)
        Player.vlcPl.Visible = True
        Player.vlcPl.BringToFront()
    End Sub

    Overloads Sub Tocar(ByVal i As Integer)
        VLCPl.playlist.playItem(i)
        VLCPl.Visible = True
        VLCPl.BringToFront()

        Player.vlcPl.playlist.playItem(i)
        Player.vlcPl.Visible = True
        Player.vlcPl.BringToFront()
    End Sub

    Sub AlternarPlayPause()
        VLCPl.playlist.togglePause()
        Player.vlcPl.playlist.togglePause()
    End Sub

    Sub Parar()
        VLCPl.playlist.stop()
        VLCPl.Visible = False
        VLCPl.SendToBack()

        Player.vlcPl.playlist.stop()
        Player.vlcPl.Visible = False
        Player.vlcPl.SendToBack()
    End Sub

    Sub Próximo()
        VLCPl.playlist.next()
        Player.vlcPl.playlist.next()
    End Sub

    Sub Anterior()
        VLCPl.playlist.prev()
        Player.vlcPl.playlist.prev()
    End Sub

    Sub AlternarTelaCheia()
        VLCPl.video.toggleFullscreen()
        Player.vlcPl.video.toggleFullscreen()
    End Sub

    Sub AtivarPlayerSecundário()
        Player.Show()
    End Sub

    Sub DesativarPlayerSecundário()
        Player.Close()
    End Sub

    Function PlayerSecundárioEstáAtivado() As Boolean
        If Application.OpenForms.Count > 1 Then
            Return True
        ElseIf Application.OpenForms.Count = 1 Then
            Return False
        End If
        Return False
    End Function

    Function TelaSecundáriaEstáAtivada() As Boolean
        If UBound(Screen.AllScreens) = 1 Then
            Return False
        ElseIf UBound(Screen.AllScreens) > 1 Then
            Return True
        End If
        Return False
    End Function

    Sub AvançarCapítulo()
        VLCPl.input.chapter.next()
        Player.vlcPl.input.chapter.next()
        AtualizarTempo()
    End Sub

    Sub RetrocederCapítulo()
        VLCPl.input.chapter.prev()
        Player.vlcPl.input.chapter.prev()
        AtualizarTempo()
    End Sub

    Sub TocarDoInício()
        VLCPl.StartTime = 0
        Tocar(VLCPl.playlist.currentItem)
    End Sub

    Sub IrParaCapítulo(ByVal i As Integer)
        VLCPl.StartTime = CalcularSegundos(Capítulos.Rows(i)("MiliSeg"))
        VLCPl.playlist.play()
    End Sub

    Sub AtualizarTempo()
        'lblTmp.Text = VLCPl.input.time
        Dim vtempo As New TimeSpan(0, 0, 0, 0, VLCPl.input.time)
        lblTmp.Text = FormatarTempo(vtempo)
    End Sub

    ''' <summary>
    ''' Retorna o tempo especificado no formato 00:00:00
    ''' </summary>
    ''' <param name="valor">Tempo desejado. Você deve atribuir valores para as propriedades 
    ''' .Hours, .Minutes e .Seconds.</param>
    ''' <returns></returns>
    Overloads Function FormatarTempo(ByVal valor As TimeSpan) As String
        Dim h, min, seg As Integer
        h = valor.Hours
        min = valor.Minutes
        seg = valor.Seconds
        If h = 0 Then
            Return min.ToString("00") & ":" & seg.ToString("00")
        Else
            Return h.ToString("00") & ":" & min.ToString("00") & ":" & seg.ToString("00")
        End If
    End Function

    ''' <summary>
    ''' Retorna o número total de horas no tempo especificado.
    ''' </summary>
    ''' <param name="valor">Tempo para se calcular as horas.</param>
    ''' <returns></returns>
    Function CalcularHoras(ByVal valor As TimeSpan) As Integer
        Return valor.TotalHours
    End Function

    ''' <summary>
    ''' Retorna o número total de minutos no tempo especificado.
    ''' </summary>
    ''' <param name="valor">Tempo para se calcular os minutos.</param>
    ''' <returns></returns>
    Function CalcularMinutos(ByVal valor As TimeSpan) As Integer
        Return valor.TotalMinutes
    End Function

    ''' <summary>
    ''' Retorna o número total de segundos no tempo especificado.
    ''' </summary>
    ''' <param name="valor">Tempo para se calcular os segundos.</param>
    ''' <returns></returns>
    Function CalcularSegundos(ByVal valor As TimeSpan) As Integer
        Return valor.TotalSeconds
    End Function

    Function CalcularMilissegundos(ByVal valor As TimeSpan) As Integer
        Return valor.TotalMilliseconds
    End Function

    Sub IrParaPosição(ByVal tempo As TimeSpan)
        VLCPl.input.position = CalcularMilissegundos(tempo)
        VLCPl.input.time = CalcularMilissegundos(tempo)
        Player.vlcPl.input.position = CalcularMilissegundos(tempo)
        Player.vlcPl.input.time = CalcularMilissegundos(tempo)
        AtualizarTempo()
    End Sub

    Sub VoltarDeterminadoTempo(ByVal tempo As TimeSpan)
        VLCPl.input.position -= CalcularMilissegundos(tempo)
        VLCPl.input.time -= CalcularMilissegundos(tempo)
        Player.vlcPl.input.position -= CalcularMilissegundos(tempo)
        Player.vlcPl.input.time -= CalcularMilissegundos(tempo)
        AtualizarTempo()
    End Sub

    Sub AvançarDeterminadoTempo(ByVal tempo As TimeSpan)
        VLCPl.input.position += CalcularMilissegundos(tempo)
        VLCPl.input.time += CalcularMilissegundos(tempo)
        Player.vlcPl.input.position += CalcularMilissegundos(tempo)
        Player.vlcPl.input.time += CalcularMilissegundos(tempo)
        AtualizarTempo()
    End Sub

    Sub CarregarCapítulos()

    End Sub

    Sub DesativarBotõesDeFerramentasDeTexto()
        txtTxt.Enabled = False
        txtTm.Enabled = False
        cmdPos.Enabled = False
        cmdEnv.Enabled = False
        cmdRemTxt.Enabled = False
    End Sub

    Sub AtivarBotõesDeFerramentasDeTexto()
        txtTxt.Enabled = True
        txtTm.Enabled = True
        cmdPos.Enabled = True
        cmdEnv.Enabled = True
        cmdRemTxt.Enabled = True
    End Sub




    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtivarPlayerSecundário()
        VLCPl.Visible = False
        Playlist.Columns.Add("Título", GetType(String))
        Playlist.Columns.Add("Caminho", GetType(String))
        Playlist.AcceptChanges()
        posiçãoTexto = "Bottom"
        dgvPlaylist.DataSource = Playlist
    End Sub

    Private Sub cmdSlcVd_Click(sender As Object, e As EventArgs) Handles cmdSlcVd.Click
        If dlgAbrVid.ShowDialog = DialogResult.OK Then
            For Each f As String In dlgAbrVid.FileNames
                Dim i As IO.FileInfo = New IO.FileInfo(f)

                AdicionarVideo("file:///" & f)

                Dim dr As DataRow = Playlist.NewRow()
                dr.Item("Título") = i.Name
                dr.Item("Caminho") = i.FullName
                Playlist.Rows.Add(dr)

            Next
            dgvPlaylist.DataSource = Playlist
        End If
    End Sub

    Private Sub cmdTc_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        AlternarPlayPause()
    End Sub

    Private Sub cmdProx_Click(sender As Object, e As EventArgs) Handles cmdProx.Click
        Próximo()
    End Sub

    Private Sub cmdVl_Click(sender As Object, e As EventArgs) Handles cmdVl.Click
        Anterior()
    End Sub

    Private Sub cmdTlCh_Click(sender As Object, e As EventArgs)
        AlternarTelaCheia()
    End Sub

    Private Sub tabPos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        Parar()
    End Sub

    Private Sub cmdEnv_Click(sender As Object, e As EventArgs) Handles cmdEnv.Click
        AdicionarTexto(txtTxt.Text, txtTm.Value, posiçãoTexto)
    End Sub

    Private Sub cmdPrCap_Click(sender As Object, e As EventArgs) Handles cmdPrCap.Click
        AvançarCapítulo()
    End Sub

    Private Sub cmdVlCap_Click(sender As Object, e As EventArgs) Handles cmdVlCap.Click
        RetrocederCapítulo()
    End Sub

    Private Sub dgvPlaylist_DoubleClick(sender As Object, e As EventArgs) Handles dgvPlaylist.DoubleClick
        If dgvPlaylist.SelectedRows.Count = 1 Then
            Tocar(dgvPlaylist.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub VLCPl_MediaPlayerTimeChanged(sender As Object, e As AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent) Handles VLCPl.MediaPlayerTimeChanged
        AtualizarTempo()
    End Sub

    Private Sub VLCPl_MediaPlayerPlaying(sender As Object, e As EventArgs) Handles VLCPl.MediaPlayerPlaying
        cmdPlay.ImageIndex = 3
    End Sub

    Private Sub VLCPl_MediaPlayerPaused(sender As Object, e As EventArgs) Handles VLCPl.MediaPlayerPaused
        cmdPlay.ImageIndex = 0
    End Sub

    Private Sub cmdRatio_Click(sender As Object, e As EventArgs) Handles cmdRatioWide.Click
        VLCPl.video.aspectRatio = WideScreen
        Player.vlcPl.video.aspectRatio = WideScreen
    End Sub

    Private Sub cmdRatioVGA_Click(sender As Object, e As EventArgs) Handles cmdRatioVGA.Click
        VLCPl.video.aspectRatio = VGA
        Player.vlcPl.video.aspectRatio = VGA
    End Sub

    Private Sub cmdRemTxt_Click(sender As Object, e As EventArgs) Handles cmdRemTxt.Click
        RemoverTexto()
    End Sub

    Private Sub rdTopLeft_CheckedChanged(sender As Object, e As EventArgs) Handles rdTopLeft.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Top-Left")
    End Sub

    Private Sub rdTopCenter_CheckedChanged(sender As Object, e As EventArgs) Handles rdTopCenter.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Top")
    End Sub

    Private Sub rdTopRight_CheckedChanged(sender As Object, e As EventArgs) Handles rdTopRight.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Top-Right")
    End Sub

    Private Sub rdCenter_CheckedChanged(sender As Object, e As EventArgs) Handles rdCenter.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Center")
    End Sub

    Private Sub rdBottomCenter_CheckedChanged(sender As Object, e As EventArgs) Handles rdBottomCenter.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Bottom")
    End Sub

    Private Sub rdBottomRight_CheckedChanged(sender As Object, e As EventArgs) Handles rdBottomRight.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Bottom-Right")
    End Sub

    Private Sub rdBottomLeft_CheckedChanged(sender As Object, e As EventArgs) Handles rdBottomLeft.CheckedChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, "Bottom-Left")
    End Sub

    Private Sub txtTm_ValueChanged(sender As Object, e As EventArgs) Handles txtTm.ValueChanged
        AdicionarTexto(txtTxt.Text, txtTm.Value, posiçãoTexto)
    End Sub

    Private Sub cmdIr_Click(sender As Object, e As EventArgs) Handles cmdIr.Click
        Dim h, min, seg As Integer
        h = CInt(txtIrParaH.Text)
        min = CInt(txtIrParaM.Text)
        seg = CInt(txtIrParaSeg.Text)
        Dim t As New TimeSpan(h, min, seg)
        IrParaPosição(t)
    End Sub

    Private Sub cmdAv10_Click(sender As Object, e As EventArgs) Handles cmdAv10.Click
        AvançarDeterminadoTempo(New TimeSpan(0, 0, 10))
    End Sub

    Private Sub cmdVl10_Click(sender As Object, e As EventArgs) Handles cmdVl10.Click
        VoltarDeterminadoTempo(New TimeSpan(0, 0, 10))
    End Sub

    Private Sub cmdAtivCron_Click(sender As Object, e As EventArgs) Handles cmdAtivCron.Click
        If tmCron.Enabled = False Then
            tmCron.Enabled = True
            tempo = New TimeSpan(0, 0, 59)
            cmdAtivCron.Enabled = False
            cmdDesCron.Enabled = True
            DesativarBotõesDeFerramentasDeTexto()
            tmCron.Start()
            AdicionarTexto(FormatarTempo(tempo))
        End If
    End Sub

    Private Sub tmCron_Tick(sender As Object, e As EventArgs) Handles tmCron.Tick
        If tempo.Seconds > 0 Then
            tempo = tempo.Subtract(New TimeSpan(0, 0, 1))
            AdicionarTexto(FormatarTempo(tempo))
        ElseIf tempo.Seconds = 0 Then
            RemoverTexto()
            tmCron.Stop()
            tmCron.Enabled = False
            cmdAtivCron.Enabled = True
            cmdDesCron.Enabled = False
            AtivarBotõesDeFerramentasDeTexto()
            Player.lblCron.Visible = False
        End If
    End Sub

    Private Sub cmdDesCron_Click(sender As Object, e As EventArgs) Handles cmdDesCron.Click
        If tmCron.Enabled = True Then
            RemoverTexto()
            tmCron.Stop()
            tmCron.Enabled = False
            cmdAtivCron.Enabled = True
            cmdDesCron.Enabled = False
            AtivarBotõesDeFerramentasDeTexto()
            Player.lblCron.Visible = False
        End If
    End Sub
End Class
