using System;

namespace TypeConversionApplication {
  class ExplicitConversion {
    static void Main(string[] args) {
      double d = 5673.74;
      int i;

      i = (int)d;
      Console.WriteLine(i);
      Console.ReadKey();
    }
  }
}