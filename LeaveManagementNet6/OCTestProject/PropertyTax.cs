using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{
    internal class PropertyTax
    {
        private decimal propertyValue;
        private string propertyAddress;
        private decimal previousYearPropertyValue;
        private double addedPropertyValue;

        public PropertyTax()
        {
        }
        public PropertyTax(decimal previousYearPropertyValue, string propertyAddress)
        {
            PreviousYearPropertyValue = previousYearPropertyValue;
            PropertyAddress = propertyAddress;
            AddedPropertyValue = 2.7;
            PropertyValue = NewAssessedPropertyValue();
        }

        public decimal PropertyValue
        {
            get => propertyValue;
            set => propertyValue = value;
        }
        public string PropertyAddress { get => propertyAddress; set => propertyAddress = value; }
        public decimal PreviousYearPropertyValue { get => previousYearPropertyValue; set => previousYearPropertyValue = value; }
        public double AddedPropertyValue
        {
            get => addedPropertyValue;
            set
            {
                addedPropertyValue = value / 100;
            }
        }

        public decimal NewAssessedPropertyValue()
        {
            return PreviousYearPropertyValue + ((decimal)AddedPropertyValue * PreviousYearPropertyValue);
        }
    }
}
