Module Module1

    Sub Main()
        ' ~~Declarations~~ 
        Dim StrUserName As String
        Dim StrInput1, StrInput2 As String
        Dim Number1, Number2 As Double
        Dim Answer As String
        Dim Today As DateTime
        Dim Operation As String
        Dim AnotherCalculation As String



        Today = DateTime.Now()

        Console.WriteLine(Today.ToString())
        Console.WriteLine("The time is " & Today.ToShortTimeString())
        Console.WriteLine("The date is " & Today.ToLongDateString())
        Console.WriteLine("Tomorrow is " & Today.AddDays(1). _
                    ToShortDateString())

        'Ask for User's Name
        Console.WriteLine("Oh, Sorry. Hello there, What is your name?")
        'Assign the String which User Enters as "StrUserName"
        StrUserName = Console.ReadLine()

        'Place Name in Message to User
        Console.WriteLine("Hello, " & StrUserName & ". Hope you are Well Today")
        Do
            Console.WriteLine("Do you want to Add, Subtract, Multiply, Divide or Sum?")
            Operation = Console.ReadLine().ToString
            If Operation = "sum" Then
                Console.WriteLine("Please enter a comma separated string of numbers.")
                StrInput1 = Console.ReadLine()
                Answer = Sum(StrInput1).ToString()
            Else
                'Ask for Number 1
                Console.WriteLine("Please enter a Whole Number")
                'Assign Entered Value to "StrInput1"
                StrInput1 = Console.ReadLine()

                'Ask for Number 2
                Console.WriteLine("Please enter another Whole Number")
                'Assign Entered Value to "StrInput2"
                StrInput2 = Console.ReadLine()

                If IsNumeric(StrInput1) Then
                    Number1 = Double.Parse(StrInput1)
                Else
                    Number1 = 0
                End If
                If IsNumeric(StrInput2) Then
                    Number2 = Double.Parse(StrInput2)
                Else
                    Number2 = 0
                End If
                Answer = DoMath(Number1, Number2, Operation).ToString()
            End If
            'Show Answer to Function
            Console.WriteLine(Answer & " is the answer.")
            Console.WriteLine("Do you want another calculation? (Y or N)")
            AnotherCalculation = Console.ReadLine().Substring(0, 1).ToUpper()

        Loop Until (AnotherCalculation = "N")
    End Sub
    Function DoMath(ByVal X As Double, ByVal Y As Double, ByVal Operation As String) As Double
        If Operation = "add" Then
            Return (X + Y).ToString()
        ElseIf Operation = "subtract" Then
            Return (X - Y).ToString()
        ElseIf Operation = "multiply" Then
            Return (X * Y).ToString()
        ElseIf Operation = "divide" Then
            If Y <> 0 Then
                Return (X / Y).ToString()
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Function Sum(ByVal Numbers As String) As Double
        Dim NumbersArray() As String
        Dim Answer As Double 
        NumbersArray = Numbers.Split(",")
        For i As Integer = 0 To NumbersArray.GetUpperBound(0)

            Answer += Double.Parse(NumbersArray(i))

        Next
        Return Answer
    End Function


End Module
