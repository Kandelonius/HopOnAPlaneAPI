using System.Collections;

namespace OCTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void RunsBeforeEveryTest()
        {
            //RetailStore customer = new RetailStore();
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Receipt_Number_Cannot_be_Negative()
        {
            long testNumber = -7;
            RetailStore customer = new RetailStore(testNumber, DateTime.Now, 187L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ReceiptNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        public void Test_Receipt_Number_Can_be_Positive()
        {
            long testNumber = 7;
            RetailStore customer = new RetailStore(testNumber, DateTime.Now, 187L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ReceiptNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Customer_Number_Cannot_be_Negative()
        {
            long testNumber = -7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, testNumber, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.CustomerNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        public void Test_Customer_Number_Can_be_Positive()
        {
            long testNumber = 7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, testNumber, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.CustomerNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Item_Number_Cannot_be_Negative()
        {
            long testNumber = -7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 871L, "Frank", "Place", "777-777-7777", testNumber, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ItemNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Item_Number_Cannot_be_Too_Large()
        {
            long testNumber = 10001;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 871L, "Frank", "Place", "777-777-7777", testNumber, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ItemNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        public void Test_Item_Number_Can_be_Positive()
        {
            long testNumber = 7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 871L, "Frank", "Place", "777-777-7777", testNumber, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ItemNumber);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Price_Number_Cannot_be_Negative()
        {
            decimal testNumber = -7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 6174L, "Frank", "Place", "777-777-7777", 781L, "Great Item", testNumber, 3);

            Assert.AreEqual(testNumber, customer.UnitPrice);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        public void Test_Price_Number_Can_be_Positive()
        {
            decimal testNumber = 7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 6174L, "Frank", "Place", "777-777-7777", 781L, "Great Item", testNumber, 3);

            Assert.AreEqual(testNumber, customer.UnitPrice);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Quantity_Number_Cannot_be_Negative()
        {
            int testNumber = -7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 6174L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 17m, testNumber);

            Assert.AreEqual(testNumber, customer.Quantity);
        }
        [TestMethod]
        [TestCategory("RetailStore")]
        public void Test_Quantity_Number_Can_be_Positive()
        {
            int testNumber = 7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, 6174L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 17m, testNumber);

            Assert.AreEqual(testNumber, customer.Quantity);
        }
        [TestMethod]
        [TestCategory("PropertyTax")]
        public void NewAssessedPropertyValue_does_not_lose_precision()
        {
            PropertyTax property = new PropertyTax(26000M, "home");
            decimal total = property.NewAssessedPropertyValue();

            Assert.AreEqual(26702.00M, total);
        }
        [TestMethod]
        [TestCategory("PropertyTax")]
        public void Current_value_is_given_by_NewAssessedPropertyValue()
        {
            PropertyTax property = new PropertyTax(26000M, "home");
            decimal total = property.PropertyValue;

            Assert.AreEqual(26702.00M, total);
        }
        [TestMethod]
        [TestCategory("PropertyTax")]
        public void Calculate_Millage_gives_the_desired_result()
        {
            PropertyTax property = new PropertyTax(26000M, "home");
            decimal total = property.CalculateMillage();

            Assert.AreEqual(17.07M, total);
        }
        [TestMethod]
        [TestCategory("PropertyTax")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Run_To_String()
        {
            PropertyTax property = new PropertyTax(26000M, "home");
            string total = property.ToString();

            Assert.AreEqual("hello", total);
        }
        [TestMethod]
        [TestCategory("ListCleaner")]
        public void Run_List_Cleaner()
        {
            {
                int total = 0;
                ArrayList dataList = new ArrayList();
                dataList.Add("Someday");
                dataList.Add(2);
                dataList.Add("app");
                dataList.Add(13.5);
                dataList.Add("red");
                dataList.Add(8);
                dataList.Add(99);
                dataList.Add("6");
                dataList.Add("Meatball soup");
                dataList.Add(18M);
                dataList.Add("pices");
                dataList.Add("14");

                ArrayList tesList = ListCleaner.CleanList(dataList);
                total = ListCleaner.AddListElements(tesList);

                Assert.AreEqual(147, total);
            }
        }
    }
}