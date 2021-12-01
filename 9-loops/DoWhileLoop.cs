using System;

namespace DoWhileLoop {
  class Program {
    static void Main(string [] args) {
      string input;
      do
      {
        print("What do you want?");
        input = Console.ReadLine();
      } while (input != "leave");
      Console.WriteLine("OK... Bye")
    }
  }
}