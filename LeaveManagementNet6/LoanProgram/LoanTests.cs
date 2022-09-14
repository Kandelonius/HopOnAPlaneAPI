namespace LoanProgram
{
    [TestClass]
    public class LoanTests
    {
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