Public Class Human : Inherits Player

    Public Overrides Sub DetermineGesture()
        Console.WriteLine("Please enter one of the following: 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'")
        sGesture = Console.ReadLine().ToLower()
        If (sGesture <> "rock" And sGesture <> "paper" And sGesture <> "scissors" And sGesture <> "lizard" And sGesture <> "spock") Then
            Console.WriteLine("I do not recognize your selection please choose again either 'Rock, 'Paper', 'Scissors', 'Lizard', 'Spock'")
            DetermineGesture()
        End If

    End Sub

    Public Overrides Sub ChooseName()
        Console.WriteLine("What is your name?")
        sName = Console.ReadLine()
    End Sub

End Class
