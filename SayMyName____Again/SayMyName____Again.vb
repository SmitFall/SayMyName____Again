'Fallon Smith
'RCET0265
'Spring 2022
'Say My Name....Again
'https://github.com/SmitFall/SayMyName____Again

Option Explicit On
Option Strict On
Option Compare Text
Module SayMyName____Again

    Sub Main()
        'set aside varibles
        Dim userResponse As String

        Console.WriteLine("Please Enter your name")
        userResponse = Console.ReadLine()

        If userResponse = "Emily" Then
            Console.WriteLine("Welcome back Emily!")
        ElseIf userResponse = "John" Then
            Console.WriteLine("Hi John! Good to see you back online. ")
        ElseIf userResponse = "Tim" Then
            Console.WriteLine("Hi Tim!")
        Else
            Console.WriteLine("Wait a second, Who are you?")
        End If
        Console.ReadLine()
    End Sub

End Module

