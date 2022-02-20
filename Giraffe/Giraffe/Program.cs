using System;

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {
      // Data types
      string characterName = "John";
      int characterAge;
      characterAge = 30;
      // char is for single characters, and needs single quotes
      char grade = 'C';
      // float is for least precise, decimal is for most precise
      double characterHeight = 72.5;
      bool isMale = true;
      // arrays
      int[] luckyNumbers = { 1, 2, 3, 4, 5 };
      //   luckyNumbers[luckyNumbers.Length - 1] = 10;
      //   Console.WriteLine(luckyNumbers[luckyNumbers.Length - 1]); // 10

      //   string[] friends = new string[2]; // creates an array of 2 strings
      //   friends[0] = "Jim";
      //   friends[1] = "Pam";
      //   // friends[2] = "Michael"; // This will throw an error
      //   // Console.WriteLine(friends[2]); // This will throw an error


      //   Console.WriteLine($"The name is {characterName} age is {characterAge}");

      //   Console.WriteLine(characterName.Contains("h")); // true
      //   Console.WriteLine(characterName.IndexOf("h")); // 2
      //   Console.WriteLine(5 / 2); // 2
      //   Console.WriteLine(5 / 2.0); // 2.5


      //   //   ReadLine keeps the console open until you press enter, and waits for user input
      //   //   Console.ReadLine();

      //   Console.Write("Enter your name: ");
      //   string name = Console.ReadLine();
      //   Console.WriteLine($"Hello {name}");
      //   Console.Write("Enter number 1: ");
      //   double num = Convert.ToDouble(Console.ReadLine());
      //   Console.Write("Enter number 2: ");
      //   double num2 = Convert.ToDouble(Console.ReadLine());
      //   Console.WriteLine($"{num} + {num2} = {num + num2}");
      //   SayHi("Juan"); // Hi Juan
      //   Console.WriteLine(Cube(5)); // 125

      //   if (isMale)
      //   {
      //     Console.WriteLine("You are male");
      //   }
      //   isMale = false;
      //   if (!isMale)
      //   {
      //     Console.WriteLine("You are not a male ");
      //   }

      //   Console.WriteLine(GetMax(4, 10)); // 10
      //   Console.WriteLine(GetDay(4)); // Thursday
      //   Console.WriteLine(GetDay(15)); // Invalid Day Number
      //   WhileLoopEx(2); // 0 1
      GuessWordGame();
    }

    // Methods / Functions
    // void means no return value
    // static means you can call it without instantiating the class
    static void SayHi(string name)
    {
      Console.WriteLine($"Hi {name}");
    }

    // int means return value
    static int Cube(int num)
    {
      int result = num * num * num;
      return result;
    }

    static int GetMax(int num1, int num2)
    {
      int result;
      if (num1 > num2)
      {
        result = num1;
      }
      else
      {
        result = num2;
      }
      return result;
    }

    static string GetDay(int dayNum)
    {
      string dayName;

      switch (dayNum)
      {
        case 0:
          dayName = "Sunday";
          break;
        case 1:
          dayName = "Monday";
          break;
        case 2:
          dayName = "Tuesday";
          break;
        case 3:
          dayName = "Wednesday";
          break;
        case 4:
          dayName = "Thursday";
          break;
        case 5:
          dayName = "Friday";
          break;
        case 6:
          dayName = "Saturday";
          break;
        default:
          dayName = "Invalid Day Number";
          break;
      }

      return dayName;
    }

    static void WhileLoopEx(int num)
    {
      int i = 0;
      while (i < num)
      {
        Console.WriteLine(i);
        i++;
      }
    }

    static void GuessWordGame()
    {
      string secretWord = "giraffe";
      string guess = "";
      int guessCount = 4;

      while (guess != secretWord && guessCount > 0)
      {
        Console.Write("Enter guess: ");
        guess = Console.ReadLine();
        guessCount--;
        if (guess != secretWord)
        {
          Console.WriteLine("Wrong!");
          Console.WriteLine($"{guessCount} guesses left");
        }
        else
        {
          Console.WriteLine("Correct!");
        }
      }
    }



  }
}
