<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.tmrShipLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipShootLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJetCharge = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJetCooldown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipShootUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipShootRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipShootDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInertia = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrFuel = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTankSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid0 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid5 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScorePopup0 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoints0 = New System.Windows.Forms.Label()
        Me.lblPoints1 = New System.Windows.Forms.Label()
        Me.lblPoints2 = New System.Windows.Forms.Label()
        Me.lblPoints3 = New System.Windows.Forms.Label()
        Me.lblPoints4 = New System.Windows.Forms.Label()
        Me.lblPoints5 = New System.Windows.Forms.Label()
        Me.tmrScorePopup1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScorePopup2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScorePopup3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScorePopup4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScorePopup5 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShipReset = New System.Windows.Forms.Timer(Me.components)
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.picFuel = New System.Windows.Forms.PictureBox()
        Me.picAsteroid1 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid5 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid2 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid4 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid3 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid0 = New System.Windows.Forms.PictureBox()
        Me.picTank = New System.Windows.Forms.PictureBox()
        Me.picShot = New System.Windows.Forms.PictureBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(12, 695)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(57, 16)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score: 0"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(12, 679)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(53, 16)
        Me.lblLives.TabIndex = 2
        Me.lblLives.Text = "Lives: 3"
        '
        'tmrShipLeft
        '
        Me.tmrShipLeft.Interval = 68
        '
        'tmrShipShootLeft
        '
        Me.tmrShipShootLeft.Interval = 1
        '
        'tmrShipUp
        '
        Me.tmrShipUp.Interval = 68
        '
        'tmrShipRight
        '
        Me.tmrShipRight.Interval = 68
        '
        'tmrShipDown
        '
        Me.tmrShipDown.Interval = 68
        '
        'tmrJetCharge
        '
        '
        'tmrJetCooldown
        '
        Me.tmrJetCooldown.Interval = 150
        '
        'tmrShipShootUp
        '
        Me.tmrShipShootUp.Interval = 1
        '
        'tmrShipShootRight
        '
        Me.tmrShipShootRight.Interval = 1
        '
        'tmrShipShootDown
        '
        Me.tmrShipShootDown.Interval = 1
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Interval = 1
        '
        'tmrInertia
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(608, 679)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fuel:"
        '
        'tmrFuel
        '
        Me.tmrFuel.Interval = 300
        '
        'tmrTankSpawn
        '
        Me.tmrTankSpawn.Enabled = True
        Me.tmrTankSpawn.Interval = 45000
        '
        'tmrAsteroid0
        '
        Me.tmrAsteroid0.Interval = 50
        '
        'tmrAsteroid1
        '
        Me.tmrAsteroid1.Interval = 50
        '
        'tmrAsteroid2
        '
        Me.tmrAsteroid2.Interval = 50
        '
        'tmrAsteroid3
        '
        Me.tmrAsteroid3.Interval = 50
        '
        'tmrAsteroid4
        '
        Me.tmrAsteroid4.Interval = 50
        '
        'tmrAsteroid5
        '
        Me.tmrAsteroid5.Interval = 50
        '
        'tmrScorePopup0
        '
        Me.tmrScorePopup0.Interval = 30
        '
        'lblPoints0
        '
        Me.lblPoints0.AutoSize = True
        Me.lblPoints0.ForeColor = System.Drawing.Color.White
        Me.lblPoints0.Location = New System.Drawing.Point(132, 117)
        Me.lblPoints0.Name = "lblPoints0"
        Me.lblPoints0.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints0.TabIndex = 16
        Me.lblPoints0.Text = "0"
        Me.lblPoints0.Visible = False
        '
        'lblPoints1
        '
        Me.lblPoints1.AutoSize = True
        Me.lblPoints1.ForeColor = System.Drawing.Color.White
        Me.lblPoints1.Location = New System.Drawing.Point(132, 168)
        Me.lblPoints1.Name = "lblPoints1"
        Me.lblPoints1.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints1.TabIndex = 17
        Me.lblPoints1.Text = "1"
        Me.lblPoints1.Visible = False
        '
        'lblPoints2
        '
        Me.lblPoints2.AutoSize = True
        Me.lblPoints2.ForeColor = System.Drawing.Color.White
        Me.lblPoints2.Location = New System.Drawing.Point(132, 224)
        Me.lblPoints2.Name = "lblPoints2"
        Me.lblPoints2.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints2.TabIndex = 18
        Me.lblPoints2.Text = "2"
        Me.lblPoints2.Visible = False
        '
        'lblPoints3
        '
        Me.lblPoints3.AutoSize = True
        Me.lblPoints3.ForeColor = System.Drawing.Color.White
        Me.lblPoints3.Location = New System.Drawing.Point(132, 279)
        Me.lblPoints3.Name = "lblPoints3"
        Me.lblPoints3.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints3.TabIndex = 19
        Me.lblPoints3.Text = "3"
        Me.lblPoints3.Visible = False
        '
        'lblPoints4
        '
        Me.lblPoints4.AutoSize = True
        Me.lblPoints4.ForeColor = System.Drawing.Color.White
        Me.lblPoints4.Location = New System.Drawing.Point(132, 340)
        Me.lblPoints4.Name = "lblPoints4"
        Me.lblPoints4.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints4.TabIndex = 20
        Me.lblPoints4.Text = "4"
        Me.lblPoints4.Visible = False
        '
        'lblPoints5
        '
        Me.lblPoints5.AutoSize = True
        Me.lblPoints5.ForeColor = System.Drawing.Color.White
        Me.lblPoints5.Location = New System.Drawing.Point(132, 392)
        Me.lblPoints5.Name = "lblPoints5"
        Me.lblPoints5.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints5.TabIndex = 21
        Me.lblPoints5.Text = "5"
        Me.lblPoints5.Visible = False
        '
        'tmrScorePopup1
        '
        Me.tmrScorePopup1.Interval = 30
        '
        'tmrScorePopup2
        '
        Me.tmrScorePopup2.Interval = 30
        '
        'tmrScorePopup3
        '
        Me.tmrScorePopup3.Interval = 30
        '
        'tmrScorePopup4
        '
        Me.tmrScorePopup4.Interval = 30
        '
        'tmrScorePopup5
        '
        Me.tmrScorePopup5.Interval = 30
        '
        'tmrSeconds
        '
        Me.tmrSeconds.Interval = 1000
        '
        'tmrShipReset
        '
        Me.tmrShipReset.Interval = 300
        '
        'picShip
        '
        Me.picShip.BackColor = System.Drawing.Color.Black
        Me.picShip.Image = Global.Final_Project.My.Resources.Resources.Ship2
        Me.picShip.Location = New System.Drawing.Point(348, 348)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(25, 25)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShip.TabIndex = 0
        Me.picShip.TabStop = False
        '
        'picFuel
        '
        Me.picFuel.BackColor = System.Drawing.Color.White
        Me.picFuel.Location = New System.Drawing.Point(608, 698)
        Me.picFuel.Name = "picFuel"
        Me.picFuel.Size = New System.Drawing.Size(100, 13)
        Me.picFuel.TabIndex = 7
        Me.picFuel.TabStop = False
        '
        'picAsteroid1
        '
        Me.picAsteroid1.BackColor = System.Drawing.Color.White
        Me.picAsteroid1.Location = New System.Drawing.Point(15, 149)
        Me.picAsteroid1.Name = "picAsteroid1"
        Me.picAsteroid1.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid1.TabIndex = 15
        Me.picAsteroid1.TabStop = False
        Me.picAsteroid1.Visible = False
        '
        'picAsteroid5
        '
        Me.picAsteroid5.BackColor = System.Drawing.Color.White
        Me.picAsteroid5.Location = New System.Drawing.Point(15, 373)
        Me.picAsteroid5.Name = "picAsteroid5"
        Me.picAsteroid5.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid5.TabIndex = 13
        Me.picAsteroid5.TabStop = False
        Me.picAsteroid5.Visible = False
        '
        'picAsteroid2
        '
        Me.picAsteroid2.BackColor = System.Drawing.Color.White
        Me.picAsteroid2.Location = New System.Drawing.Point(15, 205)
        Me.picAsteroid2.Name = "picAsteroid2"
        Me.picAsteroid2.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid2.TabIndex = 12
        Me.picAsteroid2.TabStop = False
        Me.picAsteroid2.Visible = False
        '
        'picAsteroid4
        '
        Me.picAsteroid4.BackColor = System.Drawing.Color.White
        Me.picAsteroid4.Location = New System.Drawing.Point(15, 317)
        Me.picAsteroid4.Name = "picAsteroid4"
        Me.picAsteroid4.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid4.TabIndex = 11
        Me.picAsteroid4.TabStop = False
        Me.picAsteroid4.Visible = False
        '
        'picAsteroid3
        '
        Me.picAsteroid3.BackColor = System.Drawing.Color.White
        Me.picAsteroid3.Location = New System.Drawing.Point(15, 261)
        Me.picAsteroid3.Name = "picAsteroid3"
        Me.picAsteroid3.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid3.TabIndex = 10
        Me.picAsteroid3.TabStop = False
        Me.picAsteroid3.Visible = False
        '
        'picAsteroid0
        '
        Me.picAsteroid0.BackColor = System.Drawing.Color.White
        Me.picAsteroid0.Location = New System.Drawing.Point(15, 93)
        Me.picAsteroid0.Name = "picAsteroid0"
        Me.picAsteroid0.Size = New System.Drawing.Size(100, 50)
        Me.picAsteroid0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsteroid0.TabIndex = 9
        Me.picAsteroid0.TabStop = False
        Me.picAsteroid0.Visible = False
        '
        'picTank
        '
        Me.picTank.BackColor = System.Drawing.Color.White
        Me.picTank.Image = CType(resources.GetObject("picTank.Image"), System.Drawing.Image)
        Me.picTank.Location = New System.Drawing.Point(356, 224)
        Me.picTank.Name = "picTank"
        Me.picTank.Size = New System.Drawing.Size(20, 20)
        Me.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTank.TabIndex = 8
        Me.picTank.TabStop = False
        '
        'picShot
        '
        Me.picShot.BackColor = System.Drawing.Color.White
        Me.picShot.Location = New System.Drawing.Point(369, 349)
        Me.picShot.Name = "picShot"
        Me.picShot.Size = New System.Drawing.Size(4, 4)
        Me.picShot.TabIndex = 3
        Me.picShot.TabStop = False
        Me.picShot.Visible = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(15, 507)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(308, 56)
        Me.lblGameOver.TabIndex = 23
        Me.lblGameOver.Text = "GAME OVER"
        Me.lblGameOver.Visible = False
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Black
        Me.lblExit.Location = New System.Drawing.Point(664, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(57, 19)
        Me.lblExit.TabIndex = 24
        Me.lblExit.Text = "Exit"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(720, 720)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picTank)
        Me.Controls.Add(Me.picShip)
        Me.Controls.Add(Me.picFuel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPoints5)
        Me.Controls.Add(Me.lblPoints4)
        Me.Controls.Add(Me.lblPoints3)
        Me.Controls.Add(Me.lblPoints2)
        Me.Controls.Add(Me.lblPoints1)
        Me.Controls.Add(Me.lblPoints0)
        Me.Controls.Add(Me.picAsteroid1)
        Me.Controls.Add(Me.picAsteroid5)
        Me.Controls.Add(Me.picAsteroid2)
        Me.Controls.Add(Me.picAsteroid4)
        Me.Controls.Add(Me.picAsteroid3)
        Me.Controls.Add(Me.picAsteroid0)
        Me.Controls.Add(Me.picShot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asteroid Hunter"
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picShip As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents tmrShipLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrShipShootLeft As System.Windows.Forms.Timer
    Friend WithEvents picShot As System.Windows.Forms.PictureBox
    Friend WithEvents tmrShipUp As System.Windows.Forms.Timer
    Friend WithEvents tmrShipRight As System.Windows.Forms.Timer
    Friend WithEvents tmrShipDown As System.Windows.Forms.Timer
    Friend WithEvents tmrJetCharge As System.Windows.Forms.Timer
    Friend WithEvents tmrJetCooldown As System.Windows.Forms.Timer
    Friend WithEvents tmrShipShootUp As System.Windows.Forms.Timer
    Friend WithEvents tmrShipShootRight As System.Windows.Forms.Timer
    Friend WithEvents tmrShipShootDown As System.Windows.Forms.Timer
    Friend WithEvents tmrRealTimeCheck As System.Windows.Forms.Timer
    Friend WithEvents tmrInertia As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picFuel As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFuel As System.Windows.Forms.Timer
    Friend WithEvents picTank As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTankSpawn As System.Windows.Forms.Timer
    Friend WithEvents picAsteroid0 As System.Windows.Forms.PictureBox
    Friend WithEvents picAsteroid3 As System.Windows.Forms.PictureBox
    Friend WithEvents picAsteroid4 As System.Windows.Forms.PictureBox
    Friend WithEvents picAsteroid2 As System.Windows.Forms.PictureBox
    Friend WithEvents picAsteroid5 As System.Windows.Forms.PictureBox
    Friend WithEvents picAsteroid1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAsteroid0 As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroid1 As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroid2 As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroid3 As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroid4 As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroid5 As System.Windows.Forms.Timer
    Friend WithEvents tmrScorePopup0 As System.Windows.Forms.Timer
    Friend WithEvents lblPoints0 As System.Windows.Forms.Label
    Friend WithEvents lblPoints1 As System.Windows.Forms.Label
    Friend WithEvents lblPoints2 As System.Windows.Forms.Label
    Friend WithEvents lblPoints3 As System.Windows.Forms.Label
    Friend WithEvents lblPoints4 As System.Windows.Forms.Label
    Friend WithEvents lblPoints5 As System.Windows.Forms.Label
    Friend WithEvents tmrScorePopup1 As System.Windows.Forms.Timer
    Friend WithEvents tmrScorePopup2 As System.Windows.Forms.Timer
    Friend WithEvents tmrScorePopup3 As System.Windows.Forms.Timer
    Friend WithEvents tmrScorePopup4 As System.Windows.Forms.Timer
    Friend WithEvents tmrScorePopup5 As System.Windows.Forms.Timer
    Friend WithEvents tmrSeconds As System.Windows.Forms.Timer
    Friend WithEvents tmrShipReset As System.Windows.Forms.Timer
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label

End Class
