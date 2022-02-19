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

      Console.WriteLine($"The name is {characterName} age is {characterAge}");

      Console.WriteLine(characterName.Contains("h")); // true
      Console.WriteLine(characterName.IndexOf("h")); // 2
      Console.WriteLine(5 / 2); // 2
      Console.WriteLine(5 / 2.0); // 2.5


      // ReadLine keeps the console open until you press enter, and waits for user input
      // Console.ReadLine();
      Console.Write("Enter your name: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}");
    }
  }
}
