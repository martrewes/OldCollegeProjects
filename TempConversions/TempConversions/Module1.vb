Module Module1
    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Dim TempFormat As String
        Dim TempCelsius As Decimal
        Dim TempFarenheit As Decimal
        Console.WriteLine("Hello. Welcome To Console Temperatures.")
        Console.WriteLine("Please Enter the format you wish to convert to (Fahrenheit/f or Celsius/c)")
        TempFormat = Console.ReadLine()
        If TempFormat = "f" Then
            Console.WriteLine("Please enter the Temperature in Celsius")
            TempCelsius = Console.ReadLine()
            TempFarenheit = (Val(1.8 * TempCelsius) + 32).ToString
            Console.WriteLine(TempCelsius & " Degrees Celsius is Equal to " & TempFarenheit & " Degrees Farenheit!")
            Console.ReadLine()

        ElseIf TempFormat = "c" Then
            Console.WriteLine("Please enter the Temperature in Farenhiet")
            TempFarenheit = Console.ReadLine()
            TempCelsius = ((TempFarenheit - 32) / 1.8).ToString
            Console.WriteLine(TempFarenheit & " Degrees Farenheit is Equal to " & TempCelsius & " Degrees Celsius!")
            Console.ReadLine()
        End If
    End Sub

End Module
