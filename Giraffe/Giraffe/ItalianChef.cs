using System;

namespace Giraffe
{
  // to inherit from a class, use the : symbol
  class ItalianChef : Chef
  {
    // override keyword allows you to override the method in the base class that has the "virtual" keyword
    public override void MakeSpecialDish()
    {
      Console.WriteLine("The chef makes chicken parm");
    }
    public void MakePasta()
    {
      Console.WriteLine("The chef makes pasta");
    }
  }
}