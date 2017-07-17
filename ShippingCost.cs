using System;

class ShippingCost
{
  static void Main()
  {
    Console.WriteLine("How much does your package weight?");
    string stringPackageWeight = Console.ReadLine();
    Console.WriteLine("How far will it travel?");
    string stringDistanceToTravel = Console.ReadLine();
    Console.WriteLine("How much to mail package?");
    string stringPriceModifier = Console.ReadLine();

    int intPackageWeight = int.Parse(stringPackageWeight);
    int intDistanceToTravel = int.Parse(stringDistanceToTravel);
    int intPriceModifier = int.Parse(stringPriceModifier);
    int intEstimatedShippingCost = ( intPackageWeight / 10 ) + ( intDistanceToTravel / 5 ) * intPriceModifier;

    string stringEstimateShippingCost = intEstimatedShippingCost.ToString();
    Console.WriteLine("Your estimated cost for your package is " + stringEstimateShippingCost + ".");
  }
}
