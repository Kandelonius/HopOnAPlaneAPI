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
        private decimal millageValue;
        private decimal exemption;
        private decimal taxableValue;

        public PropertyTax()
        {
        }
        public PropertyTax(decimal previousYearPropertyValue, string propertyAddress)
        {
            PreviousYearPropertyValue = previousYearPropertyValue;
            PropertyAddress = propertyAddress;
            AddedPropertyValue = 2.7;
            Exemption = 25000;
            MillageValue = 10.03M;
            PropertyValue = NewAssessedPropertyValue();
            TaxableValue = CalculateTaxableValue();
            MillageRate = CalculateMillage();
            printToString();
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
        public decimal Exemption { get => exemption; set => exemption = value; }
        public decimal TaxableValue { get => taxableValue; set => taxableValue = value; }
        public decimal MillageValue { get => millageValue; set => millageValue = value; }

        public decimal NewAssessedPropertyValue()
        {
            return Decimal.Round(PreviousYearPropertyValue + ((decimal)AddedPropertyValue * PreviousYearPropertyValue), 2);
        }
        public decimal CalculateMillage()
        {
            return Decimal.Round((TaxableValue / 1000M) * MillageValue, 2);
        }
        public decimal CalculateTaxableValue()
        {
            return PropertyValue - Exemption;
        }
        public override string ToString()
        {
            return $"Property Address: {PropertyAddress}\n" +
                $"Last Year Assessed Value: {PreviousYearPropertyValue}\n" +
                $"Current Assessed Value ${PropertyValue}\n" +
                $"Exemption: ${Exemption}\n" +
                $"Taxable Value: ${TaxableValue}\n" +
                $"Millage Rate (per $1000): ${MillageValue}\n" +
                $"Taxes Due: ${MillageRate}";
        }
        public void printToString()
        {
            Console.Write(ToString());
        }
    }
}
