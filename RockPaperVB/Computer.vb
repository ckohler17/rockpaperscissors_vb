Public Class Computer : Inherits Player


    Public Overrides Sub DetermineGesture()
        Dim MyValue As Integer
        MyValue = Int((5 * Rnd()) + 1)    ' Generate random value between 1 and 5.
        sGesture = sGestures(MyValue).ToLower()
        Console.WriteLine(sGesture)

    End Sub

    Public Overrides Sub ChooseName()
        sName = "Ralph"
    End Sub


End Class
