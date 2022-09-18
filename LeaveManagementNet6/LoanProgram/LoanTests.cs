namespace LoanProgram
{
    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        [TestCategory("Loan")]
        public void HomeToStringIsGivingExpectedInfo()
        {
            DateTime date = new DateTime(2001, 06, 24);
            HomeLoan hl = new HomeLoan(1, "Guy", "Manfred", .35M, 210000M, 30, "Place", date, 2500);

            string baseString = "loan number: 1\nfirst name: Guy\nlast name: Manfred\ninterest rate: 0.35\nloan amount: 210000\nloan tearm in years: 30\naddress: Place\nyear built: 6/24/2001 12:00:00 AM\nsquare footage: 2500";
            Assert.AreEqual(baseString, hl.ToString());
        }
        [TestMethod]
        [TestCategory("Loan")]
        public void CanCreateHomeLoanObject()
        {
            DateTime date = new DateTime(2001, 06, 24);
            HomeLoan hl = new HomeLoan(1, "Guy", "Manfred", .05M, 150000M, 30, "Place", date, 2500);

            Assert.IsNotNull(hl);
        }
        [TestMethod]
        [TestCategory("Loan")]
        public void CanCreateAutoLoanObject()
        {
            DateTime date = new DateTime(2015, 06, 24);
            AutoLoan al = new(2, "Guy", "Manfred", .05M, 15000M, 5, date, "Integra", "Acura", "Blue");

            Assert.IsNotNull(al);
        }
        [TestMethod]
        [TestCategory("Loan")]
        public void HomeCalculateInterestGivingExpectedInfo()
        {
            DateTime date = new DateTime(2001, 06, 24);
            HomeLoan hl = new HomeLoan(1, "Guy", "Manfred", .035M, 210000M, 30, "Place", date, 2500);

            decimal interest = hl.CalculateInterest();
            Assert.AreEqual(3010, interest);
        }
        [TestMethod]
        [TestCategory("ITDD")]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual("Page Name 1", pageObject1.PageName);
        }
        [TestMethod]
        [TestCategory("ITDD")]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual("Page Name 2", pageObject2.PageName);
        }
    }
}