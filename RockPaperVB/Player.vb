Public Class Player
    Public dScore As Double
    Public sName As String
    Public sGesture As String
    Public sGestures() As String


    Public Sub New()
        dScore = 0
        sGestures = {"Rock", "Paper", "Scissors", "Spock", "Lizard"}

    End Sub

    Overridable Sub DetermineGesture()

    End Sub

    Overridable Sub ChooseName()

    End Sub

End Class
