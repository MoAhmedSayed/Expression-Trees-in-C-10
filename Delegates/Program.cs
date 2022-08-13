namespace Delegates
{
   internal class Program
   {
      public delegate void WriteMessageFunction(string message);
      public static void WriteMessage(string message)
      {
         Console.WriteLine(message);
      }
      public static void WriteTimlyMessage(string message)
      {
         Console.WriteLine(message + " " + DateTime.Now);
      }
      private static void Main(string[] args)
      {
         var selection = Console.ReadLine();
         WriteMessageFunction writeMessageFunction;
         if (selection == "1")
         {
            writeMessageFunction = WriteTimlyMessage;
         }
         else
         {
            writeMessageFunction = WriteMessage;
         }
         writeMessageFunction("Hello, World!");
      }
   }
}