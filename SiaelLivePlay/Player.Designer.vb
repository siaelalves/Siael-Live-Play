<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Player
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.vlcPl = New AxAXVLC.AxVLCPlugin2()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.lblCron = New System.Windows.Forms.Label()
        CType(Me.vlcPl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vlcPl
        '
        Me.vlcPl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vlcPl.Enabled = True
        Me.vlcPl.Location = New System.Drawing.Point(0, 0)
        Me.vlcPl.Name = "vlcPl"
        Me.vlcPl.OcxState = CType(resources.GetObject("vlcPl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlcPl.Size = New System.Drawing.Size(773, 381)
        Me.vlcPl.TabIndex = 2
        Me.vlcPl.Visible = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.Transparent
        Me.picBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBack.Image = Global.SiaelLivePlay.My.Resources.Resources.JW
        Me.picBack.Location = New System.Drawing.Point(0, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(773, 381)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 4
        Me.picBack.TabStop = False
        '
        'lblCron
        '
        Me.lblCron.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCron.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCron.ForeColor = System.Drawing.Color.White
        Me.lblCron.Location = New System.Drawing.Point(0, 0)
        Me.lblCron.Name = "lblCron"
        Me.lblCron.Size = New System.Drawing.Size(773, 381)
        Me.lblCron.TabIndex = 5
        Me.lblCron.Text = "00:00"
        Me.lblCron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCron.Visible = False
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(773, 381)
        Me.Controls.Add(Me.lblCron)
        Me.Controls.Add(Me.vlcPl)
        Me.Controls.Add(Me.picBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Player"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.vlcPl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents vlcPl As AxAXVLC.AxVLCPlugin2
    Friend WithEvents picBack As PictureBox
    Friend WithEvents lblCron As Label
End Class
