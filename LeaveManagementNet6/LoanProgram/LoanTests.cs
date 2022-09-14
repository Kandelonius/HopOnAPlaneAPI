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
    }
}