Option Explicit On
Option Strict On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Roll Of The Dice
'https://github.com/AftaAnfi/Roll-Of-The-Dice.git
Module RollOfTheDice
    Dim randomNumberCounterArray(10) As Integer

    Sub Main()

        'initialize randomize function to get random numbers
        Randomize(DateTime.Now.Millisecond)

        'add a count for a number 0 - 10 (0 - 10 represent 2 - 12) 1000 times
        For j = 1 To 1000
            randomNumberCounterArray(CInt(Math.Floor(Rnd() * 6)) + CInt(Math.Floor(Rnd() * 6))) += 1
        Next

        'formatting to display the results
        Console.WriteLine("Roll of the Dice".PadLeft(CInt(Console.WindowWidth / 2)))
        Console.WriteLine("------------------------------------------------------------------")

        For i = 0 To 10
            'i + 2 due to dice roll starting at 2, and format
            Console.Write($"{(i + 2).ToString.PadLeft(5)}|")
        Next

        Console.WriteLine($"{vbNewLine}------------------------------------------------------------------")

        For i = 0 To 10
            'randomNumberArray to be formatted and add space between each loop
            Console.Write(randomNumberCounterArray(i).ToString().PadLeft(5) & "|")
        Next

        'pause console so user can see results
        Console.ReadLine()

    End Sub

End Module