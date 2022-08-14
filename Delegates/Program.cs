namespace Delegates
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         var guiters = new List<Guitar>();
         guiters.Add(new Guitar(PickupType.Electric, StringType.Steel, "Cherry Red Strat"));
         guiters.Add(new Guitar(PickupType.AcousticElectric, StringType.Nylon, "Takmine EG-116"));
         guiters.Add(new Guitar(PickupType.Acoustic, StringType.Steel, "Martin D-X1E"));

         Func<Guitar, bool> nylon = guitar => guitar.Strings == StringType.Nylon;

         var nylonGuitars = guiters.Where(nylon);
         foreach (var guitar in nylonGuitars)
         {
            Console.WriteLine(guitar.Name);
         }
      }
   }
}