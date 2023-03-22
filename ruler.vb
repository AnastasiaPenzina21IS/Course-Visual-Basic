Imports System

Module ruler
    Sub Main(args As String())
        Dim ver As Integer, decimeter As Integer, centimetre As Integer, metre As Integer, extrametre As Integer, centimetre2 As Integer

        Console.WriteLine("record any number of centimeters")
        ver = Console.ReadLine()

        metre = ver \ 100
        extrametre = metre * 100
        centimetre = ver Mod 100
        decimeter = centimetre \ 10
        centimetre2 = centimetre Mod 10

        Console.WriteLine("Metre = {0}", metre)
        Console.WriteLine("decimeter = {0}", decimeter)
        Console.WriteLine("centimetre = {0}", centimetre2)

    End Sub
End Module