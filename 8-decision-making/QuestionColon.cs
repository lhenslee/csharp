using System;

namespace QuestionColon {
  class Program {
    static void Main(string[] args) {
      string choice = Console.ReadLine();
      int response = choice == "yes" ? 7 : 1;
      Console.WriteLine("{0}", response);
    }
  }
}