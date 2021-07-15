<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.VLCPl = New AxAXVLC.AxVLCPlugin2()
        Me.cmdSlcVd = New System.Windows.Forms.Button()
        Me.cmdPics = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgAbrVid = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPlaylist = New System.Windows.Forms.DataGridView()
        Me.txtTxt = New System.Windows.Forms.TextBox()
        Me.cmdEnv = New System.Windows.Forms.Button()
        Me.txtTextTools = New System.Windows.Forms.GroupBox()
        Me.cmdPos = New System.Windows.Forms.TableLayoutPanel()
        Me.rdBottomRight = New System.Windows.Forms.RadioButton()
        Me.rdBottomCenter = New System.Windows.Forms.RadioButton()
        Me.rdBottomLeft = New System.Windows.Forms.RadioButton()
        Me.rdCenter = New System.Windows.Forms.RadioButton()
        Me.rdTopRight = New System.Windows.Forms.RadioButton()
        Me.rdTopCenter = New System.Windows.Forms.RadioButton()
        Me.rdTopLeft = New System.Windows.Forms.RadioButton()
        Me.txtTm = New System.Windows.Forms.NumericUpDown()
        Me.cmdRemTxt = New System.Windows.Forms.Button()
        Me.lblTmp = New System.Windows.Forms.Label()
        Me.grpToolsVideo = New System.Windows.Forms.GroupBox()
        Me.txtIrParaM = New System.Windows.Forms.MaskedTextBox()
        Me.txtIrParaSeg = New System.Windows.Forms.MaskedTextBox()
        Me.txtIrParaH = New System.Windows.Forms.MaskedTextBox()
        Me.cmdIr = New System.Windows.Forms.Button()
        Me.lblIrPara = New System.Windows.Forms.Label()
        Me.lblDivM = New System.Windows.Forms.Label()
        Me.lblDivH = New System.Windows.Forms.Label()
        Me.cmdRatioVGA = New System.Windows.Forms.Button()
        Me.cmdRatioWide = New System.Windows.Forms.Button()
        Me.cmdAv10 = New System.Windows.Forms.Button()
        Me.cmdVl10 = New System.Windows.Forms.Button()
        Me.cmdVlCap = New System.Windows.Forms.Button()
        Me.cmdPrCap = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdProx = New System.Windows.Forms.Button()
        Me.cmdVl = New System.Windows.Forms.Button()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.picBackLogo = New System.Windows.Forms.PictureBox()
        Me.tmCron = New System.Windows.Forms.Timer(Me.components)
        Me.cmdAtivCron = New System.Windows.Forms.Button()
        Me.cmdDesCron = New System.Windows.Forms.Button()
        CType(Me.VLCPl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlaylist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtTextTools.SuspendLayout()
        Me.cmdPos.SuspendLayout()
        CType(Me.txtTm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpToolsVideo.SuspendLayout()
        CType(Me.picBackLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VLCPl
        '
        Me.VLCPl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VLCPl.Enabled = True
        Me.VLCPl.Location = New System.Drawing.Point(376, 3)
        Me.VLCPl.Name = "VLCPl"
        Me.VLCPl.OcxState = CType(resources.GetObject("VLCPl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLCPl.Size = New System.Drawing.Size(602, 338)
        Me.VLCPl.TabIndex = 1
        '
        'cmdSlcVd
        '
        Me.cmdSlcVd.ImageList = Me.cmdPics
        Me.cmdSlcVd.Location = New System.Drawing.Point(265, 171)
        Me.cmdSlcVd.Name = "cmdSlcVd"
        Me.cmdSlcVd.Size = New System.Drawing.Size(105, 23)
        Me.cmdSlcVd.TabIndex = 2
        Me.cmdSlcVd.Text = "Adicionar vídeos"
        Me.cmdSlcVd.UseVisualStyleBackColor = True
        '
        'cmdPics
        '
        Me.cmdPics.ImageStream = CType(resources.GetObject("cmdPics.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.cmdPics.TransparentColor = System.Drawing.Color.Transparent
        Me.cmdPics.Images.SetKeyName(0, "play.png")
        Me.cmdPics.Images.SetKeyName(1, "chapter_next.png")
        Me.cmdPics.Images.SetKeyName(2, "chapter_previous.png")
        Me.cmdPics.Images.SetKeyName(3, "pause.png")
        Me.cmdPics.Images.SetKeyName(4, "playlist.png")
        Me.cmdPics.Images.SetKeyName(5, "stop.png")
        Me.cmdPics.Images.SetKeyName(6, "back.png")
        Me.cmdPics.Images.SetKeyName(7, "next.png")
        '
        'dlgAbrVid
        '
        Me.dlgAbrVid.Multiselect = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Playlist"
        '
        'dgvPlaylist
        '
        Me.dgvPlaylist.AllowUserToAddRows = False
        Me.dgvPlaylist.AllowUserToDeleteRows = False
        Me.dgvPlaylist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlaylist.Location = New System.Drawing.Point(12, 200)
        Me.dgvPlaylist.MultiSelect = False
        Me.dgvPlaylist.Name = "dgvPlaylist"
        Me.dgvPlaylist.ReadOnly = True
        Me.dgvPlaylist.RowHeadersVisible = False
        Me.dgvPlaylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlaylist.Size = New System.Drawing.Size(358, 206)
        Me.dgvPlaylist.TabIndex = 3
        '
        'txtTxt
        '
        Me.txtTxt.Location = New System.Drawing.Point(11, 26)
        Me.txtTxt.Multiline = True
        Me.txtTxt.Name = "txtTxt"
        Me.txtTxt.Size = New System.Drawing.Size(236, 46)
        Me.txtTxt.TabIndex = 11
        Me.txtTxt.Text = "Legenda"
        '
        'cmdEnv
        '
        Me.cmdEnv.Location = New System.Drawing.Point(253, 26)
        Me.cmdEnv.Name = "cmdEnv"
        Me.cmdEnv.Size = New System.Drawing.Size(99, 20)
        Me.cmdEnv.TabIndex = 12
        Me.cmdEnv.Text = "Enviar texto"
        Me.cmdEnv.UseVisualStyleBackColor = True
        '
        'txtTextTools
        '
        Me.txtTextTools.Controls.Add(Me.cmdDesCron)
        Me.txtTextTools.Controls.Add(Me.cmdAtivCron)
        Me.txtTextTools.Controls.Add(Me.cmdPos)
        Me.txtTextTools.Controls.Add(Me.txtTm)
        Me.txtTextTools.Controls.Add(Me.cmdRemTxt)
        Me.txtTextTools.Controls.Add(Me.txtTxt)
        Me.txtTextTools.Controls.Add(Me.cmdEnv)
        Me.txtTextTools.Location = New System.Drawing.Point(12, 12)
        Me.txtTextTools.Name = "txtTextTools"
        Me.txtTextTools.Size = New System.Drawing.Size(358, 153)
        Me.txtTextTools.TabIndex = 13
        Me.txtTextTools.TabStop = False
        Me.txtTextTools.Text = "Ferramentas de Texto"
        '
        'cmdPos
        '
        Me.cmdPos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.cmdPos.ColumnCount = 3
        Me.cmdPos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.Controls.Add(Me.rdBottomRight, 2, 2)
        Me.cmdPos.Controls.Add(Me.rdBottomCenter, 1, 2)
        Me.cmdPos.Controls.Add(Me.rdBottomLeft, 0, 2)
        Me.cmdPos.Controls.Add(Me.rdCenter, 1, 1)
        Me.cmdPos.Controls.Add(Me.rdTopRight, 2, 0)
        Me.cmdPos.Controls.Add(Me.rdTopCenter, 1, 0)
        Me.cmdPos.Controls.Add(Me.rdTopLeft, 0, 0)
        Me.cmdPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPos.Location = New System.Drawing.Point(62, 78)
        Me.cmdPos.Name = "cmdPos"
        Me.cmdPos.RowCount = 3
        Me.cmdPos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.cmdPos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.cmdPos.Size = New System.Drawing.Size(68, 69)
        Me.cmdPos.TabIndex = 17
        '
        'rdBottomRight
        '
        Me.rdBottomRight.AutoSize = True
        Me.rdBottomRight.Location = New System.Drawing.Point(48, 48)
        Me.rdBottomRight.Name = "rdBottomRight"
        Me.rdBottomRight.Size = New System.Drawing.Size(14, 13)
        Me.rdBottomRight.TabIndex = 8
        Me.rdBottomRight.UseVisualStyleBackColor = True
        '
        'rdBottomCenter
        '
        Me.rdBottomCenter.AutoSize = True
        Me.rdBottomCenter.Checked = True
        Me.rdBottomCenter.Location = New System.Drawing.Point(26, 48)
        Me.rdBottomCenter.Name = "rdBottomCenter"
        Me.rdBottomCenter.Size = New System.Drawing.Size(14, 13)
        Me.rdBottomCenter.TabIndex = 7
        Me.rdBottomCenter.TabStop = True
        Me.rdBottomCenter.UseVisualStyleBackColor = True
        '
        'rdBottomLeft
        '
        Me.rdBottomLeft.AutoSize = True
        Me.rdBottomLeft.Location = New System.Drawing.Point(4, 48)
        Me.rdBottomLeft.Name = "rdBottomLeft"
        Me.rdBottomLeft.Size = New System.Drawing.Size(14, 13)
        Me.rdBottomLeft.TabIndex = 6
        Me.rdBottomLeft.UseVisualStyleBackColor = True
        '
        'rdCenter
        '
        Me.rdCenter.AutoSize = True
        Me.rdCenter.Location = New System.Drawing.Point(26, 26)
        Me.rdCenter.Name = "rdCenter"
        Me.rdCenter.Size = New System.Drawing.Size(14, 13)
        Me.rdCenter.TabIndex = 4
        Me.rdCenter.TabStop = True
        Me.rdCenter.UseVisualStyleBackColor = True
        '
        'rdTopRight
        '
        Me.rdTopRight.AutoSize = True
        Me.rdTopRight.Location = New System.Drawing.Point(48, 4)
        Me.rdTopRight.Name = "rdTopRight"
        Me.rdTopRight.Size = New System.Drawing.Size(14, 13)
        Me.rdTopRight.TabIndex = 2
        Me.rdTopRight.UseVisualStyleBackColor = True
        '
        'rdTopCenter
        '
        Me.rdTopCenter.AutoSize = True
        Me.rdTopCenter.Location = New System.Drawing.Point(26, 4)
        Me.rdTopCenter.Name = "rdTopCenter"
        Me.rdTopCenter.Size = New System.Drawing.Size(14, 13)
        Me.rdTopCenter.TabIndex = 1
        Me.rdTopCenter.TabStop = True
        Me.rdTopCenter.UseVisualStyleBackColor = True
        '
        'rdTopLeft
        '
        Me.rdTopLeft.AutoSize = True
        Me.rdTopLeft.Location = New System.Drawing.Point(4, 4)
        Me.rdTopLeft.Name = "rdTopLeft"
        Me.rdTopLeft.Size = New System.Drawing.Size(14, 13)
        Me.rdTopLeft.TabIndex = 0
        Me.rdTopLeft.TabStop = True
        Me.rdTopLeft.UseVisualStyleBackColor = True
        '
        'txtTm
        '
        Me.txtTm.Location = New System.Drawing.Point(11, 78)
        Me.txtTm.Name = "txtTm"
        Me.txtTm.Size = New System.Drawing.Size(45, 20)
        Me.txtTm.TabIndex = 16
        Me.txtTm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTm.Value = New Decimal(New Integer() {48, 0, 0, 0})
        '
        'cmdRemTxt
        '
        Me.cmdRemTxt.Location = New System.Drawing.Point(253, 52)
        Me.cmdRemTxt.Name = "cmdRemTxt"
        Me.cmdRemTxt.Size = New System.Drawing.Size(99, 20)
        Me.cmdRemTxt.TabIndex = 15
        Me.cmdRemTxt.Text = "Remover texto"
        Me.cmdRemTxt.UseVisualStyleBackColor = True
        '
        'lblTmp
        '
        Me.lblTmp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTmp.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTmp.Location = New System.Drawing.Point(856, 354)
        Me.lblTmp.Name = "lblTmp"
        Me.lblTmp.Size = New System.Drawing.Size(125, 39)
        Me.lblTmp.TabIndex = 18
        Me.lblTmp.Text = "00:00"
        Me.lblTmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpToolsVideo
        '
        Me.grpToolsVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpToolsVideo.Controls.Add(Me.txtIrParaM)
        Me.grpToolsVideo.Controls.Add(Me.txtIrParaSeg)
        Me.grpToolsVideo.Controls.Add(Me.txtIrParaH)
        Me.grpToolsVideo.Controls.Add(Me.cmdIr)
        Me.grpToolsVideo.Controls.Add(Me.lblIrPara)
        Me.grpToolsVideo.Controls.Add(Me.lblDivM)
        Me.grpToolsVideo.Controls.Add(Me.lblDivH)
        Me.grpToolsVideo.Controls.Add(Me.cmdRatioVGA)
        Me.grpToolsVideo.Controls.Add(Me.cmdRatioWide)
        Me.grpToolsVideo.Location = New System.Drawing.Point(984, 4)
        Me.grpToolsVideo.Name = "grpToolsVideo"
        Me.grpToolsVideo.Size = New System.Drawing.Size(251, 402)
        Me.grpToolsVideo.TabIndex = 19
        Me.grpToolsVideo.TabStop = False
        Me.grpToolsVideo.Text = "Ferramentas de Vídeo"
        '
        'txtIrParaM
        '
        Me.txtIrParaM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtIrParaM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIrParaM.Location = New System.Drawing.Point(76, 66)
        Me.txtIrParaM.Mask = "00"
        Me.txtIrParaM.Name = "txtIrParaM"
        Me.txtIrParaM.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtIrParaM.Size = New System.Drawing.Size(43, 20)
        Me.txtIrParaM.TabIndex = 31
        Me.txtIrParaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIrParaM.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtIrParaSeg
        '
        Me.txtIrParaSeg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtIrParaSeg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIrParaSeg.Location = New System.Drawing.Point(146, 66)
        Me.txtIrParaSeg.Mask = "00"
        Me.txtIrParaSeg.Name = "txtIrParaSeg"
        Me.txtIrParaSeg.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtIrParaSeg.Size = New System.Drawing.Size(43, 20)
        Me.txtIrParaSeg.TabIndex = 30
        Me.txtIrParaSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIrParaSeg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtIrParaH
        '
        Me.txtIrParaH.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtIrParaH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIrParaH.Location = New System.Drawing.Point(6, 66)
        Me.txtIrParaH.Mask = "00"
        Me.txtIrParaH.Name = "txtIrParaH"
        Me.txtIrParaH.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtIrParaH.Size = New System.Drawing.Size(43, 20)
        Me.txtIrParaH.TabIndex = 29
        Me.txtIrParaH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIrParaH.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'cmdIr
        '
        Me.cmdIr.Location = New System.Drawing.Point(195, 64)
        Me.cmdIr.Name = "cmdIr"
        Me.cmdIr.Size = New System.Drawing.Size(50, 23)
        Me.cmdIr.TabIndex = 21
        Me.cmdIr.Text = "Ir"
        Me.cmdIr.UseVisualStyleBackColor = True
        '
        'lblIrPara
        '
        Me.lblIrPara.AutoSize = True
        Me.lblIrPara.Location = New System.Drawing.Point(6, 45)
        Me.lblIrPara.Name = "lblIrPara"
        Me.lblIrPara.Size = New System.Drawing.Size(123, 13)
        Me.lblIrPara.TabIndex = 28
        Me.lblIrPara.Text = "Ir para ponto específico:"
        '
        'lblDivM
        '
        Me.lblDivM.AutoSize = True
        Me.lblDivM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivM.Location = New System.Drawing.Point(125, 65)
        Me.lblDivM.Name = "lblDivM"
        Me.lblDivM.Size = New System.Drawing.Size(15, 19)
        Me.lblDivM.TabIndex = 27
        Me.lblDivM.Text = ":"
        '
        'lblDivH
        '
        Me.lblDivH.AutoSize = True
        Me.lblDivH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivH.Location = New System.Drawing.Point(55, 65)
        Me.lblDivH.Name = "lblDivH"
        Me.lblDivH.Size = New System.Drawing.Size(15, 19)
        Me.lblDivH.TabIndex = 25
        Me.lblDivH.Text = ":"
        '
        'cmdRatioVGA
        '
        Me.cmdRatioVGA.Location = New System.Drawing.Point(6, 19)
        Me.cmdRatioVGA.Name = "cmdRatioVGA"
        Me.cmdRatioVGA.Size = New System.Drawing.Size(75, 23)
        Me.cmdRatioVGA.TabIndex = 21
        Me.cmdRatioVGA.Text = "4 : 3"
        Me.cmdRatioVGA.UseVisualStyleBackColor = True
        '
        'cmdRatioWide
        '
        Me.cmdRatioWide.Location = New System.Drawing.Point(87, 19)
        Me.cmdRatioWide.Name = "cmdRatioWide"
        Me.cmdRatioWide.Size = New System.Drawing.Size(75, 23)
        Me.cmdRatioWide.TabIndex = 20
        Me.cmdRatioWide.Text = "16 : 9"
        Me.cmdRatioWide.UseVisualStyleBackColor = True
        '
        'cmdAv10
        '
        Me.cmdAv10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAv10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAv10.Location = New System.Drawing.Point(796, 346)
        Me.cmdAv10.Name = "cmdAv10"
        Me.cmdAv10.Size = New System.Drawing.Size(54, 59)
        Me.cmdAv10.TabIndex = 21
        Me.cmdAv10.Text = "+10"
        Me.cmdAv10.UseVisualStyleBackColor = True
        '
        'cmdVl10
        '
        Me.cmdVl10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdVl10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVl10.Location = New System.Drawing.Point(736, 346)
        Me.cmdVl10.Name = "cmdVl10"
        Me.cmdVl10.Size = New System.Drawing.Size(54, 59)
        Me.cmdVl10.TabIndex = 22
        Me.cmdVl10.Text = "-10"
        Me.cmdVl10.UseVisualStyleBackColor = True
        '
        'cmdVlCap
        '
        Me.cmdVlCap.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdVlCap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdVlCap.ImageIndex = 2
        Me.cmdVlCap.ImageList = Me.cmdPics
        Me.cmdVlCap.Location = New System.Drawing.Point(616, 347)
        Me.cmdVlCap.Name = "cmdVlCap"
        Me.cmdVlCap.Size = New System.Drawing.Size(54, 59)
        Me.cmdVlCap.TabIndex = 16
        Me.cmdVlCap.UseVisualStyleBackColor = True
        '
        'cmdPrCap
        '
        Me.cmdPrCap.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdPrCap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrCap.ImageIndex = 1
        Me.cmdPrCap.ImageList = Me.cmdPics
        Me.cmdPrCap.Location = New System.Drawing.Point(676, 347)
        Me.cmdPrCap.Name = "cmdPrCap"
        Me.cmdPrCap.Size = New System.Drawing.Size(54, 59)
        Me.cmdPrCap.TabIndex = 15
        Me.cmdPrCap.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStop.ImageIndex = 5
        Me.cmdStop.ImageList = Me.cmdPics
        Me.cmdStop.Location = New System.Drawing.Point(496, 347)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(54, 59)
        Me.cmdStop.TabIndex = 14
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdProx
        '
        Me.cmdProx.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdProx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProx.ImageIndex = 7
        Me.cmdProx.ImageList = Me.cmdPics
        Me.cmdProx.Location = New System.Drawing.Point(556, 347)
        Me.cmdProx.Name = "cmdProx"
        Me.cmdProx.Size = New System.Drawing.Size(54, 59)
        Me.cmdProx.TabIndex = 7
        Me.cmdProx.UseVisualStyleBackColor = True
        '
        'cmdVl
        '
        Me.cmdVl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdVl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdVl.ImageIndex = 6
        Me.cmdVl.ImageList = Me.cmdPics
        Me.cmdVl.Location = New System.Drawing.Point(376, 347)
        Me.cmdVl.Name = "cmdVl"
        Me.cmdVl.Size = New System.Drawing.Size(54, 59)
        Me.cmdVl.TabIndex = 6
        Me.cmdVl.UseVisualStyleBackColor = True
        '
        'cmdPlay
        '
        Me.cmdPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdPlay.BackColor = System.Drawing.Color.Transparent
        Me.cmdPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPlay.ImageIndex = 0
        Me.cmdPlay.ImageList = Me.cmdPics
        Me.cmdPlay.Location = New System.Drawing.Point(436, 348)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(54, 58)
        Me.cmdPlay.TabIndex = 5
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'picBackLogo
        '
        Me.picBackLogo.Image = Global.SiaelLivePlay.My.Resources.Resources.JW
        Me.picBackLogo.Location = New System.Drawing.Point(376, 3)
        Me.picBackLogo.Name = "picBackLogo"
        Me.picBackLogo.Size = New System.Drawing.Size(602, 339)
        Me.picBackLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackLogo.TabIndex = 23
        Me.picBackLogo.TabStop = False
        '
        'tmCron
        '
        Me.tmCron.Interval = 1000
        '
        'cmdAtivCron
        '
        Me.cmdAtivCron.Location = New System.Drawing.Point(253, 102)
        Me.cmdAtivCron.Name = "cmdAtivCron"
        Me.cmdAtivCron.Size = New System.Drawing.Size(99, 45)
        Me.cmdAtivCron.TabIndex = 18
        Me.cmdAtivCron.Text = "Ativar cronômetro de 1 minuto"
        Me.cmdAtivCron.UseVisualStyleBackColor = True
        '
        'cmdDesCron
        '
        Me.cmdDesCron.Location = New System.Drawing.Point(148, 102)
        Me.cmdDesCron.Name = "cmdDesCron"
        Me.cmdDesCron.Size = New System.Drawing.Size(99, 45)
        Me.cmdDesCron.TabIndex = 19
        Me.cmdDesCron.Text = "Desativar cronômetro"
        Me.cmdDesCron.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 417)
        Me.Controls.Add(Me.cmdVl10)
        Me.Controls.Add(Me.cmdAv10)
        Me.Controls.Add(Me.grpToolsVideo)
        Me.Controls.Add(Me.lblTmp)
        Me.Controls.Add(Me.cmdVlCap)
        Me.Controls.Add(Me.cmdPrCap)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.txtTextTools)
        Me.Controls.Add(Me.cmdProx)
        Me.Controls.Add(Me.cmdVl)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPlaylist)
        Me.Controls.Add(Me.cmdSlcVd)
        Me.Controls.Add(Me.VLCPl)
        Me.Controls.Add(Me.picBackLogo)
        Me.MinimumSize = New System.Drawing.Size(1259, 456)
        Me.Name = "main"
        Me.Text = "Live Play Video"
        CType(Me.VLCPl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlaylist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtTextTools.ResumeLayout(False)
        Me.txtTextTools.PerformLayout()
        Me.cmdPos.ResumeLayout(False)
        Me.cmdPos.PerformLayout()
        CType(Me.txtTm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpToolsVideo.ResumeLayout(False)
        Me.grpToolsVideo.PerformLayout()
        CType(Me.picBackLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VLCPl As AxAXVLC.AxVLCPlugin2
    Friend WithEvents cmdSlcVd As Button
    Friend WithEvents dlgAbrVid As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPlay As Button
    Friend WithEvents cmdVl As Button
    Friend WithEvents cmdProx As Button
    Friend WithEvents dgvPlaylist As DataGridView
    Friend WithEvents txtTxt As TextBox
    Friend WithEvents cmdEnv As Button
    Friend WithEvents txtTextTools As GroupBox
    Friend WithEvents cmdStop As Button
    Friend WithEvents cmdPrCap As Button
    Friend WithEvents cmdVlCap As Button
    Friend WithEvents lblTmp As Label
    Friend WithEvents cmdPics As ImageList
    Friend WithEvents grpToolsVideo As GroupBox
    Friend WithEvents cmdRatioWide As Button
    Friend WithEvents cmdRatioVGA As Button
    Friend WithEvents cmdRemTxt As Button
    Friend WithEvents txtTm As NumericUpDown
    Friend WithEvents cmdPos As TableLayoutPanel
    Friend WithEvents rdBottomRight As RadioButton
    Friend WithEvents rdBottomCenter As RadioButton
    Friend WithEvents rdBottomLeft As RadioButton
    Friend WithEvents rdCenter As RadioButton
    Friend WithEvents rdTopRight As RadioButton
    Friend WithEvents rdTopCenter As RadioButton
    Friend WithEvents rdTopLeft As RadioButton
    Friend WithEvents cmdIr As Button
    Friend WithEvents lblIrPara As Label
    Friend WithEvents lblDivM As Label
    Friend WithEvents lblDivH As Label
    Friend WithEvents txtIrParaH As MaskedTextBox
    Friend WithEvents txtIrParaM As MaskedTextBox
    Friend WithEvents txtIrParaSeg As MaskedTextBox
    Friend WithEvents cmdAv10 As Button
    Friend WithEvents cmdVl10 As Button
    Friend WithEvents picBackLogo As PictureBox
    Friend WithEvents cmdAtivCron As Button
    Friend WithEvents tmCron As Timer
    Friend WithEvents cmdDesCron As Button
End Class
