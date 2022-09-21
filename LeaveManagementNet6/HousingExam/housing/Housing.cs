using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingExam.housing
{
    abstract class Housing
    {
        private string address;
        private string constructionType;
        private int yearBuilt;

        protected Housing(string address, string constructionType, int yearBuilt)
        {
            Address = address;
            ConstructionType = constructionType;
            YearBuilt = yearBuilt;
        }

        public string Address { get => address; set => address = value; }
        public string ConstructionType { get => constructionType; set => constructionType = value; }
        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }

        public virtual decimal ProjectedRentalAmt() { return 0M; }

        public override string ToString()
        {
            return $"Address: {Address}\nConstruction Type: {ConstructionType}\nYear Built: {YearBuilt}";
        }
    }
}
