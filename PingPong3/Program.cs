using System;

namespace Game
{
  class PingPongGame
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number for Ping Pong");
      Console.Write("Enter : ");
      int length = int.Parse(Console.ReadLine());
      for (int i = 1; i <= length; i++)
      {
        Console.WriteLine(PingPong.Count(i));
      }
    }
  }
    
}