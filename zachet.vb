Imports System

Module zachet
    Private brush As Char = "0"c
    Dim num01 As Byte
    Dim x As Integer, y As Integer, x1 As Integer, y1 As Integer
    Sub Main(args As String())

        Console.WriteLine("1 - гор. линия, 2 - верт. линия, 3 - прямоугольник, 4 - пуст.прямоугольник, 5 - сетка, 6-орнамент,7-линии,8-цветной орнамент, 9-шахматы ")
        num01 = Console.ReadLine


        Select Case num01
            Case 1

                horizon(5, 5, 15)

            Case 2

                vertically(5, 5, 15)

            Case 3

                Closcube(10, 5, 70, 35)

            Case 4

                Empcube(10, 10, 10, 10)

            Case 5

                grid(2, 2, 70)

            Case 6

                ornament(5, 4, 6, 6)

            Case 7

                lines(10, 5, 40)

            Case 8

                colorOrnament(5, 4, 6, 6)

            Case 9

                Chess(4, 7, 7, 7)

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
    Sub Closcube(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To heigh - 1

            horizon(leftX, topY + j, width)

        Next

    End Sub
    Sub Empcube(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)

        For j = 1 To 2

            horizon(leftX + width - 1, (topY + heigh - 1) * j, leftX + width - 1)
            vertically((leftX + width - 1) * j, (topY + heigh - 1), leftX + width - 1)

        Next
    End Sub
    Sub grid(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 8
            horizon(leftX + 10, topY + i * 5, length)
            vertically(leftX + 10 * i, topY + 5, length - 34)
        Next

    End Sub

    Sub ornament(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        For j = 1 To 5
            For i = 1 To 5
                Closcube(leftX + 10 * i, topY + j * 10, width, heigh)
            Next
        Next
    End Sub

    Sub lines(leftX As Byte, topY As Byte, width As Byte)

        For i = 1 To 6
            horizon(leftX, topY * i, width)
        Next

    End Sub

    Sub colorOrnament(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.White

        For j = 1 To 5
            For i = 1 To 5
                Closcube(leftX + 10 * i, topY + j * 10, width, heigh)
            Next
        Next

    End Sub
    Sub www(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        For j = 1 To 8
            For i = 1 To 8
                Closcube(leftX * i * 2, j * topY, width, heigh)
            Next
        Next
    End Sub
    Sub ons()
        Console.ForegroundColor = ConsoleColor.Cyan
        horizon(7, 63, 65)
        vertically(7, 6, 58)
        horizon(7, 6, 65)
        vertically(71, 6, 58)
    End Sub

    Sub Chess(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.ForegroundColor = ConsoleColor.White

        www(4, 7, 7, 7)
        For j = 1 To 8
            For i = 1 To 8
                If (i + j) Mod 2 = 1 Then
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Closcube(leftX * i * 2, j * topY, width, heigh)
                End If
            Next
        Next
        ons()
    End Sub

End Module
