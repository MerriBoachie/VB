'In-Game Code

Public Class frmGame

    '"Game start" buttin code- begins game

    'When button is clicked, the player can enter the difficulty(Variable declaration to hold input)
    Dim intDifficultyChoose As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Get input from inputBox
        intDifficultyChoose = InputBox(“Choose the difficulty!! (1 for easy, 2 for medium, 3 for hard!)”, “Choose!”)

        'Start Asteroid timertick
        tmrAsteroidMove.Start()
        'Hide button on form
        btnStart.Hide()

    End Sub

    'Keypress code (KeyDown, Moves player using arrow keys when held down) Credit: http://net-informations.com/q/faq/arrowkeys.html )

    'New Point declaration for movement
    Dim ptAcross As New Point

    'Keypress detection code
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'detect up arrow key
        If keyData = Keys.Up Then
            ptAcross.X = picCorgiSprite.Location.X
            ptAcross.Y = picCorgiSprite.Location.Y - 20
            picCorgiSprite.Location = ptAcross
            Return True
        End If
        'detect down arrow key
        If keyData = Keys.Down Then
            ptAcross.X = picCorgiSprite.Location.X
            ptAcross.Y = picCorgiSprite.Location.Y + 20
            picCorgiSprite.Location = ptAcross
            Return True
        End If
        'detect left arrow key
        If keyData = Keys.Left Then
            ptAcross.X = picCorgiSprite.Location.X - 20
            ptAcross.Y = picCorgiSprite.Location.Y
            picCorgiSprite.Location = ptAcross
            Return True
        End If
        'detect right arrow key
        If keyData = Keys.Right Then
            ptAcross.X = picCorgiSprite.Location.X + 20
            ptAcross.Y = picCorgiSprite.Location.Y
            picCorgiSprite.Location = ptAcross
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    'Make the Asteroids move (As well as load Inputbox and begin Detection Subroutine)

    'Declarations- one for new movement point, 1 number generator to generate random speeds for the asteroids
    Dim ptAsteroidMove As New Point
    Dim genSpeed As New Random

    'Create an array to hold the speed values
    Dim arrSpeeds(4) As Integer

    'Timertick event- begins collision detect/life meter detect subroutines and begins asteroid movement
    Private Sub tmrAsteroidMove_Tick(sender As Object, e As EventArgs) Handles tmrAsteroidMove.Tick

        'Trycatch for inputbox

        Try

            'Difficulty will change based on player input
            If intDifficultyChoose = 1 Then
                'Loop to get speeds and put them in the array
                For intSpeedDimCounter As Integer = 0 To arrSpeeds.Length - 1
                    arrSpeeds(intSpeedDimCounter) = genSpeed.Next(10, 21)
                Next intSpeedDimCounter
            ElseIf intDifficultyChoose = 2 Then
                'Loop to get speeds and put them in the array
                For intSpeedDimCounter As Integer = 0 To arrSpeeds.Length - 1
                    arrSpeeds(intSpeedDimCounter) = genSpeed.Next(21, 31)
                Next intSpeedDimCounter
            ElseIf intDifficultyChoose = 3 Then
                'Loop to get speeds and put them in the array
                For intSpeedDimCounter As Integer = 0 To arrSpeeds.Length - 1
                    arrSpeeds(intSpeedDimCounter) = genSpeed.Next(31, 41)
                Next intSpeedDimCounter
            End If
        Catch ex As Exception

            MessageBox.Show(“You fool- enter 1, 2 or 3!!! >:(”, “Nani!?!?!”)

        End Try


        'Start detection subroutine
        Detection()

        'Begin asteroid movement across form
        ptAsteroidMove.X = picAsteroid1.Location.X - arrSpeeds(0)
        ptAsteroidMove.Y = picAsteroid1.Location.Y
        picAsteroid1.Location = ptAsteroidMove

        ptAsteroidMove.X = picAsteroid2.Location.X - arrSpeeds(1)
        ptAsteroidMove.Y = picAsteroid2.Location.Y
        picAsteroid2.Location = ptAsteroidMove

        ptAsteroidMove.X = picAsteroid3.Location.X - arrSpeeds(2)
        ptAsteroidMove.Y = picAsteroid3.Location.Y
        picAsteroid3.Location = ptAsteroidMove

        ptAsteroidMove.X = picAsteroid4.Location.X - arrSpeeds(3)
        ptAsteroidMove.Y = picAsteroid4.Location.Y
        picAsteroid4.Location = ptAsteroidMove

        ptAsteroidMove.X = picAsteroid5.Location.X - arrSpeeds(4)
        ptAsteroidMove.Y = picAsteroid5.Location.Y
        picAsteroid5.Location = ptAsteroidMove

    End Sub

    'Collision Detection- setects if asteroid hits player (Also checks to see if asteroid reaches edge of the screen)

    'Boolean declaration (for asteroid and bone)
    Dim blnCollisionDetection As Boolean
    Dim blnBoneCollision As Boolean

    'Asteroid/Bone starting points (For when the game resets)
    Dim ptAsteroid1Original As New Point(703, 109)
    Dim ptAsteroid2Original As New Point(703, 179)
    Dim ptAsteroid3Original As New Point(703, 250)
    Dim ptAsteroid4Original As New Point(703, 320)
    Dim ptAsteroid5Original As New Point(703, 392)
    Dim ptBoneOriginal As New Point(345, 160)

    Private Sub Detection()

        'X and Y point number generators- determine where asteroid resets to after it reaches the edge of the screen
        Dim genX As New Random
        Dim genY As New Random
        Dim ptXRandom As Integer = genX.Next(600, 703)
        Dim ptYRandom As Integer = genY.Next(0, 392)
        'As well as a number gen to determine the point at which the dog bone appears

        'Score counter for when player collects treats
        Static intScoreCounter As Integer

        'Point that asteroid resets to
        Dim ptAsteroidOG As New Point(ptXRandom, ptYRandom)

        'Point the dog treat resets to 
        Dim ptBone As New Point(ptXRandom, ptYRandom)

        'Point that player resets to when hit
        Dim ptOriginal As New Point(12, 125)

        'Counter for how many times player is hit (player dies when it reaches three)
        Static intHitCounter As Integer

        'If the player intersects with any of the asteroids or with the treat, the boolean Collision Detection and/or Bone Collision will be true
        If picAsteroid2.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnCollisionDetection = True
        ElseIf picAsteroid3.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnCollisionDetection = True
        ElseIf picAsteroid4.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnCollisionDetection = True
        ElseIf picAsteroid5.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnCollisionDetection = True
        ElseIf picAsteroid1.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnCollisionDetection = True
        ElseIf picBone.Bounds.IntersectsWith(picCorgiSprite.Bounds) Then
            blnBoneCollision = True
        End If

        'When the Asteroid boolean is true, the player location will reset, and 1 will be added to the hit counter; If the boolean Bone Collision is true, then 1 will be added to the score counter
        'After task executes, the booleans will reset to false
        If blnCollisionDetection = True Then
            picCorgiSprite.Location = ptOriginal
            intHitCounter = intHitCounter + 1
            blnCollisionDetection = False
        ElseIf blnBoneCollision = True Then
            picBone.Location = ptBone
            intScoreCounter = intScoreCounter + 1
            lblScore.Text = intScoreCounter
            blnBoneCollision = False
        End If

        'When an asteroid hits the edge of the screen, it will reset to a random location
        If picAsteroid1.Bounds.IntersectsWith(picBoundary.Bounds) Then
            picAsteroid1.Location = ptAsteroidOG
            ReDim arrSpeeds(4)
        ElseIf picAsteroid2.Bounds.IntersectsWith(picBoundary.Bounds) Then
            picAsteroid2.Location = ptAsteroidOG
            ReDim arrSpeeds(4)
        End If

        'Code to remove one picturebox life each time player is hit
        If intHitCounter = 1 Then
            picLifeMeter1.Hide()
        ElseIf intHitCounter = 2 Then
            picLifeMeter2.Hide()
        End If

        'End game When player runs out Of lives and reset the game
        If intHitCounter = 3 Then
            'Show game over form and hide current form
            frmGameOver.Show()
            Me.Hide()

            'Stop timertick
            tmrAsteroidMove.Stop()

            'Show game start button again
            btnStart.Show()

            'Show life meter pictureboxes
            picLifeMeter1.Show()
            picLifeMeter2.Show()

            'Reset picturebox locations and counters
            picCorgiSprite.Location = ptOriginal
            picAsteroid1.Location = ptAsteroid1Original
            picAsteroid2.Location = ptAsteroid2Original
            picAsteroid3.Location = ptAsteroid3Original
            picAsteroid4.Location = ptAsteroid4Original
            picAsteroid5.Location = ptAsteroid5Original
            picBone.Location = ptBoneOriginal

            'Before score resets to 0, intScoreHold will take that number 
            intScoreHold = intScoreCounter
            intHitCounter = 0
            intScoreCounter = 0
        End If
    End Sub

    'Variable to hold score before it resets (Declared as public so that it can be passed to game over screen)
    Public intScoreHold As Integer

End Class
