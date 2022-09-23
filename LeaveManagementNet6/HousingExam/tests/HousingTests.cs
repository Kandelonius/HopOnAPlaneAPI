using HousingExam.housing;
using System.Collections.Generic;

namespace HousingExam.tests
{
    [TestClass]
    public class HousingTests
    {
        [TestMethod]
        [TestCategory("Housing Test")]
        public void SingleFamilyTest()
        {
            List<SingleFamily> singleList = new List<SingleFamily>();

            //(decimal rentAmount, decimal squareFeet, int numberOfBedrooms, decimal numberOfBaths, bool hasPorch, bool hasGarage, string address, string constructionType, int yearBuilt)
            singleList.Add(new SingleFamily(1500, 1750, 3, 1.5M, true, false, "Place 1", "brick", 2001));
            singleList.Add(new SingleFamily(2500, 3750, 4, 2.5M, true, true, "Place 2", "wood", 2011));
            singleList.Add(new SingleFamily(1000, 1250, 2, 1M, false, false, "Place 3", "brick", 1999));
            singleList.Add(new SingleFamily(3500, 3750, 4, 3M, true, true, "Place 4", "stone", 2015));
            singleList.Add(new SingleFamily(1500, 1500, 3, 2M, true, true, "Place 5", "brick", 2007));

            foreach(SingleFamily family in singleList)
            {
                Console.WriteLine(family.ToString() + "\n");
            }
        }
        [TestMethod]
        [TestCategory("Housing Test")]
        public void MultyFamilyTest()
        {
            List<MultiUnit> multiList = new List<MultiUnit>();

            //(string address, string constructionType, int yearBuilt, string complexName, int numberOfUnits, decimal rentPerUnit)
            multiList.Add(new MultiUnit("place 1", "concrete", 2004, "Shady Glen", 44, 850M));
            multiList.Add(new MultiUnit("place 2", "concrete", 2004, "Happy Valley", 80, 1250M));
            multiList.Add(new MultiUnit("place 3", "wood", 2004, "High Volume Petes", 140, 950M));
            multiList.Add(new MultiUnit("place 4", "stone", 2004, "Saucy Meadow", 6, 1850M));
            multiList.Add(new MultiUnit("place 5", "concrete", 2004, "Shady Moore", 44, 1050M));

            foreach(MultiUnit unit in multiList)
            {
                Console.WriteLine(unit.ToString() + "\n");
            }
        }
        [TestMethod]
        [TestCategory("Housing Test")]
        public void CombinedFamilyTest()
        {
            List<Housing> housingList = new List<Housing>();

            housingList.Add(new SingleFamily(1500, 1750, 3, 1.5M, true, false, "Place 1", "brick", 2001));
            housingList.Add(new SingleFamily(2500, 3750, 4, 2.5M, true, true, "Place 2", "wood", 2011));
            housingList.Add(new SingleFamily(1000, 1250, 2, 1M, false, false, "Place 3", "brick", 1999));
            housingList.Add(new SingleFamily(3500, 3750, 4, 3M, true, true, "Place 4", "stone", 2015));
            housingList.Add(new SingleFamily(1500, 1500, 3, 2M, true, true, "Place 5", "brick", 2007));
            housingList.Add(new MultiUnit("place 1", "concrete", 2004, "Shady Glen", 44, 850M));
            housingList.Add(new MultiUnit("place 2", "concrete", 2004, "Happy Valley", 80, 1250M));
            housingList.Add(new MultiUnit("place 3", "wood", 2004, "High Volume Petes", 140, 950M));
            housingList.Add(new MultiUnit("place 4", "stone", 2004, "Saucy Meadow", 6, 1850M));
            housingList.Add(new MultiUnit("place 5", "concrete", 2004, "Shady Moore", 44, 1050M));

            foreach(Housing place in housingList)
            {
                Console.WriteLine($"Address: {place.Address}\nCost per month: ${place.ProjectedRentalAmt()}\n");
            }
        }
    }
}