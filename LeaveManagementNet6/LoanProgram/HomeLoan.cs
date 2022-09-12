using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    internal class HomeLoan
    {
        private string address;
        private DateTime yearBuilt;
        private int squareFootage;

        public HomeLoan(string address, DateTime yearBuilt, int squareFootage)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public string Address { get => address; set => address = value; }
        public DateTime YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public int SquareFootage { get => squareFootage; set => squareFootage = value; }
    }
}
