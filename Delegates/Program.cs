namespace Delegates
{
   internal class Program
   {
      public static bool WriteMessage(string message)
      {
         Console.WriteLine(message);
         return true;
      }
      public static bool WriteTimlyMessage(string message)
      {
         Console.WriteLine(message + " " + DateTime.Now);
         return true;
      }
      private static void Main(string[] args)
      {
         var selection = Console.ReadLine();

         Func<string, bool> func;

         if (selection == "1")
         {
            func = WriteTimlyMessage;
         }
         else
         {
            func = WriteMessage;
         }
         ExcuteWrite(func);
      }
      private static bool ExcuteWrite(Func<string, bool> func)
      {
         return func("Hello, World!");
      }
   }
}