using System;

namespace Giraffe
{
  class Chef
  {
    public void MakeChicken()
    {
      Console.WriteLine("The chef makes chicken");
    }

    public void MakeSalad()
    {
      Console.WriteLine("The chef makes salad");
    }

    // the virtual keyword allows you to override the method in the base class
    public virtual void MakeSpecialDish()
    {
      Console.WriteLine("The chef makes bbq ribs");
    }
  }
}