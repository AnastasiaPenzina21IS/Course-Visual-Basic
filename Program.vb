Imports System

Module 
    Sub Main(args As String())
        'TODO: ���������� �����

        Dim numberAs String = "1234"

        Console.WriteLine("������ �����")
        Dim ver As String

        Do
            ver = Console.ReadLine()

            For i As Integer = 0 To 3
                If ver.Chars(0) = number.Chars(i) Then
                    If i = 0 Then
                        Console.WriteLine("������ ����� ����� ������ - ���")
                    Else
                        Console.WriteLine("������ ����� ����� ������ - ������")
                    End If
                End If
            Next

            If number = ver Then
                Console.WriteLine("������!")
            Else
                Console.WriteLine("������")
            End If

        Loop Until number = ver

    End Sub
End Module