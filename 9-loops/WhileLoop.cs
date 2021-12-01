using System;

namespace WhileLoop {
  class Program {
    static void Main(string[] args) {
      string input = Console.ReadLine();
      while (input != "leave") {
        Console.WriteLine("I'm still here");
        input = Console.ReadLine();
      }
      Console.WriteLine("Exiting... bye");
    }
  }
}