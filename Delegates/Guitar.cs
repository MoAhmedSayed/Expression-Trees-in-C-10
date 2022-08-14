namespace Delegates
{
   internal class Guitar
   {
      public Guitar(PickupType PickupType, StringType StringType, string Name)
      {
         this.PickupType = PickupType;
         this.Strings = StringType;
         this.Name = Name;
      }

      public string Name { get; internal set; }
      public StringType Strings { get; internal set; }
      public PickupType PickupType { get; internal set; }
   }
}