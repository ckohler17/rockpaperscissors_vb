Public Class Computer : Inherits Player

    Public Overrides Sub DetermineGesture()
        MyBase.DetermineGesture()
        Dim MyValue As Integer
        MyValue = Int((6 * Rnd()) + 1)    ' Generate random value between 1 and 6.
    End Sub

    Public Overrides Sub ChooseName()
        MyBase.ChooseName()
        sName = "ralph"
    End Sub


End Class
