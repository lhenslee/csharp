using System;

namespace DoWhileLoop {
  class Program {
    static void Main(string [] args) {
      string input;
      do
      {
        Console.WriteLine("What do you want?");
        input = Console.ReadLine();
      } while (input != "leave");
      Console.WriteLine("OK... Bye");
    }
  }
}