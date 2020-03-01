Public Class Game
    Dim Player1 As New Player
    Dim Player2 As New Player
    Dim sNumberOfPlayers

    Sub DetermineNumberOfPlayers()
        Console.WriteLine("How many players are there '1' or '2'?")
        sNumberOfPlayers = Console.ReadLine()
        If (sNumberOfPlayers <> "1" And sNumberOfPlayers <> "2") Then
            Console.WriteLine("I do not recognize that option. Please enter '1' or '2'.")
            DetermineNumberOfPlayers()
        End If
    End Sub

    Sub CreatePlayers()
        If (sNumberOfPlayers = "1") Then
            Player1 = New Human
            Player2 = New Computer
        ElseIf (sNumberOfPlayers = "2") Then
            Player1 = New Human
            Player2 = New Human
        End If
    End Sub

    Sub DisplayPlayersNames()
        Console.WriteLine("Welcome players to Rock, Paper, Scissors, Lizard, Spock now featuring {0} vs {1}", Player1.sName, Player2.sName)
    End Sub

    Sub DisplayInstructions()
        Console.WriteLine("Instructions for Rock, Paper, Scissors, Lizard, Spock")
        Console.WriteLine("Goal is to be the last player standing. Each person chooses either Rock, Paper, Scissors, Lizard or Spock and shows what they picked at the same time.")
        Console.WriteLine("Rock crushes Scissors")
        Console.WriteLine("Scissors cuts Paper")
        Console.WriteLine("Paper covers Rock")
        Console.WriteLine("Rock crushes Lizard")
        Console.WriteLine("Lizard poisons Spock")
        Console.WriteLine("Spock smashes Scissors")
        Console.WriteLine("Scissors decapitates Lizard")
        Console.WriteLine("Lizard eats Paper")
        Console.WriteLine("Paper disproves Spock")
        Console.WriteLine("Spock vaporizes Rock")
    End Sub

    Sub CompareGestures()
        If (Player1.sGesture = "rock" And Player2.sGesture <> "paper" And Player2.sGesture <> "spock" And Player2.sGesture <> "rock") Then
            Console.WriteLine("{0} wins this round!", Player1.sName)
            Player1.dScore += 1
        ElseIf (Player1.sGesture = "paper" And Player2.sGesture <> "paper" And Player2.sGesture <> "lizard" And Player2.sGesture <> "scissors") Then
            Console.WriteLine("{0} wins this round!", Player1.sName)
            Player1.dScore += 1
        ElseIf (Player1.sGesture = "scissors" And Player2.sGesture <> "scissors" And Player2.sGesture <> "rock" And Player2.sGesture <> "spock") Then
            Console.WriteLine("{0} wins this round!", Player1.sName)
            Player1.dScore += 1
        ElseIf (Player1.sGesture = "lizard" And Player2.sGesture <> "lizard" And Player2.sGesture <> "scissors" And Player2.sGesture <> "rock") Then
            Console.WriteLine("{0} wins this round!", Player1.sName)
            Player1.dScore += 1
        ElseIf (Player1.sGesture = "spock" And Player2.sGesture <> "spock" And Player2.sGesture <> "lizard" And Player2.sGesture <> "paper") Then
            Console.WriteLine("{0} wins this round!", Player1.sName)
            Player1.dScore += 1
        ElseIf (Player1.sGesture = Player2.sGesture) Then
            Console.WriteLine("This round is a draw. Play again")
        Else Console.WriteLine("{0} wins this round!", Player2.sName)
            Player2.dScore += 1
        End If
    End Sub

    Sub DisplayWinner()
        If (Player1.dScore > Player2.dScore) Then
            Console.WriteLine("{0} is the winner of this game!", Player1.sName)
            Console.ReadLine()
        Else Console.WriteLine("{0} is the winner of this game!", Player2.sName)
            Console.ReadLine()
        End If
    End Sub

    Sub RunGame()
        DisplayInstructions()
        DetermineNumberOfPlayers()
        CreatePlayers()
        Player1.ChooseName()
        Player2.ChooseName()
        DisplayPlayersNames()
        While (Player1.dScore < 2 And Player2.dScore < 2)
            Player1.DetermineGesture()
            Player2.DetermineGesture()
            CompareGestures()
        End While
        DisplayWinner()


    End Sub

End Class
