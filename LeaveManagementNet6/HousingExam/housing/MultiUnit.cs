using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingExam.housing
{
    internal class MultiUnit : Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentPerUnit;

        public MultiUnit(string address, string constructionType, int yearBuilt, string complexName, int numberOfUnits, decimal rentPerUnit) : base(address, constructionType, yearBuilt)
        {
            this.complexName = complexName;
            this.numberOfUnits = numberOfUnits;
            this.rentPerUnit = rentPerUnit;
        }

        public string ComplexName { get => complexName; set => complexName = value; }
        public int NumberOfUnits { get => numberOfUnits; set => numberOfUnits = value; }
        public decimal RentPerUnit { get => rentPerUnit; set => rentPerUnit = value; }

        public override decimal ProjectedRentalAmt()
        {
            return RentPerUnit * (decimal)NumberOfUnits * 12M;
        }

        int IUnits.GetNumUnits()
        {
            return NumberOfUnits;
        }

        public override string ToString()
        {
            return $"Complex name: {ComplexName}\nNumber of units: {NumberOfUnits}\nRent per unit: {RentPerUnit}\n" + base.ToString();
        }
    }
}
