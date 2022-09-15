using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    internal class HomeLoan : Loan
    {
        private string address;
        private DateTime yearBuilt;
        private int squareFootage;

        public HomeLoan(long loanNumber, string firstName, string lastName, decimal interestRate, decimal loanAmount, int loanTearmInYears, string address, DateTime yearBuilt, int squareFootage) : base(loanNumber, firstName, lastName, interestRate, loanAmount, loanTearmInYears)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public string Address { get => address; set => address = value; }
        public DateTime YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public int SquareFootage { get => squareFootage; set => squareFootage = value; }

        public override decimal CalculateInterest()
        {
            return (
                (InterestRate / (Convert.ToDecimal(LoanTearmInYears) / 12)) * (LoanAmount + 5000)
                );
        }
        public override string ToString()
        {
            return base.ToString() + $"\naddress: {Address}\nyear built: {YearBuilt}\nsquare footage: {SquareFootage}";
        }
    }
}
