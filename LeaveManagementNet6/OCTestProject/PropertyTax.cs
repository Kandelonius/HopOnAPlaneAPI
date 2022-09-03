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
        private decimal millageRate;

        public PropertyTax()
        {
        }
        public PropertyTax(decimal previousYearPropertyValue, string propertyAddress)
        {
            PreviousYearPropertyValue = previousYearPropertyValue;
            PropertyAddress = propertyAddress;
            AddedPropertyValue = 2.7;
            PropertyValue = NewAssessedPropertyValue();
            MillageRate = CalculateMillage();
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
        public decimal MillageRate { get => millageRate; set => millageRate = value; }

        public decimal NewAssessedPropertyValue()
        {
            return Decimal.Round(PreviousYearPropertyValue + ((decimal)AddedPropertyValue * PreviousYearPropertyValue), 2);
        }
        public decimal CalculateMillage()
        {
            return Decimal.Round(((PropertyValue - 25000) / 1000M) * 10.03M, 2);
        }
    }
}
