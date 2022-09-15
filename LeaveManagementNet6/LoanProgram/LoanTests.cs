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
            HomeLoan hl = new HomeLoan(1, "Guy", "Manfred", .05M, 150000M, 30, "Place", date, 2500);

            string baseString = "loan number: 1\nfirst name: Guy\nlast name: Manfred\ninterest rate: 0.05\nloan amount: 150000\nloan tearm in years: 30\naddress: Place\nyear built: 6/24/2001 12:00:00 AM\nsquare footage: 2500";
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
    }
}