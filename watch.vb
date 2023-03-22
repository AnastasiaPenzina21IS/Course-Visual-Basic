Imports System

Module watch
    Sub Main(args As String())

        Dim ver As Integer, min As Integer, second As Integer, min2 As Integer, hour As Integer, extramin As Integer, minutes As Integer

        Console.WriteLine("write any number of seconds")
        ver = Console.ReadLine()

        min = ver \ 60
        min2 = min * 60
        second = ver Mod 60
        hour = min \ 60
        extramin = hour * 60
        minutes = min Mod 60

        Console.WriteLine("second = {0}", second)
        Console.WriteLine("minutes = {0}", minutes)
        Console.WriteLine("hour = {0}", hour)

    End Sub
End Module
