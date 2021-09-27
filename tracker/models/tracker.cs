using System;


namespace Tracker.Models
{
  public class Triangle
  {
    public string Type { get; set; }

    public bool IsTriangle(int A, int B, int C)
    {
      return (A + B > C && B + C > A && A + C > B);
      // {
      // return true;
      // }
      // return false;
    }
    public bool IsIso(int A, int B, int C)
    {
      return (A == B || B == C || C == A);
      // {
      //   return true;
      // }
      // return false;
    }
    public bool IsEqui(int A, int B, int C)
    {
      return (A == B && A == C);
      // {
      //   return true;
      // }
      // return false;
    }
    public bool IsScale(int A, int B, int C)
    {
      return (A != B && A!= C && C != B);
      // {
      //   return true;
      // }
      // return false;
    }
  }
}


// build an app to tell us is a triangle is a triangle./ what kind
// tests: All return true/false?
// 1: is triangle
// 2: is isosceles
// 3: is equilateral?
// 4: is scalene?