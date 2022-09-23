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


        }
        [TestMethod]
        [TestCategory("Housing Test")]
        public void MultyFamilyTest()
        {
            List<MultiUnit> singleList = new List<MultiUnit>();

            //(string address, string constructionType, int yearBuilt, string complexName, int numberOfUnits, decimal rentPerUnit)

        }
        [TestMethod]
        [TestCategory("Housing Test")]
        public void CombinedFamilyTest()
        {
        }
    }
}