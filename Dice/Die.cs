using System;
namespace Dice;

public class Die
{

// This is the method that creates the random numbers, refered to as rolls
  public static int Roll()
  {
    Random random = new Random();
    int Dice_Roll = random.Next(1, 7);
    Console.WriteLine("", Dice_Roll);
    return Dice_Roll;


  }


}
