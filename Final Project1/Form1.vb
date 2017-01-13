Option Strict On
'Final Project 
'Sebastian Montoya
'5/12/2014
'Asteroid Hunter
Public Class Form1
    Dim tmrDirection(3), tmrAsteroid(5), tmrScorePopup(5), tmrShipShoot(3) As Timer
    Dim picAsteroid(5) As PictureBox
    Dim lblPoints(5) As Label
    Dim blnDirection(3), blnAsteroidIn(5), blnGameOver As Boolean
    Dim blnShipImage As Boolean = True
    Dim blnShipHit As Boolean = True
    Dim intAsteroidDirection(5), intScore, intSpeed, intMPH As Integer
    Dim intFace As Integer = 2
    Dim intLives As Integer = 3
    Dim intAsteroidCount As Integer = 0
    '
    '=========
    'Form Load
    '=========
    '
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MessageBox.Show("To play, use the arrow keys to move, and the 'W' key to shoot. You may only have one bullet on the screen at one time so use it wisely! You can only shoot when you are moving. The objective of this game is to shoot as many asteroids for points as possible before losing all of your lives. The amount of points you earn depends on the size of the asteroid. You lose lives by coliding into asteroids and your fuel running empty. You can regain fuel by collecting the squares with the letter 'F' on them( those are fuel tanks and they don't regenerate often!). Press the 'Exit' button in the corner to close the application. This game will become increasingly hard as time goes on. Good luck and bonne chance!", "Asteroid Hunter: Instructions")

        tmrRealTimeCheck.Start()
        tmrFuel.Start()
        tmrSeconds.Start()
        StartFX()

        Randomize()

        'assigns timers and picture boxes to their arrays
        tmrDirection(0) = tmrShipLeft
        tmrDirection(1) = tmrShipUp
        tmrDirection(2) = tmrShipRight
        tmrDirection(3) = tmrShipDown

        tmrAsteroid(0) = tmrAsteroid0
        tmrAsteroid(1) = tmrAsteroid1
        tmrAsteroid(2) = tmrAsteroid2
        tmrAsteroid(3) = tmrAsteroid3
        tmrAsteroid(4) = tmrAsteroid4
        tmrAsteroid(5) = tmrAsteroid5

        tmrShipShoot(0) = tmrShipShootLeft
        tmrShipShoot(1) = tmrShipShootRight
        tmrShipShoot(2) = tmrShipShootUp
        tmrShipShoot(3) = tmrShipShootDown

        tmrScorePopup(0) = tmrScorePopup0
        tmrScorePopup(1) = tmrScorePopup1
        tmrScorePopup(2) = tmrScorePopup2
        tmrScorePopup(3) = tmrScorePopup3
        tmrScorePopup(4) = tmrScorePopup4
        tmrScorePopup(5) = tmrScorePopup5

        lblPoints(0) = lblPoints0
        lblPoints(1) = lblPoints1
        lblPoints(2) = lblPoints2
        lblPoints(3) = lblPoints3
        lblPoints(4) = lblPoints4
        lblPoints(5) = lblPoints5

        picAsteroid(0) = picAsteroid0
        picAsteroid(1) = picAsteroid1
        picAsteroid(2) = picAsteroid2
        picAsteroid(3) = picAsteroid3
        picAsteroid(4) = picAsteroid4
        picAsteroid(5) = picAsteroid5

        For i = 0 To 5

            picAsteroid(i).Visible = False

        Next

        picShot.Location = New Point(10000, 10000)

        'Spawns first asteroid
        picAsteroid(0).Visible = True

        tmrAsteroid(0).Start()

        AsteroidStart()

        TankSpawn()

    End Sub
    '
    '===========
    'Key Strokes
    '=========== 
    '
    '
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'tests if game is paused or over
        If blnGameOver = False Then


            'disables opposing direction
            'makes direction boolean true
            'doesn't move if out of fuel

            'makes ship move according to key pressed
            If e.KeyCode = Keys.Left Then
                tmrDirection(0).Enabled = True
                tmrDirection(2).Enabled = False
                'loads jet charge and stops jet cooldown
                tmrJetCharge.Enabled = True
                tmrJetCooldown.Enabled = False
            End If
            If e.KeyCode = Keys.Up Then
                tmrDirection(1).Enabled = True
                tmrDirection(3).Enabled = False
                'loads jet charge and stops jet cooldown
                tmrJetCharge.Enabled = True
                tmrJetCooldown.Enabled = False
            End If
            If e.KeyCode = Keys.Right Then
                tmrDirection(2).Enabled = True
                tmrDirection(0).Enabled = False
                'loads jet charge and stops jet cooldown
                tmrJetCharge.Enabled = True
                tmrJetCooldown.Enabled = False
            End If
            If e.KeyCode = Keys.Down Then
                tmrDirection(3).Enabled = True
                tmrDirection(1).Enabled = False
                'loads jet charge and stops jet cooldown
                tmrJetCharge.Enabled = True
                tmrJetCooldown.Enabled = False
            End If


            'pass if Space is pressed
            If e.KeyCode = Keys.W Then

                'must be moving to shoot
                If tmrShipLeft.Enabled = True Or tmrShipUp.Enabled = True Or tmrShipRight.Enabled = True Or tmrShipDown.Enabled = True Then

                    'pass if no shot is in play at the moment
                    If tmrShipShootLeft.Enabled = False And tmrShipShootUp.Enabled = False And tmrShipShootRight.Enabled = False And tmrShipShootDown.Enabled = False Then

                        'makes shot visible
                        picShot.Visible = True

                        'top left
                        If intFace = 1 Then
                            picShot.Left = picShip.Left
                            picShot.Top = picShip.Top + 4

                            tmrShipShootLeft.Enabled = True
                            tmrShipShootUp.Enabled = True


                            ShotFX()
                        End If

                        'top right
                        If intFace = 3 Then
                            picShot.Left = picShip.Left + (picShip.Width - 4)
                            picShot.Top = picShip.Top

                            tmrShipShootUp.Enabled = True
                            tmrShipShootRight.Enabled = True

                            ShotFX()
                        End If

                        'bottom right
                        If intFace = 5 Then
                            picShot.Left = picShip.Left + (picShip.Width - 4)
                            picShot.Top = picShip.Top + (picShip.Height - 4)


                            tmrShipShootRight.Enabled = True
                            tmrShipShootDown.Enabled = True

                            ShotFX()
                        End If
                        'bottom left
                        If intFace = 7 Then
                            picShot.Left = picShip.Left
                            picShot.Top = picShip.Top + (picShip.Height - 4)


                            tmrShipShootDown.Enabled = True
                            tmrShipShootLeft.Enabled = True

                            ShotFX()
                        End If
                        'left
                        If intFace = 0 Then
                            picShot.Left = picShip.Left
                            picShot.Top = CInt(picShip.Top + ((picShip.Height / 2) - 2))

                            tmrShipShootLeft.Enabled = True

                            ShotFX()
                        End If
                        'up
                        If intFace = 2 Then
                            picShot.Left = CInt(picShip.Left + ((picShip.Width / 2) - 2))

                            picShot.Top = picShip.Top + 4
                            tmrShipShootUp.Enabled = True

                            ShotFX()
                        End If
                        'right
                        If intFace = 4 Then
                            picShot.Left = picShip.Left + (picShip.Width - 4)
                            picShot.Top = CInt(picShip.Top + ((picShip.Height / 2) - 2))

                            tmrShipShootRight.Enabled = True

                            ShotFX()
                        End If
                        'down
                        If intFace = 6 Then
                            picShot.Left = CInt(picShip.Left + ((picShip.Width / 2) - 2))
                            picShot.Top = picShip.Top + (picShip.Height - 4)

                            tmrShipShootDown.Enabled = True

                            ShotFX()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        'Disables movement for each key taken off (will work simultaniously)

        'left
        If e.KeyCode = Keys.Left Then
            tmrDirection(0).Enabled = False
            blnDirection(0) = False
        End If
        'up
        If e.KeyCode = Keys.Up Then
            tmrDirection(1).Enabled = False
            blnDirection(1) = False
        End If
        'right
        If e.KeyCode = Keys.Right Then
            tmrDirection(2).Enabled = False
            blnDirection(2) = False
        End If
        'down
        If e.KeyCode = Keys.Down Then
            tmrDirection(3).Enabled = False
            blnDirection(3) = False
        End If

        If tmrDirection(0).Enabled = False And tmrDirection(1).Enabled = False And tmrDirection(2).Enabled = False And tmrDirection(3).Enabled = False Then
            'stops jet charge and enables jet cooldown
            tmrJetCharge.Enabled = False
            tmrJetCooldown.Enabled = True
        End If

    End Sub
    '
    '==================================
    'Charge / Cooldown / Inertia Timers
    '==================================
    '
    '
    Private Sub tmrJetCharge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJetCharge.Tick

        'gradually makes speed go faster
        'makes sure interval is in range
        If (tmrDirection(0).Interval <= 68 And tmrDirection(0).Interval >= 18) Then

            'pass if ship is in motion
            If tmrDirection(0).Enabled = True Or tmrDirection(1).Enabled = True Or tmrDirection(2).Enabled = True Or tmrDirection(3).Enabled = True Then

                'for each timer, make it faster by 2 each tick
                For i = 0 To 3
                    tmrDirection(i).Interval -= 2
                Next
            Else
                'if ship is not in motion, stop charge
                tmrJetCharge.Enabled = False
            End If
        End If

    End Sub

    Private Sub tmrJetCooldown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJetCooldown.Tick

        'gradually makes speed go slower
        If tmrDirection(0).Interval <= 67 And tmrDirection(0).Interval >= 16 Then
            For i = 0 To 3
                tmrDirection(i).Interval += 2
            Next
            'enables inertia to carry ship through space
            tmrInertia.Enabled = True
            tmrInertia.Interval = tmrDirection(0).Interval


        Else
            'makes ship come to a halt after cooldown enough
            tmrJetCooldown.Enabled = False
            tmrInertia.Enabled = False
        End If




    End Sub

    Private Sub tmrInertia_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrInertia.Tick


        'top left
        If intFace = 1 Then
            picShip.Left -= 2
            picShip.Top -= 2
            'top right
        ElseIf intFace = 3 Then
            picShip.Top -= 2
            picShip.Left += 2
            'bottom right
        ElseIf intFace = 5 Then
            picShip.Top += 2
            picShip.Left += 2
            'bottom left
        ElseIf intFace = 7 Then
            picShip.Left -= 2
            picShip.Top += 2
            'left
        ElseIf intFace = 0 Then
            picShip.Left -= 2
            'up
        ElseIf intFace = 2 Then
            picShip.Top -= 2
            'right
        ElseIf intFace = 4 Then
            picShip.Left += 2
            'down
        ElseIf intFace = 6 Then
            picShip.Top += 2
        End If

    End Sub
    '
    '=============
    'Shot Movement
    '=============
    '
    '
    'left
    Private Sub tmrShipShootLeft_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrShipShootLeft.Tick

        'moves shot by 3 pixles
        picShot.Left -= 3

    End Sub
    'right
    Private Sub tmrShipShootRight_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrShipShootRight.Tick

        'moves shot by 3 pixles
        picShot.Left += 3

    End Sub
    'up
    Private Sub tmrShipShootUp_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrShipShootUp.Tick

        'moves shot by 3 pixles
        picShot.Top -= 3

    End Sub
    'down
    Private Sub tmrShipShootDown_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrShipShootDown.Tick

        'moves shot by 3 pixles
        picShot.Top += 3

    End Sub
    '
    '=============
    'Ship Movement
    '=============
    '
    '
    Private Sub tmrShipLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShipLeft.Tick
        'moves ship left
        picShip.Left -= 2
    End Sub

    Private Sub tmrShipRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShipRight.Tick
        'moves ship right
        picShip.Left += 2
    End Sub

    Private Sub tmrShipUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShipUp.Tick
        'moves ship up
        picShip.Top -= 2
    End Sub

    Private Sub tmrShipDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShipDown.Tick
        'moves ship down
        picShip.Top += 2
    End Sub
    '
    '======
    'Timers
    '======
    '
    '
    Private Sub tmrRealTimeCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRealTimeCheck.Tick

        'checks if game is over
        GameOver()

        'checks if asteroid was hit
        AsteroidHit()

        'resets the ship after hit by asteroid
        ShipReset()

        'shows orientation of ship
        ShipImage()

        'if ship gets fuel tank
        FuelGain()

        'makes ship reappear on other side of screen
        ShipWrap()

        'checks if shot hit anything or is outside form
        ShotReset()

    End Sub

    Private Sub tmrFuel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFuel.Tick

        'depleats fuel while moving
        FuelDrain()

    End Sub

    Private Sub tmrTankSpawn_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrTankSpawn.Tick

        'resets fuel tank's location and visibility
        TankSpawn()

    End Sub

    Private Sub tmrAsteroid0_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid0.Tick

        'pass if game is not paused
        If blnGameOver = False Then

            'uses variable i according to asteroid affected
            Dim i As Integer = 0

            'tests direction and moves in that direction
            Select Case intAsteroidDirection(i)

                Case 0
                    picAsteroid(i).Left -= 2
                Case 1
                    picAsteroid(i).Left -= 2
                    picAsteroid(i).Top -= 2
                Case 2
                    picAsteroid(i).Top -= 2
                Case 3
                    picAsteroid(i).Top -= 2
                    picAsteroid(i).Left += 2
                Case 4
                    picAsteroid(i).Left += 2
                Case 5
                    picAsteroid(i).Left += 2
                    picAsteroid(i).Top += 2
                Case 6
                    picAsteroid(i).Top += 2
                Case 7
                    picAsteroid(i).Left -= 2

            End Select

            'turns on indicator for if asteroid is on screen
            If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

                blnAsteroidIn(i) = True

            End If

            'resets asteroid when off screen after having been on screen
            If blnAsteroidIn(i) = True Then

                If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                    AsteroidReset(i)

                End If

            End If
        End If
    End Sub

    Private Sub tmrAsteroid1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid1.Tick

        Dim i As Integer = 1

        Select Case intAsteroidDirection(i)

            Case 0
                picAsteroid(i).Left -= 2
            Case 1
                picAsteroid(i).Left -= 2
                picAsteroid(i).Top -= 2
            Case 2
                picAsteroid(i).Top -= 2
            Case 3
                picAsteroid(i).Top -= 2
                picAsteroid(i).Left += 2
            Case 4
                picAsteroid(i).Left += 2
            Case 5
                picAsteroid(i).Left += 2
                picAsteroid(i).Top += 2
            Case 6
                picAsteroid(i).Top += 2
            Case 7
                picAsteroid(i).Left -= 2

        End Select

        If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

            blnAsteroidIn(i) = True

        End If

        'resets asteroid when off screen
        If blnAsteroidIn(i) = True Then

            If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                AsteroidReset(i)

            End If

        End If

    End Sub

    Private Sub tmrAsteroid2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid2.Tick

        Dim i As Integer = 2

        Select Case intAsteroidDirection(i)

            Case 0
                picAsteroid(i).Left -= 2
            Case 1
                picAsteroid(i).Left -= 2
                picAsteroid(i).Top -= 2
            Case 2
                picAsteroid(i).Top -= 2
            Case 3
                picAsteroid(i).Top -= 2
                picAsteroid(i).Left += 2
            Case 4
                picAsteroid(i).Left += 2
            Case 5
                picAsteroid(i).Left += 2
                picAsteroid(i).Top += 2
            Case 6
                picAsteroid(i).Top += 2
            Case 7
                picAsteroid(i).Left -= 2

        End Select

        If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

            blnAsteroidIn(i) = True

        End If

        'resets asteroid when off screen
        If blnAsteroidIn(i) = True Then

            If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                AsteroidReset(i)

            End If

        End If

    End Sub

    Private Sub tmrAsteroid3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid3.Tick

        Dim i As Integer = 3

        Select Case intAsteroidDirection(i)

            Case 0
                picAsteroid(i).Left -= 2
            Case 1
                picAsteroid(i).Left -= 2
                picAsteroid(i).Top -= 2
            Case 2
                picAsteroid(i).Top -= 2
            Case 3
                picAsteroid(i).Top -= 2
                picAsteroid(i).Left += 2
            Case 4
                picAsteroid(i).Left += 2
            Case 5
                picAsteroid(i).Left += 2
                picAsteroid(i).Top += 2
            Case 6
                picAsteroid(i).Top += 2
            Case 7
                picAsteroid(i).Left -= 2

        End Select

        If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

            blnAsteroidIn(i) = True

        End If

        'resets asteroid when off screen
        If blnAsteroidIn(i) = True Then

            If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                AsteroidReset(i)

            End If

        End If

    End Sub

    Private Sub tmrAsteroid4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid4.Tick

        Dim i As Integer = 4

        Select Case intAsteroidDirection(i)

            Case 0
                picAsteroid(i).Left -= 2
            Case 1
                picAsteroid(i).Left -= 2
                picAsteroid(i).Top -= 2
            Case 2
                picAsteroid(i).Top -= 2
            Case 3
                picAsteroid(i).Top -= 2
                picAsteroid(i).Left += 2
            Case 4
                picAsteroid(i).Left += 2
            Case 5
                picAsteroid(i).Left += 2
                picAsteroid(i).Top += 2
            Case 6
                picAsteroid(i).Top += 2
            Case 7
                picAsteroid(i).Left -= 2

        End Select

        If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

            blnAsteroidIn(i) = True

        End If

        'resets asteroid when off screen
        If blnAsteroidIn(i) = True Then

            If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                AsteroidReset(i)

            End If

        End If

    End Sub

    Private Sub tmrAsteroid5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid5.Tick

        Dim i As Integer = 5

        Select Case intAsteroidDirection(i)

            Case 0
                picAsteroid(i).Left -= 2
            Case 1
                picAsteroid(i).Left -= 2
                picAsteroid(i).Top -= 2
            Case 2
                picAsteroid(i).Top -= 2
            Case 3
                picAsteroid(i).Top -= 2
                picAsteroid(i).Left += 2
            Case 4
                picAsteroid(i).Left += 2
            Case 5
                picAsteroid(i).Left += 2
                picAsteroid(i).Top += 2
            Case 6
                picAsteroid(i).Top += 2
            Case 7
                picAsteroid(i).Left -= 2

        End Select

        If picAsteroid(i).Left > 0 And picAsteroid(i).Left < (Me.Width - picAsteroid(i).Width) And picAsteroid(i).Top > 0 And picAsteroid(i).Top < (Me.Height - picAsteroid(i).Height) Then

            blnAsteroidIn(i) = True

        End If

        'resets asteroid when off screen
        If blnAsteroidIn(i) = True Then

            If picAsteroid(i).Left < (0 - picAsteroid(i).Width) Or picAsteroid(i).Left >= Me.Width Or picAsteroid(i).Top < (0 - picAsteroid(i).Height) Or picAsteroid(i).Top >= Me.Height Then

                AsteroidReset(i)

            End If

        End If

    End Sub

    Private Sub tmrScorePopup0_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup0.Tick

        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 0

        'adds to time passed
        intTime += 1

        'moves label up
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop timer and reset ammount of time passed to 0
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If

    End Sub

    Private Sub tmrScorePopup1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup1.Tick
        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 1

        'adds to time passed
        'moves label up
        intTime += 1
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If
    End Sub

    Private Sub tmrScorePopup2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup2.Tick
        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 2

        'adds to time passed
        'moves label up
        intTime += 1
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If
    End Sub

    Private Sub tmrScorePopup3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup3.Tick
        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 3

        'adds to time passed
        'moves label up
        intTime += 1
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If
    End Sub

    Private Sub tmrScorePopup4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup4.Tick
        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 4

        'adds to time passed
        'moves label up
        intTime += 1
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If
    End Sub

    Private Sub tmrScorePopup5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScorePopup5.Tick
        'keeps track of time passed
        Static intTime As Integer

        'value for array number
        Dim i As Integer = 5

        'adds to time passed
        'moves label up
        intTime += 1
        lblPoints(i).Top -= 1

        'once label moved 30 paces, stop
        If intTime >= 30 Then
            lblPoints(i).Visible = False
            intTime = 0
            tmrScorePopup(i).Stop()
        End If
    End Sub

    Private Sub tmrShipReset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShipReset.Tick

        'makes ship invincible
        blnShipHit = False

        'keeps track of time
        Static intTime As Integer

        'adds to time
        intTime += 1

        'makes image of ship flash
        If blnShipImage = True Then
            blnShipImage = False
        ElseIf blnShipImage = False Then
            blnShipImage = True
        End If

        'pass after 6 ticks
        If intTime = 6 Then
            'make ship killable
            blnShipHit = True
            'stops reset timer
            tmrShipReset.Stop()
            'reset time passed to 0
            intTime = 0
        End If

    End Sub

    Private Sub tmrSeconds_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSeconds.Tick

        Static intSeconds As Integer

        'sets ammount of time must pass before next asteroid
        Dim intInterval As Integer = 30

        'counts number of seconds
        intSeconds += 1

        'pass on when certain amount of time passes
        Select Case intSeconds

            Case Is < intInterval

                intAsteroidCount = 0

                '30
            Case intInterval

                'adds one to asteroid count
                intAsteroidCount += 1
                'starts timer for moving asteroid
                tmrAsteroid(intAsteroidCount).Start()
                'moves asteroid and sets speed
                AsteroidReset(intAsteroidCount)
                'makes asteroid visible
                picAsteroid(intAsteroidCount).Visible = True
                'changes image of asteroid
                AsteroidImage(intAsteroidCount)

                '60
            Case intInterval * 2

                intAsteroidCount += 1
                tmrAsteroid(intAsteroidCount).Start()
                AsteroidReset(intAsteroidCount)
                picAsteroid(intAsteroidCount).Visible = True
                AsteroidImage(intAsteroidCount)

            Case intInterval * 3

                intAsteroidCount += 1
                tmrAsteroid(intAsteroidCount).Start()
                AsteroidReset(intAsteroidCount)
                picAsteroid(intAsteroidCount).Visible = True
                AsteroidImage(intAsteroidCount)

            Case intInterval * 4

                intAsteroidCount += 1
                tmrAsteroid(intAsteroidCount).Start()
                AsteroidReset(intAsteroidCount)
                picAsteroid(intAsteroidCount).Visible = True
                AsteroidImage(intAsteroidCount)

            Case intInterval * 5

                intAsteroidCount += 1
                tmrAsteroid(intAsteroidCount).Start()
                AsteroidReset(intAsteroidCount)
                picAsteroid(intAsteroidCount).Visible = True
                AsteroidImage(intAsteroidCount)

        End Select


    End Sub
    '
    '==========
    'Procedures
    '==========
    '
    '
    Private Sub AddScore(ByVal i As Integer)

        Dim intScoreAdd As Integer = 100 - picAsteroid(i).Width

        'sets up label
        lblPoints(i).Visible = True
        lblPoints(i).Text = CStr(intScoreAdd)
        lblPoints(i).Location = New Point(CInt(picAsteroid(i).Left + ((picAsteroid(i).Width / 2) - (lblPoints(i).Width / 2))), CInt(picAsteroid(i).Top + ((picAsteroid(i).Height / 2) - (lblPoints(i).Height / 2))))

        'starts label move timer
        tmrScorePopup(i).Start()

        'adds difference to points based on size of asteroid
        intScore += intScoreAdd
        'displays new score in corner of screen
        lblScore.Text = "Score: " & intScore

    End Sub

    Private Sub AsteroidFX()

        'plays shot fx audio 
        My.Computer.Audio.Play(My.Resources.AsteroidFX, AudioPlayMode.Background)

    End Sub

    Private Sub AsteroidHit()

        For i = 0 To intAsteroidCount

            'hit detection
            If picShot.Bounds.IntersectsWith(picAsteroid(i).Bounds) Then

                'adds points of asteroid
                AddScore(i)

                'makes new location for asteroid
                AsteroidReset(i)

                AsteroidImage(i)

                AsteroidFX()

                For t = 0 To 3
                    'stops timer and makes shot invisible
                    tmrShipShoot(t).Enabled = False
                    picShot.Visible = False
                    picShot.Location = New Point(10000, 10000)
                Next

            End If

        Next

    End Sub

    Private Sub AsteroidImage(ByVal i As Integer)

        'chooses new image for asteroid
        Dim intPic As Integer = CInt(Rnd() * 3 + 1)

        'case statements for each picture chosen
        Select Case intPic

            Case 1

                picAsteroid(i).Image = My.Resources.Asteroid1

            Case 2

                picAsteroid(i).Image = My.Resources.Asteroid2

            Case 3

                picAsteroid(i).Image = My.Resources.Asteroid3

            Case 4

                picAsteroid(i).Image = My.Resources.Asteroid4


        End Select

    End Sub

    Private Sub AsteroidReset(ByVal i As Integer)

        'sets size of asteroid
        picAsteroid(i).Width = CInt(Rnd() * 95 + 5)
        picAsteroid(i).Height = picAsteroid(i).Width

        'sets new speed of asteroid
        tmrAsteroid(i).Interval = CInt(picAsteroid(i).Width / 3) + 1

        If tmrAsteroid(i).Interval <= 5 Then

            tmrAsteroid(i).Interval = 5

        End If

        'variables for coordinate
        Dim intNewX, intNewY As Integer

        'creates new coordinate
        intNewX = CInt(Rnd() * (Me.Width + picAsteroid(i).Width * 2)) - (picAsteroid(i).Width + 1)
        intNewY = CInt(Rnd() * (Me.Height + picAsteroid(i).Height * 2)) - (picAsteroid(i).Height + 1)

        'gives values outside of the form
        Do While intNewX >= 0 And intNewX < Me.Width And intNewY >= 0 And intNewY < Me.Height

            'creates new coordinate
            intNewX = CInt(Rnd() * (Me.Width + picAsteroid(i).Width * 2)) - (picAsteroid(i).Width + 1)
            intNewY = CInt(Rnd() * (Me.Height + picAsteroid(i).Height * 2)) - (picAsteroid(i).Height + 1)

        Loop

        'moves asteroid
        picAsteroid(i).Location = New Point(intNewX, intNewY)

        'assigns direction of asteroid moving towards form
        If intNewX >= Me.Width And intNewY >= 0 And intNewY <= (Me.Height - picAsteroid(i).Height) Then
            intAsteroidDirection(i) = 0
        ElseIf intNewX >= (Me.Width - picAsteroid(i).Width) And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 1
        ElseIf intNewX <= (Me.Width - picAsteroid(i).Width) And intNewX >= 0 And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 2
        ElseIf intNewX < 0 And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 3
        ElseIf intNewX < 0 And intNewY >= 0 And intNewY <= (Me.Height - picAsteroid(i).Height) Then
            intAsteroidDirection(i) = 4
        ElseIf intNewX < 0 And intNewY < 0 Then
            intAsteroidDirection(i) = 5
        ElseIf intNewX >= 0 And intNewX <= (Me.Width - picAsteroid(i).Width) And intNewY < 0 Then
            intAsteroidDirection(i) = 6
        ElseIf intNewX >= Me.Width And intNewY < 0 Then
            intAsteroidDirection(i) = 7
        End If

    End Sub

    Private Sub AsteroidStart()

        Dim i As Integer = 0

        AsteroidImage(i)

        'sets size of asteroid
        picAsteroid(i).Width = CInt(Rnd() * 90 + 10)
        picAsteroid(i).Height = picAsteroid(i).Width

        'variables for coordinate
        Dim intNewX, intNewY As Integer

        'creates new coordinate
        intNewX = CInt(Rnd() * (Me.Width + picAsteroid(i).Width * 2) - picAsteroid(i).Width)
        intNewY = CInt(Rnd() * (Me.Height + picAsteroid(i).Height * 2) - picAsteroid(i).Height)

        'gives values outside of the form
        Do While intNewX >= 0 And intNewX < Me.Width And intNewY >= 0 And intNewY < Me.Height

            'creates new coordinate
            intNewX = CInt(Rnd() * (Me.Width + picAsteroid(i).Width * 2) - picAsteroid(i).Width)
            intNewY = CInt(Rnd() * (Me.Height + picAsteroid(i).Height * 2) - picAsteroid(i).Height)

        Loop

        'moves asteroid
        picAsteroid(i).Location = New Point(intNewX, intNewY)

        'assigns direction of asteroid moving towards form
        If intNewX >= Me.Width And intNewY >= 0 And intNewY <= (Me.Height - picAsteroid(i).Height) Then
            intAsteroidDirection(i) = 0
        ElseIf intNewX >= Me.Width And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 1
        ElseIf intNewX <= (Me.Width - picAsteroid(i).Width) And intNewX >= 0 And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 2
        ElseIf intNewX < 0 And intNewY >= Me.Height Then
            intAsteroidDirection(i) = 3
        ElseIf intNewX < 0 And intNewY >= 0 And intNewY <= (Me.Height - picAsteroid(i).Height) Then
            intAsteroidDirection(i) = 4
        ElseIf intNewX < 0 And intNewY < 0 Then
            intAsteroidDirection(i) = 5
        ElseIf intNewX >= 0 And intNewX <= (Me.Width - picAsteroid(i).Width) And intNewY < 0 Then
            intAsteroidDirection(i) = 6
        ElseIf intNewX >= Me.Width And intNewY < 0 Then
            intAsteroidDirection(i) = 7
        End If

    End Sub

    Private Sub GameOver()

        'pass if fuel is depleated
        If intLives = 0 Then

            'indicator if game is over
            blnGameOver = True
            blnShipImage = False

            picShip.Location = New Point(10000, 10000)

            lblGameOver.Visible = True
            lblGameOver.Location = New Point(206, 332)

            tmrInertia.Stop()
            tmrJetCharge.Stop()
            tmrJetCharge.Stop()
            tmrTankSpawn.Stop()
            tmrShipReset.Stop()
            tmrSeconds.Stop()
            tmrRealTimeCheck.Stop()

            For i = 0 To intAsteroidCount
                tmrScorePopup(i).Stop()
            Next

            'stops all current timers for moving ship
            For i = 0 To 3
                tmrDirection(i).Stop()
            Next

        End If

    End Sub

    Private Sub ExplodeFX()

        'plays fx audio 
        My.Computer.Audio.Play(My.Resources.ExplodeFX, AudioPlayMode.Background)

    End Sub

    Private Sub FuelDrain()

        'pass if ship is accelerating
        If tmrDirection(0).Enabled = True Or tmrDirection(1).Enabled = True Or tmrDirection(2).Enabled = True Or tmrDirection(3).Enabled = True Then

            'subtracts 10 from fuel gauge
            picFuel.Width -= 1

        End If

    End Sub

    Private Sub FuelGain()

        'checks if ship touched fuel tank on screen
        If picShip.Bounds.IntersectsWith(picTank.Bounds) And picTank.Visible = True Then

            'adds fuel
            picFuel.Width += 100

            'makes fuel appropriate length
            If picFuel.Width > 100 Then
                picFuel.Width = 100
            End If

            'hides tank after taken
            picTank.Visible = False

        End If



    End Sub

    Private Sub ShipImage()

        'if user is allowed to see picture
        If blnShipImage = True Then

            'test which direction ship is facing and changes picture shown accordingly
            If tmrShipLeft.Enabled = True And tmrShipUp.Enabled = True Then
                intFace = 1

            ElseIf tmrShipUp.Enabled = True And tmrShipRight.Enabled = True Then
                intFace = 3

            ElseIf tmrShipRight.Enabled = True And tmrShipDown.Enabled = True Then
                intFace = 5

            ElseIf tmrShipDown.Enabled = True And tmrShipLeft.Enabled = True Then
                intFace = 7

            ElseIf tmrShipLeft.Enabled = True Then
                intFace = 0

            ElseIf tmrShipUp.Enabled = True Then
                intFace = 2

            ElseIf tmrShipRight.Enabled = True Then
                intFace = 4

            ElseIf tmrShipDown.Enabled = True Then
                intFace = 6

            End If

            Select Case intFace
                Case 0
                    picShip.Image = My.Resources.Ship0
                Case 1
                    picShip.Image = My.Resources.Ship1
                Case 2
                    picShip.Image = My.Resources.Ship2
                Case 3
                    picShip.Image = My.Resources.Ship3
                Case 4
                    picShip.Image = My.Resources.Ship4
                Case 5
                    picShip.Image = My.Resources.Ship5
                Case 6
                    picShip.Image = My.Resources.Ship6
                Case 7
                    picShip.Image = My.Resources.Ship7
            End Select

        Else

            'makes picture of ship nothing if user is not allowed to see
            picShip.Image = Nothing

        End If

    End Sub

    Private Sub ShipReset()

        'checks each asteroid if hit
        For i = 0 To intAsteroidCount

            'pass if asteroid touches ship / pass if fuel runs out
            If (picShip.Bounds.IntersectsWith(picAsteroid(i).Bounds) And blnShipHit = True) Or picFuel.Width = 0 Then

                'only subtracts life if ship isn't in process of restarting
                If tmrShipReset.Enabled = False And blnGameOver = False Then

                    'plays sound
                    ExplodeFX()

                    'resets location in center of form
                    picShip.Location = New Point(348, 348)
                    picFuel.Width = 100

                    'subracts one from ammount of lives and displays
                    intLives -= 1
                    lblLives.Text = "Lives: " & CStr(intLives)
                    'starts ship reset for flashing and invincibility
                    tmrShipReset.Start()

                    'stops inertia after respawn
                    tmrInertia.Stop()

                End If

            End If

        Next

    End Sub

    Private Sub ShotFX()

        'plays fx audio 
        My.Computer.Audio.Play(My.Resources.ShotFX, AudioPlayMode.Background)

    End Sub

    Private Sub ShotReset()

        'checks if each timer is on
        For t = 0 To 3

            'checks for each asteroid
            For i = 0 To intAsteroidCount

                'will destroy shot on touch of asteroid / outside bounds of form
                If (picShot.Left < 0 Or picShot.Left > Me.Width Or picShot.Top < 0 Or picShot.Top > Me.Height) Or picShot.Bounds.IntersectsWith(picAsteroid(i).Bounds) Then

                    'stops shot motion in all directions
                    tmrShipShoot(t).Enabled = False

                    'makes shot invisible
                    picShot.Visible = False

                    'moves shot out of range
                    picShot.Location = New Point(10000, 10000)

                End If

            Next

        Next


    End Sub

    Private Sub TankSpawn()
        'shows fuel tank
        picTank.Visible = True

        'variables for coordinate
        Dim intRndX, intRndY As Integer

        'creates new coordinate
        intRndX = CInt(Rnd() * 699 + 1)
        intRndY = CInt(Rnd() * 699 + 1)

        'moves fuel tank
        picTank.Location = New Point(intRndX, intRndY)
    End Sub

    Private Sub ShipWrap()

        'makes ship appear on other side of form as if wrapping around screen when moving outside bounds of form
        If picShip.Left < 0 Then
            picShip.Left = Me.Width - picShip.Width
        End If
        If picShip.Top < 0 Then
            picShip.Top = Me.Height - picShip.Height
        End If
        If picShip.Left > (Me.Width - picShip.Width) Then
            picShip.Left = 0
        End If
        If picShip.Top > (Me.Height - picShip.Height) Then
            picShip.Top = 0
        End If

    End Sub

    Private Sub StartFX()

        'plays fx audio 
        My.Computer.Audio.Play(My.Resources.StartFX, AudioPlayMode.Background)

    End Sub
    '
    '====
    'Exit
    '====
    '
    '
    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub
End Class
