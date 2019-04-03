Module Module1

    Sub Main()

        'Tamba M. Sandy | ID: 25887 | BSc Computer Science | Final Year | Date: 7th February, 2019 @ 11:49 AM

        Dim artDepartment, englishDepartment, musicDepartment, sum, averageTemp As Double

        Console.WriteLine(" ")

        Console.ForegroundColor = ConsoleColor.Green    'apply green color for the heading
        Console.WriteLine("                               THE SCHOOL CENTER HEATING SYSTEM")    'heading
        Console.ResetColor() 'reset the color to default
        Console.WriteLine("                               ................................")    'heading underline
        Console.WriteLine(" ")      'applied space between previous and subsequent line of output / paragraph spacing 

        Console.WriteLine("     Enter temperature reading for the following departments to determine wether to Turn off the temperature or Not")
        Console.WriteLine(" ")

        'PROMPTING AND ACCEPTING USER INPUT

        Console.Write("     Art Department: ")
        artDepartment = Console.ReadLine()      'accepting user input for variable name artDepartment

        Console.WriteLine(" ")
        Console.Write("     English Department: ")
        englishDepartment = Console.ReadLine()

        Console.WriteLine(" ")
        Console.Write("     Music Department: ")
        musicDepartment = Console.ReadLine()

        Console.WriteLine(" ")

        'COMPUTATION
        sum = artDepartment + englishDepartment + musicDepartment

        averageTemp = sum / 3
        averageTemp = Math.Round(artDepartment)



        'RESULT DISPLAY

        Console.WriteLine("     The Sum for the three reading is : " & sum & " degree" & " Celcious")
        Console.WriteLine(" ")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("     The Average is : " & averageTemp & " degree" & " Celcious")
        Console.ResetColor()
        Console.WriteLine(" ")

        If averageTemp <= 16 Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("        We are GOOD for Operation.")
            Console.ResetColor()
            Console.Write("        Press any key to end the program")



        ElseIf averageTemp = 17 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("        WARNING!!")
            Console.ResetColor()
            Console.WriteLine("        .....Average temperature reading should not exceed 17 degree celcious.")
            Console.WriteLine("        Press any key to end the program")

        ElseIf averageTemp > 17 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("      SYSTEM OFF !.......SYSTEM OFF !!.......SYSTEM OFF !!!")
            Console.ResetColor()
            Console.WriteLine("        Press any key to end the program")
        End If
        Console.ReadKey()
    End Sub

End Module
