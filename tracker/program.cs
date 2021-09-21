using System;
using System.Collections.Generic;
using TriangleTracker;

namespace Program
{
  public class Tracker
  {
    public static void Main()
    {
      Console.WriteLine("Check your triangle here!");
      Console.WriteLine("Input your first side length");
      string A = Console.ReadLine();
      int convertA = int.Parse(A);
      Console.WriteLine("Input your second side length");
      string B = Console.ReadLine();
      int convertB = int.Parse(B);
      Console.WriteLine("Input your third side length");
      string C = Console.ReadLine();
      int convertC = int.Parse(C);

      Triangle userTriangle = new Triangle();

      if (userTriangle.IsTriangle(convertA, convertB, convertC) == true)
      {
        Console.WriteLine("Congrats! It's a triangle!");
        if (userTriangle.IsEqui(convertA, convertB, convertC))
        {
          Console.WriteLine("It's an Equilateral!");
        }
        else if (userTriangle.IsIso(convertA, convertB, convertC) == true)
        {
          Console.WriteLine("It's an Isosceles");
        }
        else if (userTriangle.IsScale(convertA, convertB, convertC))
        {
          Console.WriteLine("It's a Scalene");
        }
      }
      else
      {
        Console.WriteLine("Not a valid triangle");
      }
    }
  }
}