/*
This program mimics the Exquisite Corpse game. 
Using methods, I randomly combine different parts of ASCII characters so they create a new creature.

In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. 
The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.
*/

using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomMode();
    }

    // Create a method that has three parameters, each representing the different parts of the body
    static void BuildACreature(string head, string body, string feet) 
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
      SwitchCase(headNum, bodyNum, feetNum);
    }

    // Create a custom method to randomly assemble a body each time the program is run
    static void RandomMode() 
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1,4);
      int body = randomNumber.Next(1,4);
      int feet = randomNumber.Next(1,4);
      SwitchCase(head, body, feet);
    }
    
    // Create a new custom method to store switch statement
    static void SwitchCase(int head, int body, int feet) 
    {
      switch (head) 
      {
        case 1:
          GhostHead();
          break;

        case 2:
          BugHead();
          break;

        case 3:
          MonsterHead();
          break;

        default:
          Console.WriteLine("Error. Invalid number.");
          break;
      }

      switch (body) 
      {
        case 1:
          GhostBody();
          break;

        case 2:
          BugBody();
          break;

        case 3:
          MonsterBody();
          break;

        default:
          Console.WriteLine("Error. Invalid number.");
          break;
      }

      switch (feet) 
      {
        case 1:
          GhostFeet();
          break;

        case 2:
          BugFeet();
          break;

        case 3:
          MonsterFeet();
          break;

        default:
          Console.WriteLine("Error. Invalid number.");
          break;
      }
    }

    // Create a new method that translates the meaning of the string data into int s
    static int TranslateToNumber(string creature) 
    {
      switch (creature) 
      {
        case "ghost":
          return 1;

        case "bug":
          return 2;

        case "monster":
          return 3;

        default:
          return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}

