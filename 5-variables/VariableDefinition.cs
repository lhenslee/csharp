using System;

namespace VariableDefinition {
  class Program {
    static void Main(string[] args) {
      short a;
      int b, input;
      double c;
      a = 10;
      b = 20;
      c = a + b;
      input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("a = {0}, b = {1}, c = {2}, input = {3}", a, b, c, input);
    }
  }
}