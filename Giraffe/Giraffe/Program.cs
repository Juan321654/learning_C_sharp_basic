using System;
using System.Collections.Generic;

namespace Giraffe
{
  class Program
  {
    // STATIC is used to declare a method that can be called without creating an instance of the class.
    // for example the Math. class, you dont have to do int x = new Math...
    // isntead you can just call Math.something and thats because of the static keyword
    // if the static keyword isnt used, you have to create an instance of the class before you can call the method
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
      luckyNumbers[luckyNumbers.Length - 1] = 10;
      Console.WriteLine(luckyNumbers[luckyNumbers.Length - 1]); // 10

      string[] friends = new string[2]; // creates an array of 2 strings
      friends[0] = "Jim";
      friends[1] = "Pam";
      // friends[2] = "Michael"; // This will throw an error
      // Console.WriteLine(friends[2]); // This will throw an error

      // Lists, lists are dynamic, you can add or remove items from the list
      // and dont have to know the size of the list
      // requires the import > using System.Collections.Generic;
      List<string> friendsList = new List<string>();
      friendsList.Add("Jim");
      friendsList.Add("Pam");
      friendsList.Add("Michael");

      // friendsList.Remove("Jim"); // removes the first instance of "Jim"
      friendsList.Insert(1, "Mike"); // inserts "Mike" at index 1


      Console.WriteLine(friendsList[0]); // Jim

      // Dictionaries, are used to store key value pairs
      // the key is the name of the item, and the value is the value of the item
      Dictionary<string, string> phonebook = new Dictionary<string, string>();
      phonebook.Add("Jim", "555-1234");
      phonebook.Add("Pam", "555-5678");
      phonebook.Add("Michael", "555-9012");


      Console.WriteLine($"The name is {characterName} age is {characterAge}");

      Console.WriteLine(characterName.Contains("h")); // true
      Console.WriteLine(characterName.IndexOf("h")); // 2
      Console.WriteLine(5 / 2); // 2
      Console.WriteLine(5 / 2.0); // 2.5


      //   ReadLine keeps the console open until you press enter, and waits for user input
      //   Console.ReadLine();

      Console.Write("Enter your name: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}");
      Console.Write("Enter number 1: ");
      double num = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter number 2: ");
      double num2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"{num} + {num2} = {num + num2}");
      SayHi("Juan"); // Hi Juan
      Console.WriteLine(Cube(5)); // 125

      if (isMale)
      {
        Console.WriteLine("You are male");
      }
      isMale = false;
      if (!isMale)
      {
        Console.WriteLine("You are not a male ");
      }

      Console.WriteLine(GetMax(4, 10)); // 10
      Console.WriteLine(GetDay(4)); // Thursday
      Console.WriteLine(GetDay(15)); // Invalid Day Number
      WhileLoopEx(2); // 0 1
      GuessWordGame();
      Console.WriteLine(GetPow(2, 3)); // 8
      twoDimensionalArray();
      HandleException();

      Book book1 = new Book("Harry Potter", "JK Rowling", 400);
      // constructor being empty, you can create a new object without having to add values
      // book1.title = "Harry Potter";
      // book1.author = "JK Rowling";
      // book1.pages = 400;
      // Console.WriteLine(book1.title);

      Student student1 = new Student("Jim", "Business", 3.6);
      Student student2 = new Student("Pam", "Art", 2.5);
      // Console.WriteLine(student1.HasHonors()); // true
      // Console.WriteLine(student2.HasHonors()); // false

      // GETTERS AND SETTERS = prevent direct access to private variables, and allow for more control
      // you can set default values and prevent wrong values to be entered
      Movie movie1 = new Movie("Jaws", "Steven Spielberg", "Dog");
      Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG-13");
      Console.WriteLine(movie1.GetRating); // NR 

      // static variables are shared by all objects, belongs to the class itself
      Song song1 = new Song("Given up", "Linkin Park", 200);
      // Console.WriteLine(Song.songCount); // 1
      Song song2 = new Song("1000 rounds", "Ghostemane", 150);
      // Console.WriteLine(Song.songCount); // 2
      // Console.WriteLine(song1.getAllSongsCount()); // 2

      // STATIC METHODS
      // by making a method static, you can call it without creating an object
      UsefulTools.SayHi("Juan"); // "Hello, Juan"

      // INHERITANCE
      // you can inherit from a class, and use the variables and methods from the parent class
      Chef chef1 = new Chef();
      chef1.MakeChicken();

      ItalianChef italianChef1 = new ItalianChef();
      italianChef1.MakeChicken();
      italianChef1.MakePasta();
      Console.WriteLine(CheckOut(5, 8, 1, 10, 50, 20, 15, 80, 99)); // 288

      // OVERLOADED CONSTRUCTOR
      Pizza pizza = new Pizza("stuffed", "red sauce", "mozzarella", "pepperoni");
      Pizza pizza2 = new Pizza("not stuffed", "blue sauce", "mozzarella");

      // OBJECT AS ARGUMENT
      // you can pass an object as an argument to a method
      Car car1 = new Car("Mustang", "red");

      ChangeColor(car1, "blue");


    }

    public static void ChangeColor(Car car, string color)
    {
      car.color = color;
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

    static int GetPow(int baseNum, int powNum)
    {
      int result = 1;
      for (int i = 0; i < powNum; i++)
      {
        result *= baseNum;
      }

      return result;
    }

    static void twoDimensionalArray()
    {
      // [,] the comma is the delimiter and lets C# know it is a 2 dimensional array
      int[,] numberGrid = {
        { 1, 2 },
        { 3, 4 },
        { 5, 6 },
        { 7, 8 }
      };
      Console.WriteLine(numberGrid[0, 0]);  // 1
      Console.WriteLine(numberGrid[0, 1]);  // 2
      Console.WriteLine(numberGrid[3, 1]);  // 8
    }

    static void HandleException()
    {
      try
      {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        // try to divide by 0 or a letter
        Console.WriteLine(num / num2);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Finally will always run no matter what");
      }


    }
    static double CheckOut(params double[] prices)
    // params means you can pass in any number of arguments
    // but it must be a single dimensional array
    {
      double total = 0;
      foreach (double price in prices)
      {
        total += price;
      }
      return total;
    }
    // OVERLOADED CLASS means that you can create multiple classes with the same name
    // but different parameters
    class Pizza
    {
      string bread;
      string sauce;
      string cheese;
      string topping;

      public Pizza(string bread, string sauce, string cheese, string topping)
      {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.topping = topping;
      }
      public Pizza(string bread, string sauce, string cheese)
      {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
      }

    }

    // ABSTRACT CLASSES = modifier that indicates missing compopents or incomplete classes
    // this means that other classes can inherit from this class, but this class cannot be instantiated
    // Vehicle someVehicle = new Vehicle(); // error
    abstract class Vehicle
    {
      public int speed = 0;

      public void Go()
      {
        Console.WriteLine("The vehicle is going");
      }
    }

    class Bike : Vehicle
    {
      int wheels = 2;
    }

  }
}

class Car
{
  public string model;
  public string color;
  public Car(string model, string color)
  {
    this.model = model;
    this.color = color;
  }
}