using System;

namespace CalculatorApplication {
  class NumberManipulator
  {
    public int FindMax(int num1, int num2)
    {
      return num1 > num2 ? num1 : num2;
    }
  }
  class Test {
    static void Main(string[] args) {
      int a, b;
      string tmp;
      NumberManipulator n = new NumberManipulator();
      for (; ; )
      {
        Console.WriteLine("Type quit to cancel.");
        Console.WriteLine("Number a: ");
        tmp = Console.ReadLine();
        if (tmp == "quit") { break; }
        a = Convert.ToInt32(tmp);
        Console.WriteLine("Number b: ");
        tmp = Console.ReadLine();
        if (tmp == "quit") { break; }
        b = Convert.ToInt32(tmp);
        Console.WriteLine("{0} is the maximum!", n.FindMax(a, b));
      } 
    }
  }
}