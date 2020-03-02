
namespace Game
{
  public class PingPong
  {
    public static string Count(int number)
    {
      if ((number % 3) == 0 && (number % 5) == 0)
      {
        return "Ping-Pong";
      }
      else if ((number % 3) == 0)
      {
        return "Ping";
      }
      else if ((number % 5) == 0)
      {
        return "Pong";
      }

      else
      {
      return number.ToString();
      }
    }

  }

}