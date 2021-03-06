  /*Test File for Custom URL Handler Testing
  @Pluggable Protocol Handler .
  @Author:Fahad Israr(github.com/fahad-israr)
 The following sample code contains a simple C# console application demonstrating one way to implement a pluggable protocol handler for the Ide URI scheme.*/

  using System;
  using System.Collections.Generic;
using System.Text;

  namespace Ide
  {
    class Program
    {
      static string ProcessInput(string s)
      {
         // TODO Verify and validate the input 
         // string as appropriate for your application.
         return s;
      }

      static void Main(string[] args)
      {
        Console.WriteLine("Ide.exe invoked with the following parameters.\r\n");
        Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

        Console.WriteLine("\n\nArguments:\n");
        foreach (string s in args)
        {
          Console.WriteLine("\t" + ProcessInput(s));
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
      }
    }
  }
