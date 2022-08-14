namespace Delegates
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         var selection = Console.ReadLine();

         Func<string, bool> func;

         if (selection == "1")
         {
            func = message =>
            {
               Console.WriteLine(message + " " + DateTime.Now);
               return true;
            };

         }
         else
         {
            func = message =>
            {
               Console.WriteLine(message);
               return true;
            };
         }
         ExcuteWrite(func);
      }
      private static bool ExcuteWrite(Func<string, bool> func)
      {
         return func("Hello, World!");
      }
   }
}