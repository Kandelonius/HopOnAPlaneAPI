using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    internal class AutoLoan
    {
        private DateTime yearBuilt;
        private string model;
        private string make;
        private string color;

        public AutoLoan(DateTime yearBuilt, string model, string make, string color)
        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Color = color;
        }

        public DateTime YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public string Color { get => color; set => color = value; }
    }
}
