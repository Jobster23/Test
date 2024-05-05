using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class ThreeOrMore
    {
        public static void Three_Or_more()
        {
            Console.WriteLine("Three or more");
            Console.WriteLine("  _______ _                                  __  __                ");
            Console.WriteLine(" |__   __| |                                |  \\/  |               ");
            Console.WriteLine("    | |  | |__  _ __ ___  ___    ___  _ __  | \\  / | ___  _ __ ___ ");
            Console.WriteLine("    | |  |  _ \\|  __/ _ \\/ _ \\  / _ \\|  __| | |\\/| |/ _ \\|  __/ _ \\,");
            Console.WriteLine("    | |  | | | | | |  __/  __/ | (_) | |    | |  | | (_) | | |  __/");
            Console.WriteLine("    |_|  |_| |_|_|  \\___|\\___|  \\___/|_|    |_|  |_|\\___/|_|  \\___|");

            Console.WriteLine("\nWelcome to Three or More. The aim of the game is to roll 5 dice and hope for a 3-of-a-kind or better. If a 2-of-a-kind is rolled, you have the chance to roll the remaining dice or to re-roll all three die. The points are as follows:");
            Console.WriteLine("\n- 3 of a kind: 3 points" + "\n- 4 of a kind: 6 points" + "\n- 5 of a kind: 12 points" + "\n- First to a total of 20.");

            Console.WriteLine("\nSelect one or two: ");
            Console.WriteLine("1 - 1 Player");
            Console.WriteLine("2 - 2 Player");

            int player = Convert.ToInt32(Console.ReadLine());

            switch (player)
            {
                case 1:
                    Console.WriteLine("1 player");
                    Testing.One_Player();
                    break;

                case 2:
                    Console.WriteLine("2 player");
                    Testing.Two_Player();
                    break;
            }


        }

        public static int One_Player()
        {

            Console.WriteLine("Enter Player name: ");
            string Player_ID = Console.ReadLine();

            int score = 0; // THIS IS THE SCORE
            int steps = 0;


            while (true)
            {
                if (score >= 20)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine(steps);
                    break;
                }

                int Die_1 = Die.Roll();
                int Die_2 = Die.Roll();
                int Die_3 = Die.Roll();
                int Die_4 = Die.Roll();
                int Die_5 = Die.Roll();


                Console.WriteLine("First Dice: " + Die_1);
                Console.WriteLine("Second Dice: " + Die_2);
                Console.WriteLine("Third Dice: " + Die_3);
                Console.WriteLine("Forth Dice: " + Die_4);
                Console.WriteLine("Fifth Dice: " + Die_5);

                // 5 or more



                if ((Die_1 == Die_2) && (Die_2 == Die_3) && (Die_3 == Die_4) && (Die_4 == Die_5))
                {
                    int FiveKind = 12;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("5 of a kind");
                    Console.ResetColor();
                    if (score >= 20)
                    {
                        int temp = score + FiveKind; // Gives score
                        Console.WriteLine(Player_ID + "'s score: " + temp);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }

                // 4 or more

                else if ((Die_1 == Die_2) && (Die_3 == Die_4) || (Die_1 == Die_2) && (Die_3 == Die_5) || (Die_2 == Die_3) && (Die_4 == Die_5) || (Die_3 == Die_4) && (Die_5 == Die_1) || (Die_4 == Die_5) && (Die_1 == Die_2))
                {
                    int FourKind = 6;
                    Console.WriteLine("\n4 of a kind");

                    if (20 >= score)
                    {
                        score = score + FourKind;
                        Console.WriteLine(Player_ID + "'s Score is: " + score);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }
                // 3 or more

                else if ((Die_1 == Die_2) && (Die_2 == Die_3) || (Die_1 == Die_2) && (Die_2 == Die_4) || (Die_1 == Die_2) && (Die_2 == Die_5) || (Die_1 == Die_4) && (Die_3 == Die_4) || (Die_1 == Die_5) && (Die_5 == Die_3) || (Die_2 == Die_3) && (Die_3 == Die_4) || (Die_2 == Die_3) && (Die_3 == Die_5) || (Die_2 == Die_4) && (Die_4 == Die_5))
                {
                    int ThreeKind = 3;
                    Console.WriteLine("\n3 of kind");

                    if (20 >= score)
                    {
                        score = score + ThreeKind;
                        Console.WriteLine(Player_ID + "'s Score is: " + score);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }


                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2 of a kind, try again!");
                    Console.ResetColor();
                    Console.WriteLine(Player_ID + "'s score: " + score);


                    if (score >= 20)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }

            }
            int score_1 = 0; // THIS IS THE SCORE
            int steps_1 = 0;
            Console.WriteLine("Press any key to play");
            Console.ReadLine();

            while (true)
            {
                if (score_1 >= 20)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine(steps_1);
                    break;
                }

                int Die_1 = Die.Roll();
                int Die_2 = Die.Roll();
                int Die_3 = Die.Roll();
                int Die_4 = Die.Roll();
                int Die_5 = Die.Roll();


                Console.WriteLine("First Dice: " + Die_1);
                Console.WriteLine("Second Dice: " + Die_2);
                Console.WriteLine("Third Dice: " + Die_3);
                Console.WriteLine("Forth Dice: " + Die_4);
                Console.WriteLine("Fifth Dice: " + Die_5);

                // 5 or more



                if ((Die_1 == Die_2) && (Die_2 == Die_3) && (Die_3 == Die_4) && (Die_4 == Die_5))
                {
                    int FiveKind = 12;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("5 of a kind");
                    Console.ResetColor();
                    if (score_1 >= 20)
                    {
                        int temp = score_1 + FiveKind; // Gives score
                        Console.WriteLine("\nComputer score: " + temp);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }

                // 4 or more

                else if ((Die_1 == Die_2) && (Die_3 == Die_4) || (Die_1 == Die_2) && (Die_3 == Die_5) || (Die_2 == Die_3) && (Die_4 == Die_5) || (Die_3 == Die_4) && (Die_5 == Die_1) || (Die_4 == Die_5) && (Die_1 == Die_2))
                {
                    int FourKind = 6;
                    Console.WriteLine("\n4 of a kind");

                    if (20 >= score_1)
                    {
                        score_1 = score_1 + FourKind;
                        Console.WriteLine("\nComputer score is: " + score_1);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }
                // 3 or more

                else if ((Die_1 == Die_2) && (Die_2 == Die_3) || (Die_1 == Die_2) && (Die_2 == Die_4) || (Die_1 == Die_2) && (Die_2 == Die_5) || (Die_1 == Die_4) && (Die_3 == Die_4) || (Die_1 == Die_5) && (Die_5 == Die_3) || (Die_2 == Die_3) && (Die_3 == Die_4) || (Die_2 == Die_3) && (Die_3 == Die_5) || (Die_2 == Die_4) && (Die_4 == Die_5))
                {
                    int ThreeKind = 3;
                    Console.WriteLine("\n3 of kind");

                    if (20 >= score_1)
                    {
                        score_1 = score_1 + ThreeKind;
                        Console.WriteLine("\nComputer score is: " + score_1);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }


                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2 of a kind, try again!");
                    Console.ResetColor();
                    Console.WriteLine("Computer score: " + score_1);


                    if (score_1 >= 20)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }




            }

            if (steps > steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Computer wins");
            }
            else if (steps < steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(Player_ID + " wins");
            }
            else if (steps == steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Draw");
            }

            return 0;

        }
        public static int Two_Player()
        {

            Console.WriteLine("Enter Player 1 name: ");
            string Player_One_ID = Console.ReadLine();

            Console.WriteLine("Enter Player 2 name: ");
            String Player_Two_ID = Console.ReadLine();



            int score = 0; // THIS IS THE SCORE
            int steps = 0;


            while (true)
            {
                if (score >= 20)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine(steps);
                    break;
                }

                int Die_1 = Die.Roll();
                int Die_2 = Die.Roll();
                int Die_3 = Die.Roll();
                int Die_4 = Die.Roll();
                int Die_5 = Die.Roll();


                Console.WriteLine("First Dice: " + Die_1);
                Console.WriteLine("Second Dice: " + Die_2);
                Console.WriteLine("Third Dice: " + Die_3);
                Console.WriteLine("Forth Dice: " + Die_4);
                Console.WriteLine("Fifth Dice: " + Die_5);

                // 5 or more



                if ((Die_1 == Die_2) && (Die_2 == Die_3) && (Die_3 == Die_4) && (Die_4 == Die_5))
                {
                    int FiveKind = 12;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("5 of a kind");
                    Console.ResetColor();
                    if (score >= 20)
                    {
                        int temp = score + FiveKind; // Gives score
                        Console.WriteLine(Player_One_ID + "'s score: " + temp);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }

                // 4 or more

                else if ((Die_1 == Die_2) && (Die_3 == Die_4) || (Die_1 == Die_2) && (Die_3 == Die_5) || (Die_2 == Die_3) && (Die_4 == Die_5) || (Die_3 == Die_4) && (Die_5 == Die_1) || (Die_4 == Die_5) && (Die_1 == Die_2))
                {
                    int FourKind = 6;
                    Console.WriteLine("\n4 of a kind");

                    if (20 >= score)
                    {
                        score = score + FourKind;
                        Console.WriteLine(Player_One_ID + "'s Score is: " + score);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }
                // 3 or more

                else if ((Die_1 == Die_2) && (Die_2 == Die_3) || (Die_1 == Die_2) && (Die_2 == Die_4) || (Die_1 == Die_2) && (Die_2 == Die_5) || (Die_1 == Die_4) && (Die_3 == Die_4) || (Die_1 == Die_5) && (Die_5 == Die_3) || (Die_2 == Die_3) && (Die_3 == Die_4) || (Die_2 == Die_3) && (Die_3 == Die_5) || (Die_2 == Die_4) && (Die_4 == Die_5))
                {
                    int ThreeKind = 3;
                    Console.WriteLine("\n3 of kind");

                    if (20 >= score)
                    {
                        score = score + ThreeKind;
                        Console.WriteLine(Player_One_ID + "'s Score is: " + score);
                        steps += 1;
                        if (score >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }


                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2 of a kind, try again!");
                    Console.ResetColor();
                    Console.WriteLine(Player_One_ID + "'s score: " + score);


                    if (score >= 20)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }

            }
            int score_1 = 0; // THIS IS THE SCORE
            int steps_1 = 0;
            Console.WriteLine("Press any key to play");
            Console.ReadLine();

            while (true)
            {
                if (score_1 >= 20)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine(steps_1);
                    break;
                }

                int Die_1 = Die.Roll();
                int Die_2 = Die.Roll();
                int Die_3 = Die.Roll();
                int Die_4 = Die.Roll();
                int Die_5 = Die.Roll();


                Console.WriteLine("First Dice: " + Die_1);
                Console.WriteLine("Second Dice: " + Die_2);
                Console.WriteLine("Third Dice: " + Die_3);
                Console.WriteLine("Forth Dice: " + Die_4);
                Console.WriteLine("Fifth Dice: " + Die_5);

                // 5 or more



                if ((Die_1 == Die_2) && (Die_2 == Die_3) && (Die_3 == Die_4) && (Die_4 == Die_5))
                {
                    int FiveKind = 12;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("5 of a kind");
                    Console.ResetColor();
                    if (score_1 >= 20)
                    {
                        int temp = score_1 + FiveKind; // Gives score
                        Console.WriteLine(Player_Two_ID + " score: " + temp);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }

                // 4 or more

                else if ((Die_1 == Die_2) && (Die_3 == Die_4) || (Die_1 == Die_2) && (Die_3 == Die_5) || (Die_2 == Die_3) && (Die_4 == Die_5) || (Die_3 == Die_4) && (Die_5 == Die_1) || (Die_4 == Die_5) && (Die_1 == Die_2))
                {
                    int FourKind = 6;
                    Console.WriteLine("\n4 of a kind");

                    if (20 >= score_1)
                    {
                        score_1 = score_1 + FourKind;
                        Console.WriteLine(Player_Two_ID + " score is: " + score_1);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }

                    }

                }
                // 3 or more

                else if ((Die_1 == Die_2) && (Die_2 == Die_3) || (Die_1 == Die_2) && (Die_2 == Die_4) || (Die_1 == Die_2) && (Die_2 == Die_5) || (Die_1 == Die_4) && (Die_3 == Die_4) || (Die_1 == Die_5) && (Die_5 == Die_3) || (Die_2 == Die_3) && (Die_3 == Die_4) || (Die_2 == Die_3) && (Die_3 == Die_5) || (Die_2 == Die_4) && (Die_4 == Die_5))
                {
                    int ThreeKind = 3;
                    Console.WriteLine("\n3 of kind");

                    if (20 >= score_1)
                    {
                        score_1 = score_1 + ThreeKind;
                        Console.WriteLine(Player_Two_ID + " score is: " + score_1);
                        steps_1 += 1;
                        if (score_1 >= 20)
                        {
                            Console.WriteLine("Game Over");
                            Console.WriteLine(steps_1);
                            break;
                        }
                        else
                        {
                            Console.Write("Rolling...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                            Console.Write("...");
                            Thread.Sleep(500);
                        }


                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2 of a kind, try again!");
                    Console.ResetColor();
                    Console.WriteLine(Player_Two_ID + " score: " + score_1);


                    if (score_1 >= 20)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }




            }

            if (steps > steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(Player_Two_ID + " wins");
            }
            else if (steps < steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(Player_One_ID + " wins");
            }
            else if (steps == steps_1)
            {
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Draw");
            }

            return 0;

        }


    }

}
