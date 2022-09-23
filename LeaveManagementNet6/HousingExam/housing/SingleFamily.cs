using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingExam.housing
{
    internal class SingleFamily : Housing
    {
        private decimal rentAmount;
        private decimal squareFeet;
        private int numberOfBedrooms;
        private decimal numberOfBaths;
        private bool hasPorch;
        private bool hasGarage;

        public SingleFamily(decimal rentAmount, decimal squareFeet, int numberOfBedrooms, decimal numberOfBaths, bool hasPorch, bool hasGarage, string address, string constructionType, int yearBuilt) : base(address, constructionType, yearBuilt)
        {
            RentAmount = rentAmount;
            SquareFeet = squareFeet;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfBaths = numberOfBaths;
            HasPorch = hasPorch;
            HasGarage = hasGarage;
        }

        public decimal RentAmount { get => rentAmount; set => rentAmount = value; }
        public decimal SquareFeet { get => squareFeet; set => squareFeet = value; }
        public int NumberOfBedrooms { get => numberOfBedrooms; set => numberOfBedrooms = value; }
        public decimal NumberOfBaths { get => numberOfBaths; set => numberOfBaths = value; }
        public bool HasPorch { get => hasPorch; set => hasPorch = value; }
        public bool HasGarage { get => hasGarage; set => hasGarage = value; }

        public override decimal ProjectedRentalAmt()
        {
            return (RentAmount * 12M);
        }

        public override string ToString()
        {
            return $"Rent Amount: ${RentAmount}\nSquare Footage: {SquareFeet}\nNumber of bedrooms: {NumberOfBedrooms}\nNumber of Baths: {NumberOfBaths}\nPorch?: {HasPorch}\nGarage?: {HasGarage}\n" + base.ToString();
        }
    }
}
