using System;

class ShippingCost
{
  // static void Main()
  // {
  //   PackageQuestionIs("How much does your package weight?");
  //   PackageQuestionIs("How far will it travel?");
  //   PackageQuestionIs("How much to mail package?");
  // }
  //   static void Main()
  //   {
  //   Console.WriteLine(question);
  //   string stringPackageWeight = Console.ReadLine();
  //   Console.WriteLine(stringPackageWeight);
  static void PackageQuestionIs(string question)
  {
    Console.WriteLine(question + " is:");
  }
  static void Main()
  {
    PackageQuestionIs("Package weight");
    string stringPackageWeight = Console.ReadLine();
    int packageWeight = int.Parse(stringPackageWeight);

    PackageQuestionIs("Distance to travel");
    string stringDistanceToTravel = Console.ReadLine();
    int distanceToTravel = int.Parse(stringDistanceToTravel);

    PackageQuestionIs("Price Modifier");
    string stringPriceModifier = Console.ReadLine();
    int priceModifier = int.Parse(stringPriceModifier);

    int intEstimatedShippingCost = ( packageWeight / 10 ) + ( distanceToTravel / 5 ) * priceModifier;

    string estimatedShippingCost = intEstimatedShippingCost.ToString();

    Console.WriteLine("Your estimated shipping cost is $" + estimatedShippingCost + ".00.");
  // First iteration
    // Console.WriteLine("How much does your package weight?");
    // string stringPackageWeight = Console.ReadLine();
    // Console.WriteLine("How far will it travel?");
    // string stringDistanceToTravel = Console.ReadLine();
    // Console.WriteLine("How much to mail package?");
    // string stringPriceModifier = Console.ReadLine();
    //
    // int intPackageWeight = int.Parse(stringPackageWeight);
    // int intDistanceToTravel = int.Parse(stringDistanceToTravel);
    // int intPriceModifier = int.Parse(stringPriceModifier);
    // int intEstimatedShippingCost = ( intPackageWeight / 10 ) + ( intDistanceToTravel / 5 ) * intPriceModifier;
    //
    // string stringEstimateShippingCost = intEstimatedShippingCost.ToString();
    // Console.WriteLine("Your estimated cost for your package is " + stringEstimateShippingCost + ".");
  }
}
