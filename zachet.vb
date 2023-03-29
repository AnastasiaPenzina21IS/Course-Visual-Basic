Imports System

Module zachet
    Private brush As Char = "0"c
    Dim num01 As Byte
    Dim x As Integer, y As Integer, x1 As Integer, y1 As Integer
    Sub Main(args As String())

        Console.WriteLine("1 - ���. �����, 2 - ����. �����, 3 - �������������, 4 - ����.�������������, 5 - �����, 6-��������,7-�����,8-������� �������� 9-�������")
        num01 = Console.ReadLine


        Select Case num01
            Case 1

                horizon(5, 5, 15)

            Case 2

                vertically(5, 5, 15)

            Case 3

                Closcube(10, 5, 70, 35)

            Case 4

                Empcube()

            Case 5

                grid()

            Case 6

                ornament()

            Case 7

                lines()

            Case 8

                colorOrnament()

            Case 9

                Chess()

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
    Sub Empcube()

        For j = 1 To 2

            horizon(10, 5 * j, 10)
            vertically(10 * j, 5, 6)

        Next
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
                Closcube(5 + 10 * i, 4 + j * 10, 6, 6)
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
                Closcube(5 + 10 * i, 4 + j * 10, 6, 6)
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

    Sub Chess()
        Console.ForegroundColor = ConsoleColor.White
        For j = 1 To 9
            For i = 1 To 8
                Console.ForegroundColor = ConsoleColor.White
                Closcube(8 * i, 1 + j * 6, 7, 8)
            Next
        Next
        For j = 1 To 8
            For i = 1 To 8
                If (i + j) Mod 2 = 1 Then
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Closcube(4 * i * 2, j * 7, 7, 7)
                End If
            Next
        Next
        ons()
    End Sub

End Module
