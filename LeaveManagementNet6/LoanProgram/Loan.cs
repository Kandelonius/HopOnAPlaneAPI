using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    abstract class Loan
    {
        private long loanNumber;
        private string firstName;
        private string lastName;
        private decimal interestRate;
        private decimal loanAmount;
        private int loanTearmInYears;

        protected Loan(long loanNumber, string firstName, string lastName, decimal interestRate, decimal loanAmount, int loanTearmInYears)
        {
            LoanNumber = loanNumber;
            FirstName = firstName;
            LastName = lastName;
            InterestRate = interestRate;
            LoanAmount = loanAmount;
            LoanTearmInYears = loanTearmInYears;
        }

        protected long LoanNumber 
        { 
            get => loanNumber;
            set
            {
                if (value > 0)
                {
                    loanNumber = value;
                }
                else
                    loanNumber = -1;
            }
        }
        protected string FirstName { get => firstName; set => firstName = value; }
        protected string LastName { get => lastName; set => lastName = value; }
        protected decimal InterestRate 
        { 
            get => interestRate;
            set
            {
                if (value > 0)
                {
                    interestRate = value;
                }
                else
                    interestRate = -1;
            }
        }
        protected decimal LoanAmount 
        { 
            get => loanAmount;
            set
            {
                if (value > 0)
                {
                    loanAmount = value;
                }
                else
                    loanAmount = -1;
            }
        }
        protected int LoanTearmInYears 
        { 
            get => loanTearmInYears;
            set
            {
                if (value > 0)
                {
                    loanTearmInYears = value;
                }
                else
                    loanTearmInYears = -1;
            }
        }
        public abstract decimal CalculateInterest();
    }
}
