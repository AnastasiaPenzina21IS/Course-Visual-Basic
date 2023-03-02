Imports System

Module zachet
    Private brush As Char = "0"c
    Dim num01 As Byte
    Dim x As Integer, y As Integer, x1 As Integer, y1 As Integer
    Sub Main(args As String())

        Console.WriteLine("1 - гор. линия, 2 - верт. линия, 3 - прямоугольник, 4 - пуст.прямоугольник, 5 - сетка, 6-орнамент,7-линии,8-цветной орнамент")
        num01 = Console.ReadLine


        Select Case num01
            Case 1

                horizon(5, 5, 15)

            Case 2

                vertically(5, 5, 15)

            Case 3

                closcube(5, 5, 50, 40)

            Case 4

                empcube(10, 10, 20, 30)

            Case 5

                grid()

            Case 6

                ornament()

            Case 7

                lines()

            Case 8

                colorOrnament()

        End Select
    End Sub

    Sub horizon(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)

        For i = 1 To length
            Console.Write(brush)
        Next

    End Sub
    Sub vertically(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)

        For i = 1 To length
            Console.Write(brush)
            Console.SetCursorPosition(leftx, topy + i)
        Next

    End Sub
    Sub closcube(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)

        For j = 1 To 10
            horizon(5, 5 + j, 20)
        Next

    End Sub
    Sub empcube(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)

        horizon(10, 25, 40)
        vertically(10, 5, 2)
        horizon(10, 5, 40)
        vertically(50, 5, 21)

    End Sub
    Sub grid()

        For i = 1 To 8
            horizon(2 + 10, 2 + i * 5, 70)
            vertically(2 + 10 * i, 2 + 5, 36)
        Next

    End Sub

    Sub ornament()

        For j = 1 To 5
            For i = 1 To 5
                closcube(7 + 10 * i, 5 + j * 10, 7, 7)
            Next
        Next

    End Sub

    Sub lines()

        For i = 1 To 6
            horizon(10, 5 * i, 40)
        Next

    End Sub

    Sub colorOrnament()
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.White

        For j = 1 To 5
            For i = 1 To 5
                closcube(7 + 10 * i, 5 + j * 10, 7, 7)
            Next
        Next

    End Sub

End Module

