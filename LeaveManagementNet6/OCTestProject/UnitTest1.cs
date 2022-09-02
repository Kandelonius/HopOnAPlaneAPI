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
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Receipt_Number_Cannot_be_Negative()
        {
            long testNumber = -7;
            RetailStore customer = new RetailStore(testNumber, DateTime.Now, 187L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ReceiptNumber);
        }
        [TestMethod]
        [TestCategory("Positive")]
        public void Test_Receipt_Number_Can_be_Positive()
        {
            long testNumber = 7;
            RetailStore customer = new RetailStore(testNumber, DateTime.Now, 187L, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.ReceiptNumber);
        }
        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Customer_Number_Cannot_be_Negative()
        {
            long testNumber = -7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, testNumber, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.CustomerNumber);
        }
        [TestMethod]
        [TestCategory("Positive")]
        public void Test_Customer_Number_Can_be_Positive()
        {
            long testNumber = 7;
            RetailStore customer = new RetailStore(178L, DateTime.Now, testNumber, "Frank", "Place", "777-777-7777", 781L, "Great Item", 78m, 3);

            Assert.AreEqual(testNumber, customer.CustomerNumber);
        }
    }
}