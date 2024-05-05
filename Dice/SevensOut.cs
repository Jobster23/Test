using CMP1903_A1_2324;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Dice;

public class SevensOut
{

    //Play() is created to loop back so the dice are rolled again, i tried putting it in a while loop but i would get the same number all the time
    public static void Sevens_Out()
    {

        Console.WriteLine("Test");
        Console.WriteLine("Sevens Out");
        Console.WriteLine("   _____                                        _  ");
        Console.WriteLine("  / ____|                                      | |  ");
        Console.WriteLine(" | (___   _____   _____ _ __  ___    ___  _   _| |_ ");
        Console.WriteLine("  \\___ \\ / _ \\ \\ / / _ \\ '_ \\/ __|  / _ \\| | | | __|");
        Console.WriteLine("  ____) |  __/\\ V /  __/ | | \\__ \\ | (_) | |_| | |_ ");
        Console.WriteLine(" |_____/ \\___| \\_/ \\___|_| |_|___/  \\___/ \\__,_|\\__|");

        Console.WriteLine("\nWelcome to Sevens Out. The aim of the game is to roll 2 dice and get the highest score you can. If you roll a 7 your turn is ended and the next player has to beat your score. If you roll 2 numbers that are the same, you get double the dice total");
        Console.WriteLine("\nFor example, if you roll a 4 and a 2 you get 6 points, if you roll 2 and a 2 you get 8 points. However if you roll a 3 and a 4 your score is added up and the next player starts");

        Console.WriteLine("Select one or two: ");
        Console.WriteLine("1 - 1 Player");
        Console.WriteLine("2 - 2 Player");

        int player = Convert.ToInt32(Console.ReadLine());

        switch (player)
        {
            case 1:
                Console.WriteLine("1 player");
                SevensOut.One_Player();
                break;

            case 2:
                Console.WriteLine("2 player");
                SevensOut.Two_Player();
                break;
        }

    }
    public static void One_Player()
    {


        Console.WriteLine("Enter name: ");
        string Player_ID = Console.ReadLine();


        Console.WriteLine(Player_ID + " Press any key to play: ");
        Console.ReadLine();

        int score = 0; // THIS IS THE SCORE
       

        while (true)
        {
            int num1 = Die.Roll();
            int num2 = Die.Roll();

            Console.WriteLine("First Dice: " + num1 + " Second Dice: " + num2);
            int Total = num1 + num2;

            if (Total == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Player_ID + " Rolled A Seven");
                Console.ResetColor();
                //int temp = score + 12;
                score += Total;
                Console.WriteLine(Player_ID + "'s score: " + score);
                Console.WriteLine("\nPress any key to play: ");
                Console.ReadLine();

                int score_1 = 0; // THIS IS THE SCORE

                while (true)
                {
                    int num_1 = Die.Roll();
                    int num_2 = Die.Roll();

                    Console.WriteLine("First Dice: " + num_1 + " Second Dice: " + num_2);
                    int Total_1 = num_1 + num_2;

                    if (Total_1 == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Computer Rolled A Seven");
                        Console.ResetColor();
                        //int temp = score + 12;
                        score_1 += Total_1;
                        //int temp = Total;
                        Console.WriteLine("Computer total score: " + score_1);


                        if (score > score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(Player_ID + " Wins");
                            
                        }
                        else if (score < score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Computer Wins");
                            
                        }
                        else if (score == score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Draw");
                            
                        }
                        break;


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Computer dice total Is " + Total_1);
                        Console.ResetColor();
                        score_1 += Total_1;
                        //int temp = Total;
                        Console.WriteLine("Computer total score: " + score_1);
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }

                break;

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Player_ID + "'s Total Is " + Total);
                Console.ResetColor();
                score += Total;
                Console.WriteLine(Player_ID + "'s score: " + score);
                Console.Write("Rolling...");
                Thread.Sleep(500);
                Console.Write("...");
                Thread.Sleep(500);
                Console.Write("...");
                Thread.Sleep(500);
            }
        }
    }

    public static void Two_Player()
    {

        Console.WriteLine("Enter Player One name: ");
        string Player_One_ID = Console.ReadLine();
        Console.WriteLine("Enter Player Two name: ");
        string Player_Two_ID = Console.ReadLine();


        Console.WriteLine(Player_One_ID + " Press any key to play: ");
        Console.ReadLine();

        int score = 0; // THIS IS THE SCORE

        while (true)
        {
            int num1 = Die.Roll();
            int num2 = Die.Roll();

            Console.WriteLine("First Dice: " + num1 + " Second Dice: " + num2);
            int Total = num1 + num2;

            //var answer = Convert.ToInt32(Console.ReadLine());

            if (Total == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Player_One_ID + " Rolled A Seven");
                Console.ResetColor();
                //int temp = score + 12;
                score += Total;
                Console.WriteLine(Player_One_ID + "'s score: " + score);
                Console.WriteLine("\nPress any key to play: ");
                Console.ReadLine();

                int score_1 = 0; // THIS IS THE SCORE

                while (true)
                {
                    int num_1 = Die.Roll();
                    int num_2 = Die.Roll();

                    Console.WriteLine("First Dice: " + num_1 + " Second Dice: " + num_2);
                    int Total_1 = num_1 + num_2;

                    //var answer = Convert.ToInt32(Console.ReadLine());

                    if (Total_1 == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Player_Two_ID + "'s Rolled A Seven");
                        Console.ResetColor();
                        //int temp = score + 12;
                        score_1 += Total_1;
                        //int temp = Total;
                        Console.WriteLine(Player_Two_ID + "'s total score: " + score_1);


                        if (score > score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(Player_One_ID + " Wins");
                        }
                        else if (score < score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(Player_Two_ID + " Wins");
                        }
                        else if (score == score_1)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Draw");
                        }
                        break;


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Player_Two_ID + "'s' dice total Is " + Total_1);
                        Console.ResetColor();
                        score_1 += Total_1;
                        //int temp = Total;
                        Console.WriteLine(Player_Two_ID + "'s total score: " + score_1);
                        Console.Write("Rolling...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                        Console.Write("...");
                        Thread.Sleep(500);
                    }

                }

                break;

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Player_One_ID + "'s Total Is " + Total);
                Console.ResetColor();
                score += Total;
                Console.WriteLine(Player_One_ID + "'s score: " + score);
                Console.Write("Rolling...");
                Thread.Sleep(500);
                Console.Write("...");
                Thread.Sleep(500);
                Console.Write("...");
                Thread.Sleep(500);
            }
        }
    }
}
  



















