Module Module1

    'Tamba M. Sandy | ID: 25887 | BSc Computer Science | Final Year | Date: 4rd Match, 2019 @ about  20:17

    'NOTE!!....PLEASE THIS PROOGRAM IS LITTLE MORE ADVANCE THAN THE NOTE REQUIRES

    Sub Main()
        Dim nationalAnthem, choice, one_or_three_Stanza As Integer        'Variable decleration and data type assignment
        Dim proceed As String

        Console.ForegroundColor = ConsoleColor.Green                    'iniciating green color for the header   ---start here
        Console.WriteLine("  ")                                          'whitespace top / padding top
        Console.WriteLine("                          THE SIERRA LEONE NATIONAL ANTHEMS  AND PLEDGE")    'Heading print out
        Console.ResetColor()                                             'color end here and does not continues to the next lines

        Console.WriteLine("                          .............................................")        'underling the heading
        Console.WriteLine(" Welcome user, as a citizen of Sierra Leone; it is a MOST for you to konw your National Anthems and Pledge.") ' statement 1

        Console.WriteLine(" Please Kindly choose from the list of our available options below: ")       ' statement 2
        Console.WriteLine("  ")
        Console.WriteLine(" Enter 1 for National Anthem and 2 for National Pledge as follows")  'statement 3 / options call
        Console.WriteLine("    1. National Anthem")
        Console.WriteLine("    2. National Pledge")
        Console.WriteLine("  ")

        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(" Enter Choice Here: ")
        Console.ResetColor()
        choice = Console.ReadLine()

        Select Case choice                          'check selected choice...a kind of switch case statement

            Case 1                                      'The National Anthem
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("  ")
                Console.WriteLine("    THE SIERRA LEONE NATIONAL ANTHEMS")
                Console.ResetColor()
                Console.WriteLine("    ")
                Console.WriteLine("    There are three (3) stanzas in Sierra National Anthem, please choose your choice of stanza as shown below ") 'option call
                Console.WriteLine("    ")
                Console.WriteLine("    1. First Stanza")
                Console.WriteLine("    2. Second Stanza")
                Console.WriteLine("    3. Third Stanza")
                Console.WriteLine("   ")
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(" Enter Stanza No. Here: ")
                Console.ResetColor()
                nationalAnthem = Console.ReadLine()

                Select Case nationalAnthem
                    Case 1                                      'Firet stanza of the national anthem

                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("  ")
                        Console.WriteLine("  ")
                        Console.WriteLine("     THE FIRST STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                        Console.ResetColor()
                        Console.WriteLine("     .................................................")
                        Console.WriteLine("  ")

                        Console.WriteLine("    High we exalt thee, realm of the free;")
                        Console.WriteLine("    Great is the love we have for thee;")
                        Console.WriteLine("    Firmly united ever we stand,")
                        Console.WriteLine("    Singing thy praise, O native land.")
                        Console.WriteLine("    We raise up our hearts and our voices on high,")
                        Console.WriteLine("    The hills and the valleys re-echo our cry;")
                        Console.WriteLine("    Blessing and peace be ever thine own,")
                        Console.WriteLine("    Land that we love, our Sierra Leone.")

                        Console.WriteLine("  ")
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.Write("    Do you want to proceed to the subsequent stanza? Enter Y for YES and E to Exit  application. Enter Here! ")
                        Console.ResetColor()
                        proceed = Console.ReadLine()

                        If (proceed = "y") Then

                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("  ")
                            Console.WriteLine("  ")
                            Console.WriteLine("     SECOND STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                            Console.ResetColor()

                            Console.WriteLine("    ..............................................")
                            Console.WriteLine("  ")
                            Console.WriteLine("    One with a faith that wisdom inspires,")
                            Console.WriteLine("    One with a zeal that never tires;")
                            Console.WriteLine("    Ever we seek to honour thy name,")
                            Console.WriteLine("    Ours is the labour, thine the fame.")
                            Console.WriteLine("    We pray that no harm on thy children may fall,")
                            Console.WriteLine("    That blessing and peace may descend on us all;")
                            Console.WriteLine("    So may we serve thee ever alone,")
                            Console.WriteLine("    Land that we love our Sierra Leone.")

                            Console.WriteLine("  ")
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.Write("    proceed to the Last stanza? Enter Y for YES and N for NO. Enter Here! ")
                            Console.ResetColor()

                            proceed = Console.ReadLine()

                            If (proceed = "y") Then

                                Console.ForegroundColor = ConsoleColor.Green
                                Console.WriteLine("  ")
                                Console.WriteLine("  ")
                                Console.WriteLine("     THIRD STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                                Console.ResetColor()
                                Console.WriteLine("     .............................................")
                                Console.WriteLine("  ")
                                Console.WriteLine("    Knowledge and truth our forefathers spread,")
                                Console.WriteLine("    Mighty the nations whom they led;")
                                Console.WriteLine("    Mighty they made thee, so too may we")
                                Console.WriteLine("    Show forth the good that is ever in thee.")
                                Console.WriteLine("    We pledge our devotion, our strength and our might,")
                                Console.WriteLine("    Thy cause to defend and to stand for thy right;")
                                Console.WriteLine("    All that we have be ever thine own,")
                                Console.WriteLine("    Land that we love, our Sierra Leone.")

                                Console.WriteLine(" ")

                                Console.Write("     Thanks for going through this interactive learning process, press any key to EXIT application: ")
                                Console.WriteLine(" ")
                                Console.ForegroundColor = ConsoleColor.Green
                                Console.WriteLine(" ")
                                Console.WriteLine("     The National Pledge can also be reach from this point.")
                                Console.ResetColor()
                                Console.WriteLine(" ")

                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write("     Enter Y to continue with the national pledge and enter any key to Exit the program : ")
                                Console.ResetColor()
                                proceed = Console.ReadLine()

                                If (proceed = "y") Then


                                    Console.ForegroundColor = ConsoleColor.Green
                                    Console.WriteLine("  ")
                                    Console.WriteLine("  ")
                                    Console.WriteLine("     THE NATIONAL PLEDGE ")
                                    Console.ResetColor()
                                    Console.WriteLine("     ....................")
                                    Console.WriteLine("  ")
                                    Console.WriteLine("    I pledge my love and loyalty to my country Sierra Leone;")
                                    Console.WriteLine("    I vow to serve her faithfully at all times;")
                                    Console.WriteLine("    I promise to defend her honour and good name;")
                                    Console.WriteLine("    Always work for her unity peace, freedom and prosperity;")
                                    Console.WriteLine("    And put her interest above all else.")
                                    Console.WriteLine("    So help me God.")
                                    Console.WriteLine("    ........................................................... ")
                                    Console.WriteLine("  ")
                                    Console.WriteLine("     Thanks for going through this mini console application, I highly appreciated your time and patience you exercised. ")
                                    Console.WriteLine("     Feel free to hook me up on facebook https://www.facebook.com/tamba.msandy , skype https://www.skype.com/t-sandy2")
                                    Console.WriteLine("     Email on sandy12444@gmail.com  or contact +232-76-849211 / +232-88-690177 / +232-31-005303.")


                                Else
                                    Console.Write("Thanks for going through this interactive learning process, press any key to EXIT application: ")
                                End If

                            Else
                                Console.Write("Thanks for going through this interactive learning process, press any key to EXIT application: ")
                            End If

                        Else
                            Console.Write("Thanks for going through this interactive learning process, press any key to EXIT application: ")
                        End If
                        Console.ReadKey()


                    Case 2                                      'Second stanza of the national anthem

                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("  ")
                        Console.WriteLine("  ")
                        Console.WriteLine("     SECOND STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                        Console.ResetColor()
                        Console.WriteLine("     ..............................................")
                        Console.WriteLine("  ")
                        Console.WriteLine("    One with a faith that wisdom inspires,")
                        Console.WriteLine("    One with a zeal that never tires;")
                        Console.WriteLine("    Ever we seek to honour thy name,")
                        Console.WriteLine("    Ours is the labour, thine the fame.")
                        Console.WriteLine("    We pray that no harm on thy children may fall,")
                        Console.WriteLine("    That blessing and peace may descend on us all;")
                        Console.WriteLine("    So may we serve thee ever alone,")
                        Console.WriteLine("    Land that we love our Sierra Leone.")

                        Console.WriteLine("  ")
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("     Please Choose your Next Stanza to Read Below.")
                        Console.ResetColor()
                        Console.WriteLine("      Enter 1: for Second Stanza")
                        Console.WriteLine("            3: for Third Stanza.")
                        Console.WriteLine(" ")
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.Write(" Enter Here! ")
                        Console.ResetColor()
                        one_or_three_Stanza = Console.ReadLine

                        If one_or_three_Stanza = 1 Then

                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("  ")
                            Console.WriteLine("  ")
                            Console.WriteLine("     THE FIRST STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                            Console.ResetColor()
                            Console.WriteLine("     .................................................")
                            Console.WriteLine("  ")

                            Console.WriteLine("    High we exalt thee, realm of the free;")
                            Console.WriteLine("    Great is the love we have for thee;")
                            Console.WriteLine("    Firmly united ever we stand,")
                            Console.WriteLine("    Singing thy praise, O native land.")
                            Console.WriteLine("    We raise up our hearts and our voices on high,")
                            Console.WriteLine("    The hills and the valleys re-echo our cry;")
                            Console.WriteLine("    Blessing and peace be ever thine own,")
                            Console.WriteLine("    Land that we love, our Sierra Leone.")

                            Console.WriteLine("  ")
                            Console.Write("     Thanks for going through this interactive learning process, press any key to EXIT application: ")


                        ElseIf one_or_three_Stanza = 3 Then

                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("  ")
                            Console.WriteLine("  ")

                            Console.WriteLine("     THIRD STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                            Console.ResetColor()

                            Console.WriteLine("    .............................................")
                            Console.WriteLine("  ")
                            Console.WriteLine("    Knowledge and truth our forefathers spread,")
                            Console.WriteLine("    Mighty the nations whom they led;")
                            Console.WriteLine("    Mighty they made thee, so too may we")
                            Console.WriteLine("    Show forth the good that is ever in thee.")
                            Console.WriteLine("    We pledge our devotion, our strength and our might,")
                            Console.WriteLine("    Thy cause to defend and to stand for thy right;")
                            Console.WriteLine("    All that we have be ever thine own,")
                            Console.WriteLine("    Land that we love, our Sierra Leone.")

                            Console.WriteLine(" ")

                            Console.ForegroundColor = ConsoleColor.Red
                            Console.Write("     Thanks for going through this interactive learning process, press any key to EXIT application: ")
                            Console.ResetColor()
                            Console.WriteLine(" ")
                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("     The National Pledge can also be reach from this point.")
                            Console.ResetColor()

                            Console.ForegroundColor = ConsoleColor.Red
                            Console.Write("     Enter Y to continue with the national pledge and enter any key to Exit the program : ")
                            Console.ResetColor()
                            proceed = Console.ReadLine()

                            If (proceed = "y") Then

                                Console.ForegroundColor = ConsoleColor.Green
                                Console.WriteLine("  ")
                                Console.WriteLine("  ")
                                Console.WriteLine("     THE NATIONAL PLEDGE ")
                                Console.ResetColor()
                                Console.WriteLine("     ....................")
                                Console.WriteLine("  ")
                                Console.WriteLine("    I pledge my love and loyalty to my country Sierra Leone;")
                                Console.WriteLine("    I vow to serve her faithfully at all times;")
                                Console.WriteLine("    I promise to defend her honour and good name;")
                                Console.WriteLine("    Always work for her unity peace, freedom and prosperity;")
                                Console.WriteLine("    And put her interest above all else.")
                                Console.WriteLine("    So help me God.")
                                Console.WriteLine("    ........................................................... ")
                                Console.WriteLine("      ")
                                Console.WriteLine("     Thanks for going through this mini console application, I highly appreciated your time and patience you exercised. ")
                                Console.WriteLine("     Feel free to hook me up on facebook https://www.facebook.com/tamba.msandy , skype https://www.skype.com/t-sandy2")
                                Console.WriteLine("     Email on sandy12444@gmail.com  or contact +232-76-849211 / +232-88-690177 / +232-31-005303.")

                            End If
                        End If

                        Console.ReadKey()




                    Case 3                                      'third stanza of the national anthem
                        Console.WriteLine("  ")
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("     THIRD STANZA OF SIERRA LEONE NATIONAL ANTHEM ")
                        Console.ResetColor()

                        Console.WriteLine("     .............................................")
                        Console.WriteLine("  ")
                        Console.WriteLine("    Knowledge and truth our forefathers spread,")
                        Console.WriteLine("    Mighty the nations whom they led;")
                        Console.WriteLine("    Mighty they made thee, so too may we")
                        Console.WriteLine("    Show forth the good that is ever in thee.")
                        Console.WriteLine("    We pledge our devotion, our strength and our might,")
                        Console.WriteLine("    Thy cause to defend and to stand for thy right;")
                        Console.WriteLine("    All that we have be ever thine own,")
                        Console.WriteLine("    Land that we love, our Sierra Leone.")

                        Console.WriteLine(" ")

                        Console.Write("     Thanks for going through this interactive learning process, press any key to EXIT application: ")
                        Console.WriteLine(" ")
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("     The National Pledge can also be reach from this point.")
                        Console.ResetColor()
                        Console.Write("     Enter Y to continue with the national pledge and enter any key to Exit the program : ")

                        proceed = Console.ReadLine()

                        If (proceed = "y") Then

                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("     THE NATIONAL PLEDGE ")
                            Console.ResetColor()
                            Console.WriteLine("     ....................")
                            Console.WriteLine("  ")
                            Console.WriteLine("    I pledge my love and loyalty to my country Sierra Leone;")
                            Console.WriteLine("    I vow to serve her faithfully at all times;")
                            Console.WriteLine("    I promise to defend her honour and good name;")
                            Console.WriteLine("    Always work for her unity peace, freedom and prosperity;")
                            Console.WriteLine("    And put her interest above all else.")
                            Console.WriteLine("    So help me God.")
                            Console.WriteLine("    ........................................................... ")
                            Console.WriteLine("  ")
                            Console.Write("     Thanks for going through this mini console application, I highly appreciated your time and patience you exercised. ")
                            Console.Write("     Feel free to hook me up on facebook https://www.facebook.com/tamba.msandy , skype https://www.skype.com/t-sandy2")
                            Console.Write("     Email on sandy12444@gmail.com  or contact +232-76-849211 / +232-88-690177 / +232-31-005303.")


                        Else
                            Console.Write("     Thanks for going through this interactive learning process, press any key to EXIT application: ")
                        End If

                        Console.ReadKey()
                        Exit Select                             'Use to exit the national anthem select statement
                End Select


            Case 2
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("  ")
                Console.WriteLine("     THE NATIONAL PLEDGE ")
                Console.ResetColor()
                Console.WriteLine("     ....................")
                Console.WriteLine("  ")
                Console.WriteLine("    I pledge my love and loyalty to my country Sierra Leone;")
                Console.WriteLine("    I vow to serve her faithfully at all times;")
                Console.WriteLine("    I promise to defend her honour and good name;")
                Console.WriteLine("    Always work for her unity peace, freedom and prosperity;")
                Console.WriteLine("    And put her interest above all else.")
                Console.WriteLine("    So help me God.")
                Console.WriteLine("    ........................................................... ")
                Console.WriteLine("  ")

                Console.Write("     Thanks for going through this mini console application, I highly appreciated your time and patience you exercise. ")
                Console.WriteLine("  ")
                Console.ForegroundColor = ConsoleColor.DarkGreen
                Console.WriteLine("                                     CONTACT INFO: ")
                Console.ResetColor()
                Console.WriteLine("     .................................................................................................................")

                Console.WriteLine("     Feel free to hook me up on facebook https://www.facebook.com/tamba.msandy , skype https://www.skype.com/t-sandy2")
                Console.WriteLine("     Email on sandy12444@gmail.com  or contact +232-76-849211 / +232-88-690177 / +232-31-005303.")
                Console.WriteLine("     .................................................................................................................")
                Console.WriteLine(" ")
                Console.Write("     Exit Application; press any key to exit: ")



                Console.ReadKey()
                Exit Select

        End Select

    End Sub

End Module
