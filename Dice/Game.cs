using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dice;

namespace CMP1903_A1_2324
{
  internal class Game
  {
        public static void Main(string[] args)
        {

          Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

          Console.WriteLine("\n ________  ___  ________  _______           ________  ________  _____ ______   _______      ");
          Console.WriteLine("|\\   ___ \\|\\  \\|\\   ____\\|\\  ___ \\         |\\   ____\\|\\   __  \\|\\   _ \\  _   \\|\\  ___ \\     ");
          Console.WriteLine("\\ \\  \\_|\\ \\ \\  \\ \\  \\___|\\ \\   __/|        \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\\\__\\ \\  \\ \\   __/|    ");
          Console.WriteLine(" \\ \\  \\ \\ \\ \\  \\ \\  \\    \\ \\  \\_|/__       \\ \\  \\  __\\ \\   __  \\ \\  \\|__| \\  \\ \\  \\_|/__  ");
          Console.WriteLine("  \\ \\  \\_\\ \\ \\  \\ \\  \\____\\ \\  \\_|\\ \\       \\ \\  \\|\\  \\ \\  \\ \\  \\ \\  \\    \\ \\  \\ \\  \\_|\\ \\ ");
          Console.WriteLine("   \\ \\_______\\ \\__\\ \\_______\\ \\_______\\       \\ \\_______\\ \\__\\ \\__\\ \\__\\    \\ \\__\\ \\_______\\,");
          Console.WriteLine("    \\|_______|\\|__|\\|_______|\\|_______|        \\|_______|\\|__|\\|__|\\|__|     \\|__|\\|_______|");


          Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            //string local = "Score.txt";
            //File.AppendAllText(local, Environment.NewLine + "UCL");
            //string txtappd = File.ReadAllText(local);
            //Console.WriteLine(txtappd);

            // The selection menu - This consists of a list and then a switch which points to the designated task:

            Console.WriteLine("\nPlease select one of the following [1-4]");


          Console.WriteLine("\n1 - Three or More");
          Console.WriteLine("2 - Sevens Out");
          Console.WriteLine("3 - Test Three or More");
          Console.WriteLine("4 - Testing");

          //Add some error handling - change to the selection of name to numbers

          int menu = Convert.ToInt32(Console.ReadLine());

          switch (menu)
          {

            case 1:

              // This selects the Three_Or_More method from the Three Or More class
              ThreeOrMore.Three_Or_more();


              break;

            case 2:

              // This selects the Sevens_Out method from the Sevens Out class
              SevensOut.Sevens_Out();


              break;


          }
            
        }

  }
}